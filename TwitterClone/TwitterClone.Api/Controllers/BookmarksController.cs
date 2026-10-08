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
        [HttpGet]
        public IActionResult GetBookmarks()
        {
            return Ok(new
            {
                Bookmarks = new[]
                {
                    new { BookmarkId = Guid.NewGuid(), TweetId = Guid.NewGuid(), UserId = Guid.NewGuid() },
                    new { BookmarkId = Guid.NewGuid(), TweetId = Guid.NewGuid(), UserId = Guid.NewGuid() },
                }
            });
        }
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
        // /api/bookmarks/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateBookmark([FromRoute] Guid id)
        {
            return Ok(new
            {
                BookmarkId = id,
                TweetId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
            });
        }
        // /api/bookmarks/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteBookmark([FromRoute] Guid id)
        {
            return Ok(new
            {
                BookmarkId = id,
                IsDeleted = true
            });
        }
    }
}
