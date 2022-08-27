using Ecommerce.Store.Entities;
using Ecommerce.Store.DataSeeding;
using Microsoft.EntityFrameworkCore;
using STORE = Ecommerce.Store.Entities.Store;

namespace Ecommerce.Store.DbContexts
{
    public class StoreDbContext : DbContext, IStoreDbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public StoreDbContext(string connectionString, string assemblyName)
        {
            _connectionString = connectionString;
            _assemblyName = assemblyName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
            }

            base.OnConfiguring(optionBuilder);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedAt = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedAt = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //many to many(prodcut to category)
            modelBuilder.Entity<ProductCategory>().HasKey(c => new { c.ProductId, c.CategoryId });

            //ProductCategory(one)--product(many)
            modelBuilder.Entity<ProductCategory>()
                .HasOne<Product>(p => p.Product)
                .WithMany(pc => pc.ProductCategories)
                .HasForeignKey(f => f.ProductId);

            //ProductCategory(one)--category(many)
            modelBuilder.Entity<ProductCategory>()
                .HasOne<Category>(c => c.Category)
                .WithMany(pc => pc.ProductCategories)
                .HasForeignKey(f => f.CategoryId);
            //middle table end

            //subscriptionPlan to Store one to many relationship
            //modelBuilder.Entity<SubscriptionPlan>()
            //    .HasMany<STORE>(s => s.Stores)
            //    .WithOne(sp => sp.SubscriptionPlan)
            //    .HasForeignKey(f => f.SubscriptionPlanId);
            //SubscriptionPlan relation removed

            //store to category one to many realtionship
            modelBuilder.Entity<STORE>()
                .HasMany<Category>(c => c.Categories)
                .WithOne(s => s.Store)
                .HasForeignKey(f => f.StoreId);

            //store to product one to many realtionship
            //modelBuilder.Entity<STORE>()
            //    .HasMany<Product>(p => p.Products)
            //    .WithOne(s => s.Store)
            //    .HasForeignKey(f => f.StoreId);

            //ProductImage to Product one to many realtionship
            modelBuilder.Entity<Product>()
                .HasMany<ProductImage>(pi => pi.ProductImages)
                .WithOne(p => p.Product)
                .HasForeignKey(f => f.ProductId);

            //product to inventory one to one relationship
            modelBuilder.Entity<Product>()
                .HasOne<Inventory>(pi => pi.ProductInventory)
                .WithOne(p => p.Product)
                .HasForeignKey<Inventory>(f => f.ProductId);

            //Product to Review one to many realtionship
            modelBuilder.Entity<Product>()
                .HasMany<Review>(r => r.Reviews)
                .WithOne(p => p.Product)
                .HasForeignKey(f => f.ProductId);

            //Review to ReviewImage one to many realtionship
            modelBuilder.Entity<Review>()
                .HasMany<ReviewImage>(ri => ri.ReviewImages)
                .WithOne(r => r.Review)
                .HasForeignKey(f => f.ReviewId);

            //Order to OrderedProduct one to many relationship
            modelBuilder.Entity<Order>()
                .HasMany<OrderedProduct>(op => op.OrderedProducts)
                .WithOne(o => o.Order)
                .HasForeignKey(f => f.OrderId);
            
            //A sequence generated for Order Numbers in Order Entity

            modelBuilder.HasSequence<int>("OrderNumbers", schema: "dbo")
           .StartsAt(1000)
           .IncrementsBy(1);

            modelBuilder.Entity<Order>()
                .Property(o => o.OrderNumber)
                .HasDefaultValueSql("NEXT VALUE FOR dbo.OrderNumbers");

            //##### Default value ####//
            modelBuilder.Entity<STORE>()
                .Property(x =>x.HostTrigger)
                .HasDefaultValue(0);
            //0 for nothing added to host
            //1 for only subdomain.localhost added to host
            //2 for 1&url added to host
            modelBuilder.Entity<Product>()
                .Property(x => x.DeleteQueue)
                .HasDefaultValue(false);
            modelBuilder.Entity<Product>()
                .Property(x => x.Featured)
                .HasDefaultValue(false);

            



            //###### Data Seeding ######//

            modelBuilder.Entity<SubscriptionPlan>()
                .HasData(new SubscriptionPlanSeeding().SubscriptionPlans);

            modelBuilder.Entity<STORE>()
                .HasData(new StoreSeeding().Stores);

            modelBuilder.Entity<Product>()
                .HasData(new ProductSeeding().Products);

            modelBuilder.Entity<Category>()
                .HasData(new CategorySeeding().Categories);

            modelBuilder.Entity<ProductCategory>()
                .HasData(new ProductCategorySeeding().ProductCategories);

            modelBuilder.Entity<ProductImage>()
                .HasData(new ProductImageSeeding().ProductImages);

            modelBuilder.Entity<Review>()
                .HasData(new ReviewSeeding().ReviewSeedings);

            modelBuilder.Entity<ReviewImage>()
                .HasData(new ReviewImagesSeeding().PReviewImages_);

            modelBuilder.Entity<Inventory>()
                .HasData(new InventorySeeding().InventorySeedings);

            modelBuilder.Entity<EmailMessage>()
                .HasData(new EmailMessageSeed().EmailMessageSeeds);
            
        }


        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedProduct> OrderedProducts { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
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

        public DbSet<ProductDelete> ProductsDeleteQueue { get; set; }//no relation with any table

        public DbSet<ProductSubscriptionNotification> ProductSubscriptionNotifications { get; set; }

    }
}