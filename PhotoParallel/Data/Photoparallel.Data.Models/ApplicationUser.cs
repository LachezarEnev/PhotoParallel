// ReSharper disable VirtualMemberCallInConstructor
namespace Photoparallel.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Identity;

    using Photoparallel.Data.Common.Models;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();

            this.Invoices = new HashSet<Invoice>();
            this.Orders = new HashSet<Order>();
            this.Rents = new HashSet<Rent>();
            this.CreditContracts = new HashSet<CreditContract>();
            this.CreditCards = new HashSet<CreditCard>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<CreditCard> CreditCards { get; set; }

        public ICollection<Invoice> Invoices { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Rent> Rents { get; set; }

        public ICollection<CreditContract> CreditContracts { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
