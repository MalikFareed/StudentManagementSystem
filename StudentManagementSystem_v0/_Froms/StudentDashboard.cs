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
    public partial class StudentDashboard : Form
    {
        int leftPanelWidth;
        bool isCollapsed;
        CourseOfferingsCRUD courseOfferingsCRUD = CourseOfferingsCRUD.getCourseOfferingsCRUD;
        CourseRegistrationCRUD courseRegistrationCRUD = CourseRegistrationCRUD.getCourseRegistrationCRUD;
        public StudentDashboard(string _sid)
        {            
            InitializeComponent();
            txtSID.Text = _sid;

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
                ucRegisterCourse1.dgvRegisteredCourses.DataSource = null;
                ucRegisterCourse1.cbOfferedCourses.DataSource = courseOfferingsCRUD.GetCourseOfferings();
                ucRegisterCourse1.cbOfferedCourses.ValueMember = "CourseID";
                ucRegisterCourse1.cbOfferedCourses.DisplayMember = "CourseTitle";

                ucRegisterCourse1.dgvRegisteredCourses.DataSource =
                    courseRegistrationCRUD.GetAllRegisteredCourse(int.Parse(txtSID.Text));

                ucCheckResult1.Hide();
                ucViewTranscript1.Hide();
                ucRegisterCourse1.BringToFront();
                ucRegisterCourse1.Show();
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
                var courses = courseRegistrationCRUD.GetAllRegisteredCoursesAsCourseObject(int.Parse(txtSID.Text));
                ucCheckResult1.cbCourse.DataSource = courses;
                ucCheckResult1.cbCourse.ValueMember = "CourseId";
                ucCheckResult1.cbCourse.DisplayMember = "Title";

                ucRegisterCourse1.Hide();
                ucViewTranscript1.Hide();
                ucCheckResult1.BringToFront();
                ucCheckResult1.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void StudentDashboard_Load(object sender, EventArgs e)
        {            
            ucRegisterCourse1.txtSID.Text = txtSID.Text;
            ucCheckResult1.txtSID.Text = txtSID.Text;
            ucViewTranscript1.txtSID.Text = txtSID.Text;
            ucRegisterCourse1.Hide();
            ucCheckResult1.Hide();
            ucViewTranscript1.Hide();
        }
        private void btnViewTranscript_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateTranscript obj = new GenerateTranscript(int.Parse(txtSID.Text));
                ucViewTranscript1.dgvTranscript.DataSource = obj.LoadCourses();

                ucRegisterCourse1.Hide();
                ucCheckResult1.Hide();
                ucViewTranscript1.BringToFront();
                ucViewTranscript1.Show();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
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
