using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductDeleteEntity = Ecommerce.Store.Entities.ProductDelete;

namespace Ecommerce.Store.Services
{
    public class ProductRestoreService : IProductRestoreService
    {
        private readonly IProductRestoreUnitOfWork _restoreUnitOfWork;
        private readonly IMapper _mapper;

        public ProductRestoreService(IMapper mapper,
            IProductRestoreUnitOfWork restoreUnitOfWork)
        {
            _restoreUnitOfWork = restoreUnitOfWork;
            _mapper = mapper;
        }
        public void Add(ProductDelete trashProduct)
        {
            //move product to delete queue, worker service will delete after 1 day
            var entity = _mapper.Map<ProductDeleteEntity>(trashProduct);

            _restoreUnitOfWork.ProductRestore.Add(entity);
            _restoreUnitOfWork.Save();

        }
        public void Remove(Guid Id)
        {
            _restoreUnitOfWork.ProductRestore.Remove(Id);
            _restoreUnitOfWork.Save();
        }
        public ProductDelete GetTrashByProductId(Guid ProductId)
        {
            var entity = _restoreUnitOfWork.ProductRestore
                .Get(x => x.ProductId == ProductId, string.Empty).FirstOrDefault();
            return _mapper.Map<ProductDelete>(entity);
        }
        public IList<ProductDelete> GetTrashedProducts(Guid StoreId)
        {
            var entities = _restoreUnitOfWork.ProductRestore.Get(x => x.StoreId == StoreId, string.Empty);
            var trasedProduct = new List<ProductDelete>();
            foreach (var entity in entities)
                trasedProduct.Add(_mapper.Map<ProductDelete>(entity));
            return trasedProduct;

        }

    }
}
