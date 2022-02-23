using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Caja.MVC.Core.Models;

namespace Caja.MVC.Core.Negocio
{
    public partial class NegocioConfiguracion
    {
        private readonly RepositorioConfiguracion repositorio = null;
        private readonly RepositorioJuego repositorioJuego = null;
        public NegocioConfiguracion(IConfiguration pConfiguracion)
        {
            repositorio = new RepositorioConfiguracion(pConfiguracion);
            repositorioJuego = new RepositorioJuego(pConfiguracion);
        }
        // <summary>
        /// Consultar un Configuracion.
        /// </summary>
        /// <param name="pIdConfiguracion">Identificador unido de configuracion.</param>        
        public Configuracion Consultar(int pIdConfiguracion)
        {
            return repositorio.Obtener(pIdConfiguracion);
        }
        
        // <summary>
        /// Consultar un Configuracion.
        /// </summary>
        /// <param name="pIdJuego">Identificador de juego.</param>        
        public Configuracion ConsultarPorIdJuego(int pIJuego)
        {
            return repositorio.ObtenerPorIdJuego(pIJuego);
        }

        public IEnumerable<Configuracion> Consultar()
        {
            return repositorio.Obtener();
        }

        public RespuestaNegocio<ConfiguracionModel> Guardar(Configuracion registro)
        {
            RespuestaNegocio<ConfiguracionModel> respuesta = new();
            ConfiguracionModel modelo = new();
            modelo.ToModel(registro);
            Validar(modelo, respuesta);

            Juegos juego = repositorioJuego.Obtener(registro.NumeroJuego);

            if (juego.Terminado == "S") {
                respuesta.RespuestaError("Juego Terminado");
            }

            if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                return respuesta;

            var operacion = modelo.Id > 0 ? repositorio.Modificar(registro) : repositorio.Insertar(registro);

            if (operacion)
                respuesta.RespuestaOK(modelo);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

        public Configuracion GuardarRetornar(Configuracion registro)
        {
            RespuestaNegocio<ConfiguracionModel> respuesta = new();
            ConfiguracionModel modelo = new();
            modelo.ToModel(registro);
            Validar(modelo, respuesta);

            Juegos juego = repositorioJuego.Obtener(registro.NumeroJuego);

            if (juego.Terminado == "S")
            {
                respuesta.RespuestaError("Juego Terminado");
            }

            if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                return null;

            return repositorio.InsertarRetornar(registro);
        }



        public RespuestaNegocio<ConfiguracionModel> Actualizar(Configuracion registro)
        {
            RespuestaNegocio<ConfiguracionModel> respuesta = new();
            ConfiguracionModel modelo = new();
            modelo.ToModel(registro);
            Validar(modelo, respuesta);

            Juegos juego = repositorioJuego.Obtener(registro.NumeroJuego);

            if (juego.Terminado == "S")
            {
                respuesta.RespuestaError("Juego Terminado");
            }

            if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                return respuesta;

            var operacion = repositorio.Modificar(registro);

            if (operacion)
                respuesta.RespuestaOK(modelo);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

        private void Validar(ConfiguracionModel model, RespuestaNegocio<ConfiguracionModel> respuesta)
        {
            respuesta.Mensaje = string.Empty;
            respuesta.Ok = true;
        }



    }
}
