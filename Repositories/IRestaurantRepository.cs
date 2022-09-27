using Models;

namespace Repositories
{
    public interface IRestaurantRepository
    {
        string PostRestaurantReq(RestInfoRequest r);
        string AddItem(Item i);
        List<Restaurant> GetRestaurant(string id);
        List<Order> ViewOrderDetails(string restaurantid);
       
    }
}