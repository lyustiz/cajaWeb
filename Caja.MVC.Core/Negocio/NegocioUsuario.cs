using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Caja.MVC.Core.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caja.MVC.Core.Negocio
{
    public sealed class NegocioUsuario
    {
        private readonly RepositorioUsuario repositorio = null;

        public NegocioUsuario(IConfiguration pConfiguracion)
        {
            repositorio = new RepositorioUsuario(pConfiguracion);
        }

        public UsuarioModel NuevoUsuario()
        {
            var modelo = new UsuarioModel();
            var perfiles = repositorio.ObtenerPerfiles();

            foreach (var perfil in perfiles)
            {
                var perfilModelo = new PerfilModel() { Id = perfil.IdPerfil, Nombre = perfil.Nombre, Seleccionado = false };
                modelo.Perfiles.Add(perfilModelo);
            }

            return modelo;
        }

        public UsuarioModel ConsultarUsuario(int id)
        {            
            var usuario = repositorio.Obtener(id);
            var modelo = new UsuarioModel().ToModel(usuario);

            var perfilesUsuario = repositorio.ObtenerPerfilesUsuario(id).ToList();
            var perfiles = repositorio.ObtenerPerfiles().ToList();

            foreach (var perfil in perfiles)
            {
                var perfilModelo = new PerfilModel() { Id = perfil.IdPerfil, Nombre = perfil.Nombre, Seleccionado = false };

                if (perfilesUsuario.Exists(x => x.IdPerfil == perfil.IdPerfil))
                    perfilModelo.Seleccionado = true;

                modelo.Perfiles.Add(perfilModelo);
            }

            return modelo;
        }

        public IEnumerable<Usuarios> ConsultarUsuarios()
        {
            return repositorio.Obtener();
        }

        /// <summary>
        /// Obtener la información de un usuario
        /// </summary>
        /// <param name="login">Login unico del usuario.</param>
        /// <param name="clave">Clave del usuario.</param>
        /// <returns><see cref="Usuarios"/></returns>
        public RespuestaNegocio<LoginModel> Validar(LoginModel modelo)
        {
            Usuarios usuario = repositorio.Obtener(modelo.Usuario);
            RespuestaNegocio<LoginModel> respuesta = new RespuestaNegocio<LoginModel>();

            if (usuario is null)
            {
                respuesta.RespuestaNull("El usuario no existe.");
                return respuesta;
            }                

            if (NegocioCommon.Encriptar(modelo.Contrasena) != usuario.Clave)
            {
                respuesta.RespuestaError("La contrase no coincide.");
                return respuesta;
            }
            var texto = NegocioCommon.DesEncriptar("MQAyADMANAA1ADYA");

            modelo.Id = usuario.IdUsuario;
            modelo.NombreCompleto = usuario.NombreCompleto;

            respuesta.RespuestaOK(modelo);

            return respuesta;
        }

        /// <summary>
        /// Consultar la lista de usuarios con perfil Socios.
        /// </summary>        
        /// <returns><see cref="IEnumerable<Usuarios>"/></returns>
        public IEnumerable<SocioModel> ConsultarSocios()
        {
            return new SocioModel().ToModelList(repositorio.ObtenerSocios());     
        }

        public RespuestaNegocio<IEnumerable<SocioModel>> GuardarPorcentajes(IEnumerable<SocioModel> listaModelo)
        {
            RespuestaNegocio<IEnumerable<SocioModel>> respuesta = new();
            ValidarDatos(listaModelo, respuesta);

            if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                return respuesta;

            List<Usuarios> listaUsuarios = new();

            foreach (var modelo in listaModelo)
            {
                Usuarios concepto = new()
                {
                    IdUsuario = modelo.Id,
                    Porcentaje = modelo.Porcentaje
                };

                listaUsuarios.Add(concepto);
            }

            var operacion = repositorio.GuardarPorcentaje(listaUsuarios);

            if (operacion)
                respuesta.RespuestaOK(listaModelo);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

        public RespuestaNegocio<UsuarioModel> GuardarUsuario(UsuarioModel modelo)
        {
            RespuestaNegocio<UsuarioModel> respuesta = new();
            ValidarUsuario(modelo, respuesta);

            if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                return respuesta;

            var usuario = new Usuarios()
            {
                IdUsuario = modelo.Id,
                Login = modelo.Usuario,
                NombreCompleto = modelo.NombreCompleto,
                Estado = "H",
                Clave = NegocioCommon.Encriptar(modelo.Clave),
                ClaveAjustes = NegocioCommon.Encriptar(modelo.Clave),
                FechaCreacion = DateTime.Now,
                Autenticado = false,
                EsSocio = modelo.Perfiles.Exists(x => x.Id == 8),
                ModificaPremios = false,
                Porcentaje = 0
            };

            var perfilesUsuario = new List<Perfilesusuario>();

            foreach (var perfil in modelo.Perfiles)
            {
                if (perfil.Seleccionado)                
                    perfilesUsuario.Add(new Perfilesusuario() { IdPerfil = perfil.Id, IdUsuario = 0});                
            }

            if (!string.IsNullOrWhiteSpace(modelo.ClaveAjustes))
            {
                usuario.ClaveAjustes = NegocioCommon.Encriptar(modelo.ClaveAjustes);
            }

            var operacion = modelo.Id > 0 ? repositorio.Modificar(usuario, perfilesUsuario) : repositorio.Insertar(usuario, perfilesUsuario);

            if (operacion)
                respuesta.RespuestaOK(modelo);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

        public RespuestaNegocio<bool> CambiarEstado(int idUsuario)
        {
            RespuestaNegocio<bool> respuesta = new();
           
            var operacion = repositorio.ModificarEstado(idUsuario);

            if (operacion)
                respuesta.RespuestaOK(operacion);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

        private void ValidarDatos(IEnumerable<SocioModel> listaModelo, RespuestaNegocio<IEnumerable<SocioModel>> respuesta)
        {
            respuesta.Mensaje = string.Empty;
            respuesta.Ok = true;

            var totalPorcentajes = listaModelo.Sum(x => x.Porcentaje);

            if (totalPorcentajes > 100)
            {
                respuesta.Ok = false;
                respuesta.Mensaje = $"La suma total de porcentaje no puede superar el 100% entre los socios.";                
            }            
        }

        public Usuarios login(string celular, string password)
        {
            return repositorio.login(celular, password);
        }

        private void ValidarUsuario(UsuarioModel model, RespuestaNegocio<UsuarioModel> respuesta)
        {
            respuesta.Mensaje = string.Empty;
            respuesta.Ok = true;                      
        }       
    }
}
