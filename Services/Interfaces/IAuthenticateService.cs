using AuthenticateJwt.Models;

namespace AuthenticateJwt.Services.Interfaces;

public interface IAuthenticateService
{
    Task<AuthenticateResponseViewModel> Authenticate(AuthenticateRequestViewModel request);
}