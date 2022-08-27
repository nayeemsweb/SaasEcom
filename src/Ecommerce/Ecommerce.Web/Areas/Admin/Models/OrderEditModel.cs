using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class OrderEditModel
    {
        private IOrderService _orderService;
        private ILifetimeScope _scope;
        private IMapper _mapper;

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid StoreId { get; set; }
        public int OrderNumber { get; set; }
        public int OrderStatus { get; set; }



        public OrderEditModel()
        {

        }

        public OrderEditModel(IMapper mapper, IOrderService orderService)
        {
             _orderService = orderService;
            _mapper = mapper;
        }

        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _orderService = _scope.Resolve<IOrderService>();
            _mapper = _scope.Resolve<IMapper>();
        }

        public void EditOrder(int status)
        {
            var order = _mapper.Map<Order>(this);
            order.OrderStatus=status;
            _orderService.EditOrder(order);
        }

        public void LoadData(int orderNumber)
        {
            var order = _orderService.GetOrder(orderNumber);
            _mapper.Map(order, this);
        }
    }
}
