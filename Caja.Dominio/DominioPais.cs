using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioPais
    {
        readonly RepositorioPais mRepositorio;
        public DominioPais()
        {
            mRepositorio = new RepositorioPais();
        }

        public List<Pais> FetchAll()
        {
            return mRepositorio.Find().ToList();
        }

        public Pais FetchOne(int id)
        {
            return mRepositorio.FindOne(id);
        }

        public List<Pais> FetchOnes(int[] ids)
        {
            return mRepositorio.FindOnes(ids).ToList();
        }

        public int Save(Pais objEntidad)
        {
            if (objEntidad.IdPais > 0)
                return mRepositorio.Update(objEntidad);
            else
                return mRepositorio.Insert(objEntidad);
        }
    }
}

