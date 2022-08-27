

using Ecommerce.Store.BusinessObjects;

namespace Ecommerce.Store.Services
{
    public interface ICartService
    {
        void AddToCart(Cart cart);
        IList<Cart> GetCartItems(Guid storeId, Guid userId);

        Boolean CheckProductPresence(Guid storeId, Guid userId, Guid productId);

        void EditCart(Cart cart,string type);
        void DeleteProduct(Guid Id);
        void DeleteCart(Guid userId);
    }
}
