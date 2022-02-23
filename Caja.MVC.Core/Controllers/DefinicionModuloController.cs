using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Caja.MVC.Core.Controllers
{
    public class DefinicionModuloController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioModulo negocio;


        public DefinicionModuloController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioModulo(configuration);
        }

        public ActionResult Index()
        {
            List<ModuloModel> modelo = new ModuloModel().ToModelList(negocio.Consultar());
            return View(modelo);
        }

        public ActionResult Create()
        {
            var modelo = new ModuloModel();
            
            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModuloModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<ModuloModel> respuesta = negocio.Guardar(modelo);

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
            var modelo = new ModuloModel().ToModel(negocio.Consultar(id));

            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ModuloModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<ModuloModel> respuesta = negocio.Guardar(modelo);

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
