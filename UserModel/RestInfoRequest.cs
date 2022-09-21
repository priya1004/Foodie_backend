using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [BsonIgnoreExtraElements]
    public class RestInfoRequest
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
        public Boolean isVerified { get; set; }
        

    }
}
