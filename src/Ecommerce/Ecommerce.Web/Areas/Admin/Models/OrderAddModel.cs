using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using System.ComponentModel.DataAnnotations;
namespace Ecommerce.Web.Areas.Admin.Models
{
    public class OrderAddModel
    {
        private IOrderService _orderService;
        private ILifetimeScope _scope;
        private IMapper _mapper;
        private ICartService _cartService;
        private IProductService _productService;
        public Guid UserId { get; set; }
        public Guid StoreId { get; set; }
        public int OrderNumber { get; set; }
        public int OrderStatus { get; set; }
        public List<OrderedProduct>? OrderedProducts { get; set; }

        public OrderAddModel()
        {

        }

        public OrderAddModel(IOrderService orderService, IMapper mapper,ICartService cartService,
                             IProductService productService)
        {
            _orderService = orderService;
            _mapper = mapper;
            _productService = productService;
            _cartService = cartService;
        }

        

        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _orderService = _scope.Resolve<IOrderService>();
            _mapper = _scope.Resolve<IMapper>();
        }

        public Guid CreateOrder(Guid userId)
        {

            var order = _mapper.Map<Order>(this);

            order.UserId = userId;
            order.OrderStatus = 0;
            order.StoreId = new Guid("C1457E73-ABC4-42A4-AF2F-CE7CA1C65FF1");

            order.OrderedProducts= new List<OrderedProduct>();

            

            var cart = _cartService.GetCartItems(order.StoreId, userId);


            foreach (var cartItem in cart)
            {
                var product = _productService.GetProductById(cartItem.ProductId);
                order.OrderedProducts?.Add(new OrderedProduct
                {
                    ProductId = cartItem.ProductId,
                    ProductName = product.Name,
                    ProductPrice = product.UnitPrice,
                    ProductQuantity = cartItem.Quantity
                });
            }
            var id = _orderService.CreateOrder(order);
            return id;
        }
        public void DeleteCart(Guid userId)
        {
            _cartService.DeleteCart(userId);
        }
    }
}
