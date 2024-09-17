using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1Controller : ControllerBase
    {

        /// <summary>
        /// Returns a simple welcome message.
        /// </summary>
        /// <returns>A string message saying "Welcome to 5125!".</returns>
        /// <example>
        /// Example request: GET /api/q1/welcome
        /// Response: "Welcome to 5125!"
        /// </example>

        [HttpGet(template: "welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }
    }
}
