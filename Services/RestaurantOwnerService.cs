using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RestaurantOwnerService : IRestaurantOwnerService
    {
        private readonly IRestaurantRepository rep;
        public RestaurantOwnerService(IRestaurantRepository r)
        {
            rep = r;
        }
        public string PostRequest(RestInfoRequest r)
        {
            return rep.PostRestaurantReq(r);
        }
        public string PostItem(Item i)
        {
            return rep.AddItem(i);
        }

        public List<Restaurant> GetRestaurant(string id)
        {
            return rep.GetRestaurant(id);
        }
        public List<Order> ViewOrderDetails(string restaurantid)
        {
            return rep.ViewOrderDetails(restaurantid);
        }
    }
}
