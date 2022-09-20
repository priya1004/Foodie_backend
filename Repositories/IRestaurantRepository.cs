using Models;

namespace Repositories
{
    public interface IRestaurantRepository
    {
        string PostRestaurantReq(RestaurantRequest r);
        string AddItem(Item i);
    }
}