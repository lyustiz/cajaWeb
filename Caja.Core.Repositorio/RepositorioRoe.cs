using Caja.Core.Entidades;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    public sealed class RepositorioRoe : RepositorioBase
    {
        public RepositorioRoe(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        public string ObtenerSerieDefecto()
        {
            var serie = Contexto.Listablas.FirstOrDefault(x => x.Defecto == "S");

            if (serie == null)
                return string.Empty;

            return serie.Simbolo;
        }

        public List<Listablas> ObtenerSeries()
        {
            return Contexto.Listablas.ToList();           
        }

        public List<Plenoautomatico> ObtenerFiguras()
        {
            return Contexto.Plenoautomatico.ToList();
        }

        public int ObtenerNumeroCartonesHoja()
        {
            return int.Parse(Contexto.Parametrosgenerales.FirstOrDefault(x => x.Referencia == "Caja-CantidadCartonesHoja")?.Valor);
        }
    }
}
