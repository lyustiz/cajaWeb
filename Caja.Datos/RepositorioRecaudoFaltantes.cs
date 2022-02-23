using Caja.Entidades;
using System;
using System.Collections.Generic;

namespace Caja.Datos
{
    public sealed class RepositorioRecaudoFaltantes : RepositorioBase, IRepositorio<RecaudoFaltante, int>
    {
        private readonly string mTabla = "recaudofaltantes";

        public RepositorioRecaudoFaltantes(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<RecaudoFaltante> Find()
        {
            throw new NotImplementedException();
        }

        public RecaudoFaltante FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RecaudoFaltante> Find(int mIdProgamacionJuego, int mIdUsuario)
        {
            IEnumerable<RecaudoFaltante> result = base.FetchObjects<RecaudoFaltante>($"SELECT * FROM {mTabla} WHERE Estado = 'A' AND IdProgramacionJuego = {mIdProgamacionJuego} AND IdUsuario = {mIdUsuario};");

            return result;
        }

        public int Insert(RecaudoFaltante objEntidad)
        {
            throw new NotImplementedException();
        }

        public int Update(RecaudoFaltante objEntidad)
        {
            throw new NotImplementedException();
        }
    }
}

