using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantOwnerAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantOwnerController : ControllerBase
    {
        private readonly IRestaurantOwnerService res;

        public RestaurantOwnerController(IRestaurantOwnerService r)
        {
            res = r;
        }



        // GET: api/<RestaurantOwnerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        [HttpPost("PostRestaurantRequest")]
        public string PostRestaurantRequest([FromBody] RestaurantRequest val)
        {
            return res.PostRequest(val);

        }
        [HttpPost("PostItemRequest")]

        public string PostItemRequest([FromBody] Item val)
        {
            return res.PostItem(val);
        }

        // GET api/<RestaurantOwnerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RestaurantOwnerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RestaurantOwnerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
       

        // DELETE api/<RestaurantOwnerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
