using Caja.API.Auth;
using Caja.API.DTO;
using Caja.Core.Entidades;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;

namespace Caja.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class JuegosController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        readonly NegocioJuego negocio;
        readonly NegocioParametroGeneral negocioParametroGeneral;
        readonly NegocioFiguras negocioFiguras;
        private readonly IJwtAuthenticationService _jwtService;
        private readonly ILogger<JuegosController> _logger;

        public JuegosController(IConfiguration configuration
            , IJwtAuthenticationService jwtService
            , ILogger<JuegosController> logger)
        {
            Configuration = configuration;
            _logger = logger;
            negocio = new NegocioJuego(Configuration);
            negocioParametroGeneral = new NegocioParametroGeneral(Configuration);
            negocioFiguras = new NegocioFiguras(Configuration);
            _jwtService = jwtService;
        }

        // GET: api/v1/Juegos
        [HttpGet]
        public ActionResult Get()
        {
            var headers = Request.Headers["authorization"].ToString();
            ResponseDTO respuesta = _jwtService.ObtenerToken(headers);
            if (respuesta.Code != HttpStatusCode.OK)
            {
                return Conflict(new { StatusCode = respuesta.Code, respuesta.Message });
            }
            TokenDTO userData = TokenDTO.fromJson(respuesta.Data);
            try
            {
                List<JuegoDTO> model = new();
                var items = negocio.Consultar(userData.IdUsuario, userData.TipoUsuario);
                if (items == null) return NotFound();
                var parametrosGenerales = negocioParametroGeneral.Consultar();

                foreach (var item in items)
                {
                    model.Add(JuegoDTOToJuego(item, parametrosGenerales));
                }

                return Ok(model);
            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró consultar la información" });
            }            
        }


        private JuegoDTO JuegoDTOToJuego(Juegos item, IEnumerable<Parametrosgenerales> parametrosGenerales)
        {
            var parametroMoneda = negocioParametroGeneral.ObtenerValor(parametrosGenerales, "strModeda");
            var parametroModuloCartones = negocioParametroGeneral.ObtenerValor(parametrosGenerales, "Caja-CantidadCartonesHoja");
            List<FiguraDTO> listFiguras = new();
            foreach (var programacionjuego in item.Programacionjuegos)
            {
                foreach (var programacionjuegosfigura in programacionjuego.Programacionjuegosfiguras) {

                    FiguraDTO figura = new()
                    {
                        IdFigura = programacionjuegosfigura.IdProgramacionJuegoFigura,
                        IdPlenoAutomatico = programacionjuegosfigura.IdPlenoAutomatico,
                        IdSerie = programacionjuego.IdSerie,
                        ValorPremio = programacionjuegosfigura.ValorPremio,
                        Estado = programacionjuegosfigura.Estado
                    };
                    listFiguras.Add(figura);
                }
            }
            
            return new JuegoDTO
            {
                IdJuego = item.IdJuego,
                TipoJuego = "R",
                FechaHoraInicio = item.FechaHoraInicio,
                FechaHoraFin = item.FechaHoraFin,
                Terminado = item.Terminado,
                ModuloCartones = int.Parse(parametroModuloCartones),
                Moneda = parametroMoneda,
                ValorModulo = item.Programacionjuegos.Count > 0 ? item.Programacionjuegos.FirstOrDefault().ValorModulo : 0,
                ValorCarton = item.Programacionjuegos.Count > 0 ? item.Programacionjuegos.FirstOrDefault().ValorCarton : 0,
                Actualizado = DateTime.Now,
                Premios = listFiguras,
                CurrentTime = DateTime.Now,
            };	
        }
    }
}
