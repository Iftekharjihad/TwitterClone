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
    }
}
