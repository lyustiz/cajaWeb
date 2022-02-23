using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioVendedor
    {
        readonly RepositorioVendedor mRepositorio;
        public DominioVendedor(int pIdUsuario)
        {
            mRepositorio = new RepositorioVendedor(pIdUsuario);
        }

        public List<Vendedor> FetchAll()
        {
            return mRepositorio.Find().ToList();
        }

        public List<Vendedor> FetchWhere(string filtro)
        {
            return mRepositorio.Find(filtro).ToList();
        }
        public Vendedor FetchOne(int id)
        {
            return mRepositorio.FindOne(id);
        }

        public List<Vendedor> FetchOnes(int[] ids)
        {
            throw new System.NotImplementedException();
        }

        public int GetMaxId()
        {
            return mRepositorio.GetMaxId();
        }

        public bool ExisteDocumento(string documento)
        {
            return mRepositorio.ExisteDocumento(documento);
        }

        public int Save(Vendedor objEntidad)
        {
            if (objEntidad.IdVendedor > 0)
                return mRepositorio.Update(objEntidad);
            else
                return mRepositorio.Insert(objEntidad);
        }

        public void Deshabilitar(int id, string estado)
        {
            mRepositorio.Deshabilitar(id, estado);
        }        
    }
}
