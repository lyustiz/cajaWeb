using Caja.Datos;
using Caja.Entidades;
using System;

namespace Caja.Dominio
{
    public sealed class DominioProgramacionJuegoDinero : DominioBase
    {
        readonly RepositorioProgramacionJuegoDinero mRepositorio;

        public DominioProgramacionJuegoDinero(int pIdUsuario)
        {
            mRepositorio = new RepositorioProgramacionJuegoDinero(pIdUsuario);
        }

        public ProgramacionJuegoDinero FindOne(int id)
        {
            return mRepositorio.FindOne(id);
        }

        public ProgramacionJuegoDinero FindByProgramacion(int id)
        {
            return mRepositorio.FindByProgramacion(id);
        }

        public RespuestaDominio Crear(ProgramacionJuegoDinero objEntidad)
        {
            try
            {
                var resultado = mRepositorio.Insert(objEntidad);

                if (resultado > 0)
                    return Ok(resultado);
                else
                    return Error("No se registro la información en juego dinero.");
            }
            catch (Exception ex)
            {
                return Error(ex.Message);
            }
        }

        public RespuestaDominio Modificar(ProgramacionJuegoDinero objEntidad)
        {
            try
            {
                var resultado = mRepositorio.Update(objEntidad);

                if (resultado > 0)
                    return Ok(resultado);
                else
                    return Error("No se modificó la información en juego dinero.");
            }
            catch (Exception ex)
            {
                return Error(ex.Message);
            }
        }

        public RespuestaDominio Deshabilitar(int pIdProgramacionJuego)
        {
            try
            {
                mRepositorio.Deshabilitar(pIdProgramacionJuego);
                return Ok();
            }
            catch (Exception ex)
            {
                return Error(ex.Message);
            }
        }
    }
}


