using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    class TeacherCRUD
    {
        static TeacherCRUD teacherCRUD = null;
        SMSDbContext context;

        private TeacherCRUD()
        {
            context = SMSDbContext.getContext;
        }

        public static TeacherCRUD getTeacherCRUD
        {
            get
            {
                if (teacherCRUD == null)
                    teacherCRUD = new TeacherCRUD();
                return teacherCRUD;
            }
        }
        public bool AddTeacher(Teacher _teacher)
        {
            context.Teachers.Add(_teacher);
            context.SaveChanges();
            return true;
        }
        public bool UpdateTeacher(Teacher _teacher)
        {
            var teacher = context.Teachers.Find(_teacher.TeacherId);
            teacher.Name = _teacher.Name;
            teacher.Qualification = _teacher.Qualification;
            teacher.Address = _teacher.Address;
            teacher.JoiningDate = _teacher.JoiningDate;
            teacher.DepartmentID = _teacher.DepartmentID;
            teacher.Salary = _teacher.Salary;

            context.SaveChanges();
            return true;
        }
        public object GetAllTeachers()
        {
            var teachers = context.Teachers
                .OrderBy(t => t.Name)
                .Select(t => new
                {
                    ID = t.TeacherId,
                    Name = t.Name,
                    Qualification = t.Qualification,
                    Address = t.Address,
                    Salary = t.Salary,
                    JoiningDate = t.JoiningDate,
                    Department = t.Department.Name
                });
            return teachers.ToList();

        }
        public List<Teacher> GetAllTeachersList()
        {
            return context.Teachers.ToList();
        }
        public bool FindTeacher(int _tid)
        {
            var found = context.Teachers
                    .SingleOrDefault(t => t.TeacherId == _tid);

            if (found == null)
                return false;
            return true;
        }
    }
}
