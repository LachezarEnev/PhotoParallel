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

        public async Task PayWithCardAsync(CreditCard card, string username)
        {
            var creditCards = await this.context.CreditCards
                .Where(x => x.Customer.UserName == username)
                .ToListAsync();

            if (creditCards.Count() != 0)
            {
                foreach (var creditCard in creditCards)
                {
                    if (creditCard.Number == card.Number)
                    {
                        this.context.Update(card);
                        await this.context.SaveChangesAsync();
                        return;
                    }
                }
            }

            this.context.Add(card);
            await this.context.SaveChangesAsync();
        }
    }
}
