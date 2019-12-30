using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    public class AssignCourse
    {
        public int ID { get; set; }       
        public Teacher Teacher { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }       
        public Course Course { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }
    }
}
