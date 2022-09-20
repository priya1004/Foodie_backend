using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ItemContext:DbContext
    {
        public ItemContext() { }

        public ItemContext(DbContextOptions<ItemContext> builder) : base(builder) { }


        public DbSet<Item> Item { get; set; }


    }
}
