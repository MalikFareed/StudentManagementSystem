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
    public partial class ucAddTeacher : UserControl
    {
        TeacherCRUD teacherCRUD = TeacherCRUD.getTeacherCRUD;
        public ucAddTeacher()
        {
            InitializeComponent();
        }
        protected void ClearTextBoxes()
        {
            txtName.Text = txtQualification.Text = txtAddress.Text = txtSalary.Text = txtTId.Text = null;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var department = cbDepartment.SelectedItem as Department;
                Teacher teacher = new Teacher();

                teacher.Name = txtName.Text;
                teacher.Qualification = txtQualification.Text;
                teacher.Address = txtAddress.Text;
                teacher.JoiningDate = dtpJoiningDate.Value;
                teacher.DepartmentID = department.DepartmentId;
                teacher.Salary = int.Parse(txtSalary.Text);

                bool added = teacherCRUD.AddTeacher(teacher);
                if (added)
                {
                    MessageBox.Show("Successfully added '" + teacher.Name + "' as new Teacher.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var department = cbDepartment.SelectedItem as Department;
                Teacher teacher = new Teacher()
                {
                    Name = txtName.Text,
                    Qualification = txtQualification.Text,
                    Address = txtAddress.Text,
                    JoiningDate = dtpJoiningDate.Value,
                    DepartmentID = department.DepartmentId,
                    Salary = int.Parse(txtSalary.Text)
                };

                bool added = teacherCRUD.AddTeacher(teacher);
                if (added)
                {
                    MessageBox.Show("Successfully added '" + teacher.Name + "' as new Teacher.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
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
                var teacher = new Teacher
                {
                    TeacherId = int.Parse(txtTId.Text),
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Qualification = txtQualification.Text,
                    JoiningDate = dtpJoiningDate.Value,
                    DepartmentID = department.DepartmentId,
                    Salary = int.Parse(txtSalary.Text)
                };

                bool updated = teacherCRUD.UpdateTeacher(teacher);
                if (updated)
                {
                    MessageBox.Show("Teacher's record updated successfully");
                }
                else
                {
                    MessageBox.Show("Failed to update record!","Note",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            var teachersRecords = teacherCRUD.GetAllTeachers();
            dgvTeachers.DataSource = teachersRecords;
        }

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {          

            try
            {
                var index = e.RowIndex;
                var selectedRow = dgvTeachers.Rows[index];

                txtTId.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtQualification.Text = selectedRow.Cells[2].Value.ToString();
                txtAddress.Text = selectedRow.Cells[3].Value.ToString();
                txtSalary.Text = selectedRow.Cells[4].Value.ToString();
                dtpJoiningDate.Value = Convert.ToDateTime(selectedRow.Cells[5].Value);               
                cbDepartment.Text = selectedRow.Cells[6].Value.ToString();               

                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
