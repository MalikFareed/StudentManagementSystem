using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem_v0._CRUD_Operations;

namespace StudentManagementSystem_v0._UserControls
{
    public partial class ucAssignCourses : UserControl
    {
        CourseCRUD courseCRUD = CourseCRUD.getCourseCRUD;
        AssignCourseCRUD assignCourseCRUD = AssignCourseCRUD.getAssignCourseCRUD;
        CourseOfferingsCRUD courseOfferingsCRUD = CourseOfferingsCRUD.getCourseOfferingsCRUD;
        public ucAssignCourses()
        {
            InitializeComponent();
        }

        private void cbSelectTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var teacher = cbSelectTeacher.SelectedItem as Teacher;
                var courses = courseOfferingsCRUD.GetCourseOfferings(teacher.DepartmentID);
               
                cbSelectCourse.DataSource = courses;
                cbSelectCourse.ValueMember = "CourseID";
                cbSelectCourse.DisplayMember = "CourseTitle";

                cbSelectCourse.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = cbSelectTeacher.SelectedItem as Teacher;
                var course = cbSelectCourse.SelectedItem as CourseOffering ;   
                

                var assignCourse = new AssignCourse
                {
                    TeacherID = teacher.TeacherId,
                    CourseID = course.CourseID
                };
                var added = assignCourseCRUD.AddAssignCourse(assignCourse);
                if (added)
                {
                    MessageBox.Show("Course assigned successfully");
                }
                else
                {
                    MessageBox.Show("Error while assigning the course!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAssignCourses.DataSource = null;
                dgvAssignCourses.DataSource = assignCourseCRUD.GetAllAssignedCourses();                              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAssignCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                var selectedRow = dgvAssignCourses.Rows[index];
                txtId.Text = selectedRow.Cells[0].Value.ToString();
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var deleted = assignCourseCRUD.DeleteAssignedCourse(int.Parse(txtId.Text));
                if (deleted)
                {
                    MessageBox.Show("Deleted successfully");
                    txtId.Text = null;
                }
                else
                {
                    MessageBox.Show("Error while deleteing!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
