using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [BsonIgnoreExtraElements]
    public class Restaurant
    {
        public string restaurantid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string cuisines { get; set; }
        public string rating { get; set; }
        public string reviews { get; set; }
        public string feature_image { get; set; }

        public string thumbnail_image { get; set; }
        public List<Menu> menu { get; set; }

        public Restaurant()
        {

        }
     

        public Restaurant(string restaurantid,string name, string address,string cuisines,string rating,string reviews,string feature_image, string thumbnail_image,List<Menu> menu )
        {
            this.restaurantid = restaurantid;
            this.name = name;
            this.address = address;
            this.cuisines = cuisines;
            this.rating = rating;
                
            this.reviews = reviews;
            this.feature_image = feature_image;
            this.thumbnail_image = thumbnail_image;
            this.menu = menu;

        }
      
        
    }
}