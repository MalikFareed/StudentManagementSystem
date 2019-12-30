using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    public abstract class StudentFactory
    {
        public abstract IStudent CreateStudent();
        public IStudent GetStudent()
        {
            IStudent student = this.CreateStudent();
            return student;
        }
    }
}
