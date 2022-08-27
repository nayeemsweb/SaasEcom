using Ecommerce.Store.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.Services
{
    public interface IOrderService
    {

        Guid CreateOrder(Order order);
        (int total, int totalDisplay, IList<Order> Orders)
            GetOrders(Guid StoreId, int pageIndex,
                       int pageSize, string orderBy);
        void EditOrder(Order order);
        Order GetOrder(int orderNumber);
        Order GetProducts(int orderNumber);
    }
}
