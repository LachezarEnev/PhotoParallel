namespace Photoparallel.Web.ViewModels.Orders
{
    using Photoparallel.Common;

    public class ConfirmOrderViewModel
    {
        public int Id { get; set; }

        public string Recipient { get; set; }

        public string RecipientPhoneNumber { get; set; }

        public string ShippingAddress { get; set; }

        public decimal TotalPrice { get; set; }

        public string PaymentType { get; set; }

        public decimal ShippingCosts { get; set; } = GlobalConstants.ShippingCosts;
    }
}
