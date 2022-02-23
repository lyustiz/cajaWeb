using AspNetCore.Reporting;
using Caja.Core.Entidades;
using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Caja.MVC.Core.Controllers
{
    public class EntregaCartonesController : Controller
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        public IConfiguration Configuration { get; }
        readonly NegocioVendedor negocio;
        readonly NegocioRoe negocioRoe;
        readonly NegocioProgramacionJuego negocioProgramacion;

        public EntregaCartonesController(IConfiguration configuration, IWebHostEnvironment pWebHostEnvironment)
        {
            Configuration = configuration;
            webHostEnvironment = pWebHostEnvironment;
            negocio = new NegocioVendedor(Configuration);
            negocioRoe = new NegocioRoe(Configuration);
            negocioProgramacion = new NegocioProgramacionJuego(configuration);
        }

        public ActionResult Index(int Id = 0, string filtroBusqueda = "")
        {
            EntregaCartoneriaModel modelo = new() { FiltroBusqueda = filtroBusqueda, IdProgramacionJuego = Id, NumeroCartonesHoja = negocioRoe.ObtenerNumeroCartonesHoja() };
            var listaProgramacionActiva = negocioProgramacion.BuscarProgramacionActiva();

            var programacion = listaProgramacionActiva.FirstOrDefault();

            if (Id > 0)
                programacion = listaProgramacionActiva.FirstOrDefault(x => x.IdProgramacionJuego == Id);

            modelo.ListaProgramaciones = new SelectList(listaProgramacionActiva, nameof(Programacionjuegos.IdProgramacionJuego), nameof(Programacionjuegos.IdProgramacionJuego), programacion);

            modelo.Detalle = negocioProgramacion.FindProgramacionJuegoHojas(filtroBusqueda).ToList();

            return View("Index", modelo);
        }

        public ActionResult SeleccionoVendedor(int pIdVendedor, int pIdProgramacion)
        {
            var resumen = negocio.ConsultarHojasPorProgramacion(pIdVendedor, pIdProgramacion);
            var hojas = negocio.ObtenerHojasVendedor(pIdVendedor, pIdProgramacion);

            return Json(new { ok = true, resumen, hojas });
        }

        public ActionResult AgregarHoja(int pIdVendedor, int pIdProgramacion, int pHoja)
        {
            var programacion = negocioProgramacion.BuscarProgramacion(pIdProgramacion);

            if (pHoja < programacion.HojaInicial || pHoja > programacion.HojaFinal)
                return Json(new { ok = false, mensaje = "No se puede entregar una hoja que no ha sido impresa, verifique la cantidad de hojas que se entregaron" });

            var hoja = negocio.ExisteHoja(pIdProgramacion, pHoja);

            if (hoja == null)
                return Json(new { ok = true });
            else
            {
                var vendedor = negocio.ConsultarVendedor(hoja.IdVendedor);
                var mensaje = $"La hoja digitada ya ha sido asignada previamente, valide nuevamente la información. Código: {vendedor.Codigo} - Vendedor: {vendedor.Nombres} {vendedor.Apellidos}";

                return Json(new { ok = false, mensaje });
            }            
        }

        [HttpPost]
        public ActionResult Guardar([FromBody]EntregaHojasModel model)
        {
            var programacion = negocioProgramacion.BuscarProgramacion(model.IdProgramacionJuego);

            var mVendedorResumen = new Vendedoresresumen()
            {
                TotalCartones = model.TotalCartones,
                CartonesCortesia = model.CartonesCortesia,
                IdProgramacionJuego = model.IdProgramacionJuego,
                IdVendedor = model.IdVendedor
            };

            mVendedorResumen.ValorTotal = (mVendedorResumen.TotalCartones - mVendedorResumen.CartonesCortesia) * programacion.ValorCarton;

            var res = negocio.GuardarHojas(mVendedorResumen, model.Hojas);

            if (res)
                return Json(new { ok = true, mensaje = "Las hojas se asociaron correctamente." });
            else
                return Json(new { ok = false, mensaje = "Error al guardar la informacion, valide de nuevo." });
        }

        public ActionResult EliminarHoja(int pIdVendedor, int pIdProgramacion, int pHoja)
        {
            var programacion = negocioProgramacion.BuscarProgramacion(pIdProgramacion);
            var resumen = negocio.ConsultarHojasPorProgramacion(pIdVendedor, pIdProgramacion);
            var hoja = negocio.ExisteHoja(pIdProgramacion, pHoja);

            if (hoja == null)
            {
                return Json(new { ok = true, reload = false });
            }
            else
            {
                resumen.TotalCartones -= negocioRoe.ObtenerNumeroCartonesHoja();
                resumen.ValorTotal = resumen.TotalCartones * programacion.ValorCarton;
                resumen.ValorPendiente = resumen.ValorTotal - resumen.PagoAnticipado;

                var res = negocio.EliminarHojaVendedor(resumen, hoja);

                if (res)
                    return Json(new { ok = true, reload = true });
            }

            return Json(new { ok = false });
        }

        public IActionResult Print(int Id = 0)
        {
            string mimType = string.Empty;
            int extension = 1;
            string path = $"{webHostEnvironment.WebRootPath}\\Reportes\\ReporteEntregaCartoneria.rdlc";
            Dictionary<string, string> parametros = new();
            parametros.Add("parNumeroJuego", $"Juego Número {Id.ToString().PadLeft(6, '0')}");

            var datos = negocio.ReporteHojasPorProgramacion(Id);
            LocalReport localReport = new(path);
            localReport.AddDataSource("Detalle", datos.Tables[0]);
            var result = localReport.Execute(RenderType.Pdf, extension, parametros, mimType);

            return File(result.MainStream, "application/pdf");
        }


    }
}
