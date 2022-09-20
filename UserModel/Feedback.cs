using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Feedback
    {
        [Key]
       public int FeedbackId { get; set; }
        public string UserId { get; set; }
        public string TypeOfUser { get; set; }
        public string Description { get; set; }

       

    }
}
