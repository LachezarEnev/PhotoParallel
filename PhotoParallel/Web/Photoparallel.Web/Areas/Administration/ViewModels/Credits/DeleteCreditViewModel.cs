namespace Photoparallel.Web.Areas.Administration.ViewModels.Credits
{
    using System.ComponentModel.DataAnnotations;

    using Photoparallel.Data.Models.Enums;

    public class DeleteCreditViewModel
    {
        [Display(Name = "Credit №")]
        public int Id { get; set; }

        [Display(Name = "Credit Value")]
        public decimal TotalAmount { get; set; }

        public string Recipient { get; set; }

        [Display(Name = "Credit Status")]
        public CreditStatus CreditStatus { get; set; }
    }
}
