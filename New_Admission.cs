using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using System.Text.RegularExpressions;



namespace CollageManagementSystem
{

    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex nameRegex = new Regex(@"^[a-zA-Z\s]+$");

            if (string.IsNullOrWhiteSpace(txtFullName.Text) || !nameRegex.IsMatch(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required and should contain only letters!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMotherName.Text) || !nameRegex.IsMatch(txtMotherName.Text))
            {
                MessageBox.Show("Mother's Name is required and should contain only letters!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtMobile.Text, @"^[0-9]{10,15}$"))
            {
                MessageBox.Show("Mobile number should contain only numbers (10-15 digits)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter a valid Email ID!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                MessageBox.Show("Please select a Gender!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = radioButtonMale.Checked ? "Male" : "Female";
            string name = txtFullName.Text;
            string mname = txtMotherName.Text;
            string dob = dateTimePickerDOB.Text;
            string email = txtEmail.Text;
            string year = txtYear.Text; // Year field from dropdown
            string program = txtProgramming.Text; // Branch field
            string sname = txtSchoolName.Text;
            string duration = txtDuration.Text; // Duration dropdown
            string address = txtAddress.Text;

            Int64 mobile = Int64.Parse(txtMobile.Text);

            try
            {
                SqlConnection con = new SqlConnection("data source = LAPTOP-FPB233T9\\SQLEXPRESS; database =college;integrated security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                // Removed "semester" from query
                cmd.CommandText = "INSERT INTO NewAdmission (fname, mname, gender, dob, mobile, email, year, branch, sname, duration, addres) " +
                                  "VALUES (@fname, @mname, @gender, @dob, @mobile, @email, @year, @branch, @sname, @duration, @addres)";

                cmd.Parameters.AddWithValue("@fname", name);
                cmd.Parameters.AddWithValue("@mname", mname);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@mobile", mobile);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@year", year); // Year added correctly
                cmd.Parameters.AddWithValue("@branch", program);
                cmd.Parameters.AddWithValue("@sname", sname);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@addres", address);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved Successfully! Remember the Registration ID.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtAddress.Clear();
            txtMotherName.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            txtProgramming.ResetText();
            txtYear.ResetText();
            txtSchoolName.Clear();
            txtDuration.ResetText();

        }

        private void New_Admission_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-FPB233T9\\SQLEXPRESS;database = college;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select max(NAID) from NewAdmission";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();

            // Check for NULL before conversion
            object value = DS.Tables[0].Rows[0][0];

            Int64 abc = (value == DBNull.Value || value == null) ? 0 : Convert.ToInt64(value);

            label13.Text = (abc + 1).ToString();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
