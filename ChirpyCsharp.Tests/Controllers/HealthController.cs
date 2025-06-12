using ChirpyCsharp.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ChirpyCsharp.Tests.Controllers;

public class HealthControllerTest
{
    [Fact]
    public void ShouldReturnOk()
    {
        var healthController = new HealthController();
        var response = healthController.HealthHandler();

        var result = Assert.IsType<OkObjectResult>(response);
        Assert.Equal(200, result.StatusCode);
        Assert.Equal("ok", result.Value);
    }
}