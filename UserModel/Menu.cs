using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
      [BsonIgnoreExtraElements]
    public class Menu
    {
     
        public  int dishid { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public double price { get; set; }   
        
    }
}
