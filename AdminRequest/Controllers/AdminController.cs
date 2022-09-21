using Microsoft.AspNetCore.Mvc;

using Services;
using Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdminRequest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        // GET: api/<AdminController>
        IAdminService adminService;
        public AdminController(IAdminService adminService)
        {
            this.adminService = adminService;
        }
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        [HttpGet("RestaurantRequest")]

        public List<RestaurantRequest> GetRestaurantRequest()
        {
            return adminService.GetRestaurantRequest();
        }
        [HttpGet("MainRestaurants")]

        public List<Restaurant> GetMainRestaurants()
        {
            return adminService.GetMainRestaurants();
        }
        //[HttpGet("Feedback")]

        ////public List<Feedback> GetFeedbacks()
        ////{
        ////   // return adminService.GetFeedbacks();
        ////}

        //[HttpPost("PostFeedback")]
        //public void Post([FromBody] Feedback value)
        //{
        //    adminService.PostFeedBacks(value);

        //}

        //// GET api/<AdminController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<AdminController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/<AdminController>/5
        [HttpPut("verified/{id}/{value}")]
        public string Put(string id, int value)
        {

            return adminService.Verified(id, value);
        }

        //// DELETE api/<AdminController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
