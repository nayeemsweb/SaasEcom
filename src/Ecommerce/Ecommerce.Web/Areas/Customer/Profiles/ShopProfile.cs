using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Web.Areas.Customer.Models;

namespace Ecommerce.Web.Areas.Customer.Profiles
{
    public class ShopProfile : Profile
    {
        public ShopProfile()
        {
            //CreateMap<ProductEditModel, Product>()
            //    .ForMember(dest => dest.Name, src => src.MapFrom(x => x.Title))
            //    .ReverseMap();

            CreateMap<ProductDetailsModel, TestProduct>()
                .ReverseMap();
            CreateMap<AddCartModel, Cart>()
                .ReverseMap();
            CreateMap<EditCartModel, Cart>()
                .ReverseMap();
            CreateMap<ReturnCartModel, Cart>()
                .ReverseMap();
            CreateMap<WishlistAddModel, Wishlist>()
                .ReverseMap();
            CreateMap<CategoryModel, Category>()
                .ReverseMap();
            CreateMap<ContactFormModel, ContactForm>()
              .ReverseMap();

            CreateMap<ProductSubscriptionNotificationModel, ProductSubscriptionNotification>()
            .ReverseMap();
        }
    }
}
