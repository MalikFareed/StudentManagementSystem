namespace StudentManagementSystem_v0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseTitleColoumnAddedInCourseOfferingTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourseOfferings", "CourseTitle", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CourseOfferings", "CourseTitle");
        }
    }
}
