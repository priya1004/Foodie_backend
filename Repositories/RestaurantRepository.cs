using Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly RestaurantContext _rc;
        IMongoClient mongoClient;
        IMongoDatabase database;
        //private readonly ItemContext _ic=new ItemContext();
        public RestaurantRepository(RestaurantContext r)
        {
            _rc = r;
            mongoClient = new MongoClient("mongodb://127.0.0.1:27017"); //url of the server
            database = mongoClient.GetDatabase("Foodie"); //db name
        }
        IMongoCollection<Owner> Owner =>database.GetCollection<Owner>("Owner");
        IMongoCollection<RestInfoRequest> requests => database.GetCollection<RestInfoRequest>("RestInfoRequest");
        IMongoCollection<Order> orders => database.GetCollection<Order>("OrderTable");
        public string PostRestaurantReq(RestaurantRequest r)
        {
            if (r != null)
            {
                _rc.RestaurantRequest.Add(r);
                _rc.SaveChanges();
                return "updated";
            }
            else
            {
                return "No value";
            }
        }
        public string AddItem(Item it)
        {
           if(it != null)
            {
                _rc.Item.Add(it);
                _rc.SaveChanges();
                return "Item Added";
                
            }
            else
            {
               return "No Value";
            }
        }

        public List<Restaurant> GetRestaurant(string id)
        {
           Owner a= (Owner)Owner.Find((p) => p.email==id).FirstOrDefault();
            List<Restaurant> rl=new List<Restaurant>();
            if (a!=null) {
                rl.Add(a.restaurant);
                    }
            return rl;



        }

        public string PostRestaurantReq(RestInfoRequest r)
        {
            requests.InsertOne(r);
            return "Inserted";
        }
        public List<Order> ViewOrderDetails(string restaurantid)
        {
            List<Order> ord = orders.Find((p) => true).ToList();
            List<Order> ord_new = new List<Order>();
            for (int i = 0; i < ord.Count; i++)
            {
                if (restaurantid == ord[i].restaurantid)
                {
                    ord_new.Add(ord[i]);

                }
            }
            return ord_new;



        }
    }
}
