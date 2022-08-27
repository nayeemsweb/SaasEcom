using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.UnitOfWorks;
using WishlistEntity = Ecommerce.Store.Entities.Wishlist;

namespace Ecommerce.Store.Services
{
    public class WishlistService : IWishlistService
    {
        private readonly IWishlistUnitOfWork _wishListUnitOfWork;
        private readonly IMapper _mapper;

        public WishlistService(IMapper mapper,
            IWishlistUnitOfWork wishListUnitOfWork)
        {
            _wishListUnitOfWork = wishListUnitOfWork;
            _mapper = mapper;
        }


        public void CreateProduct(Wishlist product)
        {
            var wishListCount = _wishListUnitOfWork.Wishlists
               .GetCount(x => x.ProductId== product.ProductId);
            if (wishListCount == 0)
            {
                var entity = _mapper.Map<WishlistEntity>(product);
                _wishListUnitOfWork.Wishlists.Add(entity);
                _wishListUnitOfWork.Save();
            }
            else
            {
                throw new Exception("Product with same Id already exists");
            }
        }

        public IList<Wishlist> GetProducts()
        {
            var wishListEntities = _wishListUnitOfWork.Wishlists.GetAll();

            List<Wishlist> products = new List<Wishlist>();

            foreach (WishlistEntity entity in wishListEntities)
            {
                products.Add(_mapper.Map<Wishlist>(entity));
            }

            return products;
        }

        public void DeleteProduct(Guid Id)
        {
            _wishListUnitOfWork.Wishlists.Remove(x=>x.ProductId==Id);
            _wishListUnitOfWork.Save();
        }
    }
}
