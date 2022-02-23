using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioCiudad
    {
        readonly RepositorioCiudad mRepositorio;
        public DominioCiudad()
        {
            mRepositorio = new RepositorioCiudad();
        }

        public List<Ciudad> FetchAll()
        {
            return mRepositorio.Find().ToList();
        }
        public List<Ciudad> FetchAllByPais(int idPais)
        {
            return mRepositorio.FindByPais(idPais).ToList();
        }

        public Ciudad FetchOne(int id)
        {
            return mRepositorio.FindOne(id);
        }

        public List<Ciudad> FetchOnes(int[] ids)
        {
            return mRepositorio.FindOnes(ids).ToList();
        }

        public int Save(Ciudad objEntidad)
        {
            if (objEntidad.IdCiudad > 0)
                return mRepositorio.Update(objEntidad);
            else
                return mRepositorio.Insert(objEntidad);
        }
    }
}


