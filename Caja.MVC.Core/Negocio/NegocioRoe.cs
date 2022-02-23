using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caja.MVC.Core.Negocio
{
    public class NegocioRoe
    {
        private readonly RepositorioRoe repositorioRoe = null;

        public NegocioRoe(IConfiguration pConfiguracion)
        {
            repositorioRoe = new RepositorioRoe(pConfiguracion);
        }

        public List<Listablas> ObtenerSeries()
        {
            return repositorioRoe.ObtenerSeries();
        }

        public List<Plenoautomatico> ObtenerFiguras()
        {
            return repositorioRoe.ObtenerFiguras();
        }

        public int ObtenerNumeroCartonesHoja()
        {
            return repositorioRoe.ObtenerNumeroCartonesHoja();
        }
    }
}
