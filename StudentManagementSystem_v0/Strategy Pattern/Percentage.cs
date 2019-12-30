using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    class Percentage : Strategy
    {
        SMSDbContext context = SMSDbContext.getContext;
        protected List<int> CoursesTotalMarks = new List<int>();
        protected double TotalMarks;
        public Percentage(int _sid)
        {
            SId = _sid;
        }
        public override double Calculate()
        {
            var courses = context.MarksEntries
               .Where(c => c.StudentID == this.SId).ToList();

            foreach (var course in courses)
            {
                var totalMarks = course.Quizes
                   + course.Assignments
                   + course.Project
                   + course.Mid
                   + course.Final;
                CoursesTotalMarks.Add(totalMarks);
            }

            var numberOfCourses = 0d;
            foreach (var total in CoursesTotalMarks)
            {
                TotalMarks += total;
                numberOfCourses++;
            }
            return (TotalMarks / numberOfCourses);
        }
    }
}
