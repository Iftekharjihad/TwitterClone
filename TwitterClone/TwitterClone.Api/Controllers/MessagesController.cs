using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MessagesController : ControllerBase
    {
        // /api/messages
        [HttpGet]
        public IActionResult GetMessages()
        {
            return Ok(new List<object>{
                new
                {
                    MessageId = Guid.NewGuid(),
                    Content = "Hello, this is a message!",
                },
                new
                {
                    MessageId = Guid.NewGuid(),
                    Content = "This is another message.",
                },
            });
        }
    }
}
