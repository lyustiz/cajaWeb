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
    public class JuegoDetalleController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        readonly NegocioJuego negocio;
        readonly NegocioParametroGeneral negocioParametroGeneral;
        readonly NegocioFiguras negocioFiguras;
        private readonly IJwtAuthenticationService _jwtService;
        private readonly ILogger<JuegosController> _logger;

        public JuegoDetalleController(IConfiguration configuration
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

        // GET: api/v1/JuegoDetalle
        [HttpGet("{idJuego:int}")]
        public ActionResult Get(int idJuego)
        {
            var headers = Request.Headers["authorization"].ToString();
            ResponseDTO respuesta = _jwtService.ObtenerToken(headers);

            if (respuesta.Code != HttpStatusCode.OK)
            {
                return Conflict(new { StatusCode = respuesta.Code, respuesta.Message });
            }

            TokenDTO userData = TokenDTO.fromJson(respuesta.Data);

            if (userData.TipoUsuario != 'S')
            {
                return Unauthorized();
            }

            try
            {
                JuegoInforme items = negocio.ConsultarJuegoDetalle(idJuego);
                if (items == null) return NotFound();
                return Ok(JuegoInformeToDTO(items));
            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró consultar la información" });
            }
        }


        private JuegoDetalleDTO JuegoInformeToDTO(JuegoInforme juego)
        {
            List<FiguraDTO> listFiguras = new();
            List<ProgramacionJuegosDTO> listProgramacionJuegos = new();

            foreach (var programacionjuego in juego.Programacionjuegos)
            {

                ProgramacionJuegosDTO AddProgramacionjuego = new()
                {
                    IdProgramacionJuego = programacionjuego.IdProgramacionJuego,
                    FechaProgramada = programacionjuego.FechaProgramada,
                    ValorCarton = programacionjuego.ValorCarton,
                    TotalCartones = programacionjuego.TotalCartones,
                    ValorModulo = programacionjuego.ValorModulo,
                    TotalModulos = programacionjuego.TotalModulos,
                    TotalPremios = programacionjuego.TotalPremios,
                    IdSerie = programacionjuego.IdSerie,
                    CartonInicial = programacionjuego.CartonInicial,
                    CartonFinal = programacionjuego.CartonFinal,
                    HojaInicial = programacionjuego.HojaInicial,
                    HojaFinal = programacionjuego.HojaFinal,
                    ResultadoFinal = programacionjuego.ResultadoFinal,
                    Estado = programacionjuego.Estado,
                };

                listProgramacionJuegos.Add(AddProgramacionjuego);

                foreach (var programacionjuegosfigura in programacionjuego.Programacionjuegosfiguras)
                {

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

            ConfiguracionDTO configuracionDTO = new()
            {
                IdConfiguracion = juego.Configuracion.IdConfiguracion,
                NumeroJuego = juego.Configuracion.NumeroJuego,
                Carton = juego.Configuracion.Carton,
                Serie = juego.Configuracion.Serie,
                Balotas = juego.Configuracion.Balotas,
                FechaRegistro = juego.Configuracion.FechaRegistro,
                IdUsuario = juego.Configuracion.IdUsuario,
                Estado = juego.Configuracion.Estado,
                FechaModificacion = juego.Configuracion.FechaModificacion,
                Reconfigurado = juego.Configuracion.Reconfigurado
            };

            
            return new JuegoDetalleDTO
            {
                IdJuego = juego.IdJuego,
                FechaHoraInicio = juego.FechaHoraInicio,
                FechaHoraFin = juego.FechaHoraFin,
                Duracion = juego.Duracion,
                IdEmpresa = juego.IdEmpresa,
                Terminado = juego.Terminado,
                IdUsuario = juego.IdUsuario,
                totalCartones = juego.totalCartones,
                cartonesAsignados = juego.cartonesAsignados,
                cartonesVendidos = juego.cartonesVendidos,
                totalModulos = juego.totalModulos,
                modulosAsignados = juego.modulosAsignados,
                modulosVendidos = juego.modulosVendidos,
                numeroVendedores = juego.numeroVendedores,
                Premios = listFiguras,
                Configuracion = configuracionDTO,
                Programacionjuegos = listProgramacionJuegos
            };
        }
    }
}
