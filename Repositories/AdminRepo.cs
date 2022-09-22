using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using MongoDB.Driver;
using UserModel;

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

        IMongoCollection<Restaurant> Restaurants => database.GetCollection<Restaurant>("RestInfo");
        IMongoCollection<RestInfoRequest> RestInfoRequests => database.GetCollection<RestInfoRequest>("RestInfoRequest");
        public List<RestInfoRequest> GetRestaurantRequest()
        {

            return RestInfoRequests.Find((p) => true).ToList();

        }
        public List<User> UserDetails()
        {

            return adminContext.Users.ToList();

        }




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
            string msg = "";
            for (int i = 0; i < rr.Count; i++)
            {
                if (rr[i].restaurantid == id)
                    restaurantRequest = rr[i];
            }
            if (restaurantRequest == null)
                msg="No restaurant Request with the given id";
            if (value == 1)
            {
                restaurantRequest.isVerified = true;
                var update = Builders<RestInfoRequest>.Update.Set(r=>r.isVerified, true);

                RestInfoRequests.UpdateOne((p)=>p.restaurantid== id,update);
                //RestInfoRequest temp = (RestInfoRequest)RestInfoRequests.Find((p) => p.restaurantid == id);
                Restaurants.InsertOne(new Restaurant(restaurantRequest.restaurantid,restaurantRequest.name,restaurantRequest.address,restaurantRequest.cuisines,restaurantRequest.rating,restaurantRequest.reviews,restaurantRequest.feature_image,restaurantRequest.thumbnail_image,restaurantRequest.menu));

                //rr.Add(new Restaurant(restaurantRequest.RestaurantName, restaurantRequest.Location, 0, restaurantRequest.RestaurantOwnerEmailID));
                msg="Restaurant is verified";


            }
            if(value==0)
            {
                restaurantRequest.isVerified = false;
                var update = Builders<RestInfoRequest>.Update.Set(r => r.isVerified, false);

                RestInfoRequests.UpdateOne((p) => p.restaurantid == id, update);
                Restaurants.DeleteOne((p) => p.restaurantid == id);

               msg= " Restaurant is Rejected";
            }

            return msg;

            
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
