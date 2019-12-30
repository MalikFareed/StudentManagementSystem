using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    class UserRegistrationCRUD : IVerifyUser
    {
        static UserRegistrationCRUD userRegistrationCRUD = null;
        SMSDbContext context;

        private UserRegistrationCRUD()
        {
            context = SMSDbContext.getContext;
        }
        public static UserRegistrationCRUD getUserRegistrationCRUD
        {
            get
            {
                if (userRegistrationCRUD == null)
                    userRegistrationCRUD = new UserRegistrationCRUD();
                return userRegistrationCRUD;
            }
        }
        public bool AddUser(RegisterUser _registerUser)
        {           
            context.RegisterUsers.Add(_registerUser);
            context.SaveChanges();
            return true;
        }

        public RegisterUser Login(string _userName, string _password)
        {
            var user = context.RegisterUsers
                .SingleOrDefault(u => u.UserName == _userName && u.Password == _password);
            
            if (user == null)
                return null;
            return user;
        }
    }
}
