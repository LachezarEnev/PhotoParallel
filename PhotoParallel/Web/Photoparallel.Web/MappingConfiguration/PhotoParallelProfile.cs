namespace Photoparallel.Web.MappingConfiguration
{
    using System.Linq;

    using AutoMapper;
    using Photoparallel.Data.Models;
    using Photoparallel.Web.Areas.Administration.ViewModels.Home;
    using Photoparallel.Web.Areas.Administration.ViewModels.Orders;
    using Photoparallel.Web.Areas.Administration.ViewModels.Products;
    using Photoparallel.Web.ViewModels.CreditCards;
    using Photoparallel.Web.ViewModels.Home;
    using Photoparallel.Web.ViewModels.Orders;
    using Photoparallel.Web.ViewModels.Products;

    public class PhotoParallelProfile : Profile
    {
        public PhotoParallelProfile()
        {
            this.CreateMap<Order, AllOrdersViewModel>()
                .ForMember(x => x.OrderStatus, y => y.MapFrom(src => src.OrderStatus.GetDisplayName()));

            this.CreateMap<Order, MyOrdersViewModel>()
                .ForMember(x => x.OrderStatus, y => y.MapFrom(src => src.OrderStatus.GetDisplayName()));

            this.CreateMap<OrderProduct, OrderProductsViewModel>()
                .ForMember(x => x.Price, y => y.MapFrom(src => src.Product.Price))
                .ForMember(x => x.InStock, y => y.MapFrom(src => src.Product.Quantity))
                .ForMember(x => x.ProductName, y => y.MapFrom(src => src.Product.Name))
                .ForMember(x => x.ImageUrl, y => y.MapFrom(src => src.Product.Images.Select(x => x.ImageUrl).FirstOrDefault()));

            this.CreateMap<Order, OrderDetailsViewModel>()
                 .ForMember(x => x.OrderStatus, y => y.MapFrom(src => src.OrderStatus.GetDisplayName()))
                 .ForMember(x => x.PaymentType, y => y.MapFrom(src => src.PaymentType.GetDisplayName()))
                 .ForMember(x => x.PaymentStatus, y => y.MapFrom(src => src.PaymentStatus.GetDisplayName()))
                 .ForMember(x => x.Invoice, y => y.MapFrom(src => src.Invoice.InvoiceNumber));

            this.CreateMap<CreateProductsInputModel, Product>();
            this.CreateMap<Product, DetailsProductViewModel>()
                .ForMember(x => x.ImageUrls, y => y.MapFrom(src => src.Images.Select(x => x.ImageUrl)));

            this.CreateMap<Product, EditProductsInputModel>();
            this.CreateMap<EditProductsInputModel, Product>();
            this.CreateMap<Product, HideProductsViewModel>();

            this.CreateMap<Product, IndexProductViewModel>()
                .ForMember(x => x.ImageUrl, y => y.MapFrom(src => src.Images.FirstOrDefault().ImageUrl));

            this.CreateMap<Product, OpenOrdersProductsViewModel>()
                .ForMember(x => x.ImageUrl, y => y.MapFrom(src => src.Images.FirstOrDefault().ImageUrl));

            this.CreateMap<Order, ConfirmOrderViewModel>()
                .ForMember(x => x.PaymentType, y => y.MapFrom(src => src.PaymentType.GetDisplayName()));

            this.CreateMap<CreditCartInputModel, CreditCard>();
        }
    }
}
