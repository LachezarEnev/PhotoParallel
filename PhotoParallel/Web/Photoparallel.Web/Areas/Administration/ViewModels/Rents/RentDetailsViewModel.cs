namespace Photoparallel.Web.Areas.Administration.ViewModels.Rents
{
    using System;
    using System.Collections.Generic;

    public class RentDetailsViewModel
    {
        public int Id { get; set; }

        public string Recipient { get; set; }

        public string RecipientPhoneNumber { get; set; }

        public string ShippingAddress { get; set; }

        public string Email { get; set; }

        public string RentsStatus { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string Invoice { get; set; }

        public int InvoiceId { get; set; }

        public string PaymentStatus { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal Guarantee { get; set; }

        public int Days { get; set; }

        public string Comment { get; set; }

        public IList<RentProductsViewModel> RentProductsViewModel { get; set; }
    }
}
