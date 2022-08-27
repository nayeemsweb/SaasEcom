using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderEntity = Ecommerce.Store.Entities.Order;
namespace Ecommerce.Store.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderUnitOfWork _orderUnitOfWork;
        private readonly IMapper _mapper;

        public OrderService(IMapper mapper,
            IOrderUnitOfWork orderUnitOfWork)
        {
            _orderUnitOfWork = orderUnitOfWork;
            _mapper = mapper;
        }
        public Guid CreateOrder(Order order)
        {
            var entity = _mapper.Map<OrderEntity>(order);

            _orderUnitOfWork.Orders.Add(entity);
            _orderUnitOfWork.Save();
            return entity.Id;
        }

        public void EditOrder(Order order)
        {
            try
            {
                var orderEntity = _orderUnitOfWork.Orders.GetById(order.Id);

                orderEntity = _mapper.Map(order, orderEntity);

                _orderUnitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Order GetOrder(int orderNumber)
        {

            var result = _orderUnitOfWork.
                Orders.Get(x => x.OrderNumber==orderNumber,string.Empty).FirstOrDefault();

            var order = _mapper.Map<Order>(result);
            return order;
        }
        public Order GetProducts(int orderNumber)
        {

            var result = _orderUnitOfWork.
                Orders.Get(x => x.OrderNumber == orderNumber, "OrderedProducts").FirstOrDefault();

            var order = _mapper.Map<Order>(result);
            return order;
        }

        public (int total, int totalDisplay, IList<Order> Orders) GetOrders
           (Guid StoreId, 
           int pageIndex,
           int pageSize, 
           string orderBy
           )
        {
            var result = _orderUnitOfWork.Orders.GetDynamic(x => x.StoreId == StoreId,
                orderBy, "OrderedProducts", pageIndex, pageSize, true);

            List<Order> orders = new List<Order>();
            foreach (OrderEntity order in result.data)
            {
                orders.Add(_mapper.Map<Order>(order));
            }

            return (result.total, result.totalDisplay, orders);
        }
    }
}
