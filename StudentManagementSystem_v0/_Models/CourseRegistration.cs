using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    public class CourseRegistration
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("StudentID")]
        public IStudent Student { get; set; }
        public int StudentID { get; set; }
        [ForeignKey("CourseID")]
        public Course Course { get; set; }
        public int CourseID { get; set; }
    }
}
