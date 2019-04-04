namespace NewEnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enrollments", "Grade", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Enrollments", "Grade", c => c.Int(nullable: false));
        }
    }
}
