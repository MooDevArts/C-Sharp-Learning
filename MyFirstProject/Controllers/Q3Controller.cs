using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3Controller : ControllerBase
    {
        /// <summary>
        /// Calculates the cube of a given number. Provides the positive version if provided number is negative ( since example in question displayed this through examples )
        /// </summary>
        /// <param name="number">The number to be cubed. (did not use "base" as IDE showed errod - it seems to be a reserved keyword) </param>
        /// <returns>The positive cube of the provided number.</returns>
        /// <example>
        /// Example request: GET /api/q3/cube/3
        /// Response: 27
        ///
        /// Example request with negative number: GET /api/q3/cube/-3
        /// Response: 27
        /// 
        /// Example request: GET /api/q3/cube/10
        /// Response: 1000
        /// </example>

        [HttpGet("cube/{number}")]
        public int GetCube(int number)
        {
            if (number < 0)
            {
                number = number * -1;
            }
            return number*number*number;
        }
    }
}
