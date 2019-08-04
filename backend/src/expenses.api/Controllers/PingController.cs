using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace expenses.api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Test()
        {
            return Ok("Super secret content, I hope you've got clearance for this...");
        }
    }
}