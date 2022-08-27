using Ecommerce.Store.Entities;
using Microsoft.EntityFrameworkCore;
using STORE = Ecommerce.Store.Entities.Store;

namespace Ecommerce.Store.DbContexts
{
    public interface IStoreDbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<STORE> Stores { get; set; }
        public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewImage> ReviewImages { get; set; }
        public DbSet<EmailMessage> EmailMessages { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<ProductDelete> ProductsDeleteQueue { get; set; }
    }

}