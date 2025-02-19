using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollageManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = textBox1.Text;
            string password = textBox2.Text;
            string userType = comboBox1.SelectedItem?.ToString(); // Get selected user type

            if (userType == "Student" && username == "student" && password == "student")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
                MessageBox.Show("Welcome Student!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (userType == "Teacher" && username == "teacher" && password == "teacher")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
                MessageBox.Show("Welcome Teacher!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (userType == "Admin" && username == "admin" && password == "admin")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
                MessageBox.Show("Welcome Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid User ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Admission na = new New_Admission();
            na.Show();

        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpgradeSemester us = new UpgradeSemester();
            us.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fees fs = new fees();
            fs.Show();

        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
        }

        private void induToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentIndividualDetail sid = new StudentIndividualDetail();
            sid.Show();
        }

        private void addTeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher at = new AddTeacher();
            at.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher st = new SearchTeacher();
            st.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            rs.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
             
        }

        private void takeAttendaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeAttendance ta = new TakeAttendance();
            ta.Show();
        }

        private void submissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentSubmission studentSubmission = new StudentSubmission();
            studentSubmission.Show();
        }

        private void noticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentNotice sn = new StudentNotice();
            sn.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            Form1 login = new Form1(); 
            login.Show(); // Show the login form
        }

    }
}

