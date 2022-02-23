using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Caja.MVC.Core.Negocio
{
    public partial class NegocioJuego
    {
        private readonly RepositorioJuego repositorio = null;
        public NegocioJuego(IConfiguration pConfiguracion)
        {
            repositorio = new RepositorioJuego(pConfiguracion);
        }
        // <summary>
        /// Consultar un Juego.
        /// </summary>
        /// <param name="pIdVendedor">Identificador unido de un vendedor.</param>        
        public Juegos Consultar(int pIdJuego)
        {
            return repositorio.Obtener(pIdJuego);
        }

        public IEnumerable<Juegos> Consultar(int idUsuario, char tipoUsuario, int limite = 15)
        {
            if (tipoUsuario == 'V')
            { 
                return repositorio.ObtenerJuegosVendedor(idUsuario, limite);
            }

            if (tipoUsuario == 'S')
            {
                return repositorio.ObtenerJuegosSocios(limite);
            }

            return null;
        }

        public JuegoInforme ConsultarJuegoDetalle(int IdJuego)
        {
            Juegos juego = repositorio.ObtenerJuegoDetalle(IdJuego);
            JuegoInforme juegoInforme = new();

            if (juego == null)
            {
                return juegoInforme;
            }

            var cartones = juego.Cartones;
             
            int totalCartones = cartones.Where( c => c.IdModulo is null ).Count();

            int cartonesAsignados = cartones.Where(c => c.IdModulo is null).Where(c => c.Idvendedor is not null).Count();

            int cartonesVendidos = cartones.Where(c => c.IdModulo is null).Where(c => c.Estado == "V").Count();

            int totalModulos = cartones.Select(c => new { c.IdModulo })
                                       .Where(c => c.IdModulo is not null).Distinct().Count();

            int modulosAsignados = cartones.Select(c => new { c.IdModulo, c.Idvendedor })
                                          .Where(c => c.IdModulo is not null)
                                          .Where(c => c.Idvendedor is not null).Distinct().Count();

            int modulosVendidos = cartones.Select(c => new { c.IdModulo, c.Estado })
                                          .Where(c => c.IdModulo is not null)
                                          .Where(c => c.Estado == "V").Distinct().Count();

            int numeroVendedores = cartones.Select(c => new { c.Idvendedor }).Distinct().Count();

            juegoInforme = new JuegoInforme()
            {
                IdJuego = juego.IdJuego,
                FechaHoraInicio = juego.FechaHoraInicio,
                FechaHoraFin = juego.FechaHoraFin,
                Duracion = juego.Duracion,
                IdEmpresa = juego.IdEmpresa,
                Terminado = juego.Terminado,
                IdUsuario = juego.IdUsuario,
                totalCartones = totalCartones,
                cartonesAsignados = cartonesAsignados,
                cartonesVendidos = cartonesVendidos,
                totalModulos = totalModulos,
                modulosAsignados = modulosAsignados,
                modulosVendidos = modulosVendidos,
                numeroVendedores = numeroVendedores,
                Configuracion = juego.Configuracion,
                Programacionjuegos = juego.Programacionjuegos
            }; 

            return juegoInforme;
        }

        public IEnumerable<Juegos> Consultar()
        {
            return repositorio.Obtener();
        }
    }
}
