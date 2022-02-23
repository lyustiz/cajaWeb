using Caja.API.DTO;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace Caja.API.Auth
{
    public class JwtAuthenticationService : IJwtAuthenticationService
    {
        private readonly string _key;

        public JwtAuthenticationService(string key)
        {
            _key = key;
        }

        public string Authenticate(UsuarioDTO usuarioDTO)
        {
            return CodeToken(usuarioDTO);
        }

        public string CodeToken(UsuarioDTO usuarioDTO)
        {
            TokenDTO tokenDTO = new TokenDTO();
            var tokenHandler = new JwtSecurityTokenHandler();
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key));
            var authClaims = new List<Claim>
                    {
                    new Claim("idUsuario",usuarioDTO.IdUsuario.ToString()),
                    new Claim("tipoUsuario",usuarioDTO.TipoUsuario.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    };
            var token = new JwtSecurityToken(
                issuer: "CAJAPI",
                audience: "CLIENTAPI",
                expires: DateTime.Now.AddHours(24).ToUniversalTime(),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );
            return tokenHandler.WriteToken(token);
        }

        public ResponseDTO ObtenerToken(string headers)
        {
            ResponseDTO  respuesta= new ResponseDTO();
            respuesta.Code = HttpStatusCode.OK;
            string session = "";
            if (headers.StartsWith("Bearer "))
            {
                session = headers.Remove(0, 7);
            }
            var jwtToken = this.DecodeToken(session);
            if (jwtToken == null)
            {
                respuesta.Code = HttpStatusCode.Unauthorized;
                respuesta.Message = "No se pudo obtener token de seguridad";
                return respuesta;
            }
            var valid = Convert.ToDateTime("1970-01-01T00:00:00Z");

            var listaClaims = jwtToken.Claims.ToList();
            var validto = valid.AddSeconds(double.Parse(listaClaims[3].Value.ToString()));
            if (validto < DateTime.Now)
            {
                respuesta.Code = HttpStatusCode.Unauthorized;
                respuesta.Message = "El token de seguridad ha vencido";
            }
            TokenDTO userData = new TokenDTO();
            userData.IdUsuario = int.Parse(listaClaims[0].Value);
            userData.TipoUsuario = char.Parse(listaClaims[1].Value);

            respuesta.Data = JsonSerializer.Serialize(userData);

            return respuesta;
        }


        public JwtSecurityToken DecodeToken(string stream)
        {

            var handler = new JwtSecurityTokenHandler();
            try
            {
                var jsonToken = handler.ReadToken(stream);
                var tokenS = jsonToken as JwtSecurityToken;
                return tokenS;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

    }
}
