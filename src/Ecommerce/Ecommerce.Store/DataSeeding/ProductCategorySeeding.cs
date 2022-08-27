using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCategoryObj = Ecommerce.Store.Entities.ProductCategory;

namespace Ecommerce.Store.DataSeeding
{
    internal class ProductCategorySeeding
    {
        internal ProductCategoryObj[] ProductCategories
        {
            get
            {
                return new ProductCategoryObj[]
                    {
                        new ProductCategoryObj{ ProductId=new Guid("7F6A2181-C381-4E6F-9C14-D9FC2C85B4F2"), CategoryId=new Guid("7A61CF49-D11A-494D-95CA-C649ED215773")},//Banana->Food
                        new ProductCategoryObj{ ProductId=new Guid("7F6A2181-C381-4E6F-9C14-D9FC2C85B4F2"), CategoryId=new Guid("D6DCF59A-0CF7-4C22-AFF5-38CD0223ACA0")},//Banana->Vegetables
                        new ProductCategoryObj{ ProductId=new Guid("7F6A2181-C381-4E6F-9C14-D9FC2C85B4F2"),CategoryId=new Guid("0B42EB8C-A7FD-46AA-A88C-8D656B016115")},//Banana->Seasonal Food
                        new ProductCategoryObj{ ProductId=new Guid("17A7DFF9-34FD-44E6-98C2-AA9DD60392EF"), CategoryId=new Guid("7A61CF49-D11A-494D-95CA-C649ED215773")},//Mango->Food
                        new ProductCategoryObj{ ProductId=new Guid("0564DC12-CA23-4508-8F53-8A4C5AEFE1A9"), CategoryId=new Guid("7A61CF49-D11A-494D-95CA-C649ED215773")},//JackFruit->Food
                        new ProductCategoryObj{ ProductId=new Guid("0C7DBEBF-C240-405B-9883-1606EC29DA00"), CategoryId=new Guid("7A61CF49-D11A-494D-95CA-C649ED215773")}//Apple->Food
                        
                        
                      
                    };
            }
        }
    }
}







