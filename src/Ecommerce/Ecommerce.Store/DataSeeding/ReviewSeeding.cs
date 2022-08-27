using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewSeedingObj = Ecommerce.Store.Entities.Review;
namespace Ecommerce.Store.DataSeeding
{
    internal class ReviewSeeding
    {
        internal ReviewSeedingObj[] ReviewSeedings
        {
            get
            {
                return new ReviewSeedingObj[]
                    { 
                        new ReviewSeedingObj{ Id=new Guid("64D4449E-7736-4A1B-AF87-19FAF732D498"), Stars=51, ReviewMessage="This product is awesome..." , UserId=new Guid("539EBCC8-48D0-4AE2-BCE3-8A805CDE9D7E") ,ProductId=new Guid("17A7DFF9-34FD-44E6-98C2-AA9DD60392EF"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ReviewSeedingObj{ Id=new Guid("69003AAC-DBD8-4CF7-A3FC-468E873B501F"), Stars=45, ReviewMessage="This product is awesome..." , UserId=new Guid("539EBCC8-48D0-4AE2-BCE3-8A805CDE9D7E") ,ProductId=new Guid("0564DC12-CA23-4508-8F53-8A4C5AEFE1A9"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ReviewSeedingObj{ Id=new Guid("58EB49F6-2650-4932-85B2-5CF2AB709D0A"), Stars=95, ReviewMessage="This product is awesome..." , UserId=new Guid("539EBCC8-48D0-4AE2-BCE3-8A805CDE9D7E") ,ProductId=new Guid("0C7DBEBF-C240-405B-9883-1606EC29DA00"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ReviewSeedingObj{ Id=new Guid("20A6A53C-6D75-4203-BD58-5D1F333630E4"), Stars=75, ReviewMessage="This product is awesome..." , UserId=new Guid("539EBCC8-48D0-4AE2-BCE3-8A805CDE9D7E") ,ProductId=new Guid("7F6A2181-C381-4E6F-9C14-D9FC2C85B4F2"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ReviewSeedingObj{ Id=new Guid("090734B5-5DCF-4B90-BF7A-14E0293EBC3C"), Stars=6, ReviewMessage="This product is awesome..." , UserId=new Guid("539EBCC8-48D0-4AE2-BCE3-8A805CDE9D7E") ,ProductId=new Guid("C8FE1651-FD04-4C52-A3C1-634AD6D0E413"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ReviewSeedingObj{ Id=new Guid("3B7F4F89-4FD9-4A0E-A44E-5A978B984F9E"), Stars=48, ReviewMessage="This product is awesome..." , UserId=new Guid("539EBCC8-48D0-4AE2-BCE3-8A805CDE9D7E") ,ProductId=new Guid("C272683A-C8D9-4E9D-B876-16F1E6F0D557"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ReviewSeedingObj{ Id=new Guid("32EB7B51-CBAB-4037-A1C0-7751E59AF006"), Stars=74, ReviewMessage="This product is awesome..." , UserId=new Guid("539EBCC8-48D0-4AE2-BCE3-8A805CDE9D7E") ,ProductId=new Guid("3384CC0B-0030-4972-9454-159D47149677"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ReviewSeedingObj{ Id=new Guid("6DA2E12E-ED26-4710-B09B-5A467F00B370"), Stars=95, ReviewMessage="This product is awesome..." , UserId=new Guid("539EBCC8-48D0-4AE2-BCE3-8A805CDE9D7E") ,ProductId=new Guid("9D9791CD-737C-4DE8-BDFD-ACF51A1DBB83"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now},
                        new ReviewSeedingObj{ Id=new Guid("EB38AF2C-ED79-4DD2-A954-DA8C0714B411"), Stars=6, ReviewMessage="This product is awesome..." , UserId=new Guid("539EBCC8-48D0-4AE2-BCE3-8A805CDE9D7E") ,ProductId=new Guid("DA35A95D-6862-45E1-8F10-6C0A5E1200D0"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now}
                    };
            }
        }
    }
}




