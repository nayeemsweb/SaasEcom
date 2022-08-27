using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreObj=Ecommerce.Store.Entities.Store;

namespace Ecommerce.Store.DataSeeding
{


    internal class StoreSeeding
    {
        internal StoreObj[] Stores
            {
                get
                {
                return new StoreObj[]
                    {
                        new StoreObj{
                            Id=new Guid("c1457e73-abc4-42a4-af2f-ce7ca1c65ff1"), Handle="amarShop", StoreName="Pera Nai Chill", StoreUrl="www.PeraNaiChill.com", StoreLogoUrl="Files/online-shopLogojpg.jpg", StoreBannerUrl="Files/Screenshot_28.png", OperatingIndustry="Food", StoreTitle="Ekdin to morei jabo",
                            StoreDescription="Ai khany valo valo khabar pawa jay", StoreEmailAddress="chill@gmail.com", PrimaryPhoneNumber="+880123456789", OptionalPhoneNumber="+880123456789", FacebookPageHandle="www.facebook.com/PeraNaiChill",
                            InstagramAccountHandle="www.instagram.com/PeraNaiChill", Country="Bangladesh", City="Dhaka", PostalCode="1236", ApartmentAddress="107, Prem Goli, Jatrabari.", DetailAddress="Nil akhash", SubscriptionPlanId=new Guid("3882468C-202F-492F-A2E2-8D27C8F47ADD"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now
                        },
                        new StoreObj{
                            Id=new Guid("2936DF93-54C3-4FF7-B2E1-00CC32B86C49"), Handle="shopAmar", StoreName="Vai Vai Mudir dokan", StoreUrl="www.vai-vai.com", StoreLogoUrl="Files/online-shopLogojpg.jpg", StoreBannerUrl="Files/Screenshot_28.png", OperatingIndustry="Electronics", StoreTitle="Baki cheye lojja diben na",
                            StoreDescription="Fresh food", StoreEmailAddress="vai_vai@gmail.com", PrimaryPhoneNumber="+880123456789", OptionalPhoneNumber="+880123456789", FacebookPageHandle="www.facebook.com/vai123",
                            InstagramAccountHandle="www.instagram.com/vai123", Country="Bangladesh", City="Dhaka", PostalCode="1236", ApartmentAddress="107, Prem Goli, Jatrabari.", DetailAddress="Nil akhash", SubscriptionPlanId=new Guid("0720C8E2-F298-40DE-840F-AC63556F45EE"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now
                        },
                        new StoreObj{
                            Id=new Guid("A36B6614-5254-4FB9-9253-F2CCA4B4739E"), Handle="store", StoreName="Pera Nai Chill 2", StoreUrl="www.PeraOnk.com", StoreLogoUrl="Files/online-shopLogojpg.jpg", StoreBannerUrl="Files/Screenshot_28.png", OperatingIndustry="Food", StoreTitle="Ekdin to morei jabo",
                            StoreDescription="Ai khany valo valo khabar pawa jay", StoreEmailAddress="chill@gmail.com", PrimaryPhoneNumber="+880123456789", OptionalPhoneNumber="+880123456789", FacebookPageHandle="www.facebook.com/PeraNaiChill",
                            InstagramAccountHandle="www.instagram.com/PeraNaiChill", Country="Bangladesh", City="Dhaka", PostalCode="1236", ApartmentAddress="107, Prem Goli, Jatrabari.", DetailAddress="Nil akhash", SubscriptionPlanId=new Guid("9CD3BD23-76DD-435F-B9EE-533F403AB0C9"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now
                        },
                        new StoreObj{
                            Id=new Guid("E8173B5C-EC25-4F48-A008-0597C99AED32"), Handle="HlwWorld", StoreName="Vai Vai Mudir dokan 2", StoreUrl="www.earth.com", StoreLogoUrl="Files/online-shopLogojpg.jpg", StoreBannerUrl="Files/Screenshot_28.png", OperatingIndustry="Electronics", StoreTitle="Baki cheye lojja diben na",
                            StoreDescription="Fresh food", StoreEmailAddress="vai_vai@gmail.com", PrimaryPhoneNumber="+880123456789", OptionalPhoneNumber="+880123456789", FacebookPageHandle="www.facebook.com/vai123",
                            InstagramAccountHandle="www.instagram.com/vai123", Country="Bangladesh", City="Dhaka", PostalCode="1236", ApartmentAddress="107, Prem Goli, Jatrabari.", DetailAddress="Nil akhash", SubscriptionPlanId=new Guid("3882468C-202F-492F-A2E2-8D27C8F47ADD"),CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now
                        }
                        };
                }
            }
        
    }
}
