using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using UserModel;
//using Models.FoodieContext;
namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FoodieContext _fc;
        public UserRepository(FoodieContext f)
        {
            _fc = f;
        }
        public bool AddUser(User u)
        {
            if (u != null)
            {
                _fc.Users.Add(u);
                _fc.SaveChanges();
                return true;
            }
            return false;

            
        }


        public List<Item> GetItem(string id)
        {
            List<Item> items = _fc.Item.ToList();
            List<Item> ritems=new List<Item>();

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].RestaurantId == id)
                {
                    ritems.Add(items[i]);
                }
            }
            return ritems;
        }


        public List<Restaurant> GetRestaurantDetails(string id)
        {
            List<Restaurant>rest_list=_fc.MainRestaurantList.ToList();
            List<Restaurant>new_rest_list=new List<Restaurant>();
            
            for(int i=0;i<rest_list.Count;i++)
            {
                if(rest_list[i].restaurantid == id)
                {
                    new_rest_list.Add(rest_list[i]);    
                }
            }
            return new_rest_list;
        }
        public bool ValidateUser(User u)
        {
            var result = _fc.Users.Where(p => p.Password == u.Password && p.Email == u.Email).FirstOrDefault();
            if (result == null)
                return false;
            return true;
        }


        //public bool ValidateUser(User u)
        //{
        //    if ((_userService.ValidateUser))
        //}


    }
}
