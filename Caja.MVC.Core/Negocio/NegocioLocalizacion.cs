using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Caja.MVC.Core.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Caja.MVC.Core.Negocio
{
    public sealed class NegocioLocalizacion
    {
        private readonly RepositorioLocalizacion repositorio = null;

        public NegocioLocalizacion(IConfiguration pConfiguracion)
        {
            repositorio = new RepositorioLocalizacion(pConfiguracion);
        }

        #region Paises

        /// <summary>
        /// Consultar el listado de paises.
        /// </summary>        
        public IEnumerable<Paises> ConsultarPaises(bool pIncluirCiudades = false)
        {
            return repositorio.ObtenerPaises(pIncluirCiudades);
        }        
        
        /// <summary>
        /// Consultar un pais.
        /// </summary>        
        public Paises ConsultarPais(int idPais)
        {
            return repositorio.ObtenerPais(idPais);
        }

        public RespuestaNegocio<PaisModel> GuadarPais(PaisModel modelo)
        {
            RespuestaNegocio<PaisModel> respuesta = new RespuestaNegocio<PaisModel>();
            bool operacion = false;

            Paises registro = new()
            {
                IdPais = modelo.IdPais,
                Descripcion = modelo.Nombre
            };

            // Validar que no exista un pais con el mismo nombre.
            var existe = repositorio.ObtenerPais(registro.Descripcion);

            if (registro.IdPais > 0)
            {
                if (existe == null || existe.IdPais == registro.IdPais)
                {
                    if (existe != null && existe.IdPais == registro.IdPais)
                        operacion = true;
                    else
                        operacion = repositorio.ModificarPais(registro);

                    if (!operacion)
                        respuesta.RespuestaError("No se logro modificar la información. Intentelo nuevamente.");
                }
                else
                    respuesta.RespuestaError("Ya existe un país con el mismo nombre.");
            }
            else
            {
                if (existe == null)
                {
                    operacion = repositorio.CrearPais(registro);

                    if (!operacion)                    
                        respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");
                }
                    
                else
                    respuesta.RespuestaError("Ya existe un país con el mismo nombre.");
            }                       

            if (operacion)
                respuesta.RespuestaOK(modelo);            

            return respuesta;
        }

        #endregion

        #region Ciudades

        /// <summary>
        /// Consultar el listado de ciudades.
        /// </summary>        
        public IEnumerable<Ciudades> ConsultarCiudades(int pIdPais)
        {
            return repositorio.ObtenerCiudades(pIdPais);
        }

        /// <summary>
        /// Consultar una ciudad.
        /// </summary>        
        public Ciudades ConsultarCiudad(int idCiudad)
        {
            return repositorio.ObtenerCiudad(idCiudad);
        }

        public RespuestaNegocio<CiudadModel> GuadarCiudad(CiudadModel modelo)
        {
            RespuestaNegocio<CiudadModel> respuesta = new RespuestaNegocio<CiudadModel>();
            bool operacion = false;

            Ciudades registro = new()
            {
                IdPais = modelo.IdPais,
                IdCiudad = modelo.IdCiudad,
                Descripcion = modelo.Nombre
            };

            // Validar que no exista una ciudad con el mismo nombre.
            var existe = repositorio.ObtenerCiudad(registro.Descripcion);

            if (registro.IdCiudad > 0)
            {
                if (existe == null || existe.IdCiudad == registro.IdCiudad)
                {
                    if (existe != null && existe.IdCiudad == registro.IdCiudad)
                        operacion = true;
                    else
                        operacion = repositorio.ModificarCiudad(registro);

                    if (!operacion)
                        respuesta.RespuestaError("No se logro modificar la información. Intentelo nuevamente.");
                }
                else
                    respuesta.RespuestaError("Ya existe una ciudad con el mismo nombre.");
            }
            else
            {
                if (existe == null)
                {
                    operacion = repositorio.CrearCiudad(registro);

                    if (!operacion)
                        respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");
                }

                else
                    respuesta.RespuestaError("Ya existe una ciudad con el mismo nombre.");
            }

            if (operacion)
                respuesta.RespuestaOK(modelo);

            return respuesta;
        }

        #endregion
    }
}


