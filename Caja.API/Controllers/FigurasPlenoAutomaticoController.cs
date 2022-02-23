using Caja.API.Auth;
using Caja.API.DTO;
using Caja.Core.Entidades;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Net;

namespace Caja.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FigurasPlenoAutomaticoController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        private readonly IJwtAuthenticationService _jwtService;
        private readonly ILogger<FigurasPlenoAutomaticoController> _logger;

        public FigurasPlenoAutomaticoController(IConfiguration configuration
            ,IJwtAuthenticationService jwtService
            , ILogger<FigurasPlenoAutomaticoController> logger)
        {
            Configuration = configuration;
            _logger = logger;
            _jwtService = jwtService;
        }


        // GET: api/v1/FigurasPlenoAutomatico
        [HttpGet]
        public ActionResult Get()
        {
            var headers = Request.Headers["authorization"].ToString();
            ResponseDTO respuesta = _jwtService.ObtenerToken(headers);
            if (respuesta.Code != HttpStatusCode.OK)
            {
                return Conflict(new { StatusCode = respuesta.Code, respuesta.Message });
            }
            try
            {
                NegocioFiguras negociopa = new(Configuration);
                FigurasPADTO model = new();

                var items = negociopa.ObtenerFigurasPleanoAutomatico();
                if (items.Count == 0) return NotFound();
                var figurasDto = items.Select(x => FiguraPlenoAutomaticoDTOToFiguraPlenoAutomatico(x)).ToList();
                model.FigurasPlenoAutomatico = figurasDto;
                model.Actualizado = DateTime.Now;
                return Ok(model);
            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = 400, Message = "No logró consultar la información" });
            }
        }

        private FiguraPADTO FiguraPlenoAutomaticoDTOToFiguraPlenoAutomatico(FiguraPA item)
        {
            
            return new FiguraPADTO
            {
                IdFigura = item.IdFigura,
                Nombre = item.Nombre,
                Posiciones = item.Posiciones,
                Estado = item.Estado,
            };	
        }
    }
}
