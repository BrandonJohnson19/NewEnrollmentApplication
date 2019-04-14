using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NewEnrollmentApplication.Models
{
    public class Student : IValidatableObject
    {
        public virtual int StudentId { get; set; }

        [Required]
        public virtual String LastName { get; set; }

        [Required]
        public virtual String FirstName { get; set; }

        public virtual String Address1 { get; set; }
        public virtual String Address2 { get; set; }
        public virtual String City { get; set; }
        public virtual int Zipcode { get; set; }
        public virtual String State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            String zipcodeString = "" + Zipcode;

            if (Address2 == Address1)
            {
                yield return (new ValidationResult("Address2 cannot be the same as Address1."));
            }

            if(State.Length > 2 || State.Length < 2)
            {
                yield return (new ValidationResult("Enter a 2 digit state code."));
            }

            if(zipcodeString.Length > 5 || zipcodeString.Length < 5)
            {
                yield return (new ValidationResult("Enter a 5 digit zipcode"));
            }
            //throw new NotImplementedException();
        }
    }
}