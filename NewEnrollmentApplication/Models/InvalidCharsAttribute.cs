using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace NewEnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        public InvalidCharsAttribute()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if ((string)value != (string)"@")
                {
                    return new ValidationResult("Error: Only the @ symbol can be used here!");
                }
            }
            return ValidationResult.Success;
        }
    }
}