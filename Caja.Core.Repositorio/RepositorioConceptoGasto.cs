using Caja.Core.Entidades;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    /// <summary>
    /// Clase de acceso a datos para concepto gastos.
    /// </summary>
    public sealed class RepositorioConceptoGasto : RepositorioBase
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioConceptoGasto"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioConceptoGasto(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        /// <summary>
        /// Obtener la información de los conceptos gastos.
        /// </summary>        
        /// <returns><see cref="Conceptogastos"/></returns>
        public IOrderedEnumerable<Conceptogastos> ObtenerConceptos()
        {
            return Contexto.Conceptogastos.ToList().OrderBy(x => x.IdConceptoGasto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaConceptos"></param>
        /// <returns></returns>
        public bool GuardarConceptos(IEnumerable<Conceptogastos> listaConceptos)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {   
                foreach (Conceptogastos concepto in listaConceptos)
                {
                    Conceptogastos existente = Contexto.Conceptogastos.Find(concepto.IdConceptoGasto);

                    existente.ValorMaximo = concepto.ValorMaximo;
                    existente.Controlado = concepto.Controlado;

                    Contexto.Conceptogastos.Update(existente);                    
                }

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

