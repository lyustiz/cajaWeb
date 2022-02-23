using Caja.Datos;
using Caja.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioHojasDevueltas : DominioBase
    {
        readonly RepositorioProgramacionJuegoHojaDevuelta mRepositorio;

        public DominioHojasDevueltas(int pIdUsuario)
        {
            mRepositorio = new RepositorioProgramacionJuegoHojaDevuelta(pIdUsuario);
        }

        public List<ProgramacionJuegoHojaDevuelta> ObtenerHojasDevueltasProgramacion(int pIdProgramacion)
        {
            return mRepositorio.Find(pIdProgramacion).ToList();
        }

        public RespuestaDominio Guardar(int pIdProgramacion, List<int> listaHojas)
        {
            try
            {
                mRepositorio.Deshabilitar(pIdProgramacion);

                foreach (int hoja in listaHojas)
                {
                    mRepositorio.Insert(new ProgramacionJuegoHojaDevuelta() { IdProgramacionJuego = pIdProgramacion, NumeroHoja = hoja });
                }

                return Ok("La informacion se guardó exitosamente");
            }
            catch (Exception ex)
            {
                return Error(ex.ToString());
            }
        }

        public RespuestaDominio Deshabilitar(int pIdProgramacion, int pNumeroHoja)
        {
            try
            {
                mRepositorio.Deshabilitar(pIdProgramacion, pNumeroHoja);                

                return Ok("La informacion se guardó exitosamente");
            }
            catch (Exception ex)
            {
                return Error(ex.ToString());
            }
        }
    }
}
