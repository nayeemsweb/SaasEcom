using Ecommerce.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.Entities
{
    public class ReviewImage : BaseEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string? ImageUrl { get; set; }

        public Guid ReviewId { get; set; }//foreign key of review
        public Review? Review { get; set; }
    }
}
