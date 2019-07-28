namespace Photoparallel.Web.Areas.Administration.ViewModels.Rents
{
    using System.ComponentModel.DataAnnotations;

    using Photoparallel.Data.Models.Enums;

    public class RentReturnInputModel
    {
        public int Id { get; set; }

        public string Recipient { get; set; }

        public string RecipientPhoneNumber { get; set; }

        public string ShippingAddress { get; set; }

        public string RentDate { get; set; }

        public string ReturnDate { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Penalty should be no negative value!")]
        public decimal Penalty { get; set; }

        public decimal Guarantee { get; set; }

        [Required]
        [Display(Name = "Returned On Time")]
        public ReturnedOnTime ReturnedOnTime { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
