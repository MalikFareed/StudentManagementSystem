using StudentManagementSystem_v0._CRUD_Operations;
using StudentManagementSystem_v0._UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_v0
{
    public partial class TeacherDashboard : Form
    {
        int leftPanelWidth;
        bool isCollapsed;
        AssignCourseCRUD assignCourseCRUD = AssignCourseCRUD.getAssignCourseCRUD;
        public TeacherDashboard(string _tid)
        {
            InitializeComponent();
            txtTID.Text = _tid;

            leftPanelWidth = pnlLeft.Width;
            isCollapsed = false;
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormActions.ExitApplication();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            FormActions.MaxNormForm(this);            
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            FormActions.MinimizeForm(this);
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            try
            {
                ucViewCourses1.dgvViewCourses.DataSource = null;
                ucViewCourses1.dgvViewCourses.DataSource = assignCourseCRUD.GetAssignedCourses(int.Parse(txtTID.Text));

                ucMarksEntry1.Hide();
                ucViewCourses1.BringToFront();
                ucViewCourses1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {           
            try
            {               
                ucMarksEntry1.cbCourse.DataSource = assignCourseCRUD.GetAssignedCoursesAsCourseObject(int.Parse(txtTID.Text));
                ucMarksEntry1.cbCourse.ValueMember = "CourseId";
                ucMarksEntry1.cbCourse.DisplayMember = "Title" ;
                                
                ucViewCourses1.Hide();
                ucMarksEntry1.BringToFront();
                ucMarksEntry1.Show();
            }
            catch (Exception ex)
            {               
                MessageBox.Show(ex.Message);
            }
        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            ucMarksEntry1.Hide();
            ucViewCourses1.Hide();            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlLeft.Width += 20;
                if (pnlLeft.Width >= leftPanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlLeft.Width -= 20;
                if (pnlLeft.Width <= 48)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
