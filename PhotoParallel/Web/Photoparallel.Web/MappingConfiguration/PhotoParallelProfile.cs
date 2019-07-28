namespace Photoparallel.Web.MappingConfiguration
{
    using System.Linq;

    using AutoMapper;
    using Photoparallel.Data.Models;
    using Photoparallel.Web.Areas.Administration.ViewModels.Home;
    using Photoparallel.Web.Areas.Administration.ViewModels.Orders;
    using Photoparallel.Web.Areas.Administration.ViewModels.Products;
    using Photoparallel.Web.Areas.Administration.ViewModels.Rents;
    using Photoparallel.Web.ViewModels.CreditCards;
    using Photoparallel.Web.ViewModels.Home;
    using Photoparallel.Web.ViewModels.Invoices;
    using Photoparallel.Web.ViewModels.Orders;
    using Photoparallel.Web.ViewModels.Products;
    using Photoparallel.Web.ViewModels.Rents;

    public class PhotoParallelProfile : Profile
    {
        public PhotoParallelProfile()
        {
            this.CreateMap<Order, AllOrdersViewModel>()
                .ForMember(x => x.OrderStatus, y => y.MapFrom(src => src.OrderStatus.GetDisplayName()));

            this.CreateMap<Order, MyOrdersViewModel>()
                .ForMember(x => x.OrderStatus, y => y.MapFrom(src => src.OrderStatus.GetDisplayName()));

            this.CreateMap<Rent, MyRentsViewModel>()
                 .ForMember(x => x.RentStatus, y => y.MapFrom(src => src.RentStatus.GetDisplayName()))
                 .ForMember(x => x.RentDate, y => y.MapFrom(src => src.RentDate.ToString("dd/MM/yyyy")))
                 .ForMember(x => x.ReturnDate, y => y.MapFrom(src => src.ReturnDate.ToString("dd/MM/yyyy")));

            this.CreateMap<Rent, AllRentsViewModel>()
                .ForMember(x => x.RentStatus, y => y.MapFrom(src => src.RentStatus.GetDisplayName()))
                 .ForMember(x => x.RentDate, y => y.MapFrom(src => src.RentDate.ToString("dd/MM/yyyy")))
                 .ForMember(x => x.ReturnDate, y => y.MapFrom(src => src.ReturnDate.ToString("dd/MM/yyyy")));

            this.CreateMap<OrderProduct, OrderProductsViewModel>()
                .ForMember(x => x.Price, y => y.MapFrom(src => src.ProductPrice))
                .ForMember(x => x.InStock, y => y.MapFrom(src => src.Product.Quantity))
                .ForMember(x => x.ProductName, y => y.MapFrom(src => src.Product.Name))
                .ForMember(x => x.ImageUrl, y => y.MapFrom(src => src.Product.Images.Select(x => x.ImageUrl).FirstOrDefault()));

            this.CreateMap<Order, OrderDetailsViewModel>()
                 .ForMember(x => x.OrderStatus, y => y.MapFrom(src => src.OrderStatus.GetDisplayName()))
                 .ForMember(x => x.PaymentType, y => y.MapFrom(src => src.PaymentType.GetDisplayName()))
                 .ForMember(x => x.PaymentStatus, y => y.MapFrom(src => src.PaymentStatus.GetDisplayName()))
                 .ForMember(x => x.Invoice, y => y.MapFrom(src => src.Invoice.InvoiceNumber))
                 .ForMember(x => x.InvoiceId, y => y.MapFrom(src => src.Invoice.Id))
                 .ForMember(x => x.Email, y => y.MapFrom(src => src.Customer.Email));

            this.CreateMap<RentProduct, RentProductsViewModel>()
                .ForMember(x => x.PricePerDay, y => y.MapFrom(src => src.ProductPricePerDay))
                .ForMember(x => x.ProductName, y => y.MapFrom(src => src.Product.Name))
                .ForMember(x => x.ImageUrl, y => y.MapFrom(src => src.Product.Images.Select(x => x.ImageUrl).FirstOrDefault()));

            this.CreateMap<Rent, RentDetailsViewModel>()
                .ForMember(x => x.RentsStatus, y => y.MapFrom(src => src.RentStatus.GetDisplayName()))
                .ForMember(x => x.ReturnedOnTime, y => y.MapFrom(src => src.ReturnedOnTime.GetDisplayName()))
                .ForMember(x => x.Invoice, y => y.MapFrom(src => src.Invoice.InvoiceNumber))
                .ForMember(x => x.InvoiceId, y => y.MapFrom(src => src.Invoice.Id))
                .ForMember(x => x.Email, y => y.MapFrom(src => src.Customer.Email));

            this.CreateMap<CreateProductsInputModel, Product>();
            this.CreateMap<Product, DetailsProductViewModel>()
                .ForMember(x => x.ImageUrls, y => y.MapFrom(src => src.Images.Select(x => x.ImageUrl)));

            this.CreateMap<Product, EditProductsInputModel>()
                .ForMember(x => x.IsRented, y => y.MapFrom(src => src.IsRented.ToString()));

            this.CreateMap<EditProductsInputModel, Product>()
             .ForMember(x => x.IsRented, y => y.MapFrom(src => bool.Parse(src.IsRented)));

            this.CreateMap<Product, HideProductsViewModel>();

            this.CreateMap<Product, IndexProductViewModel>()
                .ForMember(x => x.ImageUrl, y => y.MapFrom(src => src.Images.FirstOrDefault().ImageUrl));

            this.CreateMap<Product, OpenOrdersProductsViewModel>()
                .ForMember(x => x.ImageUrl, y => y.MapFrom(src => src.Images.FirstOrDefault().ImageUrl));

            this.CreateMap<Product, OpenRentsProductsViewModel>()
                .ForMember(x => x.ImageUrl, y => y.MapFrom(src => src.Images.FirstOrDefault().ImageUrl));

            this.CreateMap<Order, ConfirmOrderViewModel>()
                .ForMember(x => x.PaymentType, y => y.MapFrom(src => src.PaymentType.GetDisplayName()));

            this.CreateMap<Rent, ConfirmRentViewModel>();

            this.CreateMap<CreditCartInputModel, CreditCard>();

            this.CreateMap<Order, DeleteOrderViewModel>()
                .ForMember(x => x.OrderStatus, y => y.MapFrom(src => src.OrderStatus.GetDisplayName()));

            this.CreateMap<Rent, DeleteRentViewModel>()
                .ForMember(x => x.RentStatus, y => y.MapFrom(src => src.RentStatus.GetDisplayName()));

            this.CreateMap<OrderProduct, InvoiceOrderProductsViewModel>()
               //.ForMember(x => x.ProductName, y => y.MapFrom(src => src.Product.Name))
               .ForMember(x => x.Price, y => y.MapFrom(src => src.ProductPrice));

            this.CreateMap<RentProduct, InvoiceRentProductsViewModel>()
                //.ForMember(x => x.ProductName, y => y.MapFrom(src => src.Product.Name))
                .ForMember(x => x.Price, y => y.MapFrom(src => src.ProductPricePerDay));

            this.CreateMap<Invoice, InvoiceViewModel>()
                .ForMember(x => x.OrderNumber, y => y.MapFrom(src => src.Order.Id.ToString()))
                .ForMember(x => x.Recipient, y => y.MapFrom(src => src.Order.Recipient))
                .ForMember(x => x.Shipping, y => y.MapFrom(src => src.Order.Shipping));

            this.CreateMap<Invoice, InvoiceRentViewModel>()
                .ForMember(x => x.RentNumber, y => y.MapFrom(src => src.Rent.Id.ToString()))
                .ForMember(x => x.Recipient, y => y.MapFrom(src => src.Rent.Recipient))
                .ForMember(x => x.Penalty, y => y.MapFrom(src => src.Rent.Penalty));

            this.CreateMap<Rent, RentReturnInputModel>()
                .ForMember(x => x.RentDate, y => y.MapFrom(src => src.RentDate.ToString("dd/MM/yyyy")))
                .ForMember(x => x.ReturnDate, y => y.MapFrom(src => src.ReturnDate.ToString("dd/MM/yyyy")));

            this.CreateMap<Invoice, MyInvoicesViewModel>()
                .ForMember(x => x.IssuedOn, y => y.MapFrom(src => src.IssuedOn.ToString("dd/MM/yyyy")));
        }
    }
}
