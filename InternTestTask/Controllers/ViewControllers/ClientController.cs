using Microsoft.AspNetCore.Mvc;

namespace InternTestTask.Controllers.ViewControllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        public ContentResult Index()
        {
            var html = System.IO.File.ReadAllText(@"index.html");
            return base.Content(html, "text/html");
        }
    }
}
