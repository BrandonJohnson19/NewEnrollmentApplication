using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//new enrollment
namespace NewEnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }
        public virtual String Grade { get; set; }
        public virtual String Student { get; set; }
        public virtual String Course { get; set; }
    }
}