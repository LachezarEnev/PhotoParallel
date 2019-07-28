namespace Photoparallel.Web.Areas.Administration.ViewModels.Rents
{
    using System.ComponentModel.DataAnnotations;

    public class DeleteRentViewModel
    {
        [Display(Name = "Rental Order №")]
        public int Id { get; set; }

        [Display(Name = "Rental Amount")]
        public decimal TotalPrice { get; set; }

        public string Recipient { get; set; }

        [Display(Name = "Status")]
        public string RentStatus { get; set; }
    }
}
