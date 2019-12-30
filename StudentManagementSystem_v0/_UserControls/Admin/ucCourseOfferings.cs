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
    public partial class ucCourseOfferings : UserControl
    {
        CourseOfferingsCRUD courseOfferingsCRUD = CourseOfferingsCRUD.getCourseOfferingsCRUD; 
        public ucCourseOfferings()
        {
            InitializeComponent();
        }
        public void ClearTextBoxes()
        {
            txtId.Text = null;
            dgvCourseOfferings.DataSource = null;
            btnDelete.Enabled = false;
        }

        public void UpdateDGVcourseOfferings()
        {
            dgvCourseOfferings.DataSource = null;
            dgvCourseOfferings.DataSource = courseOfferingsCRUD.GetAllCourseOfferings();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = cbSelectCourse.SelectedItem as Course;
                var courseOffering = new CourseOffering
                {
                    CourseID = course.CourseId,
                    CourseTitle = course.Title,
                    Course = course                    
                };
                var added = courseOfferingsCRUD.AddCourseOffering(courseOffering);
                if (added)
                {
                    MessageBox.Show("Course offered successfully.");
                    UpdateDGVcourseOfferings();
                }
                else
                {
                    MessageBox.Show("Error while offering the course!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCourseOfferings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                var selectedRow = dgvCourseOfferings.Rows[index];
                txtId.Text = selectedRow.Cells[0].Value.ToString();

                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var deleted = courseOfferingsCRUD.DeleteCourseOffering(int.Parse(txtId.Text));
                if (deleted)
                {
                    MessageBox.Show("Course offering removed successfully");
                }
                UpdateDGVcourseOfferings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
