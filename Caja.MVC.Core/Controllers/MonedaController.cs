using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Caja.MVC.Core.Controllers
{
    public class MonedaController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioParametroGeneral negocio;

        public MonedaController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioParametroGeneral(configuration);
        }

        // GET: MonedaController
        public ActionResult Index()
        {
            MonedaModel modelo;
            var parametroMoneda = negocio.Consultar("strModeda");
            var parametroFormato = negocio.Consultar("strFormato");

            if (parametroFormato != null && parametroMoneda != null)
                modelo = new MonedaModel(parametroMoneda.Valor, parametroFormato.Valor);
            else
                modelo = new MonedaModel("$", "$ {0:#,##0}");

            return View(modelo);
        }       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(MonedaModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<MonedaModel> respuesta = negocio.ModificarMoneda(modelo);

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
