namespace Photoparallel.Web.ValidationAttributes
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Photoparallel.Common;

    public class DateStartAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime startDate = Convert.ToDateTime(value);

            if (startDate < DateTime.Now || startDate > DateTime.Now.AddDays(GlobalConstants.SevenDays))
            {
                return new ValidationResult($"Start day must be between {DateTime.Now.AddDays(GlobalConstants.OneDay).ToString("dd/MM/yyyy")} and {DateTime.Now.AddDays(GlobalConstants.SevenDays).ToString("dd/MM/yyyy")}");
            }

            return ValidationResult.Success;
        }
    }
}
