using StudentManagementSystem_v0._CRUD_Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_v0
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form addUser = new AddUser();
            addUser.Show();         

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormActions.ExitApplication();
        }
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            txtUserName.text = "";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.text = "";
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                var login = new LoginFacade(txtUserName.text,txtPassword.text);
                login.Login(this);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
