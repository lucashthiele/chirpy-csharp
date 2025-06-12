using Microsoft.AspNetCore.Mvc;

namespace ChirpyCsharp.Web.Controllers
{
    [Route("/api/health")]
    [ApiController]
    public class HealthController : Controller
    {
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public IActionResult HealthHandler()
        {
            return Ok("ok");
        }

        private static string ToLog()
        {
            var now = DateTime.UtcNow;
            return $"HealthController - {now.ToLongTimeString()} - {now.ToLongDateString()}";
        }
    }
}