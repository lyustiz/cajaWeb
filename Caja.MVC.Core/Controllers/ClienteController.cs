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
    public class ClienteController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioCliente negocio;
        
        public ClienteController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioCliente(configuration);            
        }

        public ActionResult Index(string searchString = "")
        {
            List<ClienteModel> modelo = new ClienteModel().ToModelList(negocio.Consultar(searchString));
            return View(modelo);
        }

        public ActionResult Create()
        {
            var modelo = new ClienteModel();
            
            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<ClienteModel> respuesta = negocio.Guardar(modelo);

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
            var modelo = new ClienteModel().ToModel(negocio.Consultar(id));            
            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<ClienteModel> respuesta = negocio.Guardar(modelo);

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
