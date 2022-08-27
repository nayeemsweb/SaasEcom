using Ecommerce.Store.DbContexts;

namespace Ecommerce.Web.Areas.Customer.Models
{
    public class ShopModel
    {
        public string? SortOrder { get; set; }
        public int pageIndex { get; set; }
    }
}
