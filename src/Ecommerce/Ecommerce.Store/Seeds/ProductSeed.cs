using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Store.Entities;

namespace Ecommerce.Store.Seeds
{
    internal class ProductSeed
    {
        internal Product[] Products
        {
            get
            {
                return new Product[]
                {
                    new Product{ StoreId = new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), Id = Guid.NewGuid(), Name = "Mango", UnitPrice=50},

                    new Product{ StoreId = new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),  Id = Guid.NewGuid(), Name = "Berries", UnitPrice=150,
                        },

                    new Product{ StoreId = new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),  Id = Guid.NewGuid(), Name = "Apple",UnitPrice=200,
                        },

                    new Product{StoreId = new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),  Id = Guid.NewGuid(), Name = "Jack Fruit",UnitPrice=350,
                        },

                    new Product{ StoreId = new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),  Id = Guid.NewGuid(),UnitPrice=450, Name = "Banana"
                        },

                    new Product{ StoreId = new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),  Id = Guid.NewGuid(), Name = "Pineapple",
                       },

                    new Product{ StoreId = new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),  Id = Guid.NewGuid(), Name = "Grapes",UnitPrice=550,
                       },

                    new Product{StoreId = new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),   Id = Guid.NewGuid(), Name = "Cherry",UnitPrice=700,
                        }
                };
            }
        }
    }
}