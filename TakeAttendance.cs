using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CollageManagementSystem
{
    public partial class TakeAttendance : Form
    {
        private string connectionString = "data source=LAPTOP-FPB233T9\\SQLEXPRESS;initial catalog=college;integrated security=True";

        public TakeAttendance()
        {
            InitializeComponent();

            // Fill ComboBoxes with values from Database
            LoadComboBoxValues();

            // Attach event handlers
            comboBoxBranch.SelectedIndexChanged += (s, e) => LoadStudents();
            comboBoxYear.SelectedIndexChanged += (s, e) => LoadStudents();
            comboBoxSemester.SelectedIndexChanged += (s, e) => LoadStudents();
        }

        private void LoadComboBoxValues()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Branch
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT DISTINCT branch FROM NewAdmission", con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                foreach (DataRow row in dt1.Rows)
                {
                    comboBoxBranch.Items.Add(row["branch"].ToString());
                }

                // Year
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT DISTINCT year FROM NewAdmission", con);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                foreach (DataRow row in dt2.Rows)
                {
                    comboBoxYear.Items.Add(row["year"].ToString());
                }

                // Semester
                SqlDataAdapter da3 = new SqlDataAdapter("SELECT DISTINCT semester FROM NewAdmission", con);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                foreach (DataRow row in dt3.Rows)
                {
                    comboBoxSemester.Items.Add(row["semester"].ToString());
                }
            }
        }


        private void LoadStudents()
        {
            try
            {
                if (comboBoxBranch.SelectedItem == null || comboBoxYear.SelectedItem == null || comboBoxSemester.SelectedItem == null)
                {
                    MessageBox.Show("Please select Branch, Year, and Semester.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT NAID as StudentID, fname as Name FROM NewAdmission WHERE branch = @Branch AND year = @Year AND semester = @Semester";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Branch", comboBoxBranch.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Year", comboBoxYear.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Semester", comboBoxSemester.SelectedItem.ToString());

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Debugging: Check if data is being retrieved
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show($"No students found for: \nBranch: {comboBoxBranch.SelectedItem}\nYear: {comboBoxYear.SelectedItem}\nSemester: {comboBoxSemester.SelectedItem}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Add Attendance Checkbox Column
                        if (!dt.Columns.Contains("IsPresent"))
                        {
                            dt.Columns.Add("IsPresent", typeof(bool));
                        }

                        foreach (DataRow row in dt.Rows)
                        {
                            row["IsPresent"] = false;
                        }

                        dataGridViewAttendance.DataSource = dt;
                        dataGridViewAttendance.Columns["IsPresent"].ReadOnly = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            if (dataGridViewAttendance.Rows.Count == 0)
            {
                MessageBox.Show("No students available to save attendance.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    foreach (DataGridViewRow row in dataGridViewAttendance.Rows)
                    {
                        if (row.Cells["StudentID"].Value != null && row.Cells["IsPresent"].Value != DBNull.Value)
                        {
                            int naid = Convert.ToInt32(row.Cells["StudentID"].Value);
                            string studentName = row.Cells["Name"].Value.ToString();
                            string branch = comboBoxBranch.SelectedItem.ToString();
                            string year = comboBoxYear.SelectedItem.ToString();
                            string semester = comboBoxSemester.SelectedItem.ToString();
                            bool isPresent = Convert.ToBoolean(row.Cells["IsPresent"].Value);
                            DateTime dateTaken = dateTimePicker1.Value.Date;

                            // Check if attendance already exists for this student on this date
                            string checkQuery = "SELECT COUNT(*) FROM Attendance WHERE NAID = @NAID AND DateTaken = @DateTaken";
                            using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                            {
                                checkCmd.Parameters.AddWithValue("@NAID", naid);
                                checkCmd.Parameters.AddWithValue("@DateTaken", dateTaken);
                                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                                if (count == 0) // Only insert if attendance is not already recorded
                                {
                                    string insertQuery = @"INSERT INTO Attendance (NAID, StudentName, Branch, Year, Semester, IsPresent, DateTaken) 
                                                           VALUES (@NAID, @StudentName, @Branch, @Year, @Semester, @IsPresent, @DateTaken)";

                                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                                    {
                                        cmd.Parameters.AddWithValue("@NAID", naid);
                                        cmd.Parameters.AddWithValue("@StudentName", studentName);
                                        cmd.Parameters.AddWithValue("@Branch", branch);
                                        cmd.Parameters.AddWithValue("@Year", year);
                                        cmd.Parameters.AddWithValue("@Semester", semester);
                                        cmd.Parameters.AddWithValue("@IsPresent", isPresent);
                                        cmd.Parameters.AddWithValue("@DateTaken", dateTaken);

                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }

                    MessageBox.Show("Attendance Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving Attendance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
