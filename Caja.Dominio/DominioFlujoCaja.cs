using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioFlujoCaja : DominioBase
    {
        readonly RepositorioFlujoCaja mRepositorio;
        public DominioFlujoCaja(int pIdUsuario)
        {
            mRepositorio = new RepositorioFlujoCaja(pIdUsuario);
        }

        public List<FlujoCaja> FetchAll()
        {
            return mRepositorio.Find().ToList();
        }

        public List<FlujoCaja> FetchWhere()
        {
            return mRepositorio.Find().ToList();
        }
        public FlujoCaja FetchOne(int id)
        {
            return mRepositorio.FindOne(id);
        }

        public FlujoCaja FindByProgramacion(int pIdProgramacion)
        {
            return mRepositorio.FindByProgramacion(pIdProgramacion);
        }

        public List<FlujoCaja> FetchOnes(int[] ids)
        {
            throw new System.NotImplementedException();
        }

        public int GetMaxId()
        {
            return mRepositorio.GetMaxId();
        }

        public RespuestaDominio Save(FlujoCaja objEntidad)
        {
            int resultado;

            if (objEntidad.IdFlujoCaja > 0)
                resultado = mRepositorio.Update(objEntidad);
            else
                resultado = mRepositorio.Insert(objEntidad);

            if (resultado > 0)
                return Ok(resultado);
            else
                return Error("No se guardo el flujo de caja, validar con el administrador");
        }

        public RespuestaDominio SaveHistorico(HistoricoFlujoCaja objEntidad)
        {
            int resultado = mRepositorio.InsertHistorial(objEntidad);
            
            if (resultado > 0)
                return Ok(resultado);
            else
                return Error("No se guardo el historial del flujo de caja, validar con el administrador");
        }        

        public void Deshabilitar(int id, string estado)
        {
            mRepositorio.Deshabilitar(id, estado);
        }
    }
}

