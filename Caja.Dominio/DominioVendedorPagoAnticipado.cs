using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioVendedorPagoAnticipado : DominioBase
    {
        readonly RepositorioVendedorPagoAnticipado mRepositorio;

        public DominioVendedorPagoAnticipado(int pIdUsuario)
        {
            mRepositorio = new RepositorioVendedorPagoAnticipado(pIdUsuario);
        }

        public List<VendedorPagoAnticipado> Obtener(int pIdUsuario, int pIdProgramacion)
        {
            return mRepositorio.Find(pIdProgramacion, pIdUsuario).ToList();
        }  
    }
}