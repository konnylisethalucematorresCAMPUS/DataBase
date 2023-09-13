
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Aplicacion.Contratos;
using Dominio;
using Microsoft.IdentityModel.Tokens;

namespace Seguridad.TokenSeguridad;

public class JwtGenerador : IJwtGenerador
{
    public string CrearToken(Usuario usuario)
    {
        var claims = new List<Claim>{
            new Claim(JwtRegisteredClaimNames.NameId, usuario.Username!)
        };
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("6bz%;MVYYM`6tk2/X3jjC}%CRT#QUUt^Qv$OI<=M?3)wWX+T%-9B'xrt(url%s]Yg@Y9LTsCr}g|e@:>{iSCte}Uwye`"));
        var credenciales = new SigningCredentials(key,SecurityAlgorithms.HmacSha512Signature);
        var tokenDescripcion = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddDays(20),
            SigningCredentials = credenciales
        };
        var tokenManejador = new JwtSecurityTokenHandler();
        var token = tokenManejador.CreateToken(tokenDescripcion);
        return tokenManejador.WriteToken(token);

    }
}