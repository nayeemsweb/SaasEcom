using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using Ecommerce.Store.Services.MetaData;

namespace Ecommerce.Web.Areas.Customer.Models
{
    public class CartModel
    {
        private readonly ICartService _cartService;
        private IMapper _mapper;
        public IList<GetCartModel> CartItems { get; set; }
        private IProductService _productService;
        private readonly IStoreInfoService _storeInfo;
        private readonly IUserInfoService _userInfoService;
        public Guid StoreId { get; set; }
        public Guid UserId { get; set; }
        public CartModel(ICartService cartService, IMapper mapper,
                         IProductService productService, IUserInfoService userInfoService,
                         IStoreInfoService storeInfo)
        {
            _mapper = mapper;
            _cartService = cartService;
            _productService = productService;
            _userInfoService = userInfoService;
            _storeInfo = storeInfo;
        }

        public void GetCartItems()
        {
            StoreId = new Guid(_storeInfo.GetStoreId());
            UserId = new Guid(_userInfoService.GetUserId());

            CartItems = new List<GetCartModel>();
            var cartItems = _cartService.GetCartItems(StoreId, UserId);

            foreach (var item in cartItems)
            {
                var product = _productService.GetProductById(item.ProductId);
                CartItems.Add(new GetCartModel
                {
                    ProductId= product.Id,
                    StoreId = product.StoreId,
                    UserId = UserId,
                    Name = product.Name,
                    Price = product.UnitPrice-product.DiscountedPrice,
                    ImageUrl = product.ProductImages[0].Url,
                    Quantity = item.Quantity
                });;
            }
        }
        public void DeleteProduct(Guid Id)
        {
            _cartService.DeleteProduct(Id);
        }
    }
}