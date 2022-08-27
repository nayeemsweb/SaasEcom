using SubscriptionPlanObj = Ecommerce.Store.Entities.SubscriptionPlan;
namespace Ecommerce.Store.DataSeeding
{
    internal class SubscriptionPlanSeeding
    {
        internal SubscriptionPlanObj[] SubscriptionPlans
        {
            get
            {   
                return new SubscriptionPlanObj[]
                    {
                        new SubscriptionPlanObj{
                            Id=new Guid("3882468C-202F-492F-A2E2-8D27C8F47ADD"), PlanName="Free",PlanPrice=0, ProductUploadLimit=30, PlanColor="#32a852", PublicPlan=true, StorageLimit=64,CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now
                        },
                        new SubscriptionPlanObj{
                            Id=new Guid("9CD3BD23-76DD-435F-B9EE-533F403AB0C9"), PlanName="Starter",PlanPrice=1000, ProductUploadLimit=100, PlanColor="#1a93b8", PublicPlan=true, StorageLimit=128,CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now
                        },
                        new SubscriptionPlanObj{
                            Id=new Guid("F926CCBA-0124-4219-845F-085D49240523"), PlanName="Bronze", PlanPrice=3000, ProductUploadLimit=500, PlanColor="#1a2cb8", PublicPlan=true, StorageLimit=512,CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now
                        },
                        new SubscriptionPlanObj{
                            Id=new Guid("F7E16F23-215F-4E2C-BD43-EF3811C94B25"), PlanName="Silver", PlanPrice=10000, ProductUploadLimit=1000, PlanColor="#981ab8", PublicPlan=true, StorageLimit=1024,CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now
                        },
                        new SubscriptionPlanObj{
                            Id=new Guid("0720C8E2-F298-40DE-840F-AC63556F45EE"), PlanName="Gold", PlanPrice=30000, ProductUploadLimit=5000, PlanColor="#b81a34", PublicPlan=true, StorageLimit=1024*5,CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now
                        },
                        new SubscriptionPlanObj{
                            Id=new Guid("5988B4B6-EA74-40B8-A4E6-692DCADC1D6C"), PlanName="Diamond", PlanPrice=50000, ProductUploadLimit=10000, PlanColor="#8de010", PublicPlan=true, StorageLimit=1024*10,CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now
                        },
                        new SubscriptionPlanObj{
                            Id=new Guid("6E27C9B0-DCF7-48D8-A3FC-53B001614D94"), PlanName="Platinum", PlanPrice=1000000, ProductUploadLimit=100000, PlanColor="#e01010", PublicPlan=true, StorageLimit=1024*100,CreatedAt=DateTime.Now,UpdatedAt=DateTime.Now
                        },

                    };
            }
        }
    }
}
