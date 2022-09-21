
using Models;

namespace Services
{
    public interface ICartService
    {
        List<Cart> ViewCart();
        string AddToCart(Cart c);
    }
}