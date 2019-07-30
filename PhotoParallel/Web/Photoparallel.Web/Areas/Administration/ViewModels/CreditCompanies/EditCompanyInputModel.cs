namespace Photoparallel.Web.Areas.Administration.ViewModels.CreditCompanies
{
    using System.ComponentModel.DataAnnotations;

    public class EditCompanyInputModel
    {
        public string Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "\"{0}\" must be between {2} and {1} characters!")]
        public string Name { get; set; }

        [Required]
        [Range(typeof(decimal), "0.01", "100", ErrorMessage = "\"{0}\" must be between {1} and {2}!")]
        public decimal Interest { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{9}$", ErrorMessage = "VAT № should be exactly 9 digits!")]
        [Display(Name = "VAT №")]
        public string VatNumber { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
