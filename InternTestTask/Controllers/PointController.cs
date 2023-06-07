using InternTestTask.Models;
using InternTestTask.Services;
using InternTestTask.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InternTestTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PointController : ControllerBase
    {
        private readonly IPointService _service;
        public PointController(IPointService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Point> GetAll() 
        {
            return _service.GetAll();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        { 
            return Ok(_service.Get(id));
        }
        [HttpPost]
        public IActionResult Insert(Point point)
        {
            _service.Insert(point);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Point point)
        {
            _service.Update(point);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
