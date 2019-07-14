namespace Photoparallel.Web.ViewModels.CreditCards
{
    using System.ComponentModel.DataAnnotations;

    using Photoparallel.Data.Models.Enums;

    public class CreditCartInputModel
    {
        [Required]
        [Display(Name = "Card Number")]
        [RegularExpression(@"^[0-9]{16}$", ErrorMessage ="Number must be exactly 16 digits!")]
        public string Number { get; set; }

        [Required]
        [Display(Name = "CVC2/CVV2")]
        [RegularExpression(@"^[0-9]{3}$", ErrorMessage = "CVC2/CVV2 must be exactly 3 digits!")]
        public string Cvc2 { get; set; }

        [Required]
        [Display(Name = "Expiration Date")]
        [RegularExpression(@"^[0-9]{2}\/[0-9]{2}$", ErrorMessage = "Expiration Date must be in format: 00/00!")]
        public string ExpirationDate { get; set; }

        [Required]
        [Display(Name = "Select Card")]
        public CreditCardType CreditCardType { get; set; }
    }
}
