using Models;
using UserModel;

namespace Services
{
    public interface IUserService
    {
        bool RegisterUser(User u);
        List<Item> GetItem(string id);
        List<Restaurant> GetRestaurantDetails(string id);
        //bool ValidateUser(User u);
    }
}