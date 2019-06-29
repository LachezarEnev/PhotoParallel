namespace Photoparallel.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(PhotoparallelDbContext dbContext, IServiceProvider serviceProvider);
    }
}
