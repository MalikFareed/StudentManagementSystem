namespace StudentManagementSystem_v0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignCoursesTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssignCourses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TeacherID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: false)
                .ForeignKey("dbo.Teachers", t => t.TeacherID, cascadeDelete: false)
                .Index(t => t.TeacherID)
                .Index(t => t.CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AssignCourses", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.AssignCourses", "CourseID", "dbo.Courses");
            DropIndex("dbo.AssignCourses", new[] { "CourseID" });
            DropIndex("dbo.AssignCourses", new[] { "TeacherID" });
            DropTable("dbo.AssignCourses");
        }
    }
}
