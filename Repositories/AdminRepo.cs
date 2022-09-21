using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using MongoDB.Driver;

namespace Repositories
{
    public class AdminRepo : IAdminRepo
    {

      
        IMongoClient mongoClient;
        IMongoDatabase database;
        private readonly AdminContext adminContext;
        public AdminRepo(AdminContext adminContext) {
            this.adminContext = adminContext;
            mongoClient = new MongoClient("mongodb://127.0.0.1:27017"); //url of the server
            database = mongoClient.GetDatabase("Foodie"); //db name
        }
        public List<RestaurantRequest> GetRestaurantRequest()
        {

            List<RestaurantRequest> rr = adminContext.RestaurantRequest.ToList<RestaurantRequest>();
            return rr;

        }

        IMongoCollection<Restaurant> Restaurants => database.GetCollection<Restaurant>("RestInfo");
        IMongoCollection<RestInfoRequest> RestInfoRequests => database.GetCollection<RestInfoRequest>("RestInfoRequest");
       
        public List<Restaurant> GetMainRestaurants()
        {

            return Restaurants.Find((p) => true).ToList();

        }
        //public List<Feedback> GetFeedbacks()
        //{

        //    List<Feedback>f = adminContext.Feedback.ToList<Feedback>();

        //    return f;


        //}
        public string Verified(string id, int value)
        {
            List<RestInfoRequest> rr =  RestInfoRequests.Find((p) => true).ToList();
            RestInfoRequest restaurantRequest = null;
            for (int i = 0; i < rr.Count; i++)
            {
                if (rr[i].restaurantid == id)
                    restaurantRequest = rr[i];
            }
            if (restaurantRequest == null)
                return "update rejected";
            if (value == 1)
            {
                restaurantRequest.isVerified = true;
                var update = Builders<RestInfoRequest>.Update.Set(r=>r.isVerified, true);

                RestInfoRequests.UpdateOne((p)=>p.restaurantid== id,update);
                //RestInfoRequest temp = (RestInfoRequest)RestInfoRequests.Find((p) => p.restaurantid == id);
                Restaurants.InsertOne(new Restaurant(restaurantRequest.restaurantid,restaurantRequest.name,restaurantRequest.address,restaurantRequest.cuisines,restaurantRequest.rating,restaurantRequest.reviews,restaurantRequest.feature_image,restaurantRequest.thumbnail_image,restaurantRequest.menu));

                //rr.Add(new Restaurant(restaurantRequest.RestaurantName, restaurantRequest.Location, 0, restaurantRequest.RestaurantOwnerEmailID));


            }
            //else
            //{
            //    var update = Builders<RestInfoRequest>.Update.Set("isVerified", false);
            //    RestInfoRequests.UpdateOne((p) => p.restaurantid == id, update);
               
    
            //    adminContext.MainRestaurantList.Remove(new Restaurant(restaurantRequest.RestaurantName, restaurantRequest.RestaurantId, restaurantRequest.Location, 0, restaurantRequest.RestaurantOwnerEmailID));


            //}
           // adminContext.SaveChangesAsync();

            return "updated3";
        }

        //public string PostFeedBacks(Feedback fb)
        //{
        //    adminContext.Feedback.Add(fb);
        //    adminContext.SaveChanges();
        //    return "posted";

        //}

        /*public List<Feedback> PostFeedBacks()
        {
            throw new NotImplementedException();
        }*/
    }
}
