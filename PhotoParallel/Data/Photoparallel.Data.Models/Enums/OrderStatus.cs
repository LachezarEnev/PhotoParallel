namespace Photoparallel.Data.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum OrderStatus
    {
        Open = 0,
        Pending = 1,
        Approved = 2,
        Shipped = 3,
        Delivered = 4,
        Denied = 5,

        [Display(Name = "Waiting Delivery")]
        Waiting = 6,
    }
}
