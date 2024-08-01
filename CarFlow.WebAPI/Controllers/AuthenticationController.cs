using CarFlow.DomainServices.Interfaces;
using CarFlow.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarFlow.WebAPI.Controllers;

[Route("[controller]")]
[ApiController]
public class AuthenticationController(IAccountService accountService) : ControllerBase
{
    [HttpPost("token")]
    public async Task<IActionResult> Login([FromBody] AccountContract model)
    {
        var token = await accountService.AuthenticateTokenAsync(model.Email, model.Password);

        if (token is null)
        {
            return Unauthorized();
        }

        return Ok(new { token });
    }
}