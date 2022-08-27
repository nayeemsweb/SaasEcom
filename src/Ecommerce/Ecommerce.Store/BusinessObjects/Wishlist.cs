﻿using System.ComponentModel;
using Ecommerce.Data;

namespace Ecommerce.Store.BusinessObjects
{
    public class Wishlist : BaseClass
    {
        public Guid Id { get; set; }
        public Guid StoreId { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }


    }
}
