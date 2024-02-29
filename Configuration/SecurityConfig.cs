﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace AuthenticateJwt.Configuration;

public class SecurityConfig
{
    public static string Secret = "ChaveSecretaParaGerarBearerTokenHeHeHeHe";

    public static bool ValidarChave(string chave) => chave == Secret;
    
    public static string Generate(string guid, int tempoExpiracao)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(Secret);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Sid, guid),
            }),
            Expires = DateTime.UtcNow.AddMinutes(tempoExpiracao),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}

