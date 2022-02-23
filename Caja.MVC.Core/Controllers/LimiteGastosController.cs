using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caja.MVC.Core.Controllers
{
    public class LimiteGastosController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioConceptoGasto negocio;

        public LimiteGastosController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioConceptoGasto(configuration);
        }

        public ActionResult Index()
        {
            IEnumerable<ConceptoGastoModel> modelo = negocio.Consultar(); 
            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(IEnumerable<ConceptoGastoModel> modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<IEnumerable<ConceptoGastoModel>> respuesta = negocio.GuardarConceptos(modelo);

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
