using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    class AssignCourseCRUD
    {
        static AssignCourseCRUD assignCourseCRUD = null;
        SMSDbContext context;

        private AssignCourseCRUD()
        {
            context = SMSDbContext.getContext;
        }
        public static AssignCourseCRUD getAssignCourseCRUD
        {
            get
            {
                if (assignCourseCRUD == null)
                    assignCourseCRUD = new AssignCourseCRUD();
                return assignCourseCRUD;
            }
        }
        public bool AddAssignCourse(AssignCourse _assignCourse)
        {
            context.AssignCourses.Add(_assignCourse);
            context.SaveChanges();
            return true;
        }
        public object GetAllAssignedCourses()
        {
            var courses = context.AssignCourses
                .OrderBy(c => c.CourseID)
                .Select(c => new {
                    AssigingID = c.ID,
                    Course = c.Course.Title,
                    Teacher = c.Teacher.Name
                });
            return courses.ToList();
        }
        public object GetAssignedCourses(int _tid)
        {
            var courses =  context.AssignCourses
                .OrderBy(c => c.ID)
                .Where(c => c.TeacherID == _tid)
                .Select(c => new {
                    CourseID = c.CourseID,
                    CourseTitle = c.Course.Title,
                    CreditHours = c.Course.CreditHours,                   
                });
            return courses.ToList();
        }
        public List<Course> GetAssignedCoursesAsCourseObject(int _tid)
        {
            var assignedCourses = context.AssignCourses                
                .Where(c => c.TeacherID == _tid).ToList();

            var courses = new List<Course>();
            foreach (var course in assignedCourses)
            {
                var a = context.Courses.Single(c => c.CourseId == course.CourseID);
                courses.Add(a);
            }
            return courses;
        }
        public bool DeleteAssignedCourse(int _id)
        {
            var assignedCourse = context.AssignCourses.Find(_id);
            context.AssignCourses.Remove(assignedCourse);
            context.SaveChanges();
            return true;
        }
    }
}
