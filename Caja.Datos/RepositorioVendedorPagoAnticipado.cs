using Caja.Entidades;
using System;
using System.Collections.Generic;

namespace Caja.Datos
{
    public sealed class RepositorioVendedorPagoAnticipado : RepositorioBase, IRepositorio<VendedorPagoAnticipado, int>
    {
        private readonly string mTabla = "vendedorespagoanticipados";

        public RepositorioVendedorPagoAnticipado(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<VendedorPagoAnticipado> Find()
        {
            throw new NotImplementedException();
        }

        public VendedorPagoAnticipado FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VendedorPagoAnticipado> Find(int mIdProgamacionJuego, int mIdUsuario)
        {
            IEnumerable<VendedorPagoAnticipado> result = base.FetchObjects<VendedorPagoAnticipado>($"SELECT * FROM {mTabla} WHERE Estado = 'A' AND IdProgramacionJuego = {mIdProgamacionJuego} AND IdUsuario = {mIdUsuario};");

            return result;
        }

        public int Insert(VendedorPagoAnticipado objEntidad)
        {
            throw new NotImplementedException();
        }

        public int Update(VendedorPagoAnticipado objEntidad)
        {
            throw new NotImplementedException();
        }
    }
}
