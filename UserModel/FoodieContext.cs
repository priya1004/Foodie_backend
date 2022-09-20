using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModel;


namespace Models
{
    public class FoodieContext : DbContext
    {

        public FoodieContext() { }
        public FoodieContext(DbContextOptions<FoodieContext> builder) : base(builder) { }
        

        public DbSet<User> Users {get;set;}
        public DbSet<Item> Item {get;set;}

        public DbSet<Restaurant> MainRestaurantList { get; set; }



    }
}
