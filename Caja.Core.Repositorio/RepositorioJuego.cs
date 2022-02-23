using Caja.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    public sealed class RepositorioJuego : RepositorioBase
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioUsuario"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioJuego(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        /// <summary>
        /// Obtener la información de un usuario
        /// </summary>
        /// <param name="id">Identificador unido del usuario.</param>
        /// <returns><see cref="Usuarios"/></returns>
        public Juegos Obtener(int id)
        {
            return Contexto.Juegos.Where(x => x.IdJuego == id).Include(r => r.Programacionjuegos).FirstOrDefault();
        }

        public Juegos ObtenerPorVendedor(int idJuego)
        {
            return Contexto.Juegos.Where(x => x.IdJuego == idJuego).Include(r => r.Programacionjuegos).FirstOrDefault();
        }

        public List<int>  ObtenerRangoJuegosVendedor(int idVendedor, int limite = 0)
        {
            var idJuegos = (from pj in Contexto.Programacionjuegos
                            join vh in Contexto.Vendedoreshojas on pj.IdProgramacionJuego equals vh.IdProgramacionJuego
                            where vh.IdVendedor == idVendedor
                            orderby pj.IdJuego descending
                            select pj.IdJuego).Distinct().Take(limite).ToList();

           // cambio el orden ya que se consulta en BD en orden descendiente
           return new List<int>() { idJuegos.LastOrDefault() ?? 0, idJuegos.FirstOrDefault() ?? 0 };
            
        }

        public IEnumerable<Juegos> ObtenerJuegosVendedor(int idVendedor, int limite = 0)
        {
            var idJuegos = (from pj in Contexto.Programacionjuegos
                            join vh in Contexto.Vendedoreshojas on pj.IdProgramacionJuego equals vh.IdProgramacionJuego
                            where vh.IdVendedor == idVendedor
                            orderby pj.IdJuego descending
                            select pj.IdJuego).Distinct().Take(limite).ToArray();

            var query = Contexto.Juegos
                    .Include("Programacionjuegos.Programacionjuegosfiguras")
                    .Where(j => idJuegos.Contains(j.IdJuego) );

            return query.ToList(); 
        }

        public IEnumerable<Juegos> ObtenerJuegosSocios(int limite = 0)
        {
            var query = Contexto.Juegos
                    .Include("Programacionjuegos.Programacionjuegosfiguras")
                    .Include(j => j.Configuracion)
                    .OrderByDescending(j => j.IdJuego)
                    .Take(limite);

            return query.ToList();
        }

        public Juegos ObtenerJuegoDetalle(int idJuego)
        {
            var query = Contexto.Juegos.Where(j => j.IdJuego.Equals(idJuego))
                    .Include("Programacionjuegos.Programacionjuegosfiguras")
                    .Include("Programacionjuegos.Vendedoresmodulos")
                    .Include(j => j.Configuracion)
                    .Include(j => j.Cartones)
                    .FirstOrDefault();
        
            return query;
        }

        /// <summary>
        /// Obtener un listado de los usuarios.
        /// </summary>        
        /// <returns>Listado de<see cref="Usuarios"/></returns>
        public IEnumerable<Juegos> Obtener()
        {
            return Contexto.Juegos.ToList();
        }
    }
}
