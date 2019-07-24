namespace Photoparallel.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;

    public class RentsService : IRentsService
    {
        private readonly PhotoparallelDbContext context;
        private readonly IUsersService usersService;

        public RentsService(PhotoparallelDbContext context, IUsersService usersService)
        {
            this.context = context;
            this.usersService = usersService;
        }

        public async Task<Rent> GetOpenRentByUserIdAsync(string username)
        {
            var user = this.usersService.GetUserByUsername(username);

            if (user == null)
            {
                return null;
            }

            var openRent = await this.context.Rents
               .Include(x => x.Products)
               .ThenInclude(x => x.Product)
               .ThenInclude(x => x.Images)
               .SingleOrDefaultAsync(x => x.RentStatus == RentStatus.Open && x.Customer.UserName == user.UserName);

            if (openRent == null)
            {
                openRent = new Rent
                {
                    Customer = user,
                    RentStatus = RentStatus.Open,
                };

                await this.context.Rents.AddAsync(openRent);
                await this.context.SaveChangesAsync();
            }
            else
            {
                List<RentProduct> productsToRemove = new List<RentProduct>();

                foreach (var rentProduct in openRent.Products)
                {
                    if (rentProduct.Product.IsRented)
                    {
                        productsToRemove.Add(rentProduct);
                    }
                }

                this.context.RemoveRange(productsToRemove);
                await this.context.SaveChangesAsync();
            }

            return openRent;
        }

        public async Task<bool> AddProductAsync(int id, Rent rent)
        {
            var product = await this.context.Products
               .Include(x => x.Images)
               .SingleOrDefaultAsync(x => x.Id == id);

            if (product == null || rent == null)
            {
                return false;
            }

            if (rent.Products.Any(x => x.ProductId == id))
            {
                return true;
            }

            var rentProduct = new RentProduct
            {
                Product = product,
                Rent = rent,
                Quantity = 1,
            };

            await this.context.AddAsync(rentProduct);
            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteProductAsync(int productId, Rent rent)
        {
            var rentProduct = await this.context.RentProducts.FirstOrDefaultAsync(x => x.ProductId == productId && x.RentId == rent.Id);

            if (rentProduct == null)
            {
                return false;
            }

            this.context.Remove(rentProduct);
            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task SetRentDetailsAsync(Rent rent)
        {
            this.context.Update(rent);
            await this.context.SaveChangesAsync();
        }

        public async Task FinishRentAsync(Rent rent)
        {
            rent.RentStatus = RentStatus.Pending;

            var rentProducts = await this.context.RentProducts
                .Where(x => x.RentId == rent.Id)
                .ToListAsync();

            foreach (var rentProduct in rentProducts)
            {
                rentProduct.ProductPricePerDay = rentProduct.Product.PricePerDay;
                var product = rentProduct.Product;
                product.Quantity -= 1;

                if (product.Quantity == 0)
                {
                    product.IsRented = true;
                }

                this.context.Update(product);
                this.context.Update(rentProduct);
            }

            this.context.Update(rent);
            await this.context.SaveChangesAsync();
        }
    }
}
