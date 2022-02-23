using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioVendedorReferencia
    {
        readonly RepositorioVendedorReferencia mRepositorio;
        
        public DominioVendedorReferencia()
        {
            mRepositorio = new RepositorioVendedorReferencia();            
        }

        public List<VendedorReferencia> Fetch(int idVendedor)
        {
            return mRepositorio.Find(idVendedor).ToList();
        }
        public VendedorReferencia FetchOne(int id)
        {
            return mRepositorio.FindOne(id);
        }      

        public int Save(VendedorReferencia objEntidad)
        {
            if (objEntidad.IdVendedorReferencia > 0)
                return mRepositorio.Update(objEntidad);
            else
                return mRepositorio.Insert(objEntidad);
        }

    }
}

