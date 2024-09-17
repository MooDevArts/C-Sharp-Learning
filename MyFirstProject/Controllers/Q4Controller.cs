using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {
        /// <summary>
        /// Handles a POST request of /api/q4/knockknock ( headers and body are assumed to be empty)
        /// </summary>
        /// <returns>Returns "Who's there?"</returns>
        /// <example>
        /// Example request: POST /api/q3/knockknock
        /// Response: Who's there?
        /// </example>
        
        [HttpPost("knockknock")]
        public string Knock()
        {
            return "Who's there?";
        }
    }
}
