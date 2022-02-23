using Caja.Core.Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    public sealed class RepositorioConfiguracion : RepositorioBase
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioUsuario"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioConfiguracion(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        /// <summary>
        /// Obtener la información de un usuario
        /// </summary>
        /// <param name="id">Identificador unido del usuario.</param>
        /// <returns><see cref="Usuarios"/></returns>
        public Configuracion Obtener(int id)
        {
            return Contexto.Configuracion.Where(x => x.IdConfiguracion == id).FirstOrDefault();
        }

        public Configuracion ObtenerPorIdJuego(int pIJuego)
        {
            return Contexto.Configuracion.Where(x => x.NumeroJuego == pIJuego).FirstOrDefault();
        }

        /// <summary>
        /// Obtener un listado de los usuarios.
        /// </summary>        
        /// <returns>Listado de<see cref="Usuarios"/></returns>
        public IEnumerable<Configuracion> Obtener()
        {
            return Contexto.Configuracion.ToList();
        }


        public bool Modificar(Configuracion registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                var registroUp = Contexto.Configuracion.Find(registro.IdConfiguracion);

                registroUp.Carton = registro.Carton;
                registroUp.Serie = registro.Serie;
                registroUp.Balotas = registro.Balotas;
                registroUp.Estado = registro.Estado;
                registroUp.FechaModificacion = DateTime.Now;
                registroUp.Reconfigurado = 1;

                Contexto.Configuracion.Update(registroUp);
                Contexto.SaveChanges();
                transaction.Commit();

                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }

        public bool Insertar(Configuracion registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                registro.FechaRegistro = DateTime.Now;
                registro.FechaModificacion = null;
                registro.Reconfigurado = 0;

                Contexto.Configuracion.Add(registro);
                Contexto.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }

        public Configuracion InsertarRetornar(Configuracion registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                registro.FechaRegistro = DateTime.Now;
                registro.FechaModificacion = null;
                registro.Reconfigurado = 0;
                Contexto.Configuracion.Add(registro);
                Contexto.SaveChanges();
                transaction.Commit();

                return registro;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return null;
            }
        }
    }
}
