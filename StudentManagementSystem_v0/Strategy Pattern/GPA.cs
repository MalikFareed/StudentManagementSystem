using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    class GPA : Strategy
    {
        SMSDbContext context = SMSDbContext.getContext;
        public GPA(int _sid)
        {
            SId = _sid;
        }
        public override double Calculate()
        {
            //80+ = A(4 pts)
            //70+ = B(3 pts)
            //60+ = C(2 pts)
            //50+ = D(1 pts)
            //<50 = F(0 pts)

            var qualityPoints = 0d;
            var totalCreaditHrs = 0d;
            var courses = context.MarksEntries.Where(c => c.StudentID == SId);
            var coursesObj = new List<Course>();
            foreach (var course in courses)
            {
                var totalMarks = course.Quizes + course.Assignments
                    + course.Project + course.Mid + course.Final;

                var c = context.Courses.Find(course.CourseID);
                totalCreaditHrs += c.CreditHours;

                if (totalMarks >= 80)
                    qualityPoints += c.CreditHours * 4;
                else if (totalMarks >= 70)
                    qualityPoints += c.CreditHours * 3;
                else if (totalMarks >= 60)
                    qualityPoints += c.CreditHours * 2;
                else if (totalMarks >= 50)
                    qualityPoints += c.CreditHours * 1;
                else
                    qualityPoints += c.CreditHours * 0;
            }
            return qualityPoints / totalCreaditHrs;
        }
    }
}
