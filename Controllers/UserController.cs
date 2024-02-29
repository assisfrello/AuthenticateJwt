using AuthenticateJwt.Models;
using AuthenticateJwt.Models.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticateJwt.Controllers;

[Route("user")]
[Authorize]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost("login")]
    [ProducesResponseType(typeof(UnauthorizedException), 401, "application/json")]
    public async Task<IAsyncResult> Login(LoginRequestViewModel request)
    {
        return new LoginResponseViewModel();
    }
}