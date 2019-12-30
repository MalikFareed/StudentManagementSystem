using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    public class Programs
    {
        public int ProgramsId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
    }
}
