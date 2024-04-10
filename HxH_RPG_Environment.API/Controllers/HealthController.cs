using HxH_RPG_Environment.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace HxH_RPG_Environment.API.Controllers;

[ApiController]
[Route("health")]
public class HealthController(HealthService healthService) : ControllerBase
{
    private readonly HealthService _healthService = healthService;

    [HttpGet]
    public string GetHealth()
    {
        return _healthService.GetHealth();
    }
}
