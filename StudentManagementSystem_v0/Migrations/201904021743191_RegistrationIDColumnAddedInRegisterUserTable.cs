namespace StudentManagementSystem_v0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegistrationIDColumnAddedInRegisterUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegisterUsers", "RegistrationID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RegisterUsers", "RegistrationID");
        }
    }
}
