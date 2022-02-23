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
    public class CartonesController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        readonly NegocioCarton negocio;
        readonly NegocioParametroGeneral negocioParametroGeneral;
        private readonly IJwtAuthenticationService _jwtService;
        private readonly IMapper _mapper;

        public CartonesController(IConfiguration configuration
            , IJwtAuthenticationService jwtService
            , IMapper mapper
            , ILogger<CartonesController> logger)
        {
            Configuration = configuration;
            negocio = new NegocioCarton(Configuration);
            negocioParametroGeneral = new NegocioParametroGeneral(Configuration);
            _jwtService = jwtService;
            _mapper = mapper;
        }

        // GET: api/v1/Cartones
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
                List<CartonJuegoDTO> model = new();
                var items = negocio.ObtenerCartonesJuegos(userData.IdUsuario);
                if (items == null) return NotFound();
                foreach (var item in items)
                {
                    model.Add(CartonDTOToCarton(item));
                }

                return Ok(model);
            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró consultar la información" });
            }            
        }


        [HttpPut]
        public ActionResult Put([FromBody] List<CartonJuegoDTO> cartonesJuegoDTO)
        {
            var headers = Request.Headers["authorization"].ToString();

            ResponseDTO respuesta = _jwtService.ObtenerToken(headers);

            if (respuesta.Code != HttpStatusCode.OK)
            {
                return Conflict(new { StatusCode = respuesta.Code, respuesta.Message });
            }

            if (cartonesJuegoDTO.IsNullOrZeroItems())
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No se encontró coincidencias" });
            }

            TokenDTO userData = TokenDTO.fromJson(respuesta.Data);

            try
            {
                List<CartonJuego> cartones = new();

                foreach (CartonJuegoDTO cartonJuegoDTO in cartonesJuegoDTO)
                {
                    CartonJuego cartonJuego = CartonDTOToCartonJuego(cartonJuegoDTO);

                    cartonJuego.Idvendedor = userData.IdUsuario;

                    cartones.Add(cartonJuego);
                }

                var respuestaNegocio = negocio.GuardarActualizarLote(cartones);

                if (!respuestaNegocio.Ok)
                {
                    return Conflict(respuestaNegocio);
                }

                return Ok(new { Message = "Registros Actualizados" });
            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró consultar la información" });
            }
        }

        private CartonJuegoDTO CartonDTOToCarton(CartonJuego item)
        {
            return _mapper.Map<CartonJuegoDTO>(item);
        }

        private CartonJuego CartonDTOToCartonJuego(CartonJuegoDTO item)
        {
            return _mapper.Map<CartonJuego>(item);
        }
    }
}
