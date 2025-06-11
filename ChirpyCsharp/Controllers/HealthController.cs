
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("/api/health")]
  [ApiController]
  public class HealthController : ControllerBase
  {
    [HttpGet]
    public IActionResult HealthzHandler()
    {
      return Ok("ok");
    }
  }
}