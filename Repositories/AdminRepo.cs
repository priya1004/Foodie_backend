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
        public AdminRepo() {
            mongoClient = new MongoClient("mongodb://127.0.0.1:27017"); //url of the server
            database = mongoClient.GetDatabase("Foodie"); //db name
        }
        //public List<RestaurantRequest> GetRestaurantRequest()
        //{

        //        List<RestaurantRequest> rr = adminContext.RestaurantRequest.ToList<RestaurantRequest>();
        //        return rr;

        //}

        IMongoCollection<Restaurant> Restaurants => database.GetCollection<Restaurant>("RestInfo");
        public List<Restaurant> GetMainRestaurants()
        {

            return Restaurants.Find((p) => true).ToList();

        }
        //public List<Feedback> GetFeedbacks()
        //{

        //    List<Feedback>f = adminContext.Feedback.ToList<Feedback>();

        //    return f;


        //}
        //public string Verified(int id,int value)
        //{
        //    List<RestaurantRequest> rr = adminContext.RestaurantRequest.ToList<RestaurantRequest>();
        //    RestaurantRequest restaurantRequest=null;
        //    for (int i = 0; i < rr.Count; i++)
        //    {
        //        if (rr[i].RestaurantRequestId == id)
        //           restaurantRequest = rr[i];
        //    }
        //    if (restaurantRequest == null)
        //        return "update rejected";
        //    if (value == 1)
        //    {
        //        restaurantRequest.isVerified = true;
        //        adminContext.RestaurantRequest.Update(restaurantRequest);
               
        //        adminContext.MainRestaurantList.Add(new Restaurant(restaurantRequest.RestaurantName,restaurantRequest.Location,0, restaurantRequest.RestaurantOwnerEmailID));
              
         
        //    }
        //    else
        //    {
        //        restaurantRequest.isVerified = false;
        //        adminContext.RestaurantRequest.Update(restaurantRequest);
        //         adminContext.MainRestaurantList.Remove(new Restaurant(restaurantRequest.RestaurantName,restaurantRequest.RestaurantId,  restaurantRequest.Location, 0, restaurantRequest.RestaurantOwnerEmailID));
     

        //    }
        //   adminContext.SaveChangesAsync();

        //    return "updated3";
        //}

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
