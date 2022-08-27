using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Customer.Models
{
    public class OrderedProductsModel
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private IMapper _mapper;

        public Order Order;

        public IList<OrderedProductListModel> OrderedProducts { get; set; }

        public OrderedProductsModel(IOrderService orderService, IMapper mapper,
                                  IProductService productService)
        {
            _mapper = mapper;
            _orderService = orderService;
            _productService = productService;
        }
        public void GetAllProducts(int orderNumber)
        {
            OrderedProducts = new List<OrderedProductListModel>();
            var products = _orderService.GetProducts(orderNumber);
            decimal cost = 0;
            foreach (var item in products.OrderedProducts)
            {
                cost += item.ProductPrice;
            }
            foreach (var product in products.OrderedProducts)
            {
                var singleProduct = _productService.GetProductById(product.ProductId);
                if (singleProduct != null)
                {
                    OrderedProducts.Add(new OrderedProductListModel
                    {
                        Id = products.Id,
                        UserId = products.UserId,
                        OrderNumber = orderNumber,
                        Quantity = product.ProductQuantity,
                        Description = singleProduct.Description,
                        Price = product.ProductPrice,
                        TotalPrice = cost,
                        ProductImage = singleProduct?.ProductImages?[0].Url,
                        ProductName = product.ProductName,
                        CreatedAt = products.CreatedAt,
                        Status = products.OrderStatus
                    });
                }
            }
            Order = products;
        }
    }
}
