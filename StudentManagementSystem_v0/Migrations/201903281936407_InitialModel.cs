namespace StudentManagementSystem_v0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClassSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 30),
                        CreditHours = c.Single(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.EveningStudents",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        FatherName = c.String(nullable: false),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        DateOfAdmission = c.DateTime(nullable: false),
                        ProgramID = c.Int(nullable: false),
                        ClassScheduleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.ClassSchedules", t => t.ClassScheduleID, cascadeDelete: true)
                .ForeignKey("dbo.Programs", t => t.ProgramID, cascadeDelete: true)
                .Index(t => t.ProgramID)
                .Index(t => t.ClassScheduleID);
            
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        ProgramsId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ProgramsId);
            
            CreateTable(
                "dbo.MorningStudents",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        FatherName = c.String(nullable: false),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        DateOfAdmission = c.DateTime(nullable: false),
                        ProgramID = c.Int(nullable: false),
                        ClassScheduleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.ClassSchedules", t => t.ClassScheduleID, cascadeDelete: true)
                .ForeignKey("dbo.Programs", t => t.ProgramID, cascadeDelete: true)
                .Index(t => t.ProgramID)
                .Index(t => t.ClassScheduleID);
            
            CreateTable(
                "dbo.RegisterUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        AccountLevel = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Qualification = c.String(nullable: false),
                        Salary = c.Int(nullable: false),
                        Address = c.String(),
                        JoiningDate = c.DateTime(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.WeekendStudents",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        FatherName = c.String(nullable: false),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        DateOfAdmission = c.DateTime(nullable: false),
                        ProgramID = c.Int(nullable: false),
                        ClassScheduleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.ClassSchedules", t => t.ClassScheduleID, cascadeDelete: true)
                .ForeignKey("dbo.Programs", t => t.ProgramID, cascadeDelete: true)
                .Index(t => t.ProgramID)
                .Index(t => t.ClassScheduleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeekendStudents", "ProgramID", "dbo.Programs");
            DropForeignKey("dbo.WeekendStudents", "ClassScheduleID", "dbo.ClassSchedules");
            DropForeignKey("dbo.Teachers", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.MorningStudents", "ProgramID", "dbo.Programs");
            DropForeignKey("dbo.MorningStudents", "ClassScheduleID", "dbo.ClassSchedules");
            DropForeignKey("dbo.EveningStudents", "ProgramID", "dbo.Programs");
            DropForeignKey("dbo.EveningStudents", "ClassScheduleID", "dbo.ClassSchedules");
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.WeekendStudents", new[] { "ClassScheduleID" });
            DropIndex("dbo.WeekendStudents", new[] { "ProgramID" });
            DropIndex("dbo.Teachers", new[] { "DepartmentID" });
            DropIndex("dbo.MorningStudents", new[] { "ClassScheduleID" });
            DropIndex("dbo.MorningStudents", new[] { "ProgramID" });
            DropIndex("dbo.EveningStudents", new[] { "ClassScheduleID" });
            DropIndex("dbo.EveningStudents", new[] { "ProgramID" });
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
            DropTable("dbo.WeekendStudents");
            DropTable("dbo.Teachers");
            DropTable("dbo.RegisterUsers");
            DropTable("dbo.MorningStudents");
            DropTable("dbo.Programs");
            DropTable("dbo.EveningStudents");
            DropTable("dbo.Departments");
            DropTable("dbo.Courses");
            DropTable("dbo.ClassSchedules");
            DropTable("dbo.Admins");
        }
    }
}
