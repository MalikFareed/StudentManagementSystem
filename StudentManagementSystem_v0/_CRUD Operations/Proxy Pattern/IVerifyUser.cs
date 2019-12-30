using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    interface IVerifyUser
    {
        RegisterUser Login(string _userName,string _password);
    }
}
