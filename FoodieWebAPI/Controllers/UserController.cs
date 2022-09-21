using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Models;
using Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserModel;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly Services.IUserService _services;
        private IConfiguration _config = null;
        public UserController(Services.IUserService ser, IConfiguration configuration) { _services = ser; _config = configuration; }
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

        public List<Restaurant> GetRestaurantDetails(string id)
        {
            return _services.GetRestaurantDetails(id);
        }


        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            _services.RegisterUser(value);

        }


        [HttpPost("Validate")]
        public string Validate(User u)
        {
            throw new Exception();
            if (_services.ValidateUser(u))

                return GenerateToken(u);
            return "User notfound";

        }

        private string GenerateToken(User u)
        {

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[] {
                    new Claim(JwtRegisteredClaimNames.Email, u.Email),
                    new Claim("Role", "User"),
                    new Claim("Email",u.Email),
        //new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Audience"],
             // null,
             claims,
             expires: DateTime.Now.AddMinutes(120),
             signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
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
