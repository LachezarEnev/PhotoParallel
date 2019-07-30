namespace Photoparallel.Data.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum PaymentStatus
    {
        Paid = 1,

        [Display(Name = "On delivery")]
        Ondelivery = 2,

        Credit = 3,
    }
}
