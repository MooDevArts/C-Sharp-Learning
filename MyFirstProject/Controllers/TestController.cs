using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TestController : ControllerBase
    {
        [HttpGet(template:"test1")]
        public string Method1() => "Hello Humber";

        [HttpGet(template: "test2")]
        public string Method2()
        {
            return "Hello 5125 in Humber";
        }
    }
}
