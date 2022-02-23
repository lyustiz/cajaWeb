using Caja.Datos;
using Caja.Entidades;
using Caja.Entidades.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioGastoProgramacionJuego : DominioBase
    {
        readonly RepositorioGastoProgramacionJuego mRepositorio;
        readonly RepositorioProgramacionJuego mRepositorioProgramacion;

        public DominioGastoProgramacionJuego(int pIdUsuario)
        {
            mRepositorio = new RepositorioGastoProgramacionJuego(pIdUsuario);
            mRepositorioProgramacion = new RepositorioProgramacionJuego(pIdUsuario);
        }

        public List<VistaGastosProgramacionJuego> ObtenerGastosProgramacionJuego(int pIdProgramacion)
        {
            return mRepositorio.Find(pIdProgramacion).ToList();
        }

        public List<VistaGastosProgramacionJuego> ObtenerGastosProgramacionJuego(int pIdProgramacion, int pIdUsuario)
        {
            return mRepositorio.Find(pIdProgramacion, pIdUsuario).ToList();
        }

        public ConceptoGasto ObtenerConceptoGasto(int pIdConcepto)
        {
            return mRepositorio.ObtenerConceptoGasto(pIdConcepto);
        }

        public RespuestaDominio CrearGasto(GastoProgramacionJuego objGasto, DateTime mFechaProgramada, bool mEsSocio)
        {
            var respuesta = PuedeCrearGasto(objGasto, mFechaProgramada, mEsSocio);

            if (!respuesta.Ok)
                return respuesta;

            objGasto.Socio = string.IsNullOrWhiteSpace(objGasto.Socio) ? string.Empty : objGasto.Socio;

            int mIdGasto = mRepositorio.Insert(objGasto);

            if (mIdGasto > 0)
            {
                return Ok($"El gasto se registro exitosamente.", mIdGasto);
            }
            else
                return Error("No se registro el gasto, intentelo de nuevo por favor.");

        }

        private RespuestaDominio PuedeCrearGasto(GastoProgramacionJuego objGasto, DateTime mFechaProgramada, bool mEsSocio)
        {
            decimal mTotalGastado = mRepositorio.CalularTotalGastado(objGasto.IdConceptoGasto, mFechaProgramada.Month, mFechaProgramada.Year);
            ConceptoGasto mConcepto = ObtenerConceptoGasto(objGasto.IdConceptoGasto);

            if (mConcepto is null)
                return Error("Concepto Gasto Inexistente");

            if (mConcepto.Controlado == 1 && !mEsSocio)
            {
                if (mTotalGastado + objGasto.Valor >= mConcepto.ValorMaximo)
                    return Error("El gasto excede el tope máximo permitido.");
            }

            return Ok();
        }
    }
}

