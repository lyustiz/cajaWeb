using Caja.Datos;
using Caja.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioRecaudoFaltante : DominioBase
    {
        readonly RepositorioRecaudoFaltantes mRepositorio;

        public DominioRecaudoFaltante(int pIdUsuario)
        {
            mRepositorio = new RepositorioRecaudoFaltantes(pIdUsuario);
        }

        public List<RecaudoFaltante> Obtener(int pIdUsuario, int pIdProgramacion)
        {
            return mRepositorio.Find(pIdProgramacion, pIdUsuario).ToList();
        }

        public RespuestaDominio Save(RecaudoFaltante objEntidad)
        {
            try
            {
                if (objEntidad.IdRecaudoFaltante > 0)
                {
                    if (mRepositorio.Update(objEntidad) > 0)
                        return Ok("La información se modifico exitosamente.");
                }
                else
                {
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
