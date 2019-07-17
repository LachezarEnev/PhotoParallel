namespace Photoparallel.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Data.Models;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.ViewModels.CreditCards;

    public class CreditCardsController : BaseController
    {
        private readonly ICreditCardsService creditCardsService;
        private readonly IOrdersService ordersService;
        private readonly IMapper mapper;
        private readonly IUsersService usersService;

        public CreditCardsController(ICreditCardsService creditCardsService, IOrdersService ordersService, IMapper mapper, IUsersService usersService)
        {
            this.creditCardsService = creditCardsService;
            this.ordersService = ordersService;
            this.mapper = mapper;
            this.usersService = usersService;
        }

        [Authorize]
        public async Task<IActionResult> Pay()
        {
            var order = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);

            if (order == null || order.TotalPrice == 0)
            {
                return this.RedirectToAction("Index", "Home");
            }

            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Pay(CreditCartInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var order = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);
            var user = this.usersService.GetUserByUsername(this.User.Identity.Name);

            if (user == null || order == null)
            {
                return this.RedirectToAction("Index", "Home");
            }

            var creditCard = this.mapper.Map<CreditCard>(model);

            var expirationDate = creditCard.ExpirationDate;
            int[] tokens = expirationDate.Split("/")
                .Select(x => int.Parse(x))
                .ToArray();

            string yearInString = DateTime.Now.Year.ToString();
            string lastTwoDigits = yearInString.Substring(2);
            int lastToDigitsOfTheYear = int.Parse(lastTwoDigits);

            if ((DateTime.Now.Month > tokens[0] && lastToDigitsOfTheYear == tokens[1]) || lastToDigitsOfTheYear > tokens[1] || tokens[0] > 12 || tokens[1] - lastToDigitsOfTheYear > 5)
            {
                return this.View("InvalidCard");
            }

            await this.creditCardsService.PayWithCardAsync(creditCard, user, order);

            return this.RedirectToAction("Finish", "Orders");
        }
    }
}
