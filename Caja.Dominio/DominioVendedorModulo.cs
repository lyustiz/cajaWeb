using Caja.Datos;
using Caja.Entidades;
using Caja.Entidades.Vistas;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioVendedorModulo : DominioBase
    {
        readonly RepositorioVendedorModulo mRepositorio;

        public DominioVendedorModulo(int pIdUsuario)
        {
            mRepositorio = new RepositorioVendedorModulo(pIdUsuario);
        }

        public List<VendedorModulo> ObtenerModulosVendedor(int pIdVendedor, int pIdProgramacion)
        {
            return mRepositorio.FindByVendedor(pIdVendedor, pIdProgramacion).ToList();
        }

        public List<VendedorModulo> ObtenerModulosProgramacion(int pIdProgramacion)
        {
            return mRepositorio.FindByProgramacion(pIdProgramacion).ToList();
        }

        public List<VistaModulosCartonesExportables> FindByExportables(int pIdProgramacion)
        {
            return mRepositorio.FindByExportables(pIdProgramacion).ToList();
        }

        public VendedorModulo ObtenerModulo(int pId)
        {
            return mRepositorio.FindOne(pId);
        }

        public RespuestaDominio RegistrarModuloVendedor(VendedorModulo objVendedorModulo)
        {
            int codigo = mRepositorio.Insert(objVendedorModulo);

            if (codigo > 0)
            {
                return Ok($"La módulo se asocio correctamente.", codigo);
            }
            else
                return Error("No se asocio el módulo, por favor intentelo de nuevo");

        }

        public void Deshabilitar(int id, string estado)
        {
            mRepositorio.Deshabilitar(id, estado);
        }
    }
}

