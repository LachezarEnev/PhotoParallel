namespace Photoparallel.Services
{
    using Microsoft.AspNetCore.Identity;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Services.Contracts;

    public class UsersService : IUsersService
    {
        private readonly PhotoparallelDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        public UsersService(PhotoparallelDbContext context, UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public void EditFirstName(ApplicationUser user, string firstName)
        {
            if (user == null)
            {
                return;
            }

            user.FirstName = firstName;
            this.context.SaveChanges();
        }

        public void EditLastName(ApplicationUser user, string lastName)
        {
            if (user == null)
            {
                return;
            }

            user.LastName = lastName;
            this.context.SaveChanges();
        }

        public ApplicationUser GetUserByUsername(string username)
        {
            return this.userManager.FindByNameAsync(username).GetAwaiter().GetResult();
        }
    }
}
