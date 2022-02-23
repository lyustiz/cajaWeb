using Caja.MVC.Core.Models;
using Caja.MVC.Core.Models.Paginator;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Caja.MVC.Core.Controllers
{
    //[Area("EntregasModulos")]
    public class EntregaModulosController : Controller
    {
        public IConfiguration Configuration { get; }
        readonly NegocioClienteModulo negocio;
        readonly NegocioCliente negocioCliente;
        readonly NegocioModulo negocioModulo;
        readonly NegocioProgramacionJuego negocioProgramacionJuego;
        public EntregaModulosController(IConfiguration configuration)
        {
            Configuration = configuration;
            negocio = new NegocioClienteModulo(configuration);
            negocioCliente = new NegocioCliente(configuration);
            negocioModulo = new NegocioModulo(configuration);
            negocioProgramacionJuego = new NegocioProgramacionJuego(configuration);
        }

        public ActionResult Index(int Pag = 1, int Registros = 5, string Search = null)
        {
            List<ClienteModuloModel> modelo = null;
            if (Search != null)
            {
                modelo = new ClienteModuloModel().ToModelList(negocio.Consultar())
                .Where(e => e.NombreCliente.Contains(Search) || e.Estado.Contains(Search) || e.IdModulo.ToString().Contains(Search)).ToList();
            }
            else
            {
                modelo = new ClienteModuloModel().ToModelList(negocio.Consultar());
            }

            string host = Request.Scheme + "://" + Request.Host.Value;
            object[] resultado = new Paginador<ClienteModuloModel>().paginador(modelo, Pag, Registros, "EntregasModulos", "EntregaModulos", "Index", host);

            DataPaginador<ClienteModuloModel> respuesta = new DataPaginador<ClienteModuloModel>
            {
                Lista = (List<ClienteModuloModel>)resultado[2],
                Pagi_info = (string)resultado[0],
                Pagi_navegacion = (string)resultado[1]
            };

            return View(respuesta);
        }
        public ActionResult Create()
        {
            var modelo = new ClienteModuloModel();
            CompletarListas(modelo);
            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteModuloModel modelo)
        {
            if (modelo.IdCliente == 0)
            {
                ViewBag.ErrorMessage = "Selecciona un cliente";
                CompletarListas(modelo);
                return View(modelo);
            }
            if (modelo.ListaIdModulosSeleccionados == null)
            {
                ViewBag.ErrorMessage = "Selecciona al menos un módulo";
                CompletarListas(modelo);
                return View(modelo);
            }
            if (modelo.IdJuegoInicio == 0)
            {
                ViewBag.ErrorMessage = "Selecciona un juego inicio";
                CompletarListas(modelo);
                return View(modelo);
            }
            if (modelo.IdJuegoFin == 0)
            {
                ViewBag.ErrorMessage = "Selecciona un juego fin";
                CompletarListas(modelo);
                return View(modelo);
            }
            try
            {
                RespuestaNegocio<ClienteModuloModel> respuesta = negocio.Guardar(modelo);

                if (respuesta.Ok)
                    return RedirectToAction(nameof(Index));
                else
                {
                    ViewBag.ErrorMessage = respuesta.Mensaje;
                    CompletarListas(modelo);
                    return View(modelo);
                }
            }
            catch
            {
                CompletarListas(modelo);
                return View(modelo);
            }
        }

        public ActionResult Edit(int id)
        {
            var modelo = new ClienteModuloModel().ToModel(negocio.Consultar(id));

            return View(modelo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteModuloModel modelo)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    RespuestaNegocio<ClienteModuloModel> respuesta = negocio.Guardar(modelo);

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

        private void CompletarListas(ClienteModuloModel modelo)
        {

            List<ModuloModel> modeloModulo = new ModuloModel().ToModelList(negocioModulo.Consultar());
            List<ComboModel> itemsModulos = new ClienteModuloModel().GetListaModulos(modeloModulo);
            List<ProgramacionJuegoModel> modeloProgramacionJuego = new ProgramacionJuegoModel().ToModelList(negocioProgramacionJuego.BuscarProgramacionActiva());
            List<ComboModel> itemsProgramacionJuego = new ClienteModuloModel().GetListaJuegos(modeloProgramacionJuego);
            modelo.ListaModulos = new SelectList(itemsModulos, nameof(ComboModel.Value), nameof(ComboModel.Text)).ToList();
            modelo.ListaClientes = new ClienteModel().ToModelList(negocioCliente.Consultar());            //modelo.ListaJuegos = new ProgramacionJuegoModel().ToModelList(negocioProgramacionJuego.BuscarProgramacionActiva());
            modelo.ListaJuegos = new SelectList(itemsProgramacionJuego, nameof(ComboModel.Value), nameof(ComboModel.Text));
        }
    }
}
