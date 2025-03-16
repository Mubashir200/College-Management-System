using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CollageManagementSystem
{
    public partial class UpgradeSemester : Form
    {
        private void UpgradeSemester_Load(object sender, EventArgs e)
        {
            // This method is required for the form load event
        }

        public UpgradeSemester()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Semester Update Warning!", "Confirm?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection("data source=LAPTOP-FPB233T9\\SQLEXPRESS; database=college; integrated security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(@"
                        UPDATE NewAdmission 
                        SET semester = 
                            CASE 
                                WHEN semester = '1st Semester' THEN '2nd Semester'
                                WHEN semester = '2nd Semester' THEN '3rd Semester'
                                WHEN semester = '3rd Semester' THEN '4th Semester'
                                WHEN semester = '4th Semester' THEN '5th Semester'
                                WHEN semester = '5th Semester' THEN '6th Semester'
                                WHEN semester = '6th Semester' THEN 'Completed'
                                ELSE semester
                            END", con))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Upgrade Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records updated. Check semester values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Upgrade Cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
