using Caja.Core.Entidades;
using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace Caja.MVC.Core.Controllers
{
    public class CobroCartonesController : Controller
    {
        // GET: CobroCartonesController
        private readonly IWebHostEnvironment webHostEnvironment;
        private Vendedoresresumen vendedorResumen;
        public IConfiguration Configuration { get; }
        readonly NegocioVendedor negocio;
        readonly NegocioRoe negocioRoe;
        readonly NegocioProgramacionJuego negocioProgramacion; 
        readonly NegocioParametroGeneral negocioParametro;

        public CobroCartonesController(IConfiguration configuration, IWebHostEnvironment pWebHostEnvironment)
        {
            Configuration = configuration;
            webHostEnvironment = pWebHostEnvironment;
            negocio = new NegocioVendedor(Configuration);
            negocioRoe = new NegocioRoe(Configuration);
            negocioProgramacion = new NegocioProgramacionJuego(configuration);
            negocioParametro = new NegocioParametroGeneral(configuration);
        }
        public ActionResult Index(int Id = 0, string filtroBusqueda = "")
        {
            CobroCartoneriaModel modelo = new() { FiltroBusqueda = filtroBusqueda, IdProgramacionJuego = Id, NumeroCartonesHoja = negocioRoe.ObtenerNumeroCartonesHoja() };
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
            vendedorResumen = negocio.ConsultarHojasPorProgramacion(pIdVendedor, pIdProgramacion);
            return Json(new { ok = true, vendedorResumen });
        }
        public ActionResult GuardarFaltante(int pIdVendedor, int pIdProgramacion, int pFaltante)
        {
            var maximoJuegos = negocioParametro.Consultar("MaximoJuegos");
            var resumen = negocio.ConsultarHojasPorProgramacion(pIdVendedor, pIdProgramacion);
            return Json(new { ok = true, resumen });
        }


        private void CalcularValorTotal()
        {

            double faltante = vendedorResumen.Faltante;

            //int modulosEnCartones = 0;
            int cartonesValidos = (int)(vendedorResumen.TotalCartones - vendedorResumen.CartonesCortesia - vendedorResumen.CartonesDevueltos);
            cartonesValidos = cartonesValidos < 0 ? 0 : cartonesValidos;

            //int cantidadModulos = vendedorResumen.CantidadModulos;

            double valorTotal = vendedorResumen.ValorTotal;


            
          /*  var hojasVendedor = mDominioVendedorHojas.ObtenerHojasVendedor(mIdVendedor, mProgramacionJuego.IdProgramacionJuego);

            txtRegistroHojasDevueltas.Value = hojasVendedor.Count();*/
            


            //modulosEnCartones = (int)(cantidadModulos * mProgramacionJuego.ValorModulo / mProgramacionJuego.ValorCarton);

            /*var porcentaje = mDominioPorcentajes.CalcularPorcentaje((int)txResumenTotalCartonesEfectivos.Value + modulosEnCartones);

            if (porcentaje.IsOn(-1))
                porcentaje = (int)txtRegistroPorcentajaComision.Value;

            txtRegistroPorcentajaComision.Value = porcentaje;
            txtRegistroPorcentajaComision.Enabled = !(txtRegistroPorcentajaComision.Value > 0);

            //obtner por cada juego valor carton
            int comisionPersonal = (int)((cartonesValidos * mProgramacionJuego.ValorCarton) ) * porcentaje / 100;
            int valorFinal = (int)((cartonesValidos * mProgramacionJuego.ValorCarton)) - comisionPersonal;
            txResumenValorComision.Text = string.Format(SesionActiva.FormatoMoneda, comisionPersonal);

            valorFinal = valorFinal - (int)txtRegistroGastosCortesia.Value;//valor que el ususario digitó
            txResumenTotalPagar.Text = string.Format(SesionActiva.FormatoMoneda, valorFinal);
            faltante = valorFinal - faltante;
            txResumenTotalRecibido.Text = string.Format(SesionActiva.FormatoMoneda, faltante);
            txResumenGastosCortesia.Text = string.Format(SesionActiva.FormatoMoneda, (int)txtRegistroGastosCortesia.Value);
            txResumenTotalCartonesEfectivos.Value = cartonesValidos;            */
        }

    }
}
