using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CommentsController : ControllerBase
    {
        // /api/comments
        [HttpGet]
        public IActionResult GetComments()
        {
            return Ok(new List<object>{
                new
                {
                    CommentId = Guid.NewGuid(),
                    Content = "This is a comment!",
                },
                new
                {
                    CommentId = Guid.NewGuid(),
                    Content = "This is another comment.",
                },
            });
        }
        // /api/comments
        [HttpPost]
        public IActionResult CreateComment()
        {
            var newComment = new
            {
                CommentId = Guid.NewGuid(),
                Content = "This is a new comment.",
            };
            return Ok(newComment);
        }
        // /api/comments/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateComment([FromRoute] Guid id)
        {
            var updatedComment = new
            {
                CommentId = id,
                Content = "This comment has been updated.",
            };
            return Ok(updatedComment);
        }
    }
}
