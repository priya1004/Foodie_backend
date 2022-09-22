using Models;
using UserModel;

namespace Repositories
{
    public interface IAdminRepo
    {
        List<RestInfoRequest> GetRestaurantRequest();
        string Verified(string id,int value);
        List<Restaurant> GetMainRestaurants();
        List<User> UserDetails();
        //List<Feedback> GetFeedbacks();
        //string PostFeedBacks(Feedback feedback);
    }
}