using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [BsonIgnoreExtraElements]
    public class Cart
    {
        
       public int itemid { get; set; }
        public string name { get; set; }    
        public int price { get; set; }
        public int quantity { get; set; }

       
        public string restaurantid { get; set; }

       
    }
}
