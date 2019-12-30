namespace StudentManagementSystem_v0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseRegistrationTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseRegistrations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .Index(t => t.CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseRegistrations", "CourseID", "dbo.Courses");
            DropIndex("dbo.CourseRegistrations", new[] { "CourseID" });
            DropTable("dbo.CourseRegistrations");
        }
    }
}
