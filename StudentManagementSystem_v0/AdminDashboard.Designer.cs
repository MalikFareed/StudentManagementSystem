namespace StudentManagementSystem_v0
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnPrograms = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ucAddProgram1 = new StudentManagementSystem_v0._UserControls.ucAddProgram();
            this.ucAddDepartment1 = new StudentManagementSystem_v0._UserControls.ucAddDepartment();
            this.ucAddCourse1 = new StudentManagementSystem_v0._UserControls.ucAddCourse();
            this.ucAddStudent1 = new StudentManagementSystem_v0._UserControls.ucAddStudent();
            this.ucAddTeacher1 = new StudentManagementSystem_v0._UserControls.ucAddTeacher();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 35);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Management System";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::StudentManagementSystem_v0.Properties.Resources.Minimize_Window_104px;
            this.pictureBox3.Location = new System.Drawing.Point(1008, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::StudentManagementSystem_v0.Properties.Resources.Restore_Window_104px;
            this.pictureBox2.Location = new System.Drawing.Point(1044, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1080, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btnDepartments);
            this.panel2.Controls.Add(this.btnPrograms);
            this.panel2.Controls.Add(this.btnCourses);
            this.panel2.Controls.Add(this.btnTeachers);
            this.panel2.Controls.Add(this.btnStudents);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 755);
            this.panel2.TabIndex = 3;
            // 
            // btnDepartments
            // 
            this.btnDepartments.BackColor = System.Drawing.Color.Transparent;
            this.btnDepartments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDepartments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartments.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDepartments.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_department;
            this.btnDepartments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartments.Location = new System.Drawing.Point(5, 326);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(238, 54);
            this.btnDepartments.TabIndex = 15;
            this.btnDepartments.Text = "   Departments";
            this.btnDepartments.UseVisualStyleBackColor = false;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // btnPrograms
            // 
            this.btnPrograms.BackColor = System.Drawing.Color.Transparent;
            this.btnPrograms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrograms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrograms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrograms.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrograms.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_p;
            this.btnPrograms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrograms.Location = new System.Drawing.Point(5, 266);
            this.btnPrograms.Name = "btnPrograms";
            this.btnPrograms.Size = new System.Drawing.Size(238, 54);
            this.btnPrograms.TabIndex = 14;
            this.btnPrograms.Text = "Programs";
            this.btnPrograms.UseVisualStyleBackColor = false;
            this.btnPrograms.Click += new System.EventHandler(this.btnPrograms_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.Transparent;
            this.btnCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCourses.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_book;
            this.btnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.Location = new System.Drawing.Point(5, 206);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(238, 54);
            this.btnCourses.TabIndex = 13;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.BackColor = System.Drawing.Color.Transparent;
            this.btnTeachers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnTeachers.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_training;
            this.btnTeachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeachers.Location = new System.Drawing.Point(5, 146);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(238, 54);
            this.btnTeachers.TabIndex = 12;
            this.btnTeachers.Text = "Teachers";
            this.btnTeachers.UseVisualStyleBackColor = false;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.Transparent;
            this.btnStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnStudents.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_students;
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Location = new System.Drawing.Point(5, 86);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(238, 54);
            this.btnStudents.TabIndex = 9;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(74, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Menu";
            // 
            // ucAddProgram1
            // 
            this.ucAddProgram1.Location = new System.Drawing.Point(338, 111);
            this.ucAddProgram1.Name = "ucAddProgram1";
            this.ucAddProgram1.Size = new System.Drawing.Size(700, 500);
            this.ucAddProgram1.TabIndex = 6;
            // 
            // ucAddDepartment1
            // 
            this.ucAddDepartment1.Location = new System.Drawing.Point(542, 120);
            this.ucAddDepartment1.Name = "ucAddDepartment1";
            this.ucAddDepartment1.Size = new System.Drawing.Size(700, 500);
            this.ucAddDepartment1.TabIndex = 5;
            // 
            // ucAddCourse1
            // 
            this.ucAddCourse1.Location = new System.Drawing.Point(542, 136);
            this.ucAddCourse1.Name = "ucAddCourse1";
            this.ucAddCourse1.Size = new System.Drawing.Size(700, 500);
            this.ucAddCourse1.TabIndex = 4;
            // 
            // ucAddStudent1
            // 
            this.ucAddStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddStudent1.Location = new System.Drawing.Point(248, 35);
            this.ucAddStudent1.Name = "ucAddStudent1";
            this.ucAddStudent1.Size = new System.Drawing.Size(865, 755);
            this.ucAddStudent1.TabIndex = 9;
            // 
            // ucAddTeacher1
            // 
            this.ucAddTeacher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddTeacher1.Location = new System.Drawing.Point(248, 35);
            this.ucAddTeacher1.Name = "ucAddTeacher1";
            this.ucAddTeacher1.Size = new System.Drawing.Size(865, 755);
            this.ucAddTeacher1.TabIndex = 10;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1113, 790);
            this.Controls.Add(this.ucAddTeacher1);
            this.Controls.Add(this.ucAddStudent1);
            this.Controls.Add(this.ucAddProgram1);
            this.Controls.Add(this.ucAddDepartment1);
            this.Controls.Add(this.ucAddCourse1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private _UserControls.ucAddCourse ucAddCourse1;
        private _UserControls.ucAddDepartment ucAddDepartment1;
        private _UserControls.ucAddProgram ucAddProgram1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnPrograms;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnDepartments;
        private _UserControls.ucAddStudent ucAddStudent1;
        private _UserControls.ucAddTeacher ucAddTeacher1;
    }
}

