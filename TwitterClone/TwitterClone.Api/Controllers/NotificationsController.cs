using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NotificationsController : ControllerBase
    {
        // /api/notifications
        [HttpGet]
        public IActionResult GetNotifications()
        {
            return Ok(new List<object>{
                new
                {
                    NotificationId = Guid.NewGuid(),
                    Message = "You have a new follower!",
                },
                new
                {
                    NotificationId = Guid.NewGuid(),
                    Message = "Your tweet has been liked!",
                },
            });
        }
    }
}
