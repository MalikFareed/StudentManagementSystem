using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    class CourseRegistrationCRUD
    {
        static CourseRegistrationCRUD courseRegistrationCRUD = null;
        SMSDbContext context;

        private CourseRegistrationCRUD()
        {
            context = SMSDbContext.getContext;
        }
        public static CourseRegistrationCRUD getCourseRegistrationCRUD
        {
            get
            {
                if (courseRegistrationCRUD == null)
                    courseRegistrationCRUD = new CourseRegistrationCRUD();
                return courseRegistrationCRUD;
            }
        }
        public bool RegisterCourse(CourseRegistration _courseRegistration)
        {
            context.CourseRegistrations.Add(_courseRegistration);
            context.SaveChanges();
            return true;
        }
        public List<IStudent> GetStudents(int _cid)
        {
            var students = context.CourseRegistrations.Where(c => c.CourseID == _cid);
            var studentsList = new List<IStudent>();
            var morStudents = context.MorningStudents.ToList();
            var eveStudents = context.EveningStudents.ToList();
            var weekStudents = context.WeekendStudents.ToList();

            foreach (var student in students)
            {
                foreach (var morStudent in morStudents)
                {
                    if (morStudent.StudentId == student.StudentID)
                    {
                        studentsList.Add(morStudent);
                        continue;
                    }
                }
                foreach (var eveStudent in eveStudents)
                {
                    if (eveStudent.StudentId == student.StudentID)
                    {
                        studentsList.Add(eveStudent);
                        continue;
                    }
                }
                foreach (var weekStudent in weekStudents)
                {
                    if (weekStudent.StudentId == student.StudentID)
                    {
                        studentsList.Add(weekStudent);
                        continue;
                    }
                }
            }
            return studentsList;

            
        }
        public object GetAllRegisteredCourse(int _sid)
        {
            var courses = context.CourseRegistrations
                .OrderBy(c => c.CourseID)
                .Where(c => c.StudentID == _sid)
                .Select(c => new {
                    ID = c.ID,
                    CourseName = c.Course.Title,
                    CreditHours = c.Course.CreditHours
                });
            return courses.ToList();
        }
        public List<Course> GetAllRegisteredCoursesAsCourseObject(int _sid)
        {
            var courses = context.CourseRegistrations
                .Where(c => c.StudentID == _sid);
            //loading Courses list into memory for finding the course.
            context.Courses.ToList();
            var coursesList = new List<Course>();
            foreach (var course in courses)
            {
                var c = context.Courses.Find(course.CourseID);
                coursesList.Add(c);
            }                
            return coursesList;
        }
        public bool RemoveRegisteredCourse(int _id)
        {
            var course = context.CourseRegistrations.Find(_id);
            context.CourseRegistrations.Remove(course);
            context.SaveChanges();
            return true;
        }
    }
}
