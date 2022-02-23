using Caja.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    public class RepositorioProgramacionJuego : RepositorioBase
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioProgramacionJuego"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioProgramacionJuego(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        /// <summary>
        /// Obtener un listado de los usuarios.
        /// </summary>        
        /// <returns>Listado de<see cref="Usuarios"/></returns>
        public IEnumerable<Programacionjuegos> Obtener()
        {
            return Contexto.Programacionjuegos.ToList();
        }

        public IEnumerable<Programacionjuegos> Find()
        {
            return Contexto.Programacionjuegos.OrderByDescending(x => x.IdProgramacionJuego);
        }

        public Programacionjuegos Find(int id)
        {
            return Contexto.Programacionjuegos.Find(id);
        }

        public IEnumerable<Programacionjuegos> Find(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
                return Find();

            var listado = Contexto.Programacionjuegos.Include(x => x.Programacionjuegosfiguras).OrderBy(x => x.IdProgramacionJuego).Where(x => x.Estado == estado);
                        
            return listado;
        }

        public IEnumerable<Programacionjuegosfiguras> ObtenerFiguras(int pIdProgramacion)
        {
            return Contexto.Programacionjuegosfiguras.Include(x => x.IdPlenoAutomaticoNavigation).Where(x => x.IdProgramacionJuego == pIdProgramacion).ToList();
        }

        public IEnumerable<Vprogramacionjuegovendedores> FindProgramacionJuegoHojas(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
                return Contexto.Vprogramacionjuegovendedores.ToList();
            else
            {
                return Contexto.Vprogramacionjuegovendedores.Where(x => x.Nombres.Contains(filtro) || x.Apellidos.Contains(filtro) || x.Documento.Contains(filtro) || x.Celular.Contains(filtro)).ToList();
            }          
        }

        public int SiguienteIdProgramacion()
        {
            var ultimo =  Contexto.Programacionjuegos.Max(x => x.IdProgramacionJuego);
            
            return ultimo + 1;
        }

        public bool Insertar(Programacionjuegos registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Contexto.Programacionjuegos.Add(registro);
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
    }
}
