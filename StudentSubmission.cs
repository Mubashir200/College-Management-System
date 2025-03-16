using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollageManagementSystem
{
    public partial class StudentSubmission : Form
    {
        public StudentSubmission()
        {
            InitializeComponent();
        }
        private void FetchStudentName(string studentID)
        {
            string connectionString = "Server=LAPTOP-FPB233T9\\SQLEXPRESS;Database=college;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT StudentName FROM dbo.NewAdmission WHERE StudentID = @StudentID", con);
                    cmd.Parameters.AddWithValue("@StudentID", studentID);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        lblStudentName.Text = result.ToString();
                    }
                    else
                    {
                        lblStudentName.Text = "";
                        MessageBox.Show($"Student ID '{studentID}' not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void StudentSubmission_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                FetchStudentName(txtStudentID.Text); // Fetch student name
                LoadSubmissionHistory(txtStudentID.Text); // Load previous submissions
            }


            cmbSubmissionType.Items.Clear(); // Clear previous items (if any)

            // Add submission type options dynamically
            cmbSubmissionType.Items.Add("Assignment");
            cmbSubmissionType.Items.Add("Project");
            cmbSubmissionType.Items.Add("Report");
            cmbSubmissionType.Items.Add("Research Paper");
            cmbSubmissionType.Items.Add("Presentation");
            cmbSubmissionType.Items.Add("Lab Report");
            cmbSubmissionType.Items.Add("Homework");
            cmbSubmissionType.Items.Add("Thesis");
            cmbSubmissionType.Items.Add("Quiz Response");

            // Set a default selection to prevent null reference error
            if (cmbSubmissionType.Items.Count > 0)
            {
                cmbSubmissionType.SelectedIndex = 0; // Selects the first item by default
            }

        }

        private void cmbSubmissionType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf|Word Documents|*.docx|Images|*.jpg;*.png|All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                MessageBox.Show("Please enter Student ID and select a file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentID = txtStudentID.Text;
            string submissionType = cmbSubmissionType.SelectedItem.ToString();
            string filePath = txtFilePath.Text;
            string fileName = Path.GetFileName(filePath);

            byte[] fileData = File.ReadAllBytes(filePath);

            using (SqlConnection con = new SqlConnection("data source=LAPTOP-FPB233T9\\SQLEXPRESS;database=college;integrated security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Submissions (StudentID, SubmissionType, FileName, FileData) VALUES (@StudentID, @Type, @FileName, @FileData)", con);
                cmd.Parameters.AddWithValue("@StudentID", studentID);
                cmd.Parameters.AddWithValue("@Type", submissionType);
                cmd.Parameters.AddWithValue("@FileName", fileName);
                cmd.Parameters.AddWithValue("@FileData", fileData);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Submission uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSubmissionHistory(studentID);  // Update submission history
                }
                else
                {
                    MessageBox.Show("Error uploading submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadSubmissionHistory(string studentID)
        {
            using (SqlConnection con = new SqlConnection("data source=LAPTOP-FPB233T9\\SQLEXPRESS;database=college;integrated security=True"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT SubmissionType, FileName, SubmissionDate FROM Submissions WHERE StudentID = @StudentID", con);
                da.SelectCommand.Parameters.AddWithValue("@StudentID", studentID);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSubmissionHistory.DataSource = dt;
            }
        }

        private void StudentSubmission_Load_1(object sender, EventArgs e)
        {

            txtStudentID.TextChanged += (s, ev) =>
            {
                if (!string.IsNullOrWhiteSpace(txtStudentID.Text))
                {
                    FetchStudentName(txtStudentID.Text);
                    LoadSubmissionHistory(txtStudentID.Text);
                }
            };
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                FetchStudentName(txtStudentID.Text);
            }
        }
    }
}

