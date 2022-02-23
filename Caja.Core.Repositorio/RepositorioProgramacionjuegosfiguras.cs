using Caja.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    public class RepositorioProgramacionjuegosfiguras : RepositorioBase
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioProgramacionjuegosfiguras"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioProgramacionjuegosfiguras(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        ///// <summary>
        ///// Obtener un listado de los usuarios.
        ///// </summary>        
        ///// <returns>Listado de<see cref="Usuarios"/></returns>
        //public IEnumerable<Programacionjuegosfiguras> Obtener()
        //{
        //    return Contexto.Programacionjuegosfiguras.ToList();
        //}

        //public IEnumerable<Programacionjuegosfiguras> Find()
        //{
        //    return Contexto.Programacionjuegosfiguras.OrderByDescending(x => x.IdProgramacionJuegoFigura);
        //}

        //public Programacionjuegosfiguras Find(int id)
        //{
        //    return Contexto.Programacionjuegosfiguras.Find(id);
        //}

        //public IEnumerable<Programacionjuegosfiguras> Find(string estado)
        //{
        //    if (string.IsNullOrWhiteSpace(estado))
        //        return Find();

        //    var listado = Contexto.Programacionjuegosfiguras.Include(x => x.Programacionjuegosfigurasfiguras).OrderBy(x => x.IdProgramacionjuegosfiguras).Where(x => x.Estado == estado);
                        
        //    return listado;
        //}

        //public IEnumerable<Programacionjuegosfigurasfiguras> ObtenerFiguras(int pIdProgramacion)
        //{
        //    return Contexto.Programacionjuegosfigurasfiguras.Include(x => x.IdPlenoAutomaticoNavigation).Where(x => x.IdProgramacionjuegosfiguras == pIdProgramacion).ToList();
        //}

        //public IEnumerable<VProgramacionjuegosfigurasvendedores> FindProgramacionjuegosfigurasHojas(string filtro)
        //{
        //    if (string.IsNullOrWhiteSpace(filtro))
        //        return Contexto.VProgramacionjuegosfigurasvendedores.ToList();
        //    else
        //    {
        //        return Contexto.VProgramacionjuegosfigurasvendedores.Where(x => x.Nombres.Contains(filtro) || x.Apellidos.Contains(filtro) || x.Documento.Contains(filtro) || x.Celular.Contains(filtro)).ToList();
        //    }          
        //}

        //public int SiguienteIdProgramacion()
        //{
        //    var ultimo =  Contexto.Programacionjuegosfiguras.Max(x => x.IdProgramacionjuegosfiguras);
            
        //    return ultimo + 1;
        //}

        //public bool Insertar(Programacionjuegosfiguras registro)
        //{
        //    using var transaction = Contexto.Database.BeginTransaction();

        //    try
        //    {
        //        Contexto.Programacionjuegosfiguras.Add(registro);
        //        Contexto.SaveChanges();
        //        transaction.Commit();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        transaction.Rollback();
        //        return false;
        //    }
        //}
    }
}
