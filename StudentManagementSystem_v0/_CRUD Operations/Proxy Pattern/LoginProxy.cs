using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    public class LoginProxy : IVerifyUser
    {
        public RegisterUser Login(string _userName, string _password)
        {
            UserRegistrationCRUD userRegistrationCRUD = UserRegistrationCRUD.getUserRegistrationCRUD;
            return userRegistrationCRUD.Login(_userName,_password);
        }
    }
}
