using Ecommerce.Store.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.Services
{
    public interface IProductRestoreService
    {
        void Add(ProductDelete trashProduct);
        void Remove(Guid Id);
        ProductDelete GetTrashByProductId(Guid ProductId);
        IList<ProductDelete> GetTrashedProducts(Guid StoreId);
    }
}
