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
    public partial class ucAddDepartment : UserControl
    {
        DepartmentCRUD departmentCRUD = DepartmentCRUD.getDepartmentCRUD;
        public ucAddDepartment()
        {
            InitializeComponent();
        }
        protected void ClearTextBoxes()
        {
            txtName.Text = txtDId.Text = null;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            dgvDepartments.DataSource = null;
        }      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var foundDepartmnet = departmentCRUD.FindDepartmnet(txtName.Text);
                if (!foundDepartmnet)
                {
                    var departmnet = new Department();
                    departmnet.Name = txtName.Text;
                    var result = departmentCRUD.AddDepartment(departmnet);
                    if (result)
                    {
                        MessageBox.Show("Successfully added '" + txtName.Text + "' as new Departmnet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Department already exists!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDepartments.DataSource = departmentCRUD.GetAllDepartments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var department = new Department
                {
                    DepartmentId = int.Parse(txtDId.Text),
                    Name = txtName.Text
                };
                var updated = departmentCRUD.UpdateDepartment(department);
                if (updated)
                {
                    MessageBox.Show("Department's record updated successfully");
                }
                else
                {
                    MessageBox.Show("Failed to update record!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                var selectedRow = dgvDepartments.Rows[index];

                txtDId.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();

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
            if (MessageBox.Show("Are you sure to Delete this record!", "Note", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                try
                {
                    if (txtDId.Text != "")
                    {
                        var deleted = departmentCRUD.DeleteDepartment(int.Parse(txtDId.Text));
                        if (deleted)
                        {
                            MessageBox.Show("Deleted successfully");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No record found!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
