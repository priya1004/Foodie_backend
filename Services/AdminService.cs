using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModel;

namespace Services
{
    public class AdminService : IAdminService
    {
        IAdminRepo adminRepo;
        public AdminService(IAdminRepo ar)
        {
            this.adminRepo = ar;
        }
        public List<RestInfoRequest> GetRestaurantRequest()
        {
            return adminRepo.GetRestaurantRequest();
        }
        public List<Restaurant> GetMainRestaurants()
        {
            return adminRepo.GetMainRestaurants();

        }
        public string Verified(string id, int value)
        {
            return adminRepo.Verified(id, value);
        }
        public List<User> UserDetails()
        {
            return adminRepo.UserDetails();
        }

        //public List<Feedback> GetFeedbacks()
        //{
        //    return adminRepo.GetFeedbacks();
        //}
        //public string PostFeedBacks(Feedback feedback)
        //{
        //    return adminRepo.PostFeedBacks(feedback);
        //}
    }
}
