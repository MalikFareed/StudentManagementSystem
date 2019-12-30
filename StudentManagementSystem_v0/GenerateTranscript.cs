using StudentManagementSystem_v0._CRUD_Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    class GenerateTranscript
    {
        MarksEntryCRUD marksEntryCRUD = MarksEntryCRUD.getMarksEntryCRUD; 
        SMSDbContext context = SMSDbContext.getContext;
        protected int SId;    
        protected List<int> CoursesTotalMarks = new List<int>();
        public GenerateTranscript(int _sid)
        {
            this.SId = _sid;            
        }
        public List<object> LoadCourses()
        {
            var courses = context.MarksEntries
                .Where(c => c.StudentID == this.SId).ToList();

            //declaring empty list structure of OBJECT type.
            var coursesNumbers = Enumerable.Empty<object>()
                .Select(cn => new {
                    CourseID = 0,
                    CourseName = "",
                    CreditHours = 0f,
                    Marks = 0
                }).ToList();
            foreach (var course in courses)
            {       
                var totalMarks = course.Quizes
                    + course.Assignments
                    + course.Project
                    + course.Mid
                    + course.Final;
                CoursesTotalMarks.Add(totalMarks);

                var courseObj = context.Courses.Single(c => c.CourseId == course.CourseID);
                coursesNumbers.Add( new {
                    course.CourseID,
                    CourseName = courseObj.Title,
                    course.Course.CreditHours,
                    Marks = totalMarks
                });                
            }
            return coursesNumbers.ToList<object>();
        }  
      
    }
}
