using Models;

namespace Services
{
    public interface IRestaurantOwnerService
    {
        string PostRequest(RestInfoRequest r);
        string PostItem(Item i);
        List<Restaurant> GetRestaurant(string id);
        List<Order> ViewOrderDetails(string restaurantid);
    }
}