using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewEnrollmentApplication.Models
{
    public class Student
    {
        public virtual int StudentId { get; set; }
        public virtual String LastName { get; set; }
        public virtual String FirstName { get; set; }
    }
}