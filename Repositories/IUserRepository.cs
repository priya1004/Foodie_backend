using Models;
using UserModel;

namespace Repositories
{
    public interface IUserRepository
    {
        bool AddUser(User u);
        List<Item> GetItem(string id);
        List<Restaurant> GetRestaurantDetails(string id);
        string PlaceOrder(Order o);
        //bool ValidateUser(User u);
    }
}