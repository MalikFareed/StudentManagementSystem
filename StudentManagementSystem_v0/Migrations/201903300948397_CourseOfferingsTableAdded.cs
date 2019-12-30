namespace StudentManagementSystem_v0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseOfferingsTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseOfferings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .Index(t => t.CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseOfferings", "CourseID", "dbo.Courses");
            DropIndex("dbo.CourseOfferings", new[] { "CourseID" });
            DropTable("dbo.CourseOfferings");
        }
    }
}
