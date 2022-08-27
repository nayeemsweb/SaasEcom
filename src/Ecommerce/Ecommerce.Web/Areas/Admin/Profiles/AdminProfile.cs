using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Web.Areas.Admin.Models;
using Ecommerce.Web.Areas.Customer.Models;
using StoreBO = Ecommerce.Store.BusinessObjects.Store;

namespace Ecommerce.Web.Areas.Admin.Profiles
{
    public class ShopProfile : Profile
    {
        public ShopProfile()
        {
            //CreateMap<ProductEditModel, Product>()
            //    .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Title))
            //    .ReverseMap();

            CreateMap<CategoryCreateModel, Category>()
                .ReverseMap();
            CreateMap<ShopSetupModel, StoreBO>()
                .ReverseMap();
            CreateMap<ProductAddModel, Product>()
                .ReverseMap();
            CreateMap<ProductEditModel, Product>()
                .ReverseMap();
            CreateMap<OrderAddModel, Order>()
                .ReverseMap();
            CreateMap<OrderEditModel, Order>()
                .ReverseMap();

            CreateMap<SubscriptionPlanCreateModel, SubscriptionPlan>()
                .ReverseMap();

            CreateMap<ContactFormEditModel, ContactForm>()
               .ReverseMap();

            CreateMap<SubscriptionPlanModel, SubscriptionPlan>()
                .ReverseMap();


            CreateMap<ProductSubscriptionEditModel, ProductSubscriptionNotification>()
             .ReverseMap();

        }
    }
}
