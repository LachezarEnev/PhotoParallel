namespace Photoparallel.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Photoparallel.Data.Models.Enums;

    public class Rent
    {
        public Rent()
        {
            this.Products = new HashSet<RentProduct>();
        }

        public int Id { get; set; }

        public string CustomerId { get; set; }

        public ApplicationUser Customer { get; set; }

        public string Recipient { get; set; }

        public string RecipientPhoneNumber { get; set; }

        public RentStatus RentStatus { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public ReturnedOnTime ReturnedOnTime { get; set; }

        public decimal TotalPrice { get; set; }

        public string Comment { get; set; }

        public string ShippingAddress { get; set; }

        public string CreditCardId { get; set; }

        public CreditCard CreditCard { get; set; }

        public int? InvoiceId { get; set; }

        public Invoice Invoice { get; set; }

        public decimal Shipping { get; set; } = 0;

        public ICollection<RentProduct> Products { get; set; }

        public decimal Penalty { get; set; } = 0;

        public decimal Guarantee { get; set; }
    }
}
