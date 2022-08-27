using System.ComponentModel;
using Ecommerce.Data;
namespace Ecommerce.Store.BusinessObjects
{
    public class Review : BaseClass
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public string? ReviewMessage { get; set; }
        public List<ReviewImage>? ReviewImages { get; set; }
        public int Stars { get; set; }

    }
}