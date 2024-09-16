using Microsoft.AspNetCore.Mvc;

namespace Hello1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController1 : ControllerBase
    {
        // GET: api/helloworld
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World from controller 1");
        }
    }
}
