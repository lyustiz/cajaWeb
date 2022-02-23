using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioVendedorCuentaCobrar : DominioBase
    {
        readonly RepositorioVendedorCuentaCobrar mRepositorio;

        public DominioVendedorCuentaCobrar(int pIdUsuario)
        {
            mRepositorio = new RepositorioVendedorCuentaCobrar(pIdUsuario);
        }

        public VendedorCuentaCobrar ObtenerPorVendedor(int pIdVendedor, int pIdProgramacion)
        {
            return mRepositorio.FindByVendedorProgramacion(pIdVendedor, pIdProgramacion);
        }

        public List<VendedorCuentaCobrar> ObtenerPörProgramacion(int pIdProgramacion)
        {
            return mRepositorio.FindByProgramacion(pIdProgramacion).ToList();
        }

        public VendedorCuentaCobrar ObtenerResumen(int pId)
        {
            return mRepositorio.FindOne(pId);
        }

        public RespuestaDominio RegistrarResumenVendedor(VendedorCuentaCobrar objVendedorCuentaCobrar)
        {
            int codigo = objVendedorCuentaCobrar.IdVendedorCuentaCobrar == 0 ?
                mRepositorio.Insert(objVendedorCuentaCobrar) :
                mRepositorio.Update(objVendedorCuentaCobrar);

            if (codigo > 0)
            {
                return Ok($"La informacion de registro correctamente.", codigo);
            }
            else
                return Error("No se registro el resumen, por favor intentelo de nuevo");

        }
    }
}



