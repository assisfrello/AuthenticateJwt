using AuthenticateJwt.Models;
using AuthenticateJwt.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticateJwt.Controllers;

[Route("authenticate")]
[ApiController]
public class AuthenticateController : ControllerBase
{
    private readonly IAuthenticateService _service;

    public AuthenticateController(IAuthenticateService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<AuthenticateResponseViewModel> Post(AuthenticateRequestViewModel request) => 
        await _service.Authenticate(request);
}