using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CategoryObj = Ecommerce.Store.Entities.Category;

namespace Ecommerce.Store.DataSeeding
{
    internal class CategorySeeding
    {
        internal CategoryObj[] Categories
        {
            get
            {
                return new CategoryObj[]
                    {
                        new CategoryObj{Id=new Guid("7A61CF49-D11A-494D-95CA-C649ED215773"),
                            Name="Food", Description="This is category description",
                            ImageUrl="Files/bongobondhu.jpg", StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),
                            CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now },
                        new CategoryObj{Id=new Guid("D6DCF59A-0CF7-4C22-AFF5-38CD0223ACA0"),
                            Name="Vegetable", Description="This is category description",
                            ImageUrl="Files/bongobondhu1.jpg", StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),
                        CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new CategoryObj{Id=new Guid("0B42EB8C-A7FD-46AA-A88C-8D656B016115"),
                            Name="Seasonal Food", Description="This is category description",
                            ImageUrl="Files/bongobondhu.jpg", StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1")
                        ,CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new CategoryObj{Id=new Guid("136E59E2-2046-460F-AD0E-60B75F3748C9"),
                            Name="Phone", Description="This is category description",
                            ImageUrl="Files/bongobondhu1.jpg", StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"),
                            CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new CategoryObj{Id=new Guid("7D0059E3-816C-44E1-8E36-ADB7C74E1C7C"),
                            Name="Cloths", Description="This is category description",
                            ImageUrl="Files/bongobondhu.jpg", StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1")
                        ,CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new CategoryObj{Id=new Guid("7E2C655F-5E84-48C7-BDA1-AD178A7BE899"),
                            Name="Gadgets", Description="This is category description",
                            ImageUrl="Files/pd-6.jpg", StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1")
                        ,CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new CategoryObj{Id=new Guid("C405483E-B35C-4C4E-9E7E-387B5527F0B7"),
                            Name="default", Description="This is a default Category",
                            ImageUrl="Files/pd-6.jpg", StoreId=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1")
                        ,CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},

                    };

            }
        }
    }
}

