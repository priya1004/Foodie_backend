using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [BsonIgnoreExtraElements]
    public class Restaurant
    {
        public Restaurant()
        {

        }
        //public Restaurant(string restaurantName, string location, int v, string restaurantOwnerEmailID)
        //{
        //    RestaurantName = restaurantName;

        //    Location = location;
        //    rating = v;
        //    RestaurantOwnerEmailID = restaurantOwnerEmailID;
        //}
        //public Restaurant(string restaurantName,int restaurantId ,string location, int v, string restaurantOwnerEmailID)
        //{
        //    RestaurantName = restaurantName;
        //    RestaurantId = restaurantId;
        //    Location = location;
        //    rating = v;
        //    RestaurantOwnerEmailID = restaurantOwnerEmailID;
        //}


      
        public int restaurantid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string cuisines {get; set; }
        public string rating { get; set; }
        public string reviews { get; set; }
        public string feature_image { get; set; }

        public string thumbnail_image { get; set; }
        public List<Menu> menu{get;set;}
       
    }
}