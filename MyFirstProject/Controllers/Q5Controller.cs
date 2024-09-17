using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5Controller : ControllerBase
    {
        /// <summary>
        /// Handles a POST request to /api/q5/secret with a body containing a number.
        /// </summary>
        /// <param name="number">The number provided in the request body.</param>
        /// <returns>A string revealing the secret with the provided number.</returns>
        /// <example>
        /// Example request: curl -X POST "http://localhost:xx/api/q5/secret" -H "Content-Type: application/json" -d "5"
        /// Response: "Shh.. the secret is 5"
        /// ( the number 5 is passed through the body of the reqest.. this is read and displayed in the response )
        /// </example>

        [HttpPost("secret")]
        public string Secret([FromBody] int number)
        {
            return $"Shh.. the secret is {number}";
        }
    }
}
