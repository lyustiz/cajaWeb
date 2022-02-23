using Caja.MVC.Core.App;
using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace studio.Controllers
{
    public class PagesController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioUsuario negocio;

        public PagesController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioUsuario(configuration);
        }      

        public IActionResult ErrorPage()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel modelo)
        {
            RespuestaNegocio<LoginModel> respuesta = negocio.Validar(modelo);

            if (respuesta.Ok)
            {
                HttpContext.Session.SetString(General.KeyUsuarioSesion, JsonConvert.SerializeObject(respuesta.Informacion));
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.ErrorMessage = respuesta.Mensaje;
                return View();
            }            
        }

        public ActionResult LogOff()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Pages");
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
