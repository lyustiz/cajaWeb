using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioProgramacionDevolucionCodigoBarra : DominioBase
    {
        readonly RepositorioProgramacionDevolucionCodigoBarra mRepositorio;

        public DominioProgramacionDevolucionCodigoBarra(int pIdUsuario)
        {
            mRepositorio = new RepositorioProgramacionDevolucionCodigoBarra(pIdUsuario);
        }

        public List<ProgramacionDevolucionCodigoBarra> ObtenerPorVendedor(int pIdVendedor, int pIdProgramacion)
        {
            return mRepositorio.FindByVendedor(pIdVendedor, pIdProgramacion).ToList();
        }

        public List<ProgramacionDevolucionCodigoBarra> ObtenerPorProgramacion(int pIdProgramacion)
        {
            return mRepositorio.FindByProgramacion(pIdProgramacion).ToList();
        }

        public int Save(ProgramacionDevolucionCodigoBarra objEntidad)
        {
            if (objEntidad.IdDevolucionCodigoBarra > 0)
                return mRepositorio.Update(objEntidad);
            else
                return mRepositorio.Insert(objEntidad);
        }

        public void Eliminar(int pIdVendedor, int pIdProgramacion)
        {
            mRepositorio.Delete(pIdVendedor, pIdProgramacion);
        }
    }
}
