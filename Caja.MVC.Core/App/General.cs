using Caja.MVC.Core.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Caja.MVC.Core.App
{
    public class General
    {
        public const string KeyUsuarioSesion = "UsuarioActivo";
        private readonly ISession session;

        public General(ISession _session)
        {
            session = _session;
        }

        public LoginModel UsuarioActual()
        {
            var usuario = session.GetString(KeyUsuarioSesion);
            return JsonConvert.DeserializeObject<LoginModel>(usuario);
        }
    }
}
