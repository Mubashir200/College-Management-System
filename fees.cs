using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (txtRegNumber.Text != "")
            { 

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-FPB233T9\\SQLEXPRESS;database = college;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select fname,mname,duration from NewAdmission where NAID = "+txtRegNumber.Text+"";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

                if (DS.Tables[0].Rows.Count != 0)
                {
                    fnameLabel.Text = DS.Tables[0].Rows[0][0].ToString();
                    MnameLabel.Text = DS.Tables[0].Rows[0][1].ToString();
                    DurationLabel.Text = DS.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    fnameLabel.Text = "_______";
                    MnameLabel.Text = "_______";
                    DurationLabel.Text = "_______";
                }
            }
            else
            {
                txtRegNumber.Text = "";
                txtRegNumber.Text = "";
                fnameLabel.Text = "_______";
                MnameLabel.Text = "_______";
                DurationLabel.Text = "_______";
            }
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-FPB233T9\\SQLEXPRESS;database = college;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from fees where NAID = " + txtRegNumber.Text + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);


            if(DS.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Fees Already Submitted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Fees Submitted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "data source = LAPTOP-FPB233T9\\SQLEXPRESS;database = college;integrated security=True";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con1;

            cmd.CommandText = "insert into fees (NAID,fees) values ("+txtRegNumber.Text+","+txtFees.Text+")";
            SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
            DataSet DS1 = new DataSet();
            DA1.Fill(DS1);

            if(MessageBox.Show("Fees Submitted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                txtRegNumber.Text = "";
                txtFees.Text = "";
                fnameLabel.Text = "_______";
                MnameLabel.Text = "_______";
                DurationLabel.Text = "_______";
            }
            else
            {
                MessageBox.Show("Fees is AllReady Submitted.");
                txtRegNumber.Text = "";
                txtFees.Text = "";
                fnameLabel.Text = "_______";
                MnameLabel.Text = "_______";
                DurationLabel.Text = "_______";
            }
        }
    }
}
