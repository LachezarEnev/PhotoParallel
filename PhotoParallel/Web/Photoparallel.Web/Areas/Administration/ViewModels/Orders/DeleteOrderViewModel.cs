namespace Photoparallel.Web.Areas.Administration.ViewModels.Orders
{
    using System.ComponentModel.DataAnnotations;

    public class DeleteOrderViewModel
    {
        [Display(Name = "Order №")]
        public int Id { get; set; }

        [Display(Name = "Order Value")]
        public decimal GrandTotal { get; set; }

        public string Recipient { get; set; }

        [Display(Name = "Order Status")]
        public string OrderStatus { get; set; }
    }
}
