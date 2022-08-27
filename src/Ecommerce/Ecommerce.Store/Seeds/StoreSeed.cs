using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Store.Entities;
using StoreObj = Ecommerce.Store.Entities.Store;
namespace Ecommerce.Store.Seeds
{
    internal class StoreSeed
    {
        internal StoreObj[] Stores
        {
            get
            {
                return new StoreObj[]
                {
                    new StoreObj{ Id = new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), StoreName = "M Store", StoreLogoUrl = " ", StoreBannerUrl = "", StoreUrl ="mstore.com" },
                    new StoreObj{ Id = new Guid("2936DF93-54C3-4FF7-B2E1-00CC32B86C49"), StoreName = "N Store", StoreLogoUrl = " ", StoreBannerUrl = "", StoreUrl ="nstore.com" },
                    new StoreObj{ Id = Guid.NewGuid(), StoreName = "Z Store", StoreLogoUrl = " ", StoreBannerUrl = "", StoreUrl ="zstore.com" },
                    new StoreObj{ Id = Guid.NewGuid(), StoreName = "S Store", StoreLogoUrl = " ", StoreBannerUrl = "", StoreUrl ="sstore.com" },
                    new StoreObj{ Id = Guid.NewGuid(), StoreName = "JU Store", StoreLogoUrl = " ", StoreBannerUrl = "", StoreUrl ="justore.com" },
                };
            }
        }
    }
}