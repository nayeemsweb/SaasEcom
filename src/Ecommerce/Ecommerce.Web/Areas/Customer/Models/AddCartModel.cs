using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Customer.Models
{
    public class AddCartModel
    {
        private ICartService _cartService;
        private IProductService _productService;
        private ILifetimeScope _lifetimeScope;
        private IMapper _mapper;

        public AddCartModel()
        {

        }
        public AddCartModel(ICartService cartService, IMapper mapper,
                            IProductService productService)
        {
            _cartService = cartService;
            _mapper = mapper;
            _productService = productService;
        }
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid StoreId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }

        public void Resolve(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
            _cartService = _lifetimeScope.Resolve<ICartService>();
            _productService = _lifetimeScope.Resolve<IProductService>();
            _mapper = _lifetimeScope.Resolve<IMapper>();
        }

        

        public Tuple<IList<ReturnCartModel>,IList<decimal>> Add()
        {
        

            var cartItems = _mapper.Map<Cart>(this);

            var check = _cartService.CheckProductPresence(StoreId,UserId,ProductId);

            if (check)
                _cartService.EditCart(cartItems,"add");
            
            else
                _cartService.AddToCart(cartItems);
           

            var userCart =  _cartService.GetCartItems(StoreId, UserId);

            var productPrice = new List<Decimal>();

            var returnCartList = _mapper.Map<IList<ReturnCartModel>>(userCart);

            foreach (var item in returnCartList)
            {
                productPrice.Add(GetProductPrice(item.ProductId,StoreId)*item.Quantity);
            }

            var tuple = new Tuple<IList<ReturnCartModel>,IList<decimal>>(returnCartList,productPrice);

            return tuple;
        }

        private decimal GetProductPrice(Guid ProductId, Guid StoreId)
        {
            return _productService.GetProductPrice(ProductId, StoreId);
        }
        
       
        
       
    }
}

