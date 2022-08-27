using Ecommerce.Store.BusinessObjects;

namespace Ecommerce.Store.Services
{
    public interface IProductSubscriptionService
    {
     
        void CreateProductSubscriptionNotification(ProductSubscriptionNotification productSubscriptionNotification);
        void DeleteProductSubscriptionNotification(Guid id);
        void EditProductSubscriptionNotification(ProductSubscriptionNotification productSubscriptionNotification);
        (int total, int totalDisplay, IList<ProductSubscriptionNotification> records) GetAllArchivedSubscriptions(int pageIndex, int pageSize, string searchText, string orderBy);
        ProductSubscriptionNotification GetProductSubscriptionNotification(Guid id);
        (int total, int totalDisplay, IList<ProductSubscriptionNotification> records) GetproductSubscriptionNotifications(int pageIndex, int pageSize, string searchText, string orderBy);

        void ArchiveNotification(Guid id);
    }
}