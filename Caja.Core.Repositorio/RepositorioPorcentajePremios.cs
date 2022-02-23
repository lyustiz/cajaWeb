using Caja.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace Caja.Core.Repositorio
{
    /// <summary>
    /// Clase de acceso a datos de porcentaje premios.
    /// </summary>
    public sealed class RepositorioPorcentajePremios : RepositorioBase
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioPorcentajePremios"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioPorcentajePremios(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        /// <summary>
        /// Obtener la información de la parametrizacion activa.
        /// </summary>        
        /// <returns><see cref="Porcentajepremios"/></returns>
        public Porcentajepremios Obtener()
        {
            return Contexto.Porcentajepremios.FirstOrDefault(x => x.Estado == "A");
        }

        public bool GuardarParametrizacion(Porcentajepremios IdPorcentajePremio)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Contexto.Database.ExecuteSqlRaw("UPDATE porcentajepremios set Estado = 'I' WHERE IdPorcentajePremio > 0;");
                Contexto.Porcentajepremios.Add(IdPorcentajePremio);
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

