namespace Photoparallel.Services.Contracts
{
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;

    public interface ICreditCardsService
    {
        Task PayWithCardAsync(CreditCard card, ApplicationUser user, Order order);
    }
}
