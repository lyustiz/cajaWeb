using Caja.Datos;
using Caja.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioRecaudoDetalle : DominioBase
    {
        readonly RepositorioRecaudoDetalle mRepositorio;

        public DominioRecaudoDetalle(int pIdUsuario)
        {
            mRepositorio = new RepositorioRecaudoDetalle(pIdUsuario);
        }

        public List<RecaudoDetalle> Obtener(int pIdProgramacion, int pIdUsuario)
        {
            return mRepositorio.Find(pIdProgramacion, pIdUsuario).ToList();
        }

        public List<RecaudoDetalle> Obtener(int pIdProgramacion)
        {
            return mRepositorio.Find(pIdProgramacion).ToList();
        }

        public RespuestaDominio Save(RecaudoDetalle objEntidad)
        {
            try
            {
                if (objEntidad.IdRecaudoDetalle > 0) {
                    if (mRepositorio.Update(objEntidad) > 0)
                        return Ok("La información se modifico exitosamente.");
                }
                else{
                    if (mRepositorio.Insert(objEntidad) > 0)
                        return Ok("La información se modifico exitosamente.");
                }

                return Error("La operación no se completo correctamente, por favor vuelva a intentarlo.");
            }
            catch (Exception ex)
            {
                return Error(ex.ToString());
            }            
        }
    }
}
