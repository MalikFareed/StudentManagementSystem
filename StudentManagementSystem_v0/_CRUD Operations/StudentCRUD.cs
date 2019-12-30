using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    public class StudentCRUD
    {
        static StudentCRUD studentCRUD = null;
        SMSDbContext context;

        private StudentCRUD()
        {
            context = SMSDbContext.getContext;
        }
        public static StudentCRUD getStudentCRUD
        {
            get
            {
                if (studentCRUD == null)
                    studentCRUD = new StudentCRUD();
                return studentCRUD;
            }

        }
        public bool AddStudent(MorningStudent _morningStudent)
        {
            context.MorningStudents.Add(_morningStudent);
            context.SaveChanges();
            return true;
        }
        public bool AddStudent(EveningStudent _eveningStudent)
        {
            context.EveningStudents.Add(_eveningStudent);
            context.SaveChanges();
            return true;
        }
        public bool AddStudent(WeekendStudent _weeklyStudent)
        {
            context.WeekendStudents.Add(_weeklyStudent);
            context.SaveChanges();
            return true;
        }
        public object GetAllStudents()
        {
            var morningStudents = context.MorningStudents
                .OrderBy(s => s.StudentId)
                .Select(s => new
                {
                    StudentID = s.StudentId,
                    Name = s.Name,
                    FatherName = s.FatherName,
                    Address = s.Address,
                    DoB = s.DateOfBirth,
                    DateOfAdmission = s.DateOfAdmission,
                    Program = s.Program.Title,
                    ClassSchedule = s.ClassSchedule.Time

                });

            var eveningStudents = context.EveningStudents
                .OrderBy(s => s.StudentId)
                .Select( s => new
                {
                    StudentID = s.StudentId,
                    Name = s.Name,
                    FatherName = s.FatherName,
                    Address = s.Address,
                    DoB = s.DateOfBirth,
                    DateOfAdmission = s.DateOfAdmission,
                    Program = s.Program.Title,
                    ClassSchedule = s.ClassSchedule.Time
                });

            var weeklyStudents = context.WeekendStudents
                .OrderBy(s => s.StudentId)
                .Select(s => new
                {
                    StudentID = s.StudentId,
                    Name = s.Name,
                    FatherName = s.FatherName,
                    Address = s.Address,
                    DoB = s.DateOfBirth,
                    DateOfAdmission = s.DateOfAdmission,
                    Program = s.Program.Title,
                    ClassSchedule = s.ClassSchedule.Time                   
                });

            var allStudents = morningStudents.Union(eveningStudents).Union(weeklyStudents);
            return allStudents.ToList();
           
                       
        }

        public bool UpdateStudent(MorningStudent _student)
        {
            var students = context.MorningStudents.ToList();
            foreach (var studnet in students)
            {
                if (studnet.StudentId == _student.StudentId)
                {
                    var student = context.MorningStudents.Single(s => s.StudentId == _student.StudentId);
                    student.Name = _student.Name;
                    student.FatherName = _student.FatherName;
                    student.Address = _student.Address;
                    student.DateOfBirth = _student.DateOfBirth;
                    student.DateOfAdmission = _student.DateOfAdmission;
                    student.ProgramID = _student.ProgramID;
                    student.ClassScheduleID = _student.ClassScheduleID;

                    context.SaveChanges();
                    return true;
                }
            }
            AddStudent(_student);
            return true;

        }
        public bool UpdateStudent(EveningStudent _student)
        {
            var students = context.EveningStudents.ToList();
            foreach (var studnet in students)
            {
                if (studnet.StudentId == _student.StudentId)
                {
                    var student = context.EveningStudents.Single(s => s.StudentId == _student.StudentId);
                    student.Name = _student.Name;
                    student.FatherName = _student.FatherName;
                    student.Address = _student.Address;
                    student.DateOfBirth = _student.DateOfBirth;
                    student.DateOfAdmission = _student.DateOfAdmission;
                    student.ProgramID = _student.ProgramID;
                    student.ClassScheduleID = _student.ClassScheduleID;

                    context.SaveChanges();
                    return true;
                }
            }
            AddStudent(_student);
            return true;

        }
        public bool UpdateStudent(WeekendStudent _student)
        {
            var students = context.WeekendStudents.ToList();
            foreach (var studnet in students)
            {
                if (studnet.StudentId == _student.StudentId)
                {
                    var student = context.WeekendStudents.Single(s => s.StudentId == _student.StudentId);
                    student.Name = _student.Name;
                    student.FatherName = _student.FatherName;
                    student.Address = _student.Address;
                    student.DateOfBirth = _student.DateOfBirth;
                    student.DateOfAdmission = _student.DateOfAdmission;
                    student.ProgramID = _student.ProgramID;
                    student.ClassScheduleID = _student.ClassScheduleID;

                    context.SaveChanges();                    
                    return true;
                }
            }             
            AddStudent(_student);           
            return true;

        }
        public bool DeleteStudent(int _classScheduleId,int _Sid)
        {
            if (_classScheduleId == 1)
            {
                if (context.MorningStudents.Any(s => s.StudentId == _Sid))
                {
                    var student = context.MorningStudents.Single(s => s.StudentId == _Sid);
                    context.MorningStudents.Remove(student);
                }
                else
                {
                    return false;
                }
                
            }
            else if (_classScheduleId == 2)
            {
                if (context.EveningStudents.Any(s => s.StudentId == _Sid))
                {
                    var student = context.EveningStudents.Single(s => s.StudentId == _Sid);
                    context.EveningStudents.Remove(student);
                }
                else
                {
                    return false;
                }
            }
            else if (_classScheduleId == 3)
            {
                if (context.WeekendStudents.Any(s => s.StudentId == _Sid))
                {
                    var student = context.WeekendStudents.Single(s => s.StudentId == _Sid);
                    context.WeekendStudents.Remove(student);
                }
                else
                {
                    return false;
                }
            }
            context.SaveChanges();
            return true;
        }

        public bool FindStudent(int _sid)
        {
            IChian chianMorStd = new FindMorningStudent();
            IChian chainEveStd = new FindEveningStudent();
            IChian chainWeekStd = new FindWeekendStudent();

            chianMorStd.SetNextChain(chainEveStd);
            chainEveStd.SetNextChain(chainWeekStd);

            var found = chianMorStd.Find(_sid);
            return found;
        }
      
    }
}
