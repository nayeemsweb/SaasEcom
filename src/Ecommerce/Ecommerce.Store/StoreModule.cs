using Autofac;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Repositories;
using Ecommerce.Store.Repositories.MetaData;
using Ecommerce.Store.Services;
using Ecommerce.Store.Services.MetaData;
using Ecommerce.Store.UnitOfWorks;
using Ecommerce.Store.UnitOfWorks.MetaData;

namespace Ecommerce.Store
{
    public class StoreModule : Module
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public StoreModule(string connectionString, string assemblyName)
        {
            _connectionString = connectionString;
            _assemblyName = assemblyName;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StoreDbContext>().AsSelf()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("assemblyName", _assemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<StoreDbContext>().As<IStoreDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("assemblyName", _assemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<SubscriptionPlanRepository>().As<ISubscriptionPlanRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SubscriptionPlanUnitOfWork>().As<ISubscriptionPlanUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SubscriptionPlanService>().As<ISubscriptionPlanService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StoreRepository>().As<IStoreRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StoreUnitOfWork>().As<IStoreUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StoreService>().As<IStoreService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CategoryUnitOfWork>().As<ICategoryUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CategoryService>().As<ICategoryService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductService>().As<IProductService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ProductUnitOfWork>().As<IProductUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductRestoreService>().As<IProductRestoreService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ProductRestoreRepository>().As<IProductRestoreRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ProductRestoreUnitOfWork>().As<IProductRestoreUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<MenuUnitOfWork>().As<IMenuUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CartUnitOfWork>().As<ICartUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CartRepository>().As<ICartRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CartService>().As<ICartService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmailMessageRepository>().As<IEmailMessageRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmailService>().As<IEmailService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<WishlistUnitOfWork>().As<IWishlistUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WishlistRepository>().As<IWishlistRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WishlistService>().As<IWishlistService>()
                .InstancePerLifetimeScope();


            builder.RegisterType<UserInfoService>().As<IUserInfoService>()
                .InstancePerLifetimeScope();
            
            builder.RegisterType<StoreInfoService>().As<IStoreInfoService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StoreInfoUnitOfWork>().As<IStoreInfoUnitOfWork>()
                .InstancePerLifetimeScope();
            
            builder.RegisterType<StoreInfoRepository>().As<IStoreInfoRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ContactFormUnitOfWork>().As<IContactFormUnitOfWork>()
             .InstancePerLifetimeScope();

            builder.RegisterType<ContactFormRepository>().As<IContactFormRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ContactFormService>().As<IContactFormService>()
                .InstancePerLifetimeScope();


            builder.RegisterType<OrderUnitOfWork>().As<IOrderUnitOfWork>()
               .InstancePerLifetimeScope();

            builder.RegisterType<OrderRepository>().As<IOrderRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<OrderService>().As<IOrderService>();



            builder.RegisterType<ImageUnitOfWork>().As<IImageUnitOfWork>()
               .InstancePerLifetimeScope();

            builder.RegisterType<ImageRepository>().As<IImageRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ImageService>().As<IImageService>();



            builder.RegisterType<ProductSubscriptionUnitOfWork>().As<IProductSubscriptionUnitOfWork>()
                 .InstancePerLifetimeScope();

            builder.RegisterType<ProductSubscriptionRepository>().As<IProductSubscriptionRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductSubscriptionService>().As<IProductSubscriptionService>()
                .InstancePerLifetimeScope();


            base.Load(builder);
        }
    }
}
