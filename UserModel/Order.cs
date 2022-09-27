using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [BsonIgnoreExtraElements]
    public class Order
    {

        public List<Cart> cart { get; set; }
        public Customer customer { get; set; }
        public string orderid { get; set; }
        public string status { get; set; }
        public string restaurantid { get; set; }
        public string restaurantname { get; set; }



    }
}

