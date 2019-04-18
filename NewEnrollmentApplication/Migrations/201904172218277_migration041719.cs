namespace NewEnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration041719 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollments", "LastName", c => c.String());
            AddColumn("dbo.Enrollments", "FirstName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Enrollments", "FirstName");
            DropColumn("dbo.Enrollments", "LastName");
        }
    }
}
