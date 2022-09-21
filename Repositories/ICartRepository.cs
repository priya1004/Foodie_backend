using Models;

namespace Repositories
{
    public interface ICartRepository
    {
        List<Cart> ShowCart();
        string AddToCart(Cart c);
    }
}