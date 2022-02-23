using System;
using System.Text.Json;


namespace Caja.API.DTO
{
    public class TokenDTO
    {
        public int IdUsuario { get; set; }
        public char TipoUsuario { get; set; }

        static public TokenDTO fromJson( string JsonDto)
        {
            return JsonSerializer.Deserialize<TokenDTO>(JsonDto);     
        }
    }
}
