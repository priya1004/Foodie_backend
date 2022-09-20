using Microsoft.AspNetCore.Mvc;
using Models;
using Services;
using UserModel;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly Services.IUserService _services;
        public UserController(Services.IUserService ser) { _services = ser; }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public List<Item> GetItem(string id)
        {
            return _services.GetItem(id);
        }

        [HttpGet("RestaurantDetails/{id}")]

        public List<Restaurant> GetRestaurantDetails(int id)
        {
            return _services.GetRestaurantDetails(id);
        }


        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            _services.RegisterUser(value);

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
