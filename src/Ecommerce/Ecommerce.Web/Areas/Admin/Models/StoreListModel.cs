using Ecommerce.Common;
using Ecommerce.Store.Entities;
using Ecommerce.Store.Services;
using StoreBO = Ecommerce.Store.BusinessObjects.Store;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class StoreListModel
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

        public Guid SubscriptionPlanId { get; set; }//foreignKey of SubscriptionPaln
        public SubscriptionPlan? SubscriptionPlan { get; set; }

        //public IList<Product>? Products { get; set; }//a store can have multiple products
        public IList<Category>? Categories { get; set; }//a store can have multiple categories of item

        private readonly IStoreService _storeService;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public StoreListModel(IStoreService storeService, ICategoryService categoryService, IProductService productService)
        {
            _storeService = storeService;
            _categoryService = categoryService;
            _productService = productService;
        }

        public object GetPagedStores(DataTablesAjaxRequestModel model)
        {
            var data = _storeService.GetStores(
                model.PageIndex,
                model.PageSize,
                model.SearchText,
                model.GetSortText(new string[] { "StoreLogoUrl","Handle", "StoreName", "StoreEmailAddress" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string?[]
                        {
                            record.StoreLogoUrl,
                            record.Handle,
                            record.StoreName,
                            record.StoreEmailAddress,
                            record.Id.ToString()
                        }
                    ).ToArray()
            };
        }

        public IList<StoreBO> GetAllStores()
        {
            return _storeService.GetStores();
        }
    }
}
