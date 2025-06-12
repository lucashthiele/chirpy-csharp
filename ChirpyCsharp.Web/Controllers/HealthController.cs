
using Microsoft.AspNetCore.Mvc;

namespace ChirpyCsharp.Web.Controllers
{
  [Route("/api/[controller]")]
  [ApiController]
  public class HealthController : Controller
  {
    [HttpGet]
    public IActionResult HealthHandler()
    {
      return Ok("ok");
    }
  }
}