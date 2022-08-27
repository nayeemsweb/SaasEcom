namespace Ecommerce.Web.Areas.Customer.Models
{
    public class ReturnCartModel
    {
        public Guid ProductId { get; set; }

        public Guid UserId { get; set; }

        public int Quantity { get; set; }

    }
}
