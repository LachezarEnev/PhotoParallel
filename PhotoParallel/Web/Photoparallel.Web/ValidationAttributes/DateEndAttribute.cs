namespace Photoparallel.Web.ValidationAttributes
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DateEndAttribute : ValidationAttribute
    {
        private readonly string startDateComparison;

        public DateEndAttribute(string startDateComparison)
        {
            this.startDateComparison = startDateComparison;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var enddate = (DateTime)value;
            var property = validationContext.ObjectType.GetProperty(this.startDateComparison);

            if (property == null)
            {
                throw new ArgumentException("Property with this name not found");
            }

            var startDate = (DateTime)property.GetValue(validationContext.ObjectInstance);

            if (startDate > enddate || enddate > DateTime.Now.AddDays(7))
            {
                return new ValidationResult($"End day must be between {startDate.ToString("dd/MM/yyyy")} and {DateTime.Now.AddDays(7).ToString("dd/MM/yyyy")}");
            }

            return ValidationResult.Success;
        }
    }
}
