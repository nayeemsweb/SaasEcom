using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using StoreBO = Ecommerce.Store.BusinessObjects.Store;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class ShopSetupModel
    {
        private ILifetimeScope _scope;
        private IStoreService _storeService;
        private IMapper _mapper;
        [StringLength(8, MinimumLength = 5,ErrorMessage = "Handle should minimum 5 character")]
        public string Handle { get; set; }
        [StringLength(20, ErrorMessage = "Store Name should below 20 characters")]
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

        public string? SubscriptionPlanId { get; set; }
        
        public IList<SubscriptionPlan>? SubscriptionPlans { get; set; }

        //only for setting data in view


        //public Guid SubscriptionPlanId { get; set; }

        public ShopSetupModel()
        {

        }

        public ShopSetupModel(ILifetimeScope scope, IStoreService storeService, IMapper mapper)
        {
            _scope = scope;
            _storeService = storeService;
            _mapper = mapper;

            //subscriptionPlan
            var SubscriptionPlanModel = _scope.Resolve<SubscriptionPlanModel>();
            SubscriptionPlans = SubscriptionPlanModel.getPublicPlans();
        }
        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _storeService = _scope.Resolve<IStoreService>();
            _mapper = _scope.Resolve<IMapper>();
        }
        public void CreateStore()
        {
            var store = _mapper.Map<StoreBO>(this);
            _storeService.CreateStore(store);
        }
        public bool checkHandle(string handle)
        {
            //return true if same name handle is not assigned
            return _storeService.HandleAvailability(handle); 
        }

        //public List<SelectListItem>? StoreTypes { get;}//from database


        //public string? ShopCountry { get; set; }//from store admin
        //public string? ShopCity { get; set; }//from store admin
        //public List<SelectListItem>? ShopCountries { get;}//from database
        //public List<SelectListItem>? ShopCities { get; }//from database


        //public ShopSetupModel()
        //{
        //StoreTypes = new List<SelectListItem>
        //{
        //    new SelectListItem { Value = "Clothing", Text = "Clothing" },
        //    new SelectListItem { Value = "Electronics", Text = "Electronics" },
        //    new SelectListItem { Value = "Furniture", Text = "Furniture"  },
        //    new SelectListItem { Value = "Handcrafts", Text = "Handcrafts"  },
        //    new SelectListItem { Value = "Jewelry", Text = "Jewelry"  },
        //    new SelectListItem { Value = "IT", Text = "IT"  }
        //};
        //ShopCountries = new List<SelectListItem>
        //{
        //    new SelectListItem{ Value="Bangladesh", Text="Bangladesh"},
        //    new SelectListItem{ Value="Pakisthan", Text="Pakisthan"},
        //    new SelectListItem{ Value="Nepal", Text="Nepal"},
        //    new SelectListItem{ Value="America", Text="America"},
        //    new SelectListItem{ Value="Canada", Text="Canada"},
        //    new SelectListItem{ Value="China", Text="China"}
        //};
        //ShopCities = new List<SelectListItem>
        //{
        //    new SelectListItem{ Value="Dhaka", Text="Dhaka"},
        //    new SelectListItem{ Value="Barishal", Text="Barishal"},
        //    new SelectListItem{ Value="New York", Text="New York"},
        //    new SelectListItem{ Value="Moscow", Text="Moscow"},
        //    new SelectListItem{ Value="Dubai", Text="Dubai"},
        //    new SelectListItem{ Value="Berlin", Text="Berlin"}
        //};
        //}
    }
}
