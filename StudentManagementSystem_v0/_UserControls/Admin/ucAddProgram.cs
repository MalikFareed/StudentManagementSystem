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
    public partial class ucAddProgram : UserControl
    {
        ProgramCRUD programCRUD = ProgramCRUD.getProgramCRUD;
        public ucAddProgram()
        {
            InitializeComponent();
        }
        protected void ClearTextBoxes()
        {
            txtTitle.Text = txtPId.Text = null;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            dgvPrograms.DataSource = null;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var foundprogram = programCRUD.FindProgram(txtTitle.Text);
                if (!foundprogram)
                {
                    bool result = programCRUD.AddProgram(txtTitle.Text);
                    if (result)
                    {
                        MessageBox.Show("Successfully added '" + txtTitle.Text + "' as new Program.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Program already exists!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                dgvPrograms.DataSource = null;
                dgvPrograms.DataSource = programCRUD.getAllPrograms();
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
                var program = new Programs
                {
                    ProgramsId = int.Parse(txtPId.Text),
                    Title = txtTitle.Text
                };
                var updated = programCRUD.UpdateProgram(program);
                if (updated)
                {
                    MessageBox.Show("Program's record updated successfully");
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

        private void dgvPrograms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                var selectedRow = dgvPrograms.Rows[index];

                txtPId.Text = selectedRow.Cells[0].Value.ToString();
                txtTitle.Text = selectedRow.Cells[1].Value.ToString();

                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
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
                    if (txtPId.Text != "")
                    {
                        var deleted = programCRUD.DeleteProgram(int.Parse(txtPId.Text));
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
