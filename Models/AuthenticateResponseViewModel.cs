using AuthenticateJwt.Configuration;

namespace AuthenticateJwt.Models;

public partial class AuthenticateResponseViewModel
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public string? Token { get; set; }
    public string? DataExpiracao { get; set; }
}

public partial class AuthenticateResponseViewModel
{
    public static AuthenticateResponseViewModel ReturnInvalidKey()
    {
        return new AuthenticateResponseViewModel { Success = false, Message = "Chave inválida!" };
    }
    
    public static AuthenticateResponseViewModel ReturnSuccess()
    {
        var dataExpiracao = DateTime.Now.AddMinutes(20).ToString("dd/MM/yyyy HH:mm:ss");
        var token = SecurityConfig.Generate(Guid.NewGuid().ToString(), 20);
        
        return new AuthenticateResponseViewModel { Success = true, Token = token, DataExpiracao = dataExpiracao };
    }
}