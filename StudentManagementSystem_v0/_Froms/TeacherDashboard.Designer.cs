namespace StudentManagementSystem_v0
{
    partial class TeacherDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ucMarksEntry1 = new StudentManagementSystem_v0._UserControls.ucMarksEntry();
            this.ucViewCourses1 = new StudentManagementSystem_v0._UserControls.ucViewCourses();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btnMarksEntry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 50);
            this.panel1.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnlLeft.Controls.Add(this.pictureBox5);
            this.pnlLeft.Controls.Add(this.pictureBox4);
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.txtTID);
            this.pnlLeft.Controls.Add(this.btnViewCourses);
            this.pnlLeft.Controls.Add(this.btnMarksEntry);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 50);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(245, 740);
            this.pnlLeft.TabIndex = 3;
            this.pnlLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "TID";
            // 
            // txtTID
            // 
            this.txtTID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTID.Enabled = false;
            this.txtTID.Location = new System.Drawing.Point(110, 132);
            this.txtTID.Name = "txtTID";
            this.txtTID.ReadOnly = true;
            this.txtTID.Size = new System.Drawing.Size(56, 20);
            this.txtTID.TabIndex = 76;
            this.txtTID.Text = "7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(74, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Menu";
            // 
            // ucMarksEntry1
            // 
            this.ucMarksEntry1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMarksEntry1.Location = new System.Drawing.Point(245, 50);
            this.ucMarksEntry1.Name = "ucMarksEntry1";
            this.ucMarksEntry1.Size = new System.Drawing.Size(868, 740);
            this.ucMarksEntry1.TabIndex = 5;
            // 
            // ucViewCourses1
            // 
            this.ucViewCourses1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucViewCourses1.Location = new System.Drawing.Point(245, 50);
            this.ucViewCourses1.Name = "ucViewCourses1";
            this.ucViewCourses1.Size = new System.Drawing.Size(868, 740);
            this.ucViewCourses1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_menu;
            this.pictureBox5.Location = new System.Drawing.Point(206, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 31);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::StudentManagementSystem_v0.Properties.Resources.download;
            this.pictureBox4.Location = new System.Drawing.Point(56, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 120);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.BackColor = System.Drawing.Color.Transparent;
            this.btnViewCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCourses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCourses.ForeColor = System.Drawing.Color.White;
            this.btnViewCourses.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_courses;
            this.btnViewCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCourses.Location = new System.Drawing.Point(3, 277);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(236, 54);
            this.btnViewCourses.TabIndex = 13;
            this.btnViewCourses.Text = "   View Courses";
            this.btnViewCourses.UseVisualStyleBackColor = false;
            this.btnViewCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnMarksEntry
            // 
            this.btnMarksEntry.BackColor = System.Drawing.Color.Transparent;
            this.btnMarksEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMarksEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarksEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarksEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarksEntry.ForeColor = System.Drawing.Color.White;
            this.btnMarksEntry.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_report_card_11;
            this.btnMarksEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarksEntry.Location = new System.Drawing.Point(0, 217);
            this.btnMarksEntry.Name = "btnMarksEntry";
            this.btnMarksEntry.Size = new System.Drawing.Size(239, 54);
            this.btnMarksEntry.TabIndex = 12;
            this.btnMarksEntry.Text = "Marks Entry";
            this.btnMarksEntry.UseVisualStyleBackColor = false;
            this.btnMarksEntry.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_manager;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(362, 13);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(354, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Management System     ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::StudentManagementSystem_v0.Properties.Resources.Minimize_Window_104px;
            this.pictureBox3.Location = new System.Drawing.Point(1003, 8);
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
            this.pictureBox2.Location = new System.Drawing.Point(1039, 8);
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
            this.pictureBox1.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_close_window_22;
            this.pictureBox1.Location = new System.Drawing.Point(1075, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // TeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1113, 790);
            this.Controls.Add(this.ucMarksEntry1);
            this.Controls.Add(this.ucViewCourses1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TeacherDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMarksEntry;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtTID;
        private _UserControls.ucViewCourses ucViewCourses1;
        private _UserControls.ucMarksEntry ucMarksEntry1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
    }
}

