﻿namespace CollageManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.admissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upgradeSemesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.induToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeAttendaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.aiChatBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxShowPassword);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(730, 256);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 338);
            this.panel1.TabIndex = 3;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(469, 217);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(133, 21);
            this.checkBoxShowPassword.TabIndex = 7;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Teacher",
            "Student"});
            this.comboBox1.Location = new System.Drawing.Point(247, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 43);
            this.comboBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 44);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(291, 272);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(247, 209);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 42);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(247, 164);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 42);
            this.textBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(106, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(106, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admissionToolStripMenuItem,
            this.feesToolStripMenuItem,
            this.studentDetailsToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.takeAttendaceToolStripMenuItem,
            this.submissionToolStripMenuItem,
            this.noticeToolStripMenuItem,
            this.removeStudentToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitSystemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 38);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1745, 72);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // admissionToolStripMenuItem
            // 
            this.admissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.upgradeSemesterToolStripMenuItem});
            this.admissionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admissionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("admissionToolStripMenuItem.Image")));
            this.admissionToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admissionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.admissionToolStripMenuItem.Name = "admissionToolStripMenuItem";
            this.admissionToolStripMenuItem.Size = new System.Drawing.Size(181, 68);
            this.admissionToolStripMenuItem.Text = "Admission";
            this.admissionToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(284, 40);
            this.newToolStripMenuItem.Text = "New Admission";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // upgradeSemesterToolStripMenuItem
            // 
            this.upgradeSemesterToolStripMenuItem.Name = "upgradeSemesterToolStripMenuItem";
            this.upgradeSemesterToolStripMenuItem.Size = new System.Drawing.Size(284, 40);
            this.upgradeSemesterToolStripMenuItem.Text = "Upgrade Semester";
            this.upgradeSemesterToolStripMenuItem.Click += new System.EventHandler(this.upgradeSemesterToolStripMenuItem_Click);
            // 
            // feesToolStripMenuItem
            // 
            this.feesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("feesToolStripMenuItem.Image")));
            this.feesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.feesToolStripMenuItem.Name = "feesToolStripMenuItem";
            this.feesToolStripMenuItem.Size = new System.Drawing.Size(131, 68);
            this.feesToolStripMenuItem.Text = "Fees";
            this.feesToolStripMenuItem.Click += new System.EventHandler(this.feesToolStripMenuItem_Click);
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStudentToolStripMenuItem,
            this.induToolStripMenuItem});
            this.studentDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentDetailsToolStripMenuItem.Image")));
            this.studentDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(216, 68);
            this.studentDetailsToolStripMenuItem.Text = "Search Student";
            this.studentDetailsToolStripMenuItem.Click += new System.EventHandler(this.studentDetailsToolStripMenuItem_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(274, 40);
            this.searchStudentToolStripMenuItem.Text = "Search Student";
            this.searchStudentToolStripMenuItem.Click += new System.EventHandler(this.searchStudentToolStripMenuItem_Click);
            // 
            // induToolStripMenuItem
            // 
            this.induToolStripMenuItem.Name = "induToolStripMenuItem";
            this.induToolStripMenuItem.Size = new System.Drawing.Size(274, 40);
            this.induToolStripMenuItem.Text = "Individual Details";
            this.induToolStripMenuItem.Click += new System.EventHandler(this.induToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeaToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.teacherToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("teacherToolStripMenuItem.Image")));
            this.teacherToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teacherToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(171, 68);
            this.teacherToolStripMenuItem.Text = "Teachers";
            // 
            // addTeaToolStripMenuItem
            // 
            this.addTeaToolStripMenuItem.Name = "addTeaToolStripMenuItem";
            this.addTeaToolStripMenuItem.Size = new System.Drawing.Size(361, 40);
            this.addTeaToolStripMenuItem.Text = "Add Teacher Information";
            this.addTeaToolStripMenuItem.Click += new System.EventHandler(this.addTeaToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(361, 40);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // takeAttendaceToolStripMenuItem
            // 
            this.takeAttendaceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("takeAttendaceToolStripMenuItem.Image")));
            this.takeAttendaceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeAttendaceToolStripMenuItem.Name = "takeAttendaceToolStripMenuItem";
            this.takeAttendaceToolStripMenuItem.Size = new System.Drawing.Size(249, 68);
            this.takeAttendaceToolStripMenuItem.Text = "Take Attendance";
            this.takeAttendaceToolStripMenuItem.Click += new System.EventHandler(this.takeAttendanceToolStripMenuItem_Click);
            // 
            // submissionToolStripMenuItem
            // 
            this.submissionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submissionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("submissionToolStripMenuItem.Image")));
            this.submissionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.submissionToolStripMenuItem.Name = "submissionToolStripMenuItem";
            this.submissionToolStripMenuItem.Size = new System.Drawing.Size(200, 68);
            this.submissionToolStripMenuItem.Text = "Submission";
            this.submissionToolStripMenuItem.Click += new System.EventHandler(this.submissionToolStripMenuItem_Click);
            // 
            // noticeToolStripMenuItem
            // 
            this.noticeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("noticeToolStripMenuItem.Image")));
            this.noticeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.noticeToolStripMenuItem.Name = "noticeToolStripMenuItem";
            this.noticeToolStripMenuItem.Size = new System.Drawing.Size(156, 68);
            this.noticeToolStripMenuItem.Text = "Notice";
            this.noticeToolStripMenuItem.Click += new System.EventHandler(this.noticeToolStripMenuItem_Click);
            // 
            // removeStudentToolStripMenuItem
            // 
            this.removeStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeStudentToolStripMenuItem.Image")));
            this.removeStudentToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.removeStudentToolStripMenuItem.Name = "removeStudentToolStripMenuItem";
            this.removeStudentToolStripMenuItem.Size = new System.Drawing.Size(242, 68);
            this.removeStudentToolStripMenuItem.Text = "Remove Student";
            this.removeStudentToolStripMenuItem.Click += new System.EventHandler(this.removeStudentToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(153, 68);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutUsToolStripMenuItem.Image")));
            this.aboutUsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutUsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(177, 68);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // exitSystemToolStripMenuItem
            // 
            this.exitSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.exitSystemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitSystemToolStripMenuItem.Image")));
            this.exitSystemToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitSystemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitSystemToolStripMenuItem.Name = "exitSystemToolStripMenuItem";
            this.exitSystemToolStripMenuItem.Size = new System.Drawing.Size(195, 68);
            this.exitSystemToolStripMenuItem.Text = "Exit System";
            this.exitSystemToolStripMenuItem.Click += new System.EventHandler(this.exitSystemToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 35);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aiChatBotToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1745, 38);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // aiChatBotToolStripMenuItem
            // 
            this.aiChatBotToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aiChatBotToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aiChatBotToolStripMenuItem.Image")));
            this.aiChatBotToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aiChatBotToolStripMenuItem.Name = "aiChatBotToolStripMenuItem";
            this.aiChatBotToolStripMenuItem.Size = new System.Drawing.Size(151, 34);
            this.aiChatBotToolStripMenuItem.Text = "Ai Chat bot";
            this.aiChatBotToolStripMenuItem.Click += new System.EventHandler(this.aiChatBotToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1745, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem admissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upgradeSemesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem induToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem takeAttendaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submissionToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem noticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem aiChatBotToolStripMenuItem;
    }
}

