using AutoMapper;
using Caja.API.Auth;
using Caja.API.DTO;
using Caja.Core.Entidades;
using Caja.MVC.Core.Negocio;
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
    public class SolicitudesVendedoresController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        readonly NegocioSolicitudVendedor negocio;
        readonly NegocioParametroGeneral negocioParametroGeneral;
        private readonly IJwtAuthenticationService _jwtService;
        private readonly ILogger<SolicitudesVendedoresController> _logger;
        private readonly IMapper _mapper;

        public SolicitudesVendedoresController(IConfiguration configuration
            , IJwtAuthenticationService jwtService
            , IMapper mapper
            , ILogger<SolicitudesVendedoresController> logger)
        {
            Configuration = configuration;
            _logger = logger;
            negocio = new NegocioSolicitudVendedor(Configuration);
            negocioParametroGeneral = new NegocioParametroGeneral(Configuration);
            _jwtService = jwtService;
            _mapper = mapper;
        }

        // GET: /api/v1/solicitudesvendedores
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
                List<SolicitudVendedorDTO> model = new();
                var items = negocio.ConsultarPorVendedor(userData.IdUsuario);
                if (items == null) return NotFound();
                foreach (var item in items)
                {
                    model.Add(SolicitudVendedorToDTO(item));
                }

                return Ok(model);
            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró consultar la información" });
            }
        }

        // POST: /api/v1/solicitudesvendedores
        [HttpPost]
        public ActionResult Post([FromBody] SolicitudVendedorDTO solicitudVendedorDTO)
        {
            var headers = Request.Headers["authorization"].ToString();

            ResponseDTO respuesta = _jwtService.ObtenerToken(headers);

            if (respuesta.Code != HttpStatusCode.OK)
            {
                return Conflict(new { StatusCode = respuesta.Code, respuesta.Message });
            }

            if (solicitudVendedorDTO == null)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No se recibieron datos" });
            }

            TokenDTO userData = TokenDTO.fromJson(respuesta.Data);

            try
            {
                SolicitudesVendedores items = DTOToSolicitudVendedor(solicitudVendedorDTO);

                items.IdVendedor = userData.IdUsuario;

                var respuestaNegocio = negocio.GuardarRetornar(items);

                if (respuestaNegocio == null)
                {
                    return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró Crear la Solicitud" });
                }

                return Ok(SolicitudVendedorToDTO(respuestaNegocio));
            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró Crear la Solicitud" });
            }
        }

        private SolicitudVendedorDTO SolicitudVendedorToDTO(SolicitudesVendedores item)
        {
            return new SolicitudVendedorDTO
            {
                IdSolicitudVendedor = item.IdSolicitudVendedor,
                IdVendedor = item.IdVendedor,
                IdJuego = item.IdJuego,
                TipoSolicitud = item.TipoSolicitud,
                Cantidad = item.Cantidad,
                Estado = item.Estado,
                FechaSolicitud = item.FechaSolicitud,
                FechaModificacion = item.FechaModificacion,
            };
        }

        private SolicitudesVendedores DTOToSolicitudVendedor(SolicitudVendedorDTO item)
        {
            return new SolicitudesVendedores
            {
                IdSolicitudVendedor = item.IdSolicitudVendedor,
                IdVendedor = item.IdVendedor,
                IdJuego = item.IdJuego,
                TipoSolicitud = item.TipoSolicitud,
                Cantidad = item.Cantidad,
                Estado = item.Estado,
                FechaSolicitud = item.FechaSolicitud,
                FechaModificacion = item.FechaModificacion,
            };
            

        }
    }
}
