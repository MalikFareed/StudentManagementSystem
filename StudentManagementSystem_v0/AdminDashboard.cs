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
        ProgramCRUD programCRUD = ProgramCRUD.getProgramCRUD;
        ClassScheduleCRUD classScheduleCRUD = ClassScheduleCRUD.getClassScheduleCRUD;
        DepartmentCRUD departmentCRUD = DepartmentCRUD.getDepartmentCRUD;
        TeacherCRUD teacherCRUD = TeacherCRUD.getTeacherCRUD;
        public AdminDashboard()
        {
            InitializeComponent();
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
            
        }      
        private void button1_Click(object sender, EventArgs e)
        {
            ucAddTeacher1.Hide();
            ucAddCourse1.Hide();
            ucAddProgram1.Hide();
            ucAddDepartment1.Hide();

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
            ucAddProgram1.BringToFront();
            ucAddProgram1.Show();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            ucAddStudent1.Hide();
            ucAddTeacher1.Hide();
            ucAddCourse1.Hide();
            ucAddProgram1.Hide();
            ucAddDepartment1.BringToFront();
            ucAddDepartment1.Show();
        }
    }
}
