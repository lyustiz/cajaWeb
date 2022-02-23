using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Caja.MVC.Core.Controllers
{
    public class CiudadesController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioLocalizacion negocio;

        public CiudadesController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioLocalizacion(configuration);
        }

        // GET: CiudadesController
        public ActionResult Index(int idPais = 0)
        {
            List<CiudadModel> modelo = new CiudadModel().ToModelList(negocio.ConsultarCiudades(idPais));
            return View(modelo);
        }

        public ActionResult Create()
        {
            var paises = new PaisModel().ToModelList(negocio.ConsultarPaises());

            var modelo = new CiudadModel
            {
                ListaPaises = new SelectList(paises, nameof(PaisModel.IdPais), nameof(PaisModel.Nombre))
            };

            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CiudadModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<CiudadModel> respuesta = negocio.GuadarCiudad(modelo);

                    if (respuesta.Ok)
                        return RedirectToAction(nameof(Index), modelo.IdPais);
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
            var modelo = new CiudadModel().ToModel(negocio.ConsultarCiudad(id));

            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CiudadModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<CiudadModel> respuesta = negocio.GuadarCiudad(modelo);

                    if (respuesta.Ok)
                        return RedirectToAction(nameof(Index), new { idPais = modelo.IdPais });
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
