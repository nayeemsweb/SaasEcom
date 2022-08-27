using Autofac;
using Ecommerce.Web.Areas.Admin.Models;
using Ecommerce.Web.Areas.Customer.Models;
using Ecommerce.Web.Models;
using ShopAccountModels = Ecommerce.Web.Areas.Customer.Models.ShopAccountModels;

namespace Ecommerce.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<TestClass>().As<ITestClass>()
            //    .InstancePerLifetimeScope();
            builder.RegisterType<SubscriptionPlanModel>().AsSelf()
                .InstancePerLifetimeScope();
            builder.RegisterType<ShopSetupModel>().AsSelf()
                .InstancePerLifetimeScope();
            builder.RegisterType<ShopIndexModel>().AsSelf()
                .InstancePerLifetimeScope();
            builder.RegisterType<CategoryModel>().AsSelf()
                .InstancePerLifetimeScope();
            builder.RegisterType<CategoryListModel>().AsSelf();
            builder.RegisterType<CategoryCreateModel>().AsSelf();
            builder.RegisterType<RegisterModel>().AsSelf();
            builder.RegisterType<LoginModel>().AsSelf();
            builder.RegisterType<ProductModel>().AsSelf();
            builder.RegisterType<AddCartModel>().AsSelf();
            builder.RegisterType<EditCartModel>().AsSelf();
            builder.RegisterType<CartModel>().AsSelf();
            builder.RegisterType<ProductAddModel>().AsSelf();
            builder.RegisterType<ProductEditModel>().AsSelf();
            builder.RegisterType<OrderAddModel>().AsSelf();
            builder.RegisterType<AllOrderedProducts>().AsSelf();
	        builder.RegisterType<OrderedProductsModel>().AsSelf();	
            builder.RegisterType<ProductDetailsModel>().AsSelf();
            builder.RegisterType<OrderEditModel>().AsSelf();
            

            //Shop Account Models
            builder.RegisterType<ShopAccountModels.RegisterModel>().AsSelf();
            builder.RegisterType<ShopAccountModels.LoginModel>().AsSelf();


       
		

            builder.RegisterType<WishlistAddModel>().AsSelf();
            builder.RegisterType<WishlistModel>().AsSelf();

            builder.RegisterType<ListOfAllOrdersModel>().AsSelf()
                   .InstancePerLifetimeScope();
		
                 builder.RegisterType<ListOfMyOrdersModel>().AsSelf()
                   .InstancePerLifetimeScope();		

            builder.RegisterType<ListOfAllProductsModel>().AsSelf()
                    .InstancePerLifetimeScope();
            builder.RegisterType<ListOfAllTrashProductsModel>().AsSelf()
                    .InstancePerLifetimeScope();
            builder.RegisterType<ProductVisibilityChangeModel>().AsSelf()
                    .InstancePerLifetimeScope();
            builder.RegisterType<ProductFeatureChangeModel>().AsSelf()
                    .InstancePerLifetimeScope();
            builder.RegisterType<ProductDeleteModel>().AsSelf()
                .InstancePerLifetimeScope();
            builder.RegisterType<StoreListModel>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<StoreModel>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SubscriptionPlanCreateModel>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<SubscriptionPlanListModel>().AsSelf().InstancePerLifetimeScope();



            builder.RegisterType<ListOfAllContactMessagesModel>().AsSelf()
                    .InstancePerLifetimeScope();

            builder.RegisterType<ListOfAllSubscriptionNotificationsModel>().AsSelf()
             .InstancePerLifetimeScope();

            builder.RegisterType<ListOfAllArchivedSubscriptionsModel>().AsSelf()
             .InstancePerLifetimeScope();

            builder.RegisterType<ContactFormEditModel>().AsSelf();

            builder.RegisterType<ProductImageModel>().AsSelf()
                    .InstancePerLifetimeScope();

            builder.RegisterType<ProductSubscriptionEditModel>().AsSelf();
                 
            base.Load(builder);
        }
    }
}

