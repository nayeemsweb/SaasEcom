namespace Ecommerce.Web.Areas.Customer.Models
{
    public class GetCartModel
    {
        public Guid ProductId { get; set;}
        public Guid UserId { get; set; }
        public Guid StoreId { get; set; }
        public string? Name{ get; set;}
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; } 
        public int Quantity { get; set; }

    }
}
