using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    class CourseCRUD
    {
        static CourseCRUD courseCRUD = null;
        SMSDbContext context;

        private CourseCRUD()
        {
            context = SMSDbContext.getContext;
        }
        public static CourseCRUD getCourseCRUD
        {
            get
            {
                if (courseCRUD == null)
                    courseCRUD = new CourseCRUD();
                return courseCRUD;
            }
        }
        public bool AddCourse(Course _course)
        {
            context.Courses.Add(_course);
            context.SaveChanges();
            return true;
        }
        public object GetAllCoursesWithTitles()
        {
            var courses = context.Courses
                .OrderBy(c => c.Title)
                .Select(c => new {
                    CID = c.CourseId,
                    Title = c.Title,
                    CreditHours = c.CreditHours,
                    Department = c.Department.Name
                });
            return courses.ToList();
        }
        public List<Course> GetAllCourses()
        {            
            return context.Courses.ToList();
        }       
        public bool FindCourse(string _title)
        {
            var courses = context.Courses.ToList();
            foreach (var course in courses)
            {
                if (course.Title == _title)
                    return true;                    
            }
            return false;
        }
        public List<Course> GetCourses(int _departmentID)
        {
            return context.Courses
                .OrderBy(c => c.CourseId)
                .Where(c => c.DepartmentId == _departmentID).ToList();
        }
        public bool UpdateCourse(Course _course)
        {
            if (FindCourse(_course.Title))
            {
                var course = context.Courses.Single(c => c.CourseId == _course.CourseId);
                course.Title = _course.Title;
                course.CreditHours = _course.CreditHours;
                course.DepartmentId = _course.DepartmentId;
                context.SaveChanges();
                return true;
            }           
            return false;
            
           
        }

        public bool DeleteCourse(int _cid)
        {
            var course = context.Courses.Find(_cid);
            context.Courses.Remove(course);
            context.SaveChanges();
            return true;
        }
    }
}
