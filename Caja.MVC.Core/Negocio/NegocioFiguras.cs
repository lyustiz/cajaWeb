using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Caja.MVC.Core.Negocio
{
    public class NegocioFiguras
    {
        private RepositorioFigurasPA repositorioFigurasPA = null;
        private RepositorioFigurasPJ repositorioFigurasPJ = null;

        public NegocioFiguras(IConfiguration pConfiguracion)
        {
           
        }
        public List<FiguraPA> ObtenerFigurasPleanoAutomatico()
        {
            repositorioFigurasPA = new RepositorioFigurasPA();
            return repositorioFigurasPA.Obtener().ToList();
        }
        public List<FiguraPJ> ObtenerFigurasProgramacionJuegos(int idJuego)
        {
            repositorioFigurasPJ = new RepositorioFigurasPJ();
            return repositorioFigurasPJ.ObtenerbyIdJuego(idJuego).ToList();
        }

    }
}
