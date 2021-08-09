using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MusicStore.Api.V1.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class StoreController : ControllerBase
    {
       private readonly ILogger<StoreController> _logger;

        public StoreController(ILogger<StoreController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Browse(string genre)
        {
            return Ok("Hello");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return Ok("Hello");
        }
    }
}
