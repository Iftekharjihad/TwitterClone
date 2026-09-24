using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookmarksController : ControllerBase
    {
        // /api/bookmarks
        [HttpPost]
        public IActionResult CreateBookmark()
        {
            return Ok(new
            {
                BookmarkId = Guid.NewGuid(),
                TweetId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
            });
        }
    }
}
