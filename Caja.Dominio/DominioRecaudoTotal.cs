using Caja.Datos;
using Caja.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioRecaudoTotal : DominioBase
    {
        readonly RepositorioRecaudoTotal mRepositorio;

        public DominioRecaudoTotal(int pIdUsuario)
        {
            mRepositorio = new RepositorioRecaudoTotal(pIdUsuario);
        }

        public List<RecaudoTotal> Consultar(int pIdProgramacion, int pIdUsuario)
        {
            return mRepositorio.Find(pIdProgramacion, pIdUsuario).ToList();
        }

        public List<RecaudoTotal> Consultar(int pIdProgramacion)
        {
            return mRepositorio.Find(pIdProgramacion).ToList();
        }
        public RecaudoTotal Obtener(int pIdProgramacion, int pIdUsuario)
        {
            return mRepositorio.FindOne(pIdProgramacion, pIdUsuario);
        }

        public RespuestaDominio Save(RecaudoTotal objEntidad)
        {
            try
            {
                if (objEntidad.IdRecaudoTotal > 0)
                {
                    var res = mRepositorio.Update(objEntidad);

                    if (res > 0)
                        return Ok("La información se modifico exitosamente.", res);
                }
                else
                {
                    var res = mRepositorio.Insert(objEntidad);

                    if (res > 0)
                        return Ok("La información se modifico exitosamente.", res);
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
