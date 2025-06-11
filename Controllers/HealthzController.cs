
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("/api/healthz")]
  [ApiController]
  public class HealthzController : ControllerBase
  {
    [HttpGet]
    public IActionResult HealthzHandler()
    {
      return Ok("ok");
    }
  }
}