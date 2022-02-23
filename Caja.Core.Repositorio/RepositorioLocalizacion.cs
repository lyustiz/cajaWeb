using Caja.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    /// <summary>
    /// Clase de acceso a datos de tablas de localizacion (Paises, Ciudades).
    /// </summary>
    public sealed class RepositorioLocalizacion : RepositorioBase
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioLocalizacion"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioLocalizacion(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        #region Paises
        
        /// <summary>
        /// Obtener la lista de paises.
        /// </summary>  
        public IEnumerable<Paises> ObtenerPaises(bool pIncluirCiudades = false)
        {
            if (pIncluirCiudades)
                return Contexto.Paises.Include(x => x.Ciudades).ToList();
            else
                return Contexto.Paises.ToList();
        }       

        /// <summary>
        /// Obtener un pais.
        /// </summary>  
        public Paises ObtenerPais(int idPais)
        {
            return Contexto.Paises.Find(idPais);
        }

        public Paises ObtenerPais(string pNombre)
        {
            return Contexto.Paises.Where(x => x.Descripcion == pNombre).FirstOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public bool ModificarPais(Paises registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Contexto.Paises.Update(registro);
                Contexto.SaveChanges();              

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public bool CrearPais(Paises registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Contexto.Paises.Add(registro);
                Contexto.SaveChanges();

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }

        #endregion

        #region Ciudades

        /// <summary>
        /// Obtener la lista de ciudades.
        /// </summary>  
        public IEnumerable<Ciudades> ObtenerCiudades(int pIdPais = 0)
        {
            if (pIdPais > 0)
                return Contexto.Ciudades.Include(x => x.IdPaisNavigation).Where(x => x.IdPais == pIdPais).ToList();
            else
                return Contexto.Ciudades.Include(x => x.IdPaisNavigation).ToList();
        }

        /// <summary>
        /// Obtener una ciudad.
        /// </summary>  
        public Ciudades ObtenerCiudad(int idCiudad)
        {
            return Contexto.Ciudades.Include(x => x.IdPaisNavigation).FirstOrDefault(x => x.IdCiudad == idCiudad);
        }

        public Ciudades ObtenerCiudad(string pNombre)
        {
            return Contexto.Ciudades.Include(x => x.IdPaisNavigation).Where(x => x.Descripcion == pNombre).FirstOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public bool ModificarCiudad(Ciudades registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Contexto.Ciudades.Update(registro);
                Contexto.SaveChanges();

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="registro"></param>
        /// <returns></returns>
        public bool CrearCiudad(Ciudades registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Contexto.Ciudades.Add(registro);
                Contexto.SaveChanges();

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }

        #endregion
    }
}

