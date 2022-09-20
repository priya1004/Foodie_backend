using Models;

namespace Services
{
    public interface IAdminService
    {
        //List<RestaurantRequest> GetRestaurantRequest();
        //string Verified(int id,int value);
        List<Restaurant> GetMainRestaurants();
        //List<Feedback> GetFeedbacks();
        //string PostFeedBacks(Feedback value);
    }
}