namespace StudentManagementSystem_v0._UserControls
{
    partial class ucViewCourses
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
            this.dgvViewCourses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewCourses
            // 
            this.dgvViewCourses.AllowUserToAddRows = false;
            this.dgvViewCourses.AllowUserToDeleteRows = false;
            this.dgvViewCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewCourses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewCourses.Location = new System.Drawing.Point(0, 51);
            this.dgvViewCourses.Name = "dgvViewCourses";
            this.dgvViewCourses.ReadOnly = true;
            this.dgvViewCourses.Size = new System.Drawing.Size(746, 644);
            this.dgvViewCourses.TabIndex = 70;
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
            this.label1.TabIndex = 71;
            this.label1.Text = " Current Teaching Courses";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvViewCourses);
            this.Name = "ucViewCourses";
            this.Size = new System.Drawing.Size(746, 695);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvViewCourses;
        private System.Windows.Forms.Label label1;
    }
}
