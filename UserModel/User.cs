using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModel
{
    public class User
    {
        public string Username{ get; set; }
        public string Password{ get; set; } 
        [Key]
        public string Email{ get; set; }    
    }
}
