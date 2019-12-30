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
    public partial class ucAddCourse : UserControl
    {
        CourseCRUD courseCRUD = CourseCRUD.getCourseCRUD;
        public ucAddCourse()
        {
            InitializeComponent();
        }

        protected void ClearTextBoxes()
        {
            txtTitle.Text = txtCreditHours.Text = txtCId.Text = null;
            dgvCourses.DataSource = null;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
        }
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var foundCourse = courseCRUD.FindCourse(txtTitle.Text);
                if (!foundCourse)
                {
                    var departmnet = cbDepartment.SelectedItem as Department;
                    var course = new Course();
                    course.Title = txtTitle.Text;
                    course.CreditHours = int.Parse(txtCreditHours.Text);
                    course.DepartmentId = departmnet.DepartmentId;

                    var result = courseCRUD.AddCourse(course);
                    if (result)
                    {
                        MessageBox.Show("Successfully added '" + txtTitle.Text + "' as new Course.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Course already exists!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var department = cbDepartment.SelectedItem as Department;
                Course course = new Course
                {
                    CourseId = int.Parse(txtCId.Text),
                    Title = txtTitle.Text,
                    CreditHours = int.Parse(txtCreditHours.Text),
                    DepartmentId = department.DepartmentId
                };
                bool updated = courseCRUD.UpdateCourse(course);
                if (updated)
                {
                    MessageBox.Show("Record updated successfully.");
                }
                else
                {
                    MessageBox.Show("Error while updating Record!");
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
                dgvCourses.DataSource = null;
                dgvCourses.DataSource = courseCRUD.GetAllCoursesWithTitles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                var selectedRow = dgvCourses.Rows[index];

                txtCId.Text = selectedRow.Cells[0].Value.ToString();
                txtTitle.Text = selectedRow.Cells[1].Value.ToString();
                txtCreditHours.Text = selectedRow.Cells[2].Value.ToString();
                cbDepartment.Text = selectedRow.Cells[3].Value.ToString();               

                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;

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
                if(MessageBox.Show("Are you to delete this record?","Note",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool deleted = courseCRUD.DeleteCourse(int.Parse(txtCId.Text));
                    if (deleted)
                    {
                        MessageBox.Show("Record deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting record!");
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
