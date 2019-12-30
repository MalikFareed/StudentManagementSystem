using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem_v0
{
    public sealed class SMSDbContext : DbContext
    {
        static SMSDbContext context = null;
        public SMSDbContext() { }
        public static SMSDbContext getContext
        {
            get
            {
                if (context == null)
                    context =  new SMSDbContext();
                return context;
            }
        }
        public DbSet<MorningStudent> MorningStudents { get; set; }
        public DbSet<EveningStudent> EveningStudents { get; set; }
        public DbSet<WeekendStudent> WeekendStudents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Programs> Programs { get; set; }
        public DbSet<RegisterUser> RegisterUsers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ClassSchedule> ClassSchedules { get; set; }
        public DbSet<CourseOffering> CourseOfferings { get; set; }
        public DbSet<AssignCourse> AssignCourses { get; set; }
        public DbSet<CourseRegistration> CourseRegistrations { get; set; }
        public DbSet<MarksEntry> MarksEntries { get; set; }

    } 
}
