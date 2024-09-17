using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q8Controller : ControllerBase
    {

        /// <summary>
        /// Gives the total bill given the number of smalls and larges ordered
        /// </summary>
        /// <param name="order">An object containing the quantities of small and large items.</param>
        /// <returns>A string summarizing the cost breakdown including item costs, tax, and total amount.</returns>
        /// <example>
        /// Example request body:
        /// {
        ///     "Small": 3,
        ///     "Large": 5
        /// }
        /// Response: "3 Small @ $25.5 = $76.5; 5 Large @ $40.5 = $202.5; Tax = $36.27 HST; Total = $315.27"
        /// </example>

        [HttpPost("squashfellows")]
        public string GetTotal([FromBody] Items order)
        {
            double smallCost = 25.5 * order.Small;
            double largeCost = 40.5 * order.Large;
            double tax = (smallCost + largeCost) * 0.13;
            double total = smallCost + largeCost + tax;
            return $"{order.Small} Small @ $25.5 = ${smallCost}; {order.Large} Large @ $40.5 = ${largeCost}; Tax = ${tax} HST; Total = ${total}";
        }
    }

    public class Items
    {
        public double Small { get; set; }
        public double Large { get; set; }
    }
}
