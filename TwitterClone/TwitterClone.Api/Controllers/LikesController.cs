using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LikesController : ControllerBase
    {
        // /api/likes/{tweetId}
        [HttpPost("{tweetId}")]
        public IActionResult LikeTweet([FromRoute] Guid tweetId)
        {
            return Ok(new
            {
                LikeId = Guid.NewGuid(),
                TweetId = tweetId,
                UserId = Guid.NewGuid(),
            });
        }
    }
}
