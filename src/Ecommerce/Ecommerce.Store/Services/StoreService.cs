using AutoMapper;
using Ecommerce.Store.UnitOfWorks;
using StoreBO = Ecommerce.Store.BusinessObjects.Store;
using StoreEntity = Ecommerce.Store.Entities.Store;

namespace Ecommerce.Store.Services
{
    public class StoreService : IStoreService
    {
        private readonly IStoreUnitOfWork _storeUnitOfWork;
        private readonly IMapper _mapper;

        public StoreService(IMapper mapper,
            IStoreUnitOfWork storeUnitOfWork)
        {
            _storeUnitOfWork = storeUnitOfWork;
            _mapper = mapper;
        }
        public StoreService(IStoreUnitOfWork storeUnitOfWork)//for subdomain worker proj
        {
            _storeUnitOfWork = storeUnitOfWork;
        }
        public bool HandleAvailability(string handle)//return true if same name handle is not assigned
        {
            var handleCount = _storeUnitOfWork.Stores
                .GetCount(x => x.Handle == handle.ToLower());

            return (handleCount > 0) ? false : true;
        }
        public void CreateStore(StoreBO store)
        {
            //var storeCount = _storeUnitOfWork.Stores
            //    .GetCount(x => x.StoreName == store.StoreName);

            var entity = _mapper.Map<StoreEntity>(store);

            _storeUnitOfWork.Stores.Add(entity);
            _storeUnitOfWork.Save();
        }

        public void DeleteStore(Guid id)
        {
            _storeUnitOfWork.Stores.Remove(id);
            _storeUnitOfWork.Save();
        }

        public void EditStore(StoreBO store)
        {
            var storeEntity = _storeUnitOfWork.Stores.GetById(store.Id);

            storeEntity = _mapper.Map(store, storeEntity);

            _storeUnitOfWork.Save();
        }

        public StoreBO GetStore(Guid id)
        {
            var storeEntity = _storeUnitOfWork.Stores.GetById(id);

            var store = _mapper.Map<StoreBO>(storeEntity);

            return store;
        }

        public (int total, int totalDisplay, IList<StoreBO> records) GetStores(int pageIndex,
            int pageSize, string searchText, string orderBy)
        {
            var result = _storeUnitOfWork.Stores.GetDynamic(x => x.StoreName.Contains(searchText),
                orderBy, string.Empty, pageIndex, pageSize, true);

            List<StoreBO> stores = new List<StoreBO>();
            foreach (StoreEntity store in result.data)
            {
                stores.Add(_mapper.Map<StoreBO>(store));
            }

            return (result.total, result.totalDisplay, stores);
        }

        public IList<StoreBO> GetStores()
        {
            var storeEntities = _storeUnitOfWork.Stores.GetAll();

            List<StoreBO> stores = new List<StoreBO>();

            foreach (StoreEntity entity in storeEntities)
            {
                stores.Add(_mapper.Map<StoreBO>(entity));
            }

            return stores;
        }
        public IList<StoreBO> GetAll()
        {
            var storeEntities = _storeUnitOfWork.Stores.GetAll();
            var Stores = new List<StoreBO>();
            foreach (var store in storeEntities)
                Stores.Add(_mapper.Map<StoreBO>(store));
            return Stores;
        }

        public IList<StoreBO> GetByHostTrigger(int Action)
        {
            var storeEntities = _storeUnitOfWork.Stores
                .Get(x=>x.HostTrigger==Action, string.Empty);
            var Stores = new List<StoreBO>();
            foreach (var store in storeEntities)
                Stores.Add(_mapper.Map<StoreBO>(store));
            return Stores;
        }
    }
}
