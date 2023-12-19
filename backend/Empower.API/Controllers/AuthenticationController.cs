using Empower.API.RequestModels;
using Empower.Domain.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace Empower.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthenticationController : ControllerBase
{
    [HttpPost("/login")]
    public async Task<IActionResult> LoginAsync([FromBody] LoginInputModel model)
    {
        return Ok(await Task.FromResult(model));
    }
    [HttpPost("/registry")]
    public async Task<IActionResult> RegistryUserAsync([FromBody] RegistryUserRequestModel model)
    {
        return Ok(await Task.FromResult(model));
    }
}
