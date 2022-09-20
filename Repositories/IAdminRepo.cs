using Models;

namespace Repositories
{
    public interface IAdminRepo
    {
        //List<RestaurantRequest> GetRestaurantRequest();
        //string Verified(int id,int value);
        List<Restaurant> GetMainRestaurants();
        //List<Feedback> GetFeedbacks();
        //string PostFeedBacks(Feedback feedback);
    }
}