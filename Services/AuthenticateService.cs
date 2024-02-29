using AuthenticateJwt.Configuration;
using AuthenticateJwt.Models;
using AuthenticateJwt.Services.Interfaces;

namespace AuthenticateJwt.Services;

public class AuthenticateService : IAuthenticateService
{
    public async Task<AuthenticateResponseViewModel> Authenticate(AuthenticateRequestViewModel request)
    {
        var chaveValida = SecurityConfig.ValidarChave(request.Chave!);
        
        return chaveValida 
            ? AuthenticateResponseViewModel.ReturnSuccess() 
            : AuthenticateResponseViewModel.ReturnInvalidKey();
    }
}