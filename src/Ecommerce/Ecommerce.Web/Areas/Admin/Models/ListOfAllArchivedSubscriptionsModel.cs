using Ecommerce.Common;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class ListOfAllArchivedSubscriptionsModel
    {
        private readonly IProductSubscriptionService _subscriptionNotificationService;
        private readonly IProductService _productService;
        public ListOfAllArchivedSubscriptionsModel(IProductSubscriptionService subscriptionService, IProductService productService)
        {
            _subscriptionNotificationService = subscriptionService;
            _productService = productService;
            
        }

      
        public object? GetAllArchivedSubscriptions(DataTablesAjaxRequestModel dataTableModel)
        {
            var data = _subscriptionNotificationService.GetAllArchivedSubscriptions(
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

        //public void DeleteSubscriptionNotification(Guid id)
        //{
        //    //_subscriptionNotificationService.DeleteProductSubscriptionNotification(id);
        //    //var contactForm = _mapper.Map<ContactForm>(this);

        //    //_contactFormService.EditContactForm(contactForm);
        //}
    }
}
