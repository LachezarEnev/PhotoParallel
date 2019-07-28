namespace Photoparallel.Web.ValidationAttributes
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DateStartAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime startDate = Convert.ToDateTime(value);

            if (startDate < DateTime.Now || startDate > DateTime.Now.AddDays(7))
            {
                return new ValidationResult($"Date must be between {DateTime.Now.AddDays(1).ToString("dd/MM/yyyy")} and {DateTime.Now.AddDays(7).ToString("dd/MM/yyyy")}");
            }

            return ValidationResult.Success;
        }
    }
}
