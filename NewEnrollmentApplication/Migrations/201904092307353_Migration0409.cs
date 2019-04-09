namespace NewEnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration0409 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollments", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Enrollments", "AssignedCampus", c => c.String());
            AddColumn("dbo.Enrollments", "EnrollmentSemester", c => c.String());
            AddColumn("dbo.Enrollments", "EnrollmentYear", c => c.Int(nullable: false));
            CreateIndex("dbo.Enrollments", "StudentId");
            CreateIndex("dbo.Enrollments", "CourseId");
            AddForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses", "CourseId", cascadeDelete: true);
            AddForeignKey("dbo.Enrollments", "StudentId", "dbo.Students", "StudentId", cascadeDelete: true);
            DropColumn("dbo.Enrollments", "Student");
            DropColumn("dbo.Enrollments", "Course");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enrollments", "Course", c => c.String());
            AddColumn("dbo.Enrollments", "Student", c => c.String());
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
            DropColumn("dbo.Enrollments", "EnrollmentYear");
            DropColumn("dbo.Enrollments", "EnrollmentSemester");
            DropColumn("dbo.Enrollments", "AssignedCampus");
            DropColumn("dbo.Enrollments", "IsActive");
        }
    }
}
