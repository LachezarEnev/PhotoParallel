namespace Photoparallel.Web.ViewModels.Rents
{
    using System;

    public class ConfirmRentViewModel
    {
        public int Id { get; set; }

        public string Recipient { get; set; }

        public string RecipientPhoneNumber { get; set; }

        public string ShippingAddress { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal Guarantee { get; set; }

        public string Comment { get; set; }

        public int Days { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}
