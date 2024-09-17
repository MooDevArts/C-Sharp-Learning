using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1Controller : ControllerBase
    {
        [HttpGet(template: "welcome")]
        public string Method2()
        {
            return "Welcome to 5125!";
        }
    }
}
