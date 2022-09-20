using Models;

namespace Services
{
    public interface IRestaurantOwnerService
    {
        string PostRequest(RestaurantRequest r);
        string PostItem(Item i);
    }
}