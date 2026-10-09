using System.ComponentModel.DataAnnotations;

namespace TennisManagement.Web.Application.Validations
{
    public class ValidMatchDateAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, 
            ValidationContext validationContext)
        {
            if(value is DateTime date)
            { 
                DateTime now = DateTime.Now;

                if(date < now)
                {
                    return new ValidationResult
                        (errorMessage: "Date is in the past.");
                }

                return ValidationResult.Success;
            }

            return new ValidationResult
                (errorMessage: "Invalid date format.");
        }
    }
}
