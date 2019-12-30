namespace StudentManagementSystem_v0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MarksEntryTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MarksEntries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                        Quizes = c.Int(nullable: false),
                        Assignments = c.Int(nullable: false),
                        Project = c.Int(nullable: false),
                        Mid = c.Int(nullable: false),
                        Final = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .Index(t => t.CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MarksEntries", "CourseID", "dbo.Courses");
            DropIndex("dbo.MarksEntries", new[] { "CourseID" });
            DropTable("dbo.MarksEntries");
        }
    }
}
