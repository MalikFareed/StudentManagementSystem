using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    public class MarksEntry
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("StudentID")]
        public IStudent Student { get; set; }
        public int StudentID { get; set; }
        [ForeignKey("CourseID")]
        public Course Course { get; set; }
        public int CourseID { get; set; }
        [Required]
        public int Quizes { get; set; }
        [Required]
        public int Assignments { get; set; }
        [Required]
        public int Project { get; set; }
        [Required]
        public int Mid { get; set; }
        [Required]
        public int Final { get; set; }
    }
}
