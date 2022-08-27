using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.UnitOfWorks;
using CartEntity = Ecommerce.Store.Entities.Cart;

namespace Ecommerce.Store.Services
{
    public class CartService : ICartService
    {
        private readonly ICartUnitOfWork _cartUnitOfWork;
        private readonly IMapper _mapper;

        public CartService(IMapper mapper,
            ICartUnitOfWork cartUnitOfWork)
        {
            _cartUnitOfWork = cartUnitOfWork;
            _mapper = mapper;
        }

        public void AddToCart(Cart cart)
        {
            var cartEntity = _mapper.Map<CartEntity>(cart);
            _cartUnitOfWork.CartRepository.Add(cartEntity);
            _cartUnitOfWork.Save();
        }

        public IList<Cart> GetCartItems(Guid storeId, Guid userId)
        {
            var entity = _cartUnitOfWork.CartRepository.Get(x => 
            x.StoreId == storeId && x.UserId == userId, "");
            var bo = _mapper.Map<IList<Cart>>(entity);
            return bo;
        }
        public Boolean CheckProductPresence(Guid storeId, Guid userId,Guid productId)
        {

            var cartCount = _cartUnitOfWork.CartRepository
                .GetCount(x => x.StoreId==storeId && x.UserId==userId && x.ProductId==productId);
            if (cartCount != 0)
                return true;
            else
                return false;
        }

        public void EditCart(Cart cart,string type)
        {
            
                var cartEntity = _cartUnitOfWork.CartRepository.Get(x =>
                x.StoreId == cart.StoreId && x.UserId == cart.UserId && 
                x.ProductId == cart.ProductId, "")
                .FirstOrDefault();
                if (cartEntity != null)
                {
                    cart.Id = cartEntity.Id;
                    if(type=="add")
                        cart.Quantity += cartEntity.Quantity;
                    
                    cartEntity = _mapper.Map(cart, cartEntity);
                    _cartUnitOfWork.Save();
                }
               
        }


        public void DeleteProduct(Guid Id)
        {
            _cartUnitOfWork.CartRepository.Remove(x=>x.ProductId==Id);
            _cartUnitOfWork.Save();
        }

        public void DeleteCart(Guid userId)
        {
            _cartUnitOfWork.CartRepository.Remove(x => x.UserId == userId);
            _cartUnitOfWork.Save();
        }
    }
}
