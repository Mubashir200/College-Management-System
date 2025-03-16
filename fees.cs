using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CollageManagementSystem
{
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
        }

        private void txtRegNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegNumber.Text))
            {
                ResetFields();
                return;
            }

            // Validate input (ensure it's a number)
            if (!IsNumeric(txtRegNumber.Text))
            {
                MessageBox.Show("Registration Number must be numeric!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegNumber.Clear(); // Clears input ONLY if it's invalid
                return;
            }

            using (SqlConnection con = new SqlConnection("data source=LAPTOP-FPB233T9\\SQLEXPRESS;database=college;integrated security=True"))
            {
                con.Open();
                string query = "SELECT fname, mname, duration FROM NewAdmission WHERE NAID = @NAID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NAID", txtRegNumber.Text);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        fnameLabel.Text = reader["fname"].ToString();
                        MnameLabel.Text = reader["mname"].ToString();
                        DurationLabel.Text = reader["duration"].ToString();
                    }
                    else
                    {
                        ResetFields();
                    }
                }
            }
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegNumber.Text) || string.IsNullOrWhiteSpace(txtFees.Text))
            {
                MessageBox.Show("Please enter Registration Number and Fees!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection("data source=LAPTOP-FPB233T9\\SQLEXPRESS;database=college;integrated security=True"))
            {
                con.Open();

                // Check if fees already exist
                string checkQuery = "SELECT COUNT(*) FROM fees WHERE NAID = @NAID";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@NAID", txtRegNumber.Text);

                int existingRecords = (int)checkCmd.ExecuteScalar();
                if (existingRecords > 0)
                {
                    MessageBox.Show("Fees Already Submitted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert fees record
                string insertQuery = @"
                    INSERT INTO fees (NAID, fees, FullName, MotherName) 
                    SELECT @NAID, @fees, fname, mname FROM NewAdmission WHERE NAID = @NAID";

                SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                insertCmd.Parameters.AddWithValue("@NAID", txtRegNumber.Text);
                insertCmd.Parameters.AddWithValue("@fees", txtFees.Text);
                insertCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Fees Submitted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetFields();
        }

        private void ResetFields()
        {
           // txtRegNumber.Text = "";
           fnameLabel.Text = "_______";
            txtFees.Text = "";
            fnameLabel.Text = "_______";
            MnameLabel.Text = "_______";
            DurationLabel.Text = "_______";
        }

        private void txtRegNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevents typing letters
                MessageBox.Show("Only numbers are allowed!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _); // Returns true if input is a valid number
        }

    }
}
