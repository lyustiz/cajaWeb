using Caja.Datos;
using Caja.Entidades;
using Caja.Entidades.Vistas;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioRoe
    {
        readonly RepositorioRoe mRepositorio;
        public DominioRoe()
        {
            mRepositorio = new RepositorioRoe();
        }

        public List<TipoRelacion> FetchAllTiposRelacion()
        {
            return mRepositorio.FindAllTiposRelacion().ToList();
        }

        public List<Listabla> FindAllSeries()
        {
            return mRepositorio.FindAllSeries().ToList();
        }

        public Listabla FindSerie(int pIdSerie)
        {
            return mRepositorio.FindAllSeries().FirstOrDefault(x => x.IdLisTablas == pIdSerie);
        }

        public List<ItemLista> FindAllFiguras()
        {
            return mRepositorio.FindAllFiguras().ToList();
        }

        public List<ItemLista> FindAllConceptoGastos()
        {
            return mRepositorio.FindAllConceptoGastos().ToList();
        }

        public List<ItemLista> FindAllConceptoIngresos()
        {
            return mRepositorio.FindAllConceptoIngresos().ToList();
        }

        public List<ItemLista> FindAllSocios()
        {
            return mRepositorio.FindAllSocios().ToList();
        }

        public List<DefinicionMoneda> FindAllDefinicionMoneda()
        {
            return mRepositorio.FindAllDefinicionMoneda().ToList();
        }

        public List<VistaVendedorCobroCartones> FindAllVendedoresCobroCartones(int pIdProgramacion)
        {
            return mRepositorio.FindAllVendedoresCobroCartones(pIdProgramacion).ToList();
        }

        public List<VistaVendedorCobroCartones> FindAllVendedoresCobroCartones(int pIdProgramacion, int pIdUsuario)
        {
            return mRepositorio.FindAllVendedoresCobroCartones(pIdProgramacion, pIdUsuario).ToList();
        }

        public List<int> FindAllVendedoresCobroCartonesPorUsuario(int pIdUsuario)
        {
            return mRepositorio.FindAllVendedoresCobroCartonesPorUsuario(pIdUsuario).ToList();
        }

        public List<RecaudoTotal> FindRecaudoProgramacion(int pIdProgramacion)
        {
            return mRepositorio.FindRecaudoProgramacion(pIdProgramacion).ToList();
        }

        public List<FiguraProgramacion> FindFigurasProgramacion(int pIdProgramacion)
        {
            return mRepositorio.FindFigurasProgramacion(pIdProgramacion).ToList();
        }
    }
}
