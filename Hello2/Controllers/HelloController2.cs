using Microsoft.AspNetCore.Mvc;

namespace Hello2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController2 : ControllerBase
    {
        // GET: api/helloworld
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World from controller 2");
        }
    }
}
