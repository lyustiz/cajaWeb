using Caja.API.Auth;
using Caja.API.DTO;
using Caja.Core.Entidades;
using Caja.MVC.Core.Negocio;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Caja.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class JuegosConfiguracionController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        readonly NegocioJuego negocio;
        readonly NegocioParametroGeneral negocioParametroGeneral;
        readonly NegocioConfiguracion negocioConfiguracion;
        private readonly IJwtAuthenticationService _jwtService;
        private readonly ILogger<JuegosConfiguracionController> _logger;
        private readonly IMapper _mapper;

        public JuegosConfiguracionController(IConfiguration configuration
            , IJwtAuthenticationService jwtService
            , ILogger<JuegosConfiguracionController> logger, IMapper mapper)
        {
            Configuration = configuration;
            _logger = logger;
            negocio = new NegocioJuego(Configuration);
            negocioParametroGeneral = new NegocioParametroGeneral(Configuration);
            negocioConfiguracion = new NegocioConfiguracion(Configuration);
            _jwtService = jwtService;
            _mapper = mapper;
        }

        // GET: api/v1/JuegosConfiguracion
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
                List<JuegoConfiguracionDTO> model = new List<JuegoConfiguracionDTO>();
                var items = negocio.Consultar(userData.IdUsuario, userData.TipoUsuario);
                if (items == null) return NotFound();
                var parametrosGenerales = negocioParametroGeneral.Consultar();

                foreach (var item in items)
                {
                    model.Add(JuegoConfiguracionDTOToJuego(item, parametrosGenerales));
                }

                return Ok(model);
            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró consultar la información" });
            }
        }

        // GET: api/v1/JuegosConfiguracion
        [HttpGet("{id:int}")]
        public ActionResult GetById(int id)
        {
            var headers = Request.Headers["authorization"].ToString();
            ResponseDTO respuesta = _jwtService.ObtenerToken(headers);
            if (respuesta.Code != HttpStatusCode.OK)
            {
                return Conflict(new { StatusCode = respuesta.Code, respuesta.Message });
            }

            try
            {
                var item = negocio.Consultar(id);
                if (item == null) return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No se encontró coincidencias" });
                var parametrosGenerales = negocioParametroGeneral.Consultar();
                return Ok(JuegoConfiguracionDTOToJuego(item, parametrosGenerales));
            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró consultar la información" });
            }
        }

        // POST: api/v1/JuegosConfiguracion
        [HttpPost()]
        public ActionResult Post([FromBody] ConfiguracionDTO configuracionDTO)
        {
            var headers = Request.Headers["authorization"].ToString();
            ResponseDTO respuesta = _jwtService.ObtenerToken(headers);
            if (respuesta.Code != HttpStatusCode.OK)
            {
                return Conflict(new { StatusCode = respuesta.Code, respuesta.Message });
            }

            if (configuracionDTO == null)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No se recibieron datos" });
            }

            TokenDTO userData = TokenDTO.fromJson(respuesta.Data);

            if (userData.TipoUsuario != 'S')
            { 
                return Unauthorized();
            }

            try
            {
                Configuracion configuracion = DTOToConfiguracion(configuracionDTO);

                configuracion.IdUsuario = userData.IdUsuario;

                var respuestaNegocio = negocioConfiguracion.GuardarRetornar(configuracion);

                if (respuestaNegocio == null)
                {
                    return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No se logró Configurar el juego" });
                }

                return Ok(ConfiguracionToDTO(respuestaNegocio)); ;

            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró crear el registro" });
            }
        }


        // PUT: api/v1/JuegosConfiguracion
        [HttpPut()]
        public ActionResult Put([FromBody] ConfiguracionDTO configuracionDTO)
        {
            var headers = Request.Headers["authorization"].ToString();
            ResponseDTO respuesta = _jwtService.ObtenerToken(headers);
            if (respuesta.Code != HttpStatusCode.OK)
            {
                return Conflict(new { StatusCode = respuesta.Code, respuesta.Message });
            }

            if (configuracionDTO == null)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No se encontró coincidencias" });
            }

            TokenDTO userData = TokenDTO.fromJson(respuesta.Data);

            if (userData.TipoUsuario != 'S')
            { 
                return Unauthorized();
            }

            try
            {
                Configuracion configuracion = DTOToConfiguracion(configuracionDTO);
                
                var respuestaNegocio = negocioConfiguracion.Actualizar(configuracion);

                if (!respuestaNegocio.Ok)
                {
                    return Conflict(respuestaNegocio);
                }

                return Ok(new { Message = "Registro Actualizados" });

            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró actualizar la información" });
            }
        }

        private JuegoConfiguracionDTO JuegoConfiguracionDTOToJuego(Juegos item, IEnumerable<Parametrosgenerales> parametrosGenerales)
        {
            ConfiguracionDTO configuracionDto = null;
            var parametroMoneda = negocioParametroGeneral.ObtenerValor(parametrosGenerales, "strModeda");
            var parametroModuloCartones = negocioParametroGeneral.ObtenerValor(parametrosGenerales, "Caja-CantidadCartonesHoja");
            if (item.Configuracion != null)
            {
                configuracionDto = new ConfiguracionDTO();
                configuracionDto.IdConfiguracion = item.Configuracion.IdConfiguracion;
                configuracionDto.NumeroJuego = item.IdJuego;
                configuracionDto.Carton = item.Configuracion.Carton;
                configuracionDto.Serie = item.Configuracion.Serie;
                configuracionDto.Balotas = item.Configuracion.Balotas;
                configuracionDto.FechaRegistro = item.Configuracion.FechaRegistro;
                configuracionDto.IdUsuario = item.Configuracion.IdUsuario;
                configuracionDto.Estado = item.Configuracion.Estado;
                configuracionDto.FechaModificacion = item.Configuracion.FechaModificacion;
                configuracionDto.Reconfigurado = item.Configuracion.Reconfigurado;
            }

            List<FiguraDTO> listFiguras = new();

            foreach (var programacionjuego in item.Programacionjuegos)
            {
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

            return new JuegoConfiguracionDTO
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
                Configuracion = configuracionDto,
                Premios = listFiguras,
                CurrentTime = DateTime.Now,
            };
        }

        private Configuracion DTOToConfiguracion(ConfiguracionDTO configuracionDTO)
        {
            return new Configuracion()
            {
                IdConfiguracion = configuracionDTO.IdConfiguracion,
                NumeroJuego = configuracionDTO.NumeroJuego,
                Carton = configuracionDTO.Carton,
                Serie = configuracionDTO.Serie,
                Balotas = configuracionDTO.Balotas,
                FechaRegistro = configuracionDTO.FechaRegistro,
                IdUsuario = configuracionDTO.IdUsuario,
                Estado = configuracionDTO.Estado,
                FechaModificacion = configuracionDTO.FechaModificacion,
                Reconfigurado = configuracionDTO.Reconfigurado,

            };
        }

        private ConfiguracionDTO ConfiguracionToDTO(Configuracion configuracion)
        {
            return new ConfiguracionDTO()
            {
                IdConfiguracion = configuracion.IdConfiguracion,
                NumeroJuego = configuracion.NumeroJuego,
                Carton = configuracion.Carton,
                Serie = configuracion.Serie,
                Balotas = configuracion.Balotas,
                FechaRegistro = configuracion.FechaRegistro,
                IdUsuario = configuracion.IdUsuario,
                Estado = configuracion.Estado,
                FechaModificacion = configuracion.FechaModificacion,
                Reconfigurado = configuracion.Reconfigurado,
            };
        }

    }

}
