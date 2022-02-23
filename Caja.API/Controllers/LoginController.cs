using AutoMapper;
using Caja.API.Auth;
using Caja.API.DTO;
using Caja.MVC.Core.Negocio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;

namespace Caja.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LoginController : ControllerBase
    {
        public IConfiguration Configuration { get; }

        readonly NegocioVendedor negocioVendedor;
        readonly NegocioUsuario negocioUsuario;
        private readonly ILogger<LoginController> _logger;
        private readonly IJwtAuthenticationService _authService;
        private readonly IMapper _mapper;

        public LoginController( IConfiguration configuration
            , ILogger<LoginController> logger
            , IJwtAuthenticationService authService
            , IMapper mapper)
        {
            Configuration = configuration;
            _logger = logger;
            negocioVendedor = new NegocioVendedor(Configuration);
            negocioUsuario = new NegocioUsuario(Configuration);
            _authService = authService;
            _mapper = mapper;

        }

        [AllowAnonymous]
        [HttpGet]
        public object Get()
        {
            var responseObject = new { Status = "Running" };
            _logger.LogInformation($"Status: {responseObject.Status}");
            return responseObject;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserRequestDTO user)
        {
            UsuarioDTO usuarioDTO = loginUsuarioTipo( user );

            if (usuarioDTO.IdUsuario == 0)
            {
                return Unauthorized();
            }
            string token = _authService.Authenticate(usuarioDTO);
 
            Response.Headers.Add("authorization", token);

            return Ok(usuarioDTO);
        }

        private UsuarioDTO loginUsuarioTipo(UserRequestDTO login)
        {
            UsuarioDTO usuarioDTO = new UsuarioDTO();
            usuarioDTO.IdUsuario = 0;
            usuarioDTO.Actualizado = DateTime.Now;
            usuarioDTO.TipoUsuario = login.TipoUsuario;

            if (string.IsNullOrEmpty(login.Usuario) || string.IsNullOrEmpty(login.Password))
            {
                return usuarioDTO;
            }

            if (login.TipoUsuario == 'V') 
            {
               var usuario = negocioVendedor.login(login.Usuario, login.Password);
                if (usuario != null)
                {
                    usuarioDTO = _mapper.Map<UsuarioDTO>(usuario);
                    usuarioDTO.IdUsuario = usuario.IdVendedor;
                    usuarioDTO.TipoUsuario = 'V';
                }
                
            }

            if (login.TipoUsuario == 'S')
            { 
                var usuario = negocioUsuario.login(login.Usuario, login.Password);
                if (usuario != null)
                {
                    usuarioDTO.IdUsuario = usuario.IdUsuario;
                    usuarioDTO.Nombres = usuario.NombreCompleto;
                    usuarioDTO.TipoUsuario = 'S';
                    usuarioDTO.Estado = usuario.Estado;
                    usuarioDTO.FechaIngreso = usuario.FechaUltimoIngreso;
                    usuarioDTO.FechaCreacion = usuario.FechaCreacion;
                }
            }

            usuarioDTO.Actualizado = DateTime.Now;

            return usuarioDTO;
        }



    }
}
