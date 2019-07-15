namespace Photoparallel.Web.Areas.Administration.ViewModels.Home
{
    using System;

    public class AllOrdersViewModel
    {
        public int Id { get; set; }

        public string OrderStatus { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? EstimatedDeliveryDate { get; set; }
    }
}
