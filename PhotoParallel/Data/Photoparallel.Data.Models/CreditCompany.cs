namespace Photoparallel.Data.Models
{
    using System.Collections.Generic;

    public class CreditCompany
    {
        public CreditCompany()
        {
            this.Contracts = new HashSet<CreditContract>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<CreditContract> Contracts { get; set; }
    }
}
