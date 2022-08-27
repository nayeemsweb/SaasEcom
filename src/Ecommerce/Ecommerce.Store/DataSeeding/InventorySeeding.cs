using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorySeedingObj = Ecommerce.Store.Entities.Inventory;
namespace Ecommerce.Store.DataSeeding
{
    internal class InventorySeeding
    {
        internal InventorySeedingObj[] InventorySeedings
        {
            get
            {
                return new InventorySeedingObj[]
                    {
                        new InventorySeedingObj{ Id=new Guid("0AC9C4CD-003D-4BCE-B5BC-732F025A57DF"), Quantity=23, ProductId=new Guid("17A7DFF9-34FD-44E6-98C2-AA9DD60392EF"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new InventorySeedingObj{ Id=new Guid("97081FB9-F963-4125-AEE3-AE7DEAECB0EC"), Quantity=4, ProductId=new Guid("0564DC12-CA23-4508-8F53-8A4C5AEFE1A9"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new InventorySeedingObj{ Id=new Guid("E2390A67-27F8-439F-9C62-3ECB09DCA511"), Quantity=6, ProductId=new Guid("0C7DBEBF-C240-405B-9883-1606EC29DA00"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new InventorySeedingObj{ Id=new Guid("3CA1F739-7559-4A50-B4E3-8E8D8C86D482"), Quantity=7, ProductId=new Guid("7F6A2181-C381-4E6F-9C14-D9FC2C85B4F2"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new InventorySeedingObj{ Id=new Guid("76E3DAC5-FACF-471D-AF6C-BA5EB733F0D8"), Quantity=45, ProductId=new Guid("C8FE1651-FD04-4C52-A3C1-634AD6D0E413"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new InventorySeedingObj{ Id=new Guid("B5EDE1AA-D435-4817-B11D-55A518AD338F"), Quantity=235, ProductId=new Guid("C272683A-C8D9-4E9D-B876-16F1E6F0D557"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new InventorySeedingObj{ Id=new Guid("1FA9D85A-1F28-4A16-A6AB-83CD29082A9D"), Quantity=68, ProductId=new Guid("3384CC0B-0030-4972-9454-159D47149677"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new InventorySeedingObj{ Id=new Guid("BEB721E0-0880-47B0-8A4E-298214B89134"), Quantity=90, ProductId=new Guid("9D9791CD-737C-4DE8-BDFD-ACF51A1DBB83"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new InventorySeedingObj{ Id=new Guid("9249ED3F-50D1-4F62-8D2F-9E047770EA6C"), Quantity=94, ProductId=new Guid("DA35A95D-6862-45E1-8F10-6C0A5E1200D0"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now}

                    };
            }
        } 
    }
}
