using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caja.MVC.Core.Controllers
{
    public class SociosController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioUsuario negocio;

        public SociosController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioUsuario(configuration);

        }

        // GET: PorcentajePermiosController
        public ActionResult Index()
        {
            IEnumerable<SocioModel> modelo = negocio.ConsultarSocios();
            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(IEnumerable<SocioModel> modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<IEnumerable<SocioModel>> respuesta = negocio.GuardarPorcentajes(modelo);

                    if (respuesta.Ok)
                    {
                        ViewBag.SuccessMessage = "La información se actualizó exitosamente.";
                        return View("Index", modelo);
                    }
                    else
                    {
                        ViewBag.ErrorMessage = respuesta.Mensaje;
                        return View("Index", modelo);
                    }
                }
                catch
                {
                    return View("Index", modelo);
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Valida los datos, algo esta mal !!!";
                return View("Index", modelo);
            }
        }
    }
}
