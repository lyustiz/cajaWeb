using Caja.API.DTO;
using Caja.Core.Entidades;
using System.IdentityModel.Tokens.Jwt;

namespace Caja.API.Auth
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(UsuarioDTO usuarioDTO);
        JwtSecurityToken DecodeToken(string stream);
        ResponseDTO ObtenerToken(string headers);
    }
}
