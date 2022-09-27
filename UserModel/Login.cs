    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Login
    {
        [Key]
        public string email { get; set; }
        public string password { get; set; }
        public string usertype { get; set; }
        



    }
}
