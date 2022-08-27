using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductObj = Ecommerce.Store.Entities.Product;

namespace Ecommerce.Store.DataSeeding
{
    internal class ProductSeeding //StoreId is a foreign key for product table
    {
        internal ProductObj[] Products
        {
            get
            {
                return new ProductObj[]
                    {
                        //store 1 seed (Pera Nai Chill)

                        new ProductObj{ Id=new Guid("17A7DFF9-34FD-44E6-98C2-AA9DD60392EF"), Name="Mango",Description="Forget about description, firstly eat all of those.", UnitPrice=230, DiscountedPrice=200,  ActiveStatus=true, Featured=false,  StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ProductObj{ Id=new Guid("0564DC12-CA23-4508-8F53-8A4C5AEFE1A9"), Name="JackFruit", Description="Forget about description, firstly eat all of those.", UnitPrice=230, DiscountedPrice=200,  ActiveStatus=true, Featured=false, StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ProductObj{ Id=new Guid("0C7DBEBF-C240-405B-9883-1606EC29DA00"), Name="APPLE", Description="Forget about description, firstly eat all of those.", UnitPrice=230, DiscountedPrice=200,  ActiveStatus=true, Featured=false, StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ProductObj{ Id=new Guid("7F6A2181-C381-4E6F-9C14-D9FC2C85B4F2"), Name="BANANA",Description="Forget about description, firstly eat all of those.", UnitPrice=230, DiscountedPrice=200,  ActiveStatus=true, Featured=false, StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ProductObj{ Id=new Guid("C8FE1651-FD04-4C52-A3C1-634AD6D0E413"), Name="BLACK BERRY", Description="Forget about description, firstly eat all of those.", UnitPrice=230, DiscountedPrice=200,  ActiveStatus=true, Featured=false, StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ProductObj{ Id=new Guid("C272683A-C8D9-4E9D-B876-16F1E6F0D557"), Name="BLACK BERRY",Description="Forget about description, firstly eat all of those.", UnitPrice=230, DiscountedPrice=200,  ActiveStatus=true, Featured=false, StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ProductObj{ Id=new Guid("3384CC0B-0030-4972-9454-159D47149677"), Name="BLACK BERRY",Description="Forget about description, firstly eat all of those.", UnitPrice=230, DiscountedPrice=200,  ActiveStatus=true, Featured=false, StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ProductObj{ Id=new Guid("9D9791CD-737C-4DE8-BDFD-ACF51A1DBB83"), Name="CUSTARD APPLE",Description="Forget about description, firstly eat all of those.", UnitPrice=230, DiscountedPrice=200,  ActiveStatus=true, Featured=false, StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ProductObj{ Id=new Guid("DA35A95D-6862-45E1-8F10-6C0A5E1200D0"), Name="DATE",Description="Forget about description, firstly eat all of those.", UnitPrice=230, DiscountedPrice=200,  ActiveStatus=true, Featured=false, StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},

                    };
            }
        }
    }
}
