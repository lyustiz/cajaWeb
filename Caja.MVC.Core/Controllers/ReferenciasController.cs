using Caja.MVC.Core.App;
using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Caja.MVC.Core.Controllers
{
    public class ReferenciasController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioVendedor negocio;
        readonly NegocioLocalizacion negocioLocalizacion;

        public ReferenciasController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioVendedor(configuration);
            negocioLocalizacion = new NegocioLocalizacion(configuration);
        }
        public ActionResult Index(int idVendedor)
        {
            List<ReferenciaModel> modelo = new ReferenciaModel().ToModelList(negocio.ConsultarReferencias(idVendedor));
            VendedorModel vendedor = new VendedorModel().ToModel(negocio.ConsultarVendedor(idVendedor));

            ViewBag.IdVendedor = idVendedor;
            ViewBag.NombreVendedor = $"{vendedor.Nombres} {vendedor.Apellidos}".Trim();

            return View(modelo);
        }

        public ActionResult Create(int idVendedor)
        {
            var modelo = new ReferenciaModel();
            CompletarListas(modelo);
            modelo.IdVendedor = idVendedor;

            VendedorModel vendedor = new VendedorModel().ToModel(negocio.ConsultarVendedor(idVendedor));

            ViewBag.IdVendedor = idVendedor;
            ViewBag.NombreVendedor = $"{vendedor.Nombres} {vendedor.Apellidos}".Trim();

            return View(modelo);
        }

        private void CompletarListas(ReferenciaModel modelo)
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
            modelo.ListaTipoRelacion = Listas.ObtenerListaTiposRelacion();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReferenciaModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<ReferenciaModel> respuesta = negocio.GuardarReferencia(modelo);

                    if (respuesta.Ok)
                        return RedirectToAction(nameof(Index), new { idVendedor = modelo.IdVendedor });
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

        public ActionResult Edit(int id)
        {
            var modelo = new ReferenciaModel().ToModel(negocio.ConsultarReferencia(id));
            CompletarListas(modelo);

            VendedorModel vendedor = new VendedorModel().ToModel(negocio.ConsultarVendedor(modelo.IdVendedor));

            ViewBag.IdVendedor = modelo.IdVendedor;
            ViewBag.NombreVendedor = $"{vendedor.Nombres} {vendedor.Apellidos}".Trim();

            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReferenciaModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<ReferenciaModel> respuesta = negocio.GuardarReferencia(modelo);

                    if (respuesta.Ok)
                        return RedirectToAction(nameof(Index), new { idVendedor = modelo.IdVendedor });
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

