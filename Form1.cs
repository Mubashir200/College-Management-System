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
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
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



        private void label4_Click(object sender, EventArgs e)
        {
            // Add your functionality here
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Add your functionality here
        }

        private void noticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentNotice sn = new StudentNotice();
            sn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Add your functionality here
        }

      
     

        private void submissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentSubmission studentSubmission = new StudentSubmission();
            studentSubmission.Show();
        }

        private void takeAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakeAttendance ta = new TakeAttendance();
            ta.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Add your functionality here
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            menuStrip1.Visible = false; // Hide menu initially
            menuStrip2.Visible = false; // Hide menu initially
            panel1.Visible = true;      // Ensure login panel is visible

            // Button hover effect
            this.button1.MouseEnter += (s, ev) => this.button1.BackColor = Color.FromArgb(41, 128, 185);
            this.button1.MouseLeave += (s, ev) => this.button1.BackColor = Color.FromArgb(52, 152, 219);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string userRole = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(userRole))
            {
                MessageBox.Show("Please select a role before proceeding.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsValidLogin(userRole, username, password))
            {
                MessageBox.Show($"Welcome {userRole}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Now make UI changes after message box is dismissed
                menuStrip1.Visible = true;
                menuStrip2.Visible = true;
                panel1.Visible = false;
                SetMenuVisibility(userRole); // Update menu visibility based on role
            }
            else
            {
                MessageBox.Show("Invalid User ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private bool IsValidLogin(string role, string username, string password)
        {
            return (role == "Student" && username == "student" && password == "student") ||
                   (role == "Teacher" && username == "teacher" && password == "teacher") ||
                   (role == "Admin" && username == "admin" && password == "admin");
        }

        private void SetMenuVisibility(string role)
        {
            // Hide all menu items first (But DON'T disable them)
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                item.Visible = false;

            }
           


            // Show relevant menu items
            if (role == "Student")
            {
                feesToolStripMenuItem.Visible = true;
                submissionToolStripMenuItem.Visible = true;
                noticeToolStripMenuItem.Visible = true;
                aiChatBotToolStripMenuItem.Visible = true;
            }
            else if (role == "Teacher")
            {
                studentDetailsToolStripMenuItem.Visible = true;
                takeAttendaceToolStripMenuItem.Visible = true;
                submissionToolStripMenuItem.Visible = true;
                noticeToolStripMenuItem.Visible = true;
                aiChatBotToolStripMenuItem.Visible = true;
            }
            else if (role == "Admin")
            {
                foreach (ToolStripItem item in menuStrip1.Items)
                {
                    item.Visible = true; // Show everything for Admin
                }
                foreach (ToolStripItem item in menuStrip2.Items)
                {
                    item.Visible = true; // Show everything for Admin
                }
            }

            // Common menu items for all roles
            logoutToolStripMenuItem.Visible = true;
            aboutUsToolStripMenuItem.Visible = true;
            exitSystemToolStripMenuItem.Visible = true;
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = false; // Hide menu
            menuStrip2.Visible = false; // Hide menu
            panel1.Visible = true;      // Show login panel again
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1; // Reset role selection
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aiChatBotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChatBot chatBot = new ChatBot();
            chatBot.Show();
        }
    }
}
