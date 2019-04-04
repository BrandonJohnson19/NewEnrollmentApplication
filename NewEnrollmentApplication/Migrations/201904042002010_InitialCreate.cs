namespace NewEnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        EnrollmentId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                        Student = c.String(),
                        Course = c.String(),
                    })
                .PrimaryKey(t => t.EnrollmentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Enrollments");
        }
    }
}
