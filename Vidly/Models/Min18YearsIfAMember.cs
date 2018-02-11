using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        private readonly int MIN_AGE_FOR_MEMBERSHIP = 18;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }

            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birthdate is required");
            }

            var age = GetAge(customer.Birthdate.Value);
            return (age >= MIN_AGE_FOR_MEMBERSHIP)
                ? ValidationResult.Success 
                : new ValidationResult("Customer should be at least 18 years old to be able to get a membership.");
            
        }

        private int GetAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;

            if (birthDate.AddYears(age) > today) age--;

            return age;
        }
    }
}