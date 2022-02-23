using Caja.API.Auth;
using Caja.API.DTO;
using Caja.Core.Entidades;
using Caja.MVC.Core.Models;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;

namespace Caja.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ClientesController : ControllerBase
    {

        public IConfiguration Configuration { get; }
        readonly NegocioCliente negocio;
        private readonly IJwtAuthenticationService _jwtService;
        private readonly ILogger<ClientesController> _logger;

        public ClientesController(IConfiguration configuration
            , IJwtAuthenticationService jwtService
            , ILogger<ClientesController> logger)
        {
            Configuration = configuration;
            _logger = logger;
            negocio = new NegocioCliente(Configuration);
            _jwtService = jwtService;
        }

        // GET: api/v1/Clientes
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
                List<ClienteDTO> model = new();
                var items = negocio.ConsultarPorVendedor(userData.IdUsuario);
                if (items == null) return NotFound();
                foreach (var item in items)
                {
                    model.Add(ClienteToClienteDTO(item));
                }

                return Ok(model);
            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró consultar la información" });
            }            
        }

        // PUT: api/v1/Clientes
        [HttpPut]
        public ActionResult Put([FromBody] List<ClienteDTO> clientesDTO)
        {
            var headers = Request.Headers["authorization"].ToString();
            ResponseDTO respuesta = _jwtService.ObtenerToken(headers);
            
            if (respuesta.Code != HttpStatusCode.OK)
            {
                return Conflict(new { StatusCode = respuesta.Code, respuesta.Message });
            }

            if (clientesDTO.IsNullOrZeroItems())
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No se encontró coincidencias" });
            }

            TokenDTO userData = TokenDTO.fromJson(respuesta.Data);

            try
            {
                List<Clientes> clientes = new();

                foreach (ClienteDTO clienteDto in clientesDTO)
                {
                    Clientes cliente = ClienteDTOToCliente(clienteDto);

                    cliente.IdVendedor = userData.IdUsuario;

                    clientes.Add(cliente);
                }

                var respuestaNegocio = negocio.GuardarActualizarLote(clientes);

                if (!respuestaNegocio.Ok)
                {
                    return Conflict(respuestaNegocio);
                }

                 return Ok(new { Message = "Registros Actualizados" } );

            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró actualizar la información" });
            }
        }

        // GET: api/v1/Clientes
        [HttpGet("{id:int}")]
        public ActionResult GetById(int id)
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
                var item = negocio.Consultar(userData.IdUsuario);
                if (item == null) return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message ="No se encontró coincidencias" });
                return Ok(ClienteToClienteDTO(item));
            }
            catch (Exception)
            {
                return Conflict(new { StatusCode = HttpStatusCode.NotFound, Message = "No logró consultar la información" });
            }
        }

        private ClienteDTO ClienteToClienteDTO(Clientes item)
        {
            return new ClienteDTO
            {
                IdCliente = item.IdCliente,
                Codigo = item.Codigo,
                Nombre = item.Nombre,
                Barrio = item.Barrio,
                Celular = item.Celular,
                Documento = item.NumeroDocumento,
                Estado = item.Estado
            };	
        }

        private Clientes ClienteDTOToCliente(ClienteDTO item)
        {
            return new Clientes
            {
                Codigo = item.Codigo,
                Nombre = item.Nombre,
                Barrio = item.Barrio,
                Celular = item.Celular,
                NumeroDocumento = item.Documento,
                Estado = item.Estado
            };
        }
    }
}
