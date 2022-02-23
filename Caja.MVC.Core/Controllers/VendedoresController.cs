using Caja.MVC.Core.App;
using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Caja.MVC.Core.Controllers
{
    public class VendedoresController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioVendedor negocio;
        readonly NegocioLocalizacion negocioLocalizacion;

        public VendedoresController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioVendedor(configuration);
            negocioLocalizacion = new NegocioLocalizacion(configuration);
        }
        public ActionResult Index(string searchString = "")
        {
            List<VendedorModel> modelo = new VendedorModel().ToModelList(negocio.ConsultarVendedores(searchString));
            return View(modelo);
        }

        public ActionResult Create()
        {
            var modelo = new VendedorModel();
            CompletarListas(modelo);

            return View(modelo);
        }

        private void CompletarListas(VendedorModel modelo)
        {
            var paises = new PaisModel().ToModelList(negocioLocalizacion.ConsultarPaises());

            List<ComboModel> itemsCiudades = new();

            foreach (var pais in paises)
            {
                var ciudades = new CiudadModel().ToModelList(negocioLocalizacion.ConsultarCiudades(pais.IdPais));

                foreach (var ciudad in ciudades)
                    itemsCiudades.Add(new ComboModel() { Value = ciudad.IdCiudad, Text = $"{ciudad.Nombre}/{pais.Nombre.ToUpper()}" });
            }

            modelo.ListaCiudades = new SelectList(itemsCiudades, nameof(ComboModel.Value), nameof(ComboModel.Text));
            modelo.ListaEstadosCivil = Listas.ObtenerListaEstadoCivil();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VendedorModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<VendedorModel> respuesta = negocio.Guardar(modelo);

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
                CompletarListas(modelo);
                return View(modelo);
            }
        }

        public ActionResult State(int id)
        {
            var modelo = negocio.CambiarEstado(id);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var modelo = new VendedorModel().ToModel(negocio.ConsultarVendedor(id));
            CompletarListas(modelo);
            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(VendedorModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<VendedorModel> respuesta = negocio.Guardar(modelo);

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
                CompletarListas(modelo);
                return View(modelo);
            }
        }
    }
}
