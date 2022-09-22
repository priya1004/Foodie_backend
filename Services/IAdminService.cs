using Models;
using UserModel;

namespace Services
{
    public interface IAdminService
    {
        List<RestInfoRequest> GetRestaurantRequest();
        string Verified(string id,int value);
        List<User> UserDetails();
        List<Restaurant> GetMainRestaurants();
        //List<Feedback> GetFeedbacks();
        //string PostFeedBacks(Feedback value);
    }
}