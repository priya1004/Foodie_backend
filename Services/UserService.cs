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
    public class UserService : IUserService
    {
        IUserRepository r;
        public UserService(IUserRepository v)
        {

            r = v;
        }
        public bool RegisterUser(User u)
        {
            r.AddUser(u);
            return true;
        }

        public List<Item> GetItem(string id)
        {
            return r.GetItem(id);
        }
        public List<Restaurant> GetRestaurantDetails(string id)
        {
            return r.GetRestaurantDetails(id);
        }

        public string PlaceOrder(Order o)
        {
            return r.PlaceOrder(o);
        }
        //public bool ValidateUser(User u)
        //{
        //    return r.ValidateUser(u);
        //}

    }
}
