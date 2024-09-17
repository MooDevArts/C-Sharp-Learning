using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// Returns a greeting, with the name passed as a parameter attached.
        /// </summary>
        /// <param name = "name">The name of the person to greet.</param>
        /// <returns>A string message saying "Hello, {name}!".</returns>
        /// <example>
        /// Example request: GET /api/q2/greeting?name=Gary
        /// Response: "Hello, Gary!"
        /// 
        /// Example request: GET /api/q2/greeting
        /// Response: "Hello, Stranger!"
        /// </example>

        [HttpGet(template: "greeting")]
        public string GET(string name = "Stranger")
        {
            return $"Hello, {name}!";
        }
    }
}
