using Caja.Core.Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    /// <summary>
    /// Clase de acceso a datos de parametros generales.
    /// </summary>
    public sealed class RepositorioParametroGeneral : RepositorioBase
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioParametroGeneral"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioParametroGeneral(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        /// <summary>
        /// Obtener la información de un usuario
        /// </summary>
        /// <param name="referencia">Referencia única del parametro.</param>
        /// <returns><see cref="Parametrosgenerales"/></returns>
        public Parametrosgenerales Obtener(string referencia)
        {
            return Contexto.Parametrosgenerales.FirstOrDefault(x => x.Referencia == referencia);
        }

        public IEnumerable<Parametrosgenerales> Obtener()
        {
            return Contexto.Parametrosgenerales.ToList();
        }

        public bool ModificarMoneda(Parametrosgenerales registroMoneda, Parametrosgenerales registroFormato)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Contexto.Parametrosgenerales.Update(registroMoneda);
                Contexto.SaveChanges();

                Contexto.Parametrosgenerales.Update(registroFormato);
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
    }
}

