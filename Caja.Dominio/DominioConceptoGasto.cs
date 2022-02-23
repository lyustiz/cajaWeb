using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioConceptoGasto : DominioAuditoria
    {
        readonly RepositorioConceptoGasto mRepositorio;
        public DominioConceptoGasto()
        {
            mRepositorio = new RepositorioConceptoGasto();
        }

        public List<ConceptoGasto> FetchAll()
        {
            return mRepositorio.Find().ToList();
        }

        public List<ConceptoGasto> FetchAllEstadistica()
        {
            return mRepositorio.Find().ToList();
        }

        public ConceptoGasto FetchOne(int id)
        {
            return mRepositorio.FindOne(id);
        }

        public List<ConceptoGasto> FetchOnes(int[] ids)
        {
            return mRepositorio.FindOnes(ids).ToList();
        }

        public int Save(ConceptoGasto objEntidad, AuditoriaHistoria auditoria)
        {
            int resultado;

            if (objEntidad.IdConceptoGasto > 0)
                resultado = mRepositorio.Update(objEntidad);
            else
                resultado = mRepositorio.Insert(objEntidad);

            /// Registrar Auditoria
            if (auditoria != null)
                RegistrarAuditoria(auditoria);

            return resultado;
        }
    }
}
