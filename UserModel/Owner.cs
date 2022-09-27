using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    [BsonIgnoreExtraElements]
    public class Owner
    {
        public Owner(string restaurant_owner_email, Restaurant r)
        {
            email = restaurant_owner_email;
            restaurant = r;
        }

        public  string email { get; set; }
        public Restaurant restaurant { get; set; }
     
    }
}
