using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class StoreModel
    {
        private readonly IStoreService _storeService;
        public StoreModel(IStoreService productService)
        {
            _storeService = productService;
        }

        public void Delete(Guid id)
        {
            _storeService.DeleteStore(id);
        }
    }
}
