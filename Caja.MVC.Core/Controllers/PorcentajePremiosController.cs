using Caja.MVC.Core.App;
using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Caja.MVC.Core.Controllers
{
    public class PorcentajePremiosController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioPorcentajePremios negocio;

        public PorcentajePremiosController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioPorcentajePremios(configuration);
        }

        // GET: PorcentajePermiosController
        public ActionResult Index()
        {
            PorcentajePremioModel modelo = new PorcentajePremioModel().ToModel(negocio.Consultar());
            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(PorcentajePremioModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<PorcentajePremioModel> respuesta = negocio.GuardarParametrizacion(modelo);

                    if (respuesta.Ok)
                    {
                        ViewBag.SuccessMessage = "La información se guardó exitosamente.";
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
