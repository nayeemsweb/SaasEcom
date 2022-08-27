using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Customer.Models
{
    public class EditCartModel
    {
        private ICartService _cartService;
        private IProductService _productService;
        private ILifetimeScope _lifetimeScope;
        private IMapper _mapper;

        public Guid _StoreId { get; set; }//from view

        public Guid _UserId { get; set; }//from view

        public EditCartModel()
        {

        }
        public EditCartModel(ICartService cartService, IMapper mapper,
                            IProductService productService)
        {
            _cartService = cartService;
            _mapper = mapper;
            _productService = productService;
        }
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

        internal void setStoreId(Guid storeId)
        {
            _StoreId = StoreId;
        }
        internal void setUserId(Guid userId)
        {
            _UserId = userId;
        }
        public Tuple<IList<ReturnCartModel>, IList<decimal>> Edit()
        {
            this.StoreId = _StoreId;
            this.UserId = _UserId;

            var cartItems = _mapper.Map<Cart>(this);

            //edit cart
            _cartService.EditCart(cartItems,"edit");


            var userCart = _cartService.GetCartItems(StoreId, UserId);

            var productPrice = new List<Decimal>();

            var returnCartList = _mapper.Map<IList<ReturnCartModel>>(userCart);

            foreach (var item in returnCartList)
            {
                productPrice.Add(GetProductPrice(item.ProductId, StoreId) * item.Quantity);
            }

            var tuple = new Tuple<IList<ReturnCartModel>, IList<decimal>>(returnCartList, productPrice);

            return tuple;
        }

        private decimal GetProductPrice(Guid ProductId, Guid StoreId)
        {
            return _productService.GetProductPrice(ProductId, StoreId);
        }




    }
}

