namespace Ecommerce.Web.Areas.Admin.Models
{
    public class OrderedProductList
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int OrderNumber { get; set; }
        public int Quantity { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public string? ProductImage { get; set; }
        public string? ProductName { get; set; }

    }
}
