using InternTestTask.Models;
using InternTestTask.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InternTestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_commentService.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_commentService.Get(id));
        }
        [HttpPost]
        public IActionResult Insert(Comment comment)
        {
            _commentService.Insert(comment);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Comment comment)
        {
            _commentService.Update(comment);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _commentService.Delete(id);
            return Ok();
        }
    }
}
