using Ecommerce.Common;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class ListOfAllSubscriptionNotificationsModel
    {
        private readonly IProductSubscriptionService _subscriptionNotificationService;
        private readonly IProductService _productService;
        public ListOfAllSubscriptionNotificationsModel(IProductSubscriptionService subscriptionService, IProductService productService)
        {
            _subscriptionNotificationService = subscriptionService;
            _productService = productService;
            
        }

        public object? GetAllSubscriptionNotifications(DataTablesAjaxRequestModel dataTableModel)
        {
            var data = _subscriptionNotificationService.GetproductSubscriptionNotifications(
                    dataTableModel.PageIndex,
                    dataTableModel.PageSize,
                    dataTableModel.SearchText,
                    dataTableModel.GetSortText(
                        new string[] {"Email",
                            "PhoneNo",
                            "Time"}));
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                               record.Id.ToString(),

                               (_productService.GetProductById(record.ProductId)).ProductImages.Select(x => x.Url).FirstOrDefault().ToString(),

                             (_productService.GetProductById(record.ProductId)).Name, 

                                                             
                                record.Email,
                                record.PhoneNo,
                                record.Time.ToString(),
                                record.Id.ToString(),
                                
                               
                        }
                    ).ToArray()
            };
        }

        internal void ArchiveNotification(Guid id)
        {
            _subscriptionNotificationService.ArchiveNotification(id);
        }

        public void DeleteSubscriptionNotification(Guid id)
        {
            _subscriptionNotificationService.DeleteProductSubscriptionNotification(id);
           
        }
    }
}
