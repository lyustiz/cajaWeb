using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Caja.MVC.Core.Models;
using Microsoft.Extensions.Configuration;

namespace Caja.MVC.Core.Negocio
{
    public sealed class NegocioPorcentajePremios
    {
        private readonly RepositorioPorcentajePremios repositorio = null;

        public NegocioPorcentajePremios(IConfiguration pConfiguracion)
        {
            repositorio = new RepositorioPorcentajePremios(pConfiguracion);
        }

        /// <summary>
        /// Consultar la información de la parametrizacion de porcentajes.
        /// </summary>        
        /// <returns><see cref="Porcentajepremios"/></returns>
        public Porcentajepremios Consultar()
        {
            return repositorio.Obtener();
        }

        public RespuestaNegocio<PorcentajePremioModel> GuardarParametrizacion(PorcentajePremioModel modelo)
        {
            RespuestaNegocio<PorcentajePremioModel> respuesta = new();
            ValidarDatos(modelo, respuesta);

            if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                return respuesta;

            Porcentajepremios registro = new()
            {
                ActivoDescuento = modelo.ActivoDescuento ? (short)1 : (short)0,
                Premio1Porcentaje = modelo.Premio1Porcentaje,
                Premio1Cartones = modelo.Premio1Cartones,
                Premio2Porcentaje = modelo.Premio2Porcentaje,
                Premio2Cartones = modelo.Premio2Cartones,
                Premio3Porcentaje = modelo.Premio3Porcentaje,
                Premio3Cartones = modelo.Premio3Cartones,
                Premio4Porcentaje = modelo.Premio4Porcentaje,
                Premio4Cartones = modelo.Premio4Cartones,
                Premio5Porcentaje = modelo.Premio5Porcentaje,
                Premio5Cartones = modelo.Premio5Cartones,
                IdUsuario = modelo.IdUsuario,
                Estado = "A"
            };

            var operacion = repositorio.GuardarParametrizacion(registro);

            if (operacion)
                respuesta.RespuestaOK(modelo);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

        private void ValidarDatos(PorcentajePremioModel data, RespuestaNegocio<PorcentajePremioModel> respuesta)
        {
            respuesta.Mensaje = string.Empty;
            respuesta.Ok = true;

            if (data.Premio1Cartones >= data.Premio2Cartones)
            {
                respuesta.Ok = false;
                respuesta.Mensaje = "La cantidad de cartones para el premio 1, debe ser menor que la cantidad de cartones para el premio 2";
            }
            else if (data.Premio2Cartones >= data.Premio3Cartones)
            {
                respuesta.Ok = false;
                respuesta.Mensaje = "La cantidad de cartones para el premio 2, debe ser menor que la cantidad de cartones para el premio 3";
            }
            else if (data.Premio3Cartones >= data.Premio4Cartones)
            {
                respuesta.Ok = false;
                respuesta.Mensaje = "La cantidad de cartones para el premio 3, debe ser menor que la cantidad de cartones para el premio 4";
            }
            else if (data.Premio4Cartones >= data.Premio5Cartones)
            {
                respuesta.Ok = false;
                respuesta.Mensaje = "La cantidad de cartones para el premio 4, debe ser menor que la cantidad de cartones para el premio 5";
            } 
        }
    }
}


