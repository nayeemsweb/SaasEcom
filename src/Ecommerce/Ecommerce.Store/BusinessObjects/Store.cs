using System.ComponentModel;
using Ecommerce.Data;

namespace Ecommerce.Store.BusinessObjects
{
    public class Store : BaseClass
    {
        public Guid Id { get; set; }
        public string Handle { get; set; }
        public string StoreName { get; set; }
        public string? StoreUrl { get; set; }
        public string? StoreLogoUrl { get; set; }
        public string? StoreBannerUrl { get; set; }
        public string? OperatingIndustry { get; set; }
        public string? StoreTitle { get; set; }
        public string? StoreDescription { get; set; }
        public string? StoreEmailAddress { get; set; }
        public string? PrimaryPhoneNumber { get; set; }
        public string? OptionalPhoneNumber { get; set; }
        public string? FacebookPageHandle { get; set; }
        public string? InstagramAccountHandle { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? ApartmentAddress { get; set; }
        public string? DetailAddress { get; set; }

        public int HostTrigger { get; set; }//for host file, subdomain & url

        public Guid SubscriptionPlanId { get; set; }

        //public IList<Product>? Products { get; set; }//a store can have multiple products
        public IList<Category>? Categories{ get; set; }//a store can have multiple categories of item
    }
}