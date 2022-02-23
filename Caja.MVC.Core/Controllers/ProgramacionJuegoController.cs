using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Caja.Core.Entidades;
using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace Caja.MVC.Core.Controllers
{
    public class ProgramacionJuegoController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioProgramacionJuego negocio;
        readonly NegocioRoe negocioRoe;

        public ProgramacionJuegoController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioProgramacionJuego(configuration);
            negocioRoe = new NegocioRoe(configuration);
        }

        // GET: MonedaController
        public ActionResult Index(int Id = 0)
        {
            var listaProgramacionActiva = negocio.BuscarProgramacionActiva();
            var listaSeries = negocioRoe.ObtenerSeries();
            var listaFiguras = negocioRoe.ObtenerFiguras();

            ViewBag.EsNuevo = false;

            if (listaProgramacionActiva.IsNullOrZeroItems())
            {
                ProgramacionJuegoModel modelo = new() { FechaJuego = DateTime.Now };
                modelo.ListaProgramaciones = new SelectList(listaProgramacionActiva, nameof(Programacionjuegos.IdProgramacionJuego), nameof(Programacionjuegos.IdProgramacionJuego));
                modelo.ListaSeries = new SelectList(listaSeries, nameof(Listablas.IdLisTablas), nameof(Listablas.Name));
                modelo.ListaFiguras = new SelectList(listaFiguras, nameof(Plenoautomatico.IdPlenoAutomatico), nameof(Plenoautomatico.Name));

                return View(modelo);
            }
            else
            {
                var programacion = listaProgramacionActiva.FirstOrDefault();

                if (Id > 0)
                    programacion = listaProgramacionActiva.FirstOrDefault(x => x.IdProgramacionJuego == Id);

                programacion.Programacionjuegosfiguras = negocio.BuscarFigurasProgramacion(programacion.IdProgramacionJuego);
                ProgramacionJuegoModel modelo = new ProgramacionJuegoModel().ToModel(programacion);

                modelo.ListaProgramaciones = new SelectList(listaProgramacionActiva, nameof(Programacionjuegos.IdProgramacionJuego), nameof(Programacionjuegos.IdProgramacionJuego), programacion);
                modelo.ListaSeries = new SelectList(listaSeries, nameof(Listablas.IdLisTablas), nameof(Listablas.Name));
                modelo.ListaFiguras = new SelectList(listaFiguras, nameof(Plenoautomatico.IdPlenoAutomatico), nameof(Plenoautomatico.Name));

                return View(modelo);
            }
        }

        public ActionResult Nuevo()
        {
            int siguienteId = negocio.SiguienteIdProgramacion();

            var listaProgramacionActiva = new List<Programacionjuegos>
            {
                new Programacionjuegos() { IdProgramacionJuego = siguienteId }
            };

            var listaSeries = negocioRoe.ObtenerSeries();
            var listaFiguras = negocioRoe.ObtenerFiguras();

            ProgramacionJuegoModel modelo = new() { FechaJuego = DateTime.Now };
            modelo.ListaProgramaciones = new SelectList(listaProgramacionActiva, nameof(Programacionjuegos.IdProgramacionJuego), nameof(Programacionjuegos.IdProgramacionJuego));
            modelo.ListaSeries = new SelectList(listaSeries, nameof(Listablas.IdLisTablas), nameof(Listablas.Name));
            modelo.ListaFiguras = new SelectList(listaFiguras, nameof(Plenoautomatico.IdPlenoAutomatico), nameof(Plenoautomatico.Name));

            ViewBag.EsNuevo = true;

            return View("Index", modelo);

        }

        [HttpPost]
        public ActionResult Save([FromBody] ProgramacionJuegoModel modelo)
        {
            if (modelo != null)
            {
                var resultado = negocio.Guardar(modelo);

                if (resultado.Ok)
                    resultado.Mensaje = "La programación del juego se registro exitosamente.";

                return Json(resultado);                
            }
            else
            {
                return Json(new RespuestaNegocio<string>() { Ok = false, Mensaje = "El formularo tiene error en los datos, por favor validelo nuevamente." });
            }
        }
    }
}
