using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cart
    {
        [BsonId]
        public string _id { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int RestaurantId {get;set;}
        public string RestaurantName { get; set; }
        public int Price { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        

       
    }
}
