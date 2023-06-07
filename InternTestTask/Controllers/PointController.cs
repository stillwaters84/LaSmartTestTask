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
        private readonly IPointService _serivce;
        public PointController(IPointService service)
        {
            _serivce = service;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_serivce.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        { 
            return Ok(_serivce.Get(id));
        }
        [HttpPost]
        public IActionResult Insert(Point point)
        {
            _serivce.Insert(point);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(Point point)
        {
            _serivce.Update(point);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _serivce.Delete(id);
            return Ok();
        }
    }
}
