namespace Photoparallel.Web.ViewModels.Orders
{
    using System.ComponentModel.DataAnnotations;

    using Photoparallel.Common;
    using Photoparallel.Data.Models.Enums;

    public class CreateOrderInputModel
    {
        public int Id { get; set; }

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
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Postal code must be exactely 4 digits!")]
        public string PostalCode { get; set; }

        [Display(Name = "Payment type")]
        public PaymentType PaymentType { get; set; }

        public decimal ShippingCosts { get; set; } = GlobalConstants.ShippingCosts;

        public decimal TotalPrice { get; set; }
    }
}
