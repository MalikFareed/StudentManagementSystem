using System;


namespace StudentManagementSystem_v0
{
    public interface IStudent
    {        
         int StudentId { get; set; }       
         string Name { get; set; }        
         string FatherName { get; set; }
         string Address { get; set; }
         DateTime DateOfBirth { get; set; }       
         DateTime DateOfAdmission { get; set; }         
         int ProgramID { get; set; }
         int ClassScheduleID { get; set; }


    }
}
