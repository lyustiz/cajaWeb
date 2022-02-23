using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioVendedorResumen : DominioBase
    {
        readonly RepositorioVendedorResumen mRepositorio;

        public DominioVendedorResumen(int pIdUsuario)
        {
            mRepositorio = new RepositorioVendedorResumen(pIdUsuario);
        }

        public VendedorResumen ObtenerResumenVendedor(int pIdVendedor, int pIdProgramacion)
        {
            return mRepositorio.FindByVendedorProgramacion(pIdVendedor, pIdProgramacion);
        }

        public List<VendedorResumen> ObtenerResumenProgramacion(int pIdProgramacion)
        {
            return mRepositorio.FindByProgramacion(pIdProgramacion).ToList();
        }

        public VendedorResumen ObtenerResumen(int pId)
        {
            return mRepositorio.FindOne(pId);
        }

        public RespuestaDominio RegistrarResumenVendedor(VendedorResumen objVendedorResumen)
        {
            int codigo = objVendedorResumen.IdVendedorResumen == 0 ? 
                mRepositorio.Insert(objVendedorResumen) : 
                mRepositorio.Update(objVendedorResumen);

            if (codigo > 0)
            {
                return Ok($"La informacion de registro correctamente.", codigo);
            }
            else
                return Error("No se registro el resumen, por favor intentelo de nuevo");

        }
    }
}


