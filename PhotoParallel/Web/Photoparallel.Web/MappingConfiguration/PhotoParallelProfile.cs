namespace Photoparallel.Web.MappingConfiguration
{
    using AutoMapper;
    using Photoparallel.Data.Models;
    using Photoparallel.Web.Areas.Administration.ViewModels.Home;
    using Photoparallel.Web.Areas.Administration.ViewModels.Orders;

    public class PhotoParallelProfile : Profile
    {
        public PhotoParallelProfile()
        {
            this.CreateMap<Order, AllOrdersViewModel>()
                .ForMember(x => x.OrderStatus, y => y.MapFrom(src => src.OrderStatus.GetDisplayName()));

            this.CreateMap<OrderProduct, OrderProductsViewModel>();

            this.CreateMap<Order, OrderDetailsViewModel>()
                 .ForMember(x => x.OrderStatus, y => y.MapFrom(src => src.OrderStatus.GetDisplayName()))
                 .ForMember(x => x.FirstName, y => y.MapFrom(src => src.Customer.FirstName))
                 .ForMember(x => x.LastName, y => y.MapFrom(src => src.Customer.LastName))
                 .ForMember(x => x.PhoneNumber, y => y.MapFrom(src => src.Customer.PhoneNumber));
        }
    }
}
