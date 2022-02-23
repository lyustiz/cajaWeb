using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Caja.MVC.Core.Controllers
{
    public class PaisesController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioLocalizacion negocio;
        
        public PaisesController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioLocalizacion(configuration);
        }

        public ActionResult Index()
        {
            List<PaisModel> modelo = new PaisModel().ToModelList(negocio.ConsultarPaises());
            return View(modelo);
        }

        public ActionResult Create()
        {
            var modelo = new PaisModel();
            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PaisModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<PaisModel> respuesta = negocio.GuadarPais(modelo);

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
            var modelo = new PaisModel().ToModel(negocio.ConsultarPais(id));

            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PaisModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<PaisModel> respuesta = negocio.GuadarPais(modelo);

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
