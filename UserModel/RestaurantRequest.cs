using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RestaurantRequest
    {
        public Boolean isVerified { get; set; }
        public string RestaurantName { get; set; }
        public string Description { get; set; }
        public int RestaurantId { get; set; }
        public string Location { get; set; }
        public string RestaurantOwnerEmailID { get; set; }
        [Key]
        public int RestaurantRequestId { get; set; }
       

    }
}
