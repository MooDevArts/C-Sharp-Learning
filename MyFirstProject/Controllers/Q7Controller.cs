using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        /// Gives the displaced date depending on the number of days mentioned
        /// </summary>
        /// <param name="days">The number of days to add to the current date.</param>
        /// <returns>The future date as a string in the format yyyy-MM-dd.</returns>
        /// <example>
        /// Example request: /api/date/futureDate?days=1
        /// Response: 2024-09-18 (assuming today is 2024-09-17)
        /// </example>
        
        [HttpGet("timemachine")]

        public string GetDate(int days)
        {
            DateTime currentDate = DateTime.Now;
            DateTime futureDate = currentDate.AddDays(days);
            string date = futureDate.ToString("yyyy-MM-dd");
            return date;
        }
    }
}
