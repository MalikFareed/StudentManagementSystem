using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    public class ClassSchedule
    {
        public int Id { get; set; }

        [Required]
        public string Time { get; set; }
    }
}
