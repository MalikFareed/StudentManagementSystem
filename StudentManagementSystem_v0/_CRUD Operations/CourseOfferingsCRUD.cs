using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0._CRUD_Operations
{
    class CourseOfferingsCRUD
    {
        static CourseOfferingsCRUD courseOfferingsCRUD = null;
        SMSDbContext context;

        private CourseOfferingsCRUD()
        {
            context = SMSDbContext.getContext;
        }
        public static CourseOfferingsCRUD getCourseOfferingsCRUD
        {
            get
            {
                if (courseOfferingsCRUD == null)
                    courseOfferingsCRUD = new CourseOfferingsCRUD();
                return courseOfferingsCRUD;
            }
        }
        public bool AddCourseOffering(CourseOffering _courseOffering)
        {
            context.CourseOfferings.Add(_courseOffering);
            context.SaveChanges();
            return true;
        }      
        public object GetAllCourseOfferings()
        {
            var courseOfferings = context.CourseOfferings
                .OrderBy(c => c.ID)
                .Select(c => new
                {
                    OfferingID = c.ID,
                    CourseID = c.CourseID,
                    CourseName = c.Course.Title
                });
            return courseOfferings.ToList();           

        }
        public bool DeleteCourseOffering(int _id)
        {
            var courseOffering = context.CourseOfferings.Find(_id);
            context.CourseOfferings.Remove(courseOffering);
            context.SaveChanges();
            return true;
        }
        public List<CourseOffering> GetCourseOfferings(int _did)
        {            
            return context.CourseOfferings
                .Where(c => c.Course.DepartmentId == _did).ToList();
        }
        public List<CourseOffering> GetCourseOfferings()
        {
            return context.CourseOfferings.ToList();
        }
    }
}
