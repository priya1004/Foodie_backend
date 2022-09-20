using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RestaurantContext:DbContext
    {

        public RestaurantContext() { }
        public RestaurantContext(DbContextOptions<RestaurantContext> builder) : base(builder) { }


        public DbSet<RestaurantRequest> RestaurantRequest{ get; set; }
        public DbSet<Item> Item { get; set; }
    }
}
