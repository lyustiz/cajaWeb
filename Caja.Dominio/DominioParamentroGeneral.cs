using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioParamentroGeneral
    {
        readonly RepositorioParametroGeneral mRepositorio;
        public DominioParamentroGeneral()
        {
            mRepositorio = new RepositorioParametroGeneral();
        }

        public ParametroGeneral FetchBy(TipoBusquedaParametroGeneral tipo, object valor)
        {
            return mRepositorio.FindBy(tipo, valor);
        }

        public ParametroGeneral FetchOne(int id)
        {
            return mRepositorio.FindOne(id);
        }

        public List<ParametroGeneral> FetchOnes(int[] ids)
        {
            return mRepositorio.FindOnes(ids).ToList();
        }

        public int Save(ParametroGeneral objEntidad)
        {
            if (objEntidad.IdParametros_Generales > 0)
                return mRepositorio.Update(objEntidad);
            else
                return mRepositorio.Insert(objEntidad);
        }

        public void GenerarPermisos()
        {
            new RepositorioPerfilPermiso().GenerareData();
        }
    }
}
