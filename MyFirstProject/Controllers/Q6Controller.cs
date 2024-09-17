using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6Controller : ControllerBase
    {
        /// <summary>
        /// Handles a GET request with a parameter of a side of a Hexagon and returns its area
        /// </summary>
        /// <param name="side">Side of the hypothetical hexagon</param>
        /// <returns>Area of the hypothetical hexagon</returns>
        /// <example>
        /// Example request: /api/q6/hexagon/20
        /// Response: 1039.2304845413264
        /// </example>

        [HttpGet("hexagon/{side}")]
        public double CalcAreaofHexagon(double side)
        {
            double sqrt3 = Math.Sqrt(3);
            double area = (3 * sqrt3 / 2) * side * side;
            return area;
        }  
    }
}
