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
    public partial class ucRegisterCourse : UserControl
    {
        CourseRegistrationCRUD courseRegistrationCRUD = CourseRegistrationCRUD.getCourseRegistrationCRUD;
        public ucRegisterCourse()
        {
            InitializeComponent();
        }
        public void ClearTextBoxes()
        {
            txtID.Text = txtCoursetitle.Text = null;
            btnRemove.Enabled = false;
        }
        public void LoadDGVRegisteredCourses()
        {
            dgvRegisteredCourses.DataSource = null;
            dgvRegisteredCourses.DataSource = 
                courseRegistrationCRUD.GetAllRegisteredCourse(int.Parse(txtSID.Text));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var course = cbOfferedCourses.SelectedItem as CourseOffering;
                var sid = int.Parse(txtSID.Text);

                var registerCourse = new CourseRegistration
                {
                    CourseID = course.CourseID,
                    StudentID = sid
                };
                var registered = courseRegistrationCRUD.RegisterCourse(registerCourse);
                if (registered)
                {
                    MessageBox.Show("Course Registerd successfully");                   
                    LoadDGVRegisteredCourses();
                }
                else
                {
                    MessageBox.Show("Error while registering course!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }        
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var removed = courseRegistrationCRUD.RemoveRegisteredCourse(int.Parse(txtID.Text));
                if (removed)
                {
                    MessageBox.Show("Course removed successfully");
                    ClearTextBoxes();
                    LoadDGVRegisteredCourses();
                }
                else
                {
                    MessageBox.Show("Error while removing course!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRegisteredCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                var selectedRow = dgvRegisteredCourses.Rows[index];
                txtID.Text = selectedRow.Cells[0].Value.ToString();
                txtCoursetitle.Text = selectedRow.Cells[1].Value.ToString();

                btnRemove.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
