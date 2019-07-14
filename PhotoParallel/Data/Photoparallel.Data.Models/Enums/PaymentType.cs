namespace Photoparallel.Data.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum PaymentType
    {
        [Display(Name = "Cash on delivery")]
        CashОnDelivery = 1,

        [Display(Name = "Visa/MasterCard")]
        Card = 2,
    }
}
