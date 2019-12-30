using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Qualification { get; set; }

        [Required]
        public int Salary { get; set; }
        public string Address { get; set; }
        public DateTime JoiningDate { get; set; }  
        
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }

        public int DepartmentID { get; set; }
    }
}
