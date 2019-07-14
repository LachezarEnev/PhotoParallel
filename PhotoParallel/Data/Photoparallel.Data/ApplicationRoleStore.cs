namespace Photoparallel.Data
{
    using System.Security.Claims;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Photoparallel.Data.Models;

    public class ApplicationRoleStore : RoleStore<
        ApplicationRole,
        PhotoparallelDbContext,
        string,
        IdentityUserRole<string>,
        IdentityRoleClaim<string>>
    {
        public ApplicationRoleStore(PhotoparallelDbContext context, IdentityErrorDescriber describer = null)
            : base(context, describer)
        {
        }

        protected override IdentityRoleClaim<string> CreateRoleClaim(ApplicationRole role, Claim claim) =>
            new IdentityRoleClaim<string>
            {
                RoleId = role.Id,
                ClaimType = claim.Type,
                ClaimValue = claim.Value,
            };
    }
}
