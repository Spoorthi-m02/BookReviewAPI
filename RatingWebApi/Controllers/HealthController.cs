using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RatingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CheckHealth()
        {
            return Ok("Good Health");
        }
    }
}
