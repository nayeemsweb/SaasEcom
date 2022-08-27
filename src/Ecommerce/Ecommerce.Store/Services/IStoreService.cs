using StoreBO = Ecommerce.Store.BusinessObjects.Store;

namespace Ecommerce.Store.Services
{
    public interface IStoreService
    {
        void CreateStore(StoreBO store);
        void DeleteStore(Guid id);
        void EditStore(StoreBO store);
        StoreBO GetStore(Guid id);
        bool HandleAvailability(string handle);//return true if same name handle is not assigned        
        (int total, int totalDisplay, IList<StoreBO> records) GetStores(int pageIndex,
            int pageSize, string searchText, string orderBy);
        IList<StoreBO> GetStores();
        IList<StoreBO> GetAll();
        IList<StoreBO> GetByHostTrigger(int Action);
    }
}
