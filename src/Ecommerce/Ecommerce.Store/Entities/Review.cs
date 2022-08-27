using System.ComponentModel;
using Ecommerce.Data;
using Ecommerce.Membership.Entities;

namespace Ecommerce.Store.Entities
{
    public class Review : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public int Stars { get; set; }
        public string? ReviewMessage { get; set; }
        public Guid UserId { get; set; }
        
        public Guid ProductId { get; set; }//foreign key of product
        public Product? Product { get; set; }

        public IList<ReviewImage>? ReviewImages { get; set; }

    }
}