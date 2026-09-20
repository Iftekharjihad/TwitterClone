using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<User>
            {
                new User(
                    Guid.NewGuid(),
                    "john.doe@example.com",
                    "John",
                    "Doe",
                    DateTime.UtcNow,
                    Guid.NewGuid()
                ),
                new User(
                    Guid.NewGuid(),
                    "janesmith@gmail.com",
                    "Jane",
                    "Smith",
                    DateTime.UtcNow,
                    Guid.NewGuid()
                ),
                new User(
                    Guid.NewGuid(),
                    "iftekhar@gmail.com",
                    "Iftekhar",
                    "Jihad",
                    DateTime.UtcNow,
                    Guid.NewGuid()
                ),
            };
            return Ok(users);
        }
    }
}
