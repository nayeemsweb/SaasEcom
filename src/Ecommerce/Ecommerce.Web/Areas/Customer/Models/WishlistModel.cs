using Ecommerce.Store.Services;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;

namespace Ecommerce.Web.Areas.Customer.Models
{
    public class WishlistModel
    {
        private readonly IWishlistService _wishListService;
        private readonly IProductService _productService;
        private IMapper _mapper;

        public IList<Product> products;

        public WishlistModel(IWishlistService wishListService, IMapper mapper,
                             IProductService productService)
        {
            _mapper = mapper;
            _wishListService = wishListService;
            _productService = productService;
        }
        public void GetAllWishlists()
        {
            var wishListProducts = _wishListService.GetProducts();
            products = new List<Product>();
            foreach (var item in wishListProducts)
            {
                products.Add(_productService.GetProductForWishlistById(item.ProductId));
            }
        }

        public void DeleteWishlist(Guid Id)
        {
            _wishListService.DeleteProduct(Id);   
        }
    }
}
