using Ecommerce.Data;

namespace Ecommerce.Store.Entities
{
    public class Category : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }

        public Guid StoreId { get; set; }//foreign key of store table
        public Store? Store { get; set; }//navigation of store table

        public IList<ProductCategory>? ProductCategories { get; set; }

    }
}
