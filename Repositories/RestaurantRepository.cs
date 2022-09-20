using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly RestaurantContext _rc;
        
        //private readonly ItemContext _ic=new ItemContext();
        public RestaurantRepository(RestaurantContext r)
        {
            _rc = r;
        }
     
        public string PostRestaurantReq(RestaurantRequest r)
        {
            if (r != null)
            {
                _rc.RestaurantRequest.Add(r);
                _rc.SaveChanges();
                return "updated";
            }
            else
            {
                return "No value";
            }
        }
        public string AddItem(Item it)
        {
           if(it != null)
            {
                _rc.Item.Add(it);
                _rc.SaveChanges();
                return "Item Added";
                
            }
            else
            {
               return "No Value";
            }
        }


    }
}
