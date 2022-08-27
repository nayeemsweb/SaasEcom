using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using WishlistBO = Ecommerce.Store.BusinessObjects.Wishlist;
namespace Ecommerce.Web.Areas.Customer.Models
{
    public class WishlistAddModel
    {
        private IWishlistService _wishListService;
        private ILifetimeScope _scope;
        private IMapper _mapper;

       
        public Guid StoreId { get; set; } = new Guid ("3384CC0B-0030-4972-9454-159D47149677");
        public Guid UserId { get; set; } = new Guid("DB6FA3F2-6EE6-4A3B-AC6C-9FB746857A56");

        public Guid ProductId { get; set; }

        public WishlistAddModel()
        {

        }

        public WishlistAddModel(IWishlistService wishListService, IMapper mapper)
        {
            _wishListService = wishListService;
            _mapper = mapper;
        }

        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _wishListService = _scope.Resolve<IWishlistService>();
            _mapper = _scope.Resolve<IMapper>();
        }

        public void CreateWishlist(Guid Id)
        {

            var wishList = _mapper.Map<WishlistBO>(this);
            wishList.ProductId = Id;
            _wishListService.CreateProduct(wishList);
        }

    }
}

