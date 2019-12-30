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
    public partial class ucMarksEntry : UserControl
    {
        CourseRegistrationCRUD courseRegistrationCRUD = CourseRegistrationCRUD.getCourseRegistrationCRUD;
        MarksEntryCRUD marksEntryCRUD = MarksEntryCRUD.getMarksEntryCRUD;

        public ucMarksEntry()
        {
            InitializeComponent();
        }

        private void ClearTextBoxes()
        {
            txtId.Text = txtAssignment.Text = txtQuiz.Text = txtProject.Text = txtMid.Text = txtFinal.Text = null;
            btnRemove.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
        }        
        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {               
                var course = cbCourse.SelectedItem as Course;
                var students = courseRegistrationCRUD.GetStudents(course.CourseId);

                cbStudent.DataSource = null;
                cbStudent.DataSource = students;
                cbStudent.ValueMember = "StudentId";
                cbStudent.DisplayMember = "Name";
                cbStudent.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if ((txtQuiz.Text == "" || int.Parse(txtQuiz.Text) > 5)||
                (txtAssignment.Text == "" || int.Parse(txtAssignment.Text) > 5) ||
                (txtProject.Text == "" || int.Parse(txtProject.Text) > 20) || 
                (txtMid.Text == "" || int.Parse(txtMid.Text) > 30) ||
                ( txtFinal.Text == "" || int.Parse(txtFinal.Text) > 40))
            {
                MessageBox.Show("One or more field(s) empty OR Entered Marks are not correct!");
                return;
            }
            try
            {
                var course = cbCourse.SelectedItem as Course;
                var student = cbStudent.SelectedItem as IStudent;

                var entry = new MarksEntry
                {
                    CourseID = course.CourseId,
                    StudentID = student.StudentId,
                    Quizes = int.Parse(txtQuiz.Text),
                    Assignments = int.Parse(txtAssignment.Text),
                    Project = int.Parse(txtProject.Text),
                    Mid = int.Parse(txtMid.Text),
                    Final = int.Parse(txtFinal.Text)
                };
                var added = marksEntryCRUD.AddMarksEntry(entry);
                if (added)
                {
                    MessageBox.Show("Marks entered successfully");
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Failed to enter marks!");
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
                var course = cbCourse.SelectedItem as Course;

                dgvMarks.DataSource = null;
                dgvMarks.DataSource = marksEntryCRUD.GetAllEnteries(course.CourseId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dgvMarks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = e.RowIndex;
                var selectedRow = dgvMarks.Rows[index];
                txtId.Text = selectedRow.Cells[0].Value.ToString();
                cbCourse.Text = selectedRow.Cells[1].Value.ToString();
                txtQuiz.Text = selectedRow.Cells[3].Value.ToString();
                txtAssignment.Text = selectedRow.Cells[4].Value.ToString();
                txtProject.Text = selectedRow.Cells[5].Value.ToString();
                txtMid.Text = selectedRow.Cells[6].Value.ToString();
                txtFinal.Text = selectedRow.Cells[7].Value.ToString();

                btnInsert.Enabled = false;
                btnRemove.Enabled = true;
                btnUpdate.Enabled = true;
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
                var removed = marksEntryCRUD.RemoveEntry(int.Parse(txtId.Text));
                if (removed)
                {
                    MessageBox.Show("Entry removed successfully");
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Error while removing the entry!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtQuiz.Text == "" || int.Parse(txtQuiz.Text) > 5) ||
                (txtAssignment.Text == "" || int.Parse(txtAssignment.Text) > 5) ||
                (txtProject.Text == "" || int.Parse(txtProject.Text) > 20) ||
                (txtMid.Text == "" || int.Parse(txtMid.Text) > 30) ||
                (txtFinal.Text == "" || int.Parse(txtFinal.Text) > 40))
            {
                MessageBox.Show("One or more field(s) empty OR Entered Marks are not correct!");
                return;
            }
            try
            {
                var updated = marksEntryCRUD.UpdateEntry(int.Parse(txtId.Text), int.Parse(txtQuiz.Text), 
                    int.Parse(txtAssignment.Text), int.Parse(txtProject.Text), int.Parse(txtMid.Text), int.Parse(txtFinal.Text));
                if (updated)
                {
                    MessageBox.Show("Entry updated successfully");
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Error while updating entry!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQuiz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        
            {
                e.Handled = true;
            }

        }

    }
}
