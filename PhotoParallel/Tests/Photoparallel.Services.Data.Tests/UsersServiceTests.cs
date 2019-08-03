namespace Photoparallel.Services.Data.Tests
{
    using System;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;

    using Xunit;

    public class UsersServiceTests
    {
        [Fact]
        public void EditFirstNameRequstsShouldEditFirstName()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                  .UseInMemoryDatabase(Guid.NewGuid().ToString())
                  .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var user = new ApplicationUser
            {
                UserName = "gosho@sth.bg",
                FirstName = "Goshko",
            };
            dbContext.Users.Add(user);
            dbContext.SaveChanges();

            var mockUserStore = new Mock<IUserStore<ApplicationUser>>();
            var userManager = new Mock<UserManager<ApplicationUser>>(mockUserStore.Object, null, null, null, null, null, null, null, null);

            var usersService = new UsersService(dbContext, userManager.Object);

            var firstName = "Gosho";
            usersService.EditFirstName(user, firstName);

            Assert.Equal(firstName, user.FirstName);
        }

        [Fact]
        public void EditLastNameRequstsShouldEditLastName()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                  .UseInMemoryDatabase(Guid.NewGuid().ToString())
                  .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var user = new ApplicationUser
            {
                UserName = "gosho@sth.bg",
                LastName = "goshi",
            };
            dbContext.Users.Add(user);
            dbContext.SaveChanges();

            var mockUserStore = new Mock<IUserStore<ApplicationUser>>();
            var userManager = new Mock<UserManager<ApplicationUser>>(mockUserStore.Object, null, null, null, null, null, null, null, null);

            var usersService = new UsersService(dbContext, userManager.Object);

            var lastName = "Goshev";
            usersService.EditLastName(user, lastName);

            Assert.Equal(lastName, user.LastName);
        }

        [Fact]
        public void GetUserByUsernameShouldReturnUser()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                  .UseInMemoryDatabase(Guid.NewGuid().ToString())
                  .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var user = new ApplicationUser
            {
                UserName = "gosho@sth.bg",
            };

            dbContext.Users.Add(user);
            dbContext.SaveChanges();

            var mockUserStore = new Mock<IUserStore<ApplicationUser>>();
            var userManager = new Mock<UserManager<ApplicationUser>>(mockUserStore.Object, null, null, null, null, null, null, null, null);
            userManager.Setup(r => r.FindByNameAsync(user.UserName))
                       .ReturnsAsync(user);

            var usersService = new UsersService(dbContext, userManager.Object);

            var searchedUser = usersService.GetUserByUsername(user.UserName);

            Assert.Equal(user.UserName, searchedUser.UserName);
        }
    }
}
