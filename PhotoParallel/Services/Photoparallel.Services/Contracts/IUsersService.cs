namespace Photoparallel.Services.Contracts
{
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;

    public interface IUsersService
    {
        ApplicationUser GetUserByUsername(string username);

        void EditFirstName(ApplicationUser user, string firstName);

        void EditLastName(ApplicationUser user, string lastName);
    }
}
