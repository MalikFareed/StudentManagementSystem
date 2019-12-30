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
    public partial class ucAddStudent : UserControl
    {
        StudentCRUD studentCRUD = StudentCRUD.getStudentCRUD;
        public ucAddStudent()
        {
            InitializeComponent();
        }
        protected void ClearTextBoxes()
        {
            txtName.Text = txtFatherName.Text  = txtAddress.Text = txtSId.Text = null;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
        }   
        private void dgvStudents_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {            
            try
            {
                var index = e.RowIndex;
                var selectedRow = dgvStudents.Rows[index];

                txtSId.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                txtFatherName.Text = selectedRow.Cells[2].Value.ToString();
                txtAddress.Text = selectedRow.Cells[3].Value.ToString();
                dtpDoB.Value = Convert.ToDateTime(selectedRow.Cells[4].Value);
                dtpDoAdmission.Value = Convert.ToDateTime(selectedRow.Cells[5].Value);
                cbProgram.Text = selectedRow.Cells[6].Value.ToString();
                cbClassesSchedule.Text = selectedRow.Cells[7].Value.ToString();

                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;

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
                Programs program = cbProgram.SelectedItem as Programs;
                StudentFactory student;
                MorningStudent morningStudent = null;
                EveningStudent eveningStudent = null;
                WeekendStudent weeklyStudent = null;
                bool insert = false;

                ClassSchedule classSchedule = cbClassesSchedule.SelectedItem as ClassSchedule;

                if (classSchedule.Id == 1)
                {
                    student = new MorningStudentFactory();
                    morningStudent = (MorningStudent)student.GetStudent();
                }
                else if (classSchedule.Id == 2)
                {
                    student = new EveningStudentFactory();
                    eveningStudent = (EveningStudent)student.GetStudent();
                }
                else if (classSchedule.Id == 3)
                {
                    student = new WeekendStudentFactory();
                    weeklyStudent = (WeekendStudent)student.GetStudent();
                }
                else student = null;

                if (student != null)
                {
                    if (classSchedule.Id == 1)
                    {
                        morningStudent.Name = txtName.Text.Trim();
                        morningStudent.FatherName = txtFatherName.Text.Trim();
                        morningStudent.Address = txtAddress.Text.Trim();
                        morningStudent.DateOfBirth = dtpDoB.Value;
                        morningStudent.DateOfAdmission = dtpDoAdmission.Value;
                        morningStudent.ProgramID = program.ProgramsId;
                        morningStudent.ClassScheduleID = classSchedule.Id;

                        insert = studentCRUD.AddStudent(morningStudent);
                        ClearTextBoxes();

                    }
                    else if (classSchedule.Id == 2)
                    {
                        eveningStudent.Name = txtName.Text.Trim();
                        eveningStudent.FatherName = txtFatherName.Text.Trim();
                        eveningStudent.Address = txtAddress.Text.Trim();
                        eveningStudent.DateOfBirth = dtpDoB.Value;
                        eveningStudent.DateOfAdmission = dtpDoAdmission.Value;
                        eveningStudent.ProgramID = program.ProgramsId;
                        eveningStudent.ClassScheduleID = classSchedule.Id;

                        insert = studentCRUD.AddStudent(eveningStudent);
                        ClearTextBoxes();
                    }
                    else if (classSchedule.Id == 3)
                    {
                        weeklyStudent.Name = txtName.Text.Trim();
                        weeklyStudent.FatherName = txtFatherName.Text.Trim();
                        weeklyStudent.Address = txtAddress.Text.Trim();
                        weeklyStudent.DateOfBirth = dtpDoB.Value;
                        weeklyStudent.DateOfAdmission = dtpDoAdmission.Value;
                        weeklyStudent.ProgramID = program.ProgramsId;
                        weeklyStudent.ClassScheduleID = classSchedule.Id;

                        insert = studentCRUD.AddStudent(weeklyStudent);
                        ClearTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Error!");
                }

                if (insert)
                {
                    MessageBox.Show("New Student added successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = null;
            var allStudents = studentCRUD.GetAllStudents();
            dgvStudents.DataSource = allStudents;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var progarm = cbProgram.SelectedItem as Programs;
            var classSchedule = cbClassesSchedule.SelectedItem as ClassSchedule;
            bool updated = false;

            if (classSchedule.Id == 1)
            {
                MorningStudent student = new MorningStudent
                {
                    StudentId = int.Parse(txtSId.Text.Trim()),
                    Name = txtName.Text.Trim(),
                    FatherName = txtFatherName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    DateOfBirth = dtpDoB.Value,
                    DateOfAdmission = dtpDoAdmission.Value,
                    ProgramID = progarm.ProgramsId,
                    ClassScheduleID = classSchedule.Id
                };
                updated = studentCRUD.UpdateStudent(student);
            }
            else if(classSchedule.Id == 2)
            {
                EveningStudent student = new EveningStudent
                {
                    StudentId = int.Parse(txtSId.Text.Trim()),
                    Name = txtName.Text.Trim(),
                    FatherName = txtFatherName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    DateOfBirth = dtpDoB.Value,
                    DateOfAdmission = dtpDoAdmission.Value,
                    ProgramID = progarm.ProgramsId,
                    ClassScheduleID = classSchedule.Id
                };
                updated = studentCRUD.UpdateStudent(student);
            }
            else if (classSchedule.Id == 3)
            {
                WeekendStudent student = new WeekendStudent
                {
                    StudentId = int.Parse(txtSId.Text.Trim()),
                    Name = txtName.Text.Trim(),
                    FatherName = txtFatherName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    DateOfBirth = dtpDoB.Value,
                    DateOfAdmission = dtpDoAdmission.Value,
                    ProgramID = progarm.ProgramsId,
                    ClassScheduleID = classSchedule.Id
                };
                updated = studentCRUD.UpdateStudent(student);
            }
            if (updated)
            {
                MessageBox.Show("Updated Successfully");
            }
        }

        private void cbClassesSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }      

        private void cbClassesSchedule_Click(object sender, EventArgs e)
        {           
            if (txtSId.Text != "")
            {
                var classSchedule = cbClassesSchedule.SelectedItem as ClassSchedule;
                studentCRUD.DeleteStudent(classSchedule.Id, int.Parse(txtSId.Text));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to Delete this record!","Note",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.Yes)
            { 
            try
            {
                if (txtSId.Text != "")
                {
                    var classSchedule = cbClassesSchedule.SelectedItem as ClassSchedule;
                    var deleted = studentCRUD.DeleteStudent(classSchedule.Id, int.Parse(txtSId.Text));
                    if (deleted)
                    {
                        MessageBox.Show("Deleted successfully");
                        ClearTextBoxes();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            dgvStudents.DataSource = null;
        }
    }
}
