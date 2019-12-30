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
    public partial class AdminDashboard : Form
    {
        int leftPanelWidth;
        bool isCollapsed;
        ProgramCRUD programCRUD = ProgramCRUD.getProgramCRUD;
        ClassScheduleCRUD classScheduleCRUD = ClassScheduleCRUD.getClassScheduleCRUD;
        DepartmentCRUD departmentCRUD = DepartmentCRUD.getDepartmentCRUD;
        TeacherCRUD teacherCRUD = TeacherCRUD.getTeacherCRUD;
        CourseCRUD courseCRUD = CourseCRUD.getCourseCRUD;
        CourseOfferingsCRUD courseOfferingsCRUD = CourseOfferingsCRUD.getCourseOfferingsCRUD;

        public AdminDashboard()
        {
            InitializeComponent();

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
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            ucAddStudent1.Hide();
            ucAddTeacher1.Hide();
            ucAddCourse1.Hide();
            ucAddProgram1.Hide();
            ucAddDepartment1.Hide();
            ucCourseOfferings1.Hide();
            ucAssignCourses1.Hide();
            
        }      
        private void button1_Click(object sender, EventArgs e)
        {
            ucAddTeacher1.Hide();
            ucAddCourse1.Hide();
            ucAddProgram1.Hide();
            ucAddDepartment1.Hide();
            ucCourseOfferings1.Hide();
            ucAssignCourses1.Hide();

            //loading all programs
            ucAddStudent1.cbProgram.DataSource = null;
            var programs = programCRUD.getAllPrograms();
            ucAddStudent1.cbProgram.DataSource = programs;
            ucAddStudent1.cbProgram.ValueMember = "ProgramsId";
            ucAddStudent1.cbProgram.DisplayMember = "Title";

            //loading class timings
            ucAddStudent1.cbClassesSchedule.DataSource = null;
            var classSchedules = classScheduleCRUD.getAllClassSchedules();
            ucAddStudent1.cbClassesSchedule.DataSource = classSchedules;
            ucAddStudent1.cbClassesSchedule.ValueMember = "Id";
            ucAddStudent1.cbClassesSchedule.DisplayMember = "Time";

            ucAddStudent1.BringToFront();
            ucAddStudent1.Show();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            ucAddStudent1.Hide();
            ucAddCourse1.Hide();
            ucAddProgram1.Hide();
            ucAddDepartment1.Hide();
            ucCourseOfferings1.Hide();
            ucAssignCourses1.Hide();

            //adding departments in cb
            ucAddTeacher1.cbDepartment.DataSource = null;
            var departments = departmentCRUD.GetAllDepartments();
            ucAddTeacher1.cbDepartment.DataSource = departments;
            ucAddTeacher1.cbDepartment.ValueMember = "DepartmentId";
            ucAddTeacher1.cbDepartment.DisplayMember = "Name";

            ucAddTeacher1.BringToFront();
            ucAddTeacher1.Show();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            ucAddStudent1.Hide();
            ucAddTeacher1.Hide();
            ucAddProgram1.Hide();
            ucAddDepartment1.Hide();
            ucCourseOfferings1.Hide();
            ucAssignCourses1.Hide();

            //loading all departmnets in cb
            ucAddCourse1.cbDepartment.DataSource = null;
            var departments = departmentCRUD.GetAllDepartments();
            ucAddCourse1.cbDepartment.DataSource = departments;
            ucAddCourse1.cbDepartment.ValueMember = "DepartmentId";
            ucAddCourse1.cbDepartment.DisplayMember = "Name";

            ucAddCourse1.BringToFront();
            ucAddCourse1.Show();
        }

        private void btnPrograms_Click(object sender, EventArgs e)
        {
            ucAddStudent1.Hide();
            ucAddTeacher1.Hide();
            ucAddCourse1.Hide();
            ucAddDepartment1.Hide();
            ucCourseOfferings1.Hide();
            ucAssignCourses1.Hide();

            ucAddProgram1.BringToFront();
            ucAddProgram1.Show();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            ucAddStudent1.Hide();
            ucAddTeacher1.Hide();
            ucAddCourse1.Hide();
            ucAddProgram1.Hide();
            ucCourseOfferings1.Hide();
            ucAssignCourses1.Hide();

            ucAddDepartment1.BringToFront();
            ucAddDepartment1.Show();
        }

        private void ucAddTeacher1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ucAddStudent1.Hide();
            ucAddTeacher1.Hide();
            ucAddCourse1.Hide();
            ucAddProgram1.Hide();
            ucAddDepartment1.Hide();           
            ucAssignCourses1.Hide();

            try
            {
                var courses = courseCRUD.GetAllCourses();               
                ucCourseOfferings1.cbSelectCourse.DataSource = courses;
                ucCourseOfferings1.cbSelectCourse.ValueMember = "CourseID";
                ucCourseOfferings1.cbSelectCourse.DisplayMember = "Title";

                ucCourseOfferings1.UpdateDGVcourseOfferings();
                ucCourseOfferings1.BringToFront();
                ucCourseOfferings1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucAddStudent1.Hide();
            ucAddTeacher1.Hide();
            ucAddCourse1.Hide();
            ucAddProgram1.Hide();
            ucAddDepartment1.Hide();
            ucCourseOfferings1.Hide();

            try
            {            
                
                ucAssignCourses1.cbSelectTeacher.DataSource = teacherCRUD.GetAllTeachersList();                

                ucAssignCourses1.cbSelectTeacher.ValueMember = "TeacherId";
                ucAssignCourses1.cbSelectTeacher.DisplayMember = "Name";

                ucAssignCourses1.BringToFront();
                ucAssignCourses1.Show();
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

        private void ucCourseOfferings1_Load(object sender, EventArgs e)
        {

        }
    }
}
