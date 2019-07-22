namespace Photoparallel.Data.Models.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum OrderStatus
    {
        Open = 1,
        Pending = 2,
        [Display(Name = "Waiting Delivery")]
        Waiting = 3,
        Approved = 4,
        Shipped = 5,
        Delivered = 6,
        Denied = 7,
    }
}
