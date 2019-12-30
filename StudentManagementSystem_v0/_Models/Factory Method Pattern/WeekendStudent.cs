using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    public class WeekendStudent :IStudent
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FatherName { get; set; }

        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        [Required]
        public DateTime DateOfAdmission { get; set; }

        [ForeignKey("ProgramID")]
        public Programs Program { get; set; }
        public int ProgramID { get; set; }

        [ForeignKey("ClassScheduleID")]
        public ClassSchedule ClassSchedule { get; set; }
        public int ClassScheduleID { get; set; }
    }
}
