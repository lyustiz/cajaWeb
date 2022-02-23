using Caja.Datos;
using Caja.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioNominaDescuento : DominioBase
    {
        readonly RepositorioNominaDescuento mRepositorio;

        public DominioNominaDescuento(int pIdUsuario)
        {
            mRepositorio = new RepositorioNominaDescuento(pIdUsuario);
        }

        public List<NominaDescuento> Obtener(int pIdProgramacion, int pIdUsuario)
        {
            return mRepositorio.Find(pIdProgramacion, pIdUsuario).ToList();
        }

        public RespuestaDominio Save(NominaDescuento objEntidad)
        {
            try
            {
                if (objEntidad.IdNominaDescuento > 0)
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

