namespace StudentManagementSystem_v0._UserControls
{
    partial class ucRegisterCourse
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRegisteredCourses = new System.Windows.Forms.DataGridView();
            this.txtCoursetitle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbOfferedCourses = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Courses Offered";
            // 
            // dgvRegisteredCourses
            // 
            this.dgvRegisteredCourses.AllowUserToAddRows = false;
            this.dgvRegisteredCourses.AllowUserToDeleteRows = false;
            this.dgvRegisteredCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegisteredCourses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRegisteredCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisteredCourses.Location = new System.Drawing.Point(3, 202);
            this.dgvRegisteredCourses.Name = "dgvRegisteredCourses";
            this.dgvRegisteredCourses.ReadOnly = true;
            this.dgvRegisteredCourses.Size = new System.Drawing.Size(740, 490);
            this.dgvRegisteredCourses.TabIndex = 69;
            this.dgvRegisteredCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegisteredCourses_CellClick);
            // 
            // txtCoursetitle
            // 
            this.txtCoursetitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoursetitle.Enabled = false;
            this.txtCoursetitle.Location = new System.Drawing.Point(568, 109);
            this.txtCoursetitle.Name = "txtCoursetitle";
            this.txtCoursetitle.ReadOnly = true;
            this.txtCoursetitle.Size = new System.Drawing.Size(173, 20);
            this.txtCoursetitle.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(522, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Course";
            // 
            // cbOfferedCourses
            // 
            this.cbOfferedCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOfferedCourses.FormattingEnabled = true;
            this.cbOfferedCourses.Location = new System.Drawing.Point(157, 110);
            this.cbOfferedCourses.Name = "cbOfferedCourses";
            this.cbOfferedCourses.Size = new System.Drawing.Size(233, 21);
            this.cbOfferedCourses.TabIndex = 72;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_left_arrow;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(641, 135);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 44);
            this.btnRemove.TabIndex = 67;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = global::StudentManagementSystem_v0.Properties.Resources.icons8_right_arrow;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.Location = new System.Drawing.Point(290, 139);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 40);
            this.btnRegister.TabIndex = 66;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(567, 72);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(173, 20);
            this.txtID.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "ID";
            // 
            // txtSID
            // 
            this.txtSID.Enabled = false;
            this.txtSID.Location = new System.Drawing.Point(157, 72);
            this.txtSID.Name = "txtSID";
            this.txtSID.ReadOnly = true;
            this.txtSID.Size = new System.Drawing.Size(233, 20);
            this.txtSID.TabIndex = 74;
            this.txtSID.Text = "7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 48);
            this.label1.TabIndex = 78;
            this.label1.Text = " Course Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucRegisterCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.cbOfferedCourses);
            this.Controls.Add(this.txtCoursetitle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvRegisteredCourses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRegister);
            this.Name = "ucRegisterCourse";
            this.Size = new System.Drawing.Size(746, 695);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisteredCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtCoursetitle;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbOfferedCourses;
        public System.Windows.Forms.DataGridView dgvRegisteredCourses;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
