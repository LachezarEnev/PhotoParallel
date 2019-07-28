namespace Photoparallel.Services
{
    using System;
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
        private readonly IInvoicesService invoicesService;
        private readonly IProductsService productsService;

        public RentsService(PhotoparallelDbContext context, IUsersService usersService, IInvoicesService invoicesService, IProductsService productsService)
        {
            this.context = context;
            this.usersService = usersService;
            this.invoicesService = invoicesService;
            this.productsService = productsService;
        }

        public async Task<Rent> CreateOpenRentByUserIdAsync(string username)
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

        public async Task<Rent> GetOpenRentAsync(string username)
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

            return openRent;
        }

        public async Task<bool> AddProductAsync(int id, Rent rent)
        {
            //var product = await this.context.Products
            //   .Include(x => x.Images)
            //   .SingleOrDefaultAsync(x => x.Id == id);

            var product = await this.productsService.GetProductByIdAsync(id);

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

        public async Task<IEnumerable<Rent>> GetAllRentsByUserAsync(string username)
        {
            var rents = await this.context.Rents
                .Where(x => x.RentStatus != RentStatus.Open && x.Customer.UserName == username)
                .OrderByDescending(x => x.Id)
                .ToArrayAsync();

            return rents;
        }

        public async Task<Rent> GetRentByIdAsync(int id)
        {
            var rent = await this.context.Rents
                .Include(x => x.Customer)
                .Include(x => x.Invoice)
                .Where(x => x.RentStatus != RentStatus.Open)
                .FirstOrDefaultAsync(x => x.Id == id);

            return rent;
        }

        public async Task<IEnumerable<RentProduct>> RentProductsByRentIdAsync(int id)
        {
            var rentProducts = await this.context.RentProducts
                .Include(x => x.Product)
                .ThenInclude(x => x.Images)
                .Where(x => x.RentId == id)
                .ToArrayAsync();

            return rentProducts;
        }

        public async Task<IEnumerable<Rent>> GetPendingRentsAsync()
        {
            var pendingRents = await this.context.Rents
                .Where(x => x.RentStatus == RentStatus.Pending)
                .OrderBy(x => x.RentDate)
                .ToArrayAsync();

            return pendingRents;
        }

        public async Task<IEnumerable<Rent>> GetRentedRentsAsync()
        {
            var rentedRents = await this.context.Rents
               .Where(x => x.RentStatus == RentStatus.Rented)
               .OrderBy(x => x.ReturnDate)
               .ToArrayAsync();

            return rentedRents;
        }

        public async Task<IEnumerable<Rent>> GetDeniedRentsAsync()
        {
            var deniedRents = await this.context.Rents
               .Where(x => x.RentStatus == RentStatus.Denied)
               .OrderBy(x => x.Id)
               .ToArrayAsync();

            return deniedRents;
        }

        public async Task<IEnumerable<Rent>> GetReturnedRentsAsync()
        {
            var returnedRents = await this.context.Rents
               .Where(x => x.RentStatus == RentStatus.Returned)
               .OrderByDescending(x => x.ReturnDate)
               .ToArrayAsync();

            return returnedRents;
        }

        public async Task ShipAsync(int id)
        {
            var rent = await this.context.Rents
                .SingleOrDefaultAsync(x => x.Id == id && x.RentStatus == RentStatus.Pending);

            if (rent == null)
            {
                return;
            }

            rent.RentStatus = RentStatus.Rented;

            this.context.Update(rent);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteRentAsync(int id)
        {
            var rent = await this.context.Rents
                .Include(x => x.Products)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (rent == null)
            {
                return;
            }

            var rentedProducts = await this.context.RentProducts
                .Where(x => x.RentId == id)
                .Include(x => x.Product)
                .ToArrayAsync();

            foreach (var rentedProduct in rentedProducts)
            {
                var product = rentedProduct.Product;
                product.Quantity += 1;
                product.IsRented = false;

                this.context.Update(product);
            }

            rent.RentStatus = RentStatus.Denied;

            this.context.Update(rent);
            await this.context.SaveChangesAsync();
        }

        public async Task ReturnAsync(int rentId, decimal penalty, ReturnedOnTime returnedOnTime)
        {
            var rent = await this.context.Rents
                .SingleOrDefaultAsync(x => x.Id == rentId && x.RentStatus == RentStatus.Rented);

            if (rent == null)
            {
                return;
            }

            rent.Penalty = penalty;
            rent.ReturnedOnTime = returnedOnTime;
            rent.RentStatus = RentStatus.Returned;

            this.context.Update(rent);

            var rentProducts = await this.context.RentProducts
                .Where(x => x.RentId == rentId)
                .Include(x => x.Product)
                .ToArrayAsync();

            foreach (var rentProduct in rentProducts)
            {
                var product = rentProduct.Product;
                product.Quantity += 1;
                product.IsRented = false;

                this.context.Update(product);
            }

            await this.context.SaveChangesAsync();

            await this.invoicesService.CreateRentInvoiceAsync(rent);
        }
    }
}
