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
        [Key]
        public string email { get; set; }
        public string username{ get; set; }
        public string password{ get; set; } 
        
        public string usertype { get; set; }
        private string _token = " ";
        public string Token
        {
            get { return _token; }
            set { _token = value; }
        }
    }
}
