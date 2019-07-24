namespace Photoparallel.Data.Models
{
    public class RentProduct
    {
        public int Quantity { get; set; }

        public decimal ProductPricePerDay { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int RentId { get; set; }

        public Rent Rent { get; set; }
    }
}
