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
    public partial class ucAddUser : UserControl
    {
        TeacherCRUD teacherCRUD = TeacherCRUD.getTeacherCRUD;
        StudentCRUD studentCRUD = StudentCRUD.getStudentCRUD;
        UserRegistrationCRUD userRegistrationCRUD = UserRegistrationCRUD.getUserRegistrationCRUD;
        private string accountLevel;
        
        public ucAddUser()
        {
            InitializeComponent();
        }
        protected void ClearTextBoxes()
        {
            txtRegID.Text = txtUserName.Text = txtPassword.Text = txtConfirmPass.Text = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormActions.ExitApplication();
        }
        private void ucAddUser_Load(object sender, EventArgs e)
        {
            btnSignUp.Enabled = false;
        }

        private void rbStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStudent.Checked)
            {
                accountLevel = "student";
                btnSignUp.Enabled = true;
            }
        }

        private void rbTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTeacher.Checked)
            {
                accountLevel = "teacher";
                btnSignUp.Enabled = true;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if ((txtRegID.Text == "" || txtUserName.Text == "" || txtPassword.Text == "" || txtConfirmPass.Text == ""))
            {
                MessageBox.Show("One or more filed(s) empty!");
                return;               
            }
            if (txtPassword.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Password fields did'nt match!");
                return;
            }

            try
            {
                if (accountLevel == "student")
                {
                    var found = studentCRUD.FindStudent(int.Parse(txtRegID.Text));
                    if (!found)
                    {
                        MessageBox.Show("Registration ID does not find in our records!");
                        return;
                    }
                }
                else if(accountLevel == "teacher")
                {
                    var found = teacherCRUD.FindTeacher(int.Parse(txtRegID.Text));
                    if (!found)
                    {
                        MessageBox.Show("Registration ID does not find in our records!");
                        return;
                    }
                }

                var user = new RegisterUser
                {
                    RegistrationID = int.Parse(txtRegID.Text),
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    AccountLevel = accountLevel
                };
                var added = userRegistrationCRUD.AddUser(user);
                if (added)
                {
                    MessageBox.Show("Added successfully, please SignIn with your UserName and Password.");
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Error while adding record.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form addUser = this.FindForm();
            addUser.Hide();
            Form login = new LoginForm();
            login.Show();
        }
    }
}
