using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Store.Entities;

namespace Ecommerce.Store.Seeds
{
    internal class CategorySeed
    {
        internal Category[] Categories
        {
            get
            {
                return new Category[]
                {
                    new Category{ Id = new Guid(), StoreId = new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), Name = "Fruits",
                        ImageUrl="/EcommerceTheme/img/product/product-1.jpg"},

                    new Category{ Id = new Guid(), StoreId = new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), Name = "Vegitables",
                        ImageUrl="/EcommerceTheme/img/product/product-2.jpg"},

                    new Category{ Id = new Guid(), StoreId = new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), Name = "Moblies",
                        ImageUrl="/EcommerceTheme/img/product/product-3.jpg"},

                    new Category{ Id = new Guid(), StoreId = new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), Name = "Electronics",
                        ImageUrl="/EcommerceTheme/img/product/product-4.jpg"}
                };
            }
        }
    }
}