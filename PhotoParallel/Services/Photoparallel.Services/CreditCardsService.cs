namespace Photoparallel.Services
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Services.Contracts;

    public class CreditCardsService : ICreditCardsService
    {
        private readonly PhotoparallelDbContext context;

        public CreditCardsService(PhotoparallelDbContext context)
        {
            this.context = context;
        }

        public async Task PayWithCardAsync(CreditCard card, ApplicationUser user, Order order)
        {
            var creditCards = await this.context.CreditCards
                .Include(x => x.Orders)
                .Where(x => x.Customer.UserName == user.UserName)
                .ToListAsync();

            if (creditCards.Count() != 0)
            {
                foreach (var creditCard in creditCards)
                {
                    if (creditCard.Number == card.Number)
                    {
                        creditCard.Orders.Add(order);
                        this.context.Update(creditCard);
                        await this.context.SaveChangesAsync();
                    }
                }

                return;
            }

            card.Orders.Add(order);
            card.Customer = user;

            this.context.Add(card);
            await this.context.SaveChangesAsync();
        }
    }
}
