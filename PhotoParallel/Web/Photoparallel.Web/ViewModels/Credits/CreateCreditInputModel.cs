namespace Photoparallel.Web.ViewModels.Credits
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Photoparallel.Data.Models;

    public class CreateCreditInputModel
    {
        public CreateCreditInputModel()
        {
            this.CreditCompanies = new HashSet<CreditCompany>();
        }

        public int Id { get; set; }

        [Required]
        public int Months { get; set; }

        [Required]
        [Display(Name = "Credit Company")]
        public string Company { get; set; }

        public Order Order { get; set; }

        [Required]
        [RegularExpression(@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "City/Village")]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Postal code")]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Postal code should be exactly 4 digits!")]
        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "UCN")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "UCN should be exactly 10 digits!")]
        public string Ucn { get; set; }

        [Required]
        [Display(Name = "Id Number")]
        [RegularExpression(@"^[0-9]{9}$", ErrorMessage = "Id Number should be exactly 9 digits!")]
        public string IdNumber { get; set; }

        [Required]
        [Range(typeof(decimal), "0.01", "79228162514264337593543950335", ErrorMessage = "\"{0}\" should be greater than 0!")]
        public decimal Salary { get; set; }

        public IEnumerable<CreditCompany> CreditCompanies { get; set; }
    }
}
