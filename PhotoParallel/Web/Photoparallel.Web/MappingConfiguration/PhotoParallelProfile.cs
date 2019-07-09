namespace Photoparallel.Web.MappingConfiguration
{
    using System.Linq;

    using AutoMapper;
    using Photoparallel.Data.Models;
    using Photoparallel.Web.Areas.Administration.ViewModels.Home;
    using Photoparallel.Web.Areas.Administration.ViewModels.Orders;
    using Photoparallel.Web.Areas.Administration.ViewModels.Products;
    using Photoparallel.Web.ViewModels.Home;
    using Photoparallel.Web.ViewModels.Orders;
    using Photoparallel.Web.ViewModels.Products;

    public class PhotoParallelProfile : Profile
    {
        public PhotoParallelProfile()
        {
            this.CreateMap<Order, AllOrdersViewModel>()
                .ForMember(x => x.OrderStatus, y => y.MapFrom(src => src.OrderStatus.GetDisplayName()));

            this.CreateMap<OrderProduct, OrderProductsViewModel>()
                .ForMember(x => x.Price, y => y.MapFrom(src => src.Product.Price))
                .ForMember(x => x.ProductName, y => y.MapFrom(src => src.Product.Name))
                .ForMember(x => x.ImageUrl, y => y.MapFrom(src => src.Product.Images.Select(x => x.ImageUrl).FirstOrDefault()));

            this.CreateMap<Order, OrderDetailsViewModel>()
                 .ForMember(x => x.OrderStatus, y => y.MapFrom(src => src.OrderStatus.GetDisplayName()))
                 .ForMember(x => x.FirstName, y => y.MapFrom(src => src.Customer.FirstName))
                 .ForMember(x => x.LastName, y => y.MapFrom(src => src.Customer.LastName))
                 .ForMember(x => x.PhoneNumber, y => y.MapFrom(src => src.Customer.PhoneNumber));

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
        }
    }
}
