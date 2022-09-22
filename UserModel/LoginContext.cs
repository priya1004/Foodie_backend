using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModel;

namespace Models
{
    public class LoginContext:DbContext
    {

        public LoginContext()
        {

        }
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {
        }

        
        public DbSet<Login> LoginTable { get; set; }
        public DbSet<User> Users { get; set; }
        

    }
}
