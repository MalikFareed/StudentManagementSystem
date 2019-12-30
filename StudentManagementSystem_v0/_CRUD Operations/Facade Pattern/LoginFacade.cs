using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    public class LoginFacade
    {
        private string UserName;
        private string Password;
        IVerifyUser loginProxy;

        public LoginFacade(string _userName,string _password)
        {
            this.UserName = _userName;
            this.Password = _password;
        }
        public void Login(Form _form)
        {
            loginProxy = new LoginProxy();
            var user = loginProxy.Login(UserName, Password);
            if (user != null)
            {
                if (user.AccountLevel == "admin")
                {
                    _form.Hide();
                    Form admin = new AdminDashboard();
                    admin.Show();
                }
                else if (user.AccountLevel == "student")
                {
                    _form.Hide();
                    Form student = new StudentDashboard(user.RegistrationID.ToString());
                    student.Show();
                }
                else if (user.AccountLevel == "teacher")
                {
                    _form.Hide();
                    Form teacher = new TeacherDashboard(user.RegistrationID.ToString());
                    teacher.Show();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!");
            }
        }

    }
}
