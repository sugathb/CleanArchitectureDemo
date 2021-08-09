using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MusicStore.Api.V1.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MusicController : ControllerBase
    {
       private readonly ILogger<MusicController> _logger;

        public MusicController(ILogger<MusicController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello");
        }
    }
}
