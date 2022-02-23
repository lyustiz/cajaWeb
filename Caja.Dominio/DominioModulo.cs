using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioModulo
    {
        readonly RepositorioModulo mRepositorio;
        public DominioModulo()
        {
            mRepositorio = new RepositorioModulo();
        }

        public List<Modulo> FetchAll()
        {
            return mRepositorio.Find().ToList();
        }

        public List<Modulo> FetchWhere(string filtro)
        {
            return mRepositorio.Find(filtro).ToList();
        }
        public Modulo Find(int numero)
        {
            return mRepositorio.Find(numero);
        }

        public Modulo FetchOne(int id)
        {
            return mRepositorio.FindOne(id);
        }

        public bool ExisteModulo(int numero, int idModulo)
        {
            return mRepositorio.ExisteModulo(numero, idModulo);
        }

        public bool ExisteModulo(int numero)
        {
            return mRepositorio.ExisteModulo(numero);
        }
        public bool ExisteCartonSerie(int carton, string serie, int idModulo)
        {
            return mRepositorio.ExisteCartonSerie(carton, serie, idModulo);
        }


        public List<Modulo> FetchOnes(int[] ids)
        {
            throw new System.NotImplementedException();
        }

        public int Save(Modulo objEntidad)
        {
            if (objEntidad.IdModulo > 0)
                return mRepositorio.Update(objEntidad);
            else
                return mRepositorio.Insert(objEntidad);
        }

        
    }
}