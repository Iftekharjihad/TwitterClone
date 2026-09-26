
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwittersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public TwittersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        //public void GetTweet()
        //{
        //    var connectionString = _configuration.GetValue<string>("Logging:LogLevel:Default");
        //}
        [HttpGet]
        public IActionResult GetTweets()
        {
            var tweets = new List<Tweet>
            {
                new Tweet("My First Tweet")
                {
                    UserId = Guid.NewGuid(),
                    Content = "This is Content1",
                },
                new Tweet("My Second Tweet")
                {
                    UserId = Guid.NewGuid(),
                    Content = "This is Content2",
                },
            };
            return Ok(tweets);
        }
    }
}
