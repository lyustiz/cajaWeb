using Caja.Datos;
using Caja.Entidades;
using Caja.Entidades.Vistas;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioIngresoProgramacionJuego : DominioBase
    {
        readonly RepositorioIngresoProgramacionJuego mRepositorio;

        public DominioIngresoProgramacionJuego(int pIdUsuario)
        {
            mRepositorio = new RepositorioIngresoProgramacionJuego(pIdUsuario);
        }

        public List<VistaIngresosProgramacionJuego> ObtenerIngresosProgramacionJuego(int pIdProgramacion)
        {
            return mRepositorio.Find(pIdProgramacion).ToList();
        }

        public List<VistaIngresosProgramacionJuego> ObtenerIngresosProgramacionJuego(int pIdProgramacion, int pIdUsuario)
        {
            return mRepositorio.Find(pIdProgramacion, pIdUsuario).ToList();
        }

        public RespuestaDominio CrearIngreso(IngresoProgramacionJuego objIngreso)
        {
            int mIdIngreso = mRepositorio.Insert(objIngreso);

            if (mIdIngreso > 0)
            {
                return Ok($"El ingreso se registro exitosamente.", mIdIngreso);
            }
            else
                return Error("No se registro el ingreso, intentelo de nuevo por favor.");

        }
    }
}
