using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    public class RegisterUser
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int RegistrationID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string AccountLevel { get; set; }
    }
}
