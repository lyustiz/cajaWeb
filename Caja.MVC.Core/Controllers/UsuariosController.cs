using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Caja.MVC.Core.Controllers
{
    public class UsuariosController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioUsuario negocio;

        public UsuariosController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioUsuario(configuration);
        }

        public ActionResult Index()
        {
            List<UsuarioModel> modelo = new UsuarioModel().ToModelList(negocio.ConsultarUsuarios());
            return View(modelo);
        }

        public ActionResult Create()
        {
            var modelo = negocio.NuevoUsuario();
            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<UsuarioModel> respuesta = negocio.GuardarUsuario(modelo);

                    if (respuesta.Ok)
                        return RedirectToAction(nameof(Index));
                    else
                    {
                        ViewBag.ErrorMessage = respuesta.Mensaje;
                        return View(modelo);
                    }
                }
                catch
                {
                    return View(modelo);
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Valida los datos, algo esta mal !!!";
                return View(modelo);
            }
        }

        public ActionResult Edit(int id)
        {
            var modelo = negocio.ConsultarUsuario(id);

            return View(modelo);
        }

        public ActionResult State(int id)
        {
            var modelo = negocio.CambiarEstado(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<UsuarioModel> respuesta = negocio.GuardarUsuario(modelo);

                    if (respuesta.Ok)
                        return RedirectToAction(nameof(Index));
                    else
                    {
                        ViewBag.ErrorMessage = respuesta.Mensaje;
                        return View(modelo);
                    }
                }
                catch
                {
                    return View(modelo);
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Valida los datos, algo esta mal !!!";
                return View(modelo);
            }
        }
    }
}
