using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using ProductEO = Ecommerce.Store.Entities.Product;
using TestProductEO = Ecommerce.Store.Entities.TestProduct;
using StoreBO = Ecommerce.Store.BusinessObjects.Store;
using StoreEO = Ecommerce.Store.Entities.Store;
using CategoryEO = Ecommerce.Store.Entities.Category;
using CartEO = Ecommerce.Store.Entities.Cart;
using ProductImageEO = Ecommerce.Store.Entities.ProductImage;
using ProductCategoryEO = Ecommerce.Store.Entities.ProductCategory;
using ReviewEO = Ecommerce.Store.Entities.Review;
using InventoryEO = Ecommerce.Store.Entities.Inventory;
using WishlistEO = Ecommerce.Store.Entities.Wishlist;
using SubscriptionPlanEO = Ecommerce.Store.Entities.SubscriptionPlan;
using ContactFormEO = Ecommerce.Store.Entities.ContactForm;

using ProductDeleteEO = Ecommerce.Store.Entities.ProductDelete;
using OrderEO = Ecommerce.Store.Entities.Order;
using OrderedProductEO = Ecommerce.Store.Entities.OrderedProduct;

using SubscriptionFormEO = Ecommerce.Store.Entities.ContactForm;
using ProductSubscriptionNotificationEO = Ecommerce.Store.Entities.ProductSubscriptionNotification;



namespace Ecommerce.Store.Profiles
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<ProductEO, Product>()
                .ReverseMap();

            CreateMap<ProductDeleteEO, ProductDelete>()
                .ReverseMap();

            CreateMap<InventoryEO, Inventory>()
                .ReverseMap();

            CreateMap<ProductCategoryEO, ProductCategory>()
                .ReverseMap();

            CreateMap<ProductImageEO, ProductImage>()
                .ReverseMap();

            CreateMap<StoreEO, StoreBO>()
                .ReverseMap();

            CreateMap<SubscriptionPlanEO, SubscriptionPlan>()
                .ReverseMap();

            CreateMap<TestProductEO, TestProduct>()
                .ReverseMap();

            CreateMap<CategoryEO, Category>()
                .ReverseMap();

            CreateMap<CartEO, Cart>()
                .ReverseMap();

            CreateMap<ReviewEO, Review>()
                .ReverseMap();

            CreateMap<WishlistEO, Wishlist>()
                .ReverseMap();

            CreateMap<ContactFormEO, ContactForm>()
               .ReverseMap();


            CreateMap<OrderEO, Order>()
               .ReverseMap();

            CreateMap<OrderedProductEO, OrderedProduct>()
              .ReverseMap();


            
            CreateMap<SubscriptionFormEO, SubscriptionForm>()
               .ReverseMap();

            CreateMap<ProductSubscriptionNotificationEO, ProductSubscriptionNotification>()
              .ReverseMap();

        }
    }
}