namespace Ecommerce.Store.BusinessObjects
{
    public class Category : BaseClass
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public List<ProductCategory>? ProductCategories { get; set; }

    }
}
