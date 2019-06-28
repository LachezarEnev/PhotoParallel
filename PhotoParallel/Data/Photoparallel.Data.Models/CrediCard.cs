namespace Photoparallel.Data.Models
{
    using System.Collections.Generic;

    public class CreditCard
    {
        public CreditCard()
        {
            this.Orders = new HashSet<Order>();
            this.Rents = new HashSet<Rent>();
        }

        public string Id { get; set; }

        public string Number { get; set; }

        public string CustomerId { get; set; }

        public ApplicationUser Customer { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Rent> Rents { get; set; }
    }
}
