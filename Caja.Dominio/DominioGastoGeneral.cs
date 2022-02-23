using Caja.Datos;
using Caja.Entidades;
using Caja.Entidades.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioGastoGeneral : DominioBase
    {
        readonly RepositorioGastoGeneral mRepositorio;
        readonly RepositorioFlujoCaja mRepositorioFlujoCaja;

        public DominioGastoGeneral(int pIdUsuario)
        {
            mRepositorio = new RepositorioGastoGeneral(pIdUsuario);
            mRepositorioFlujoCaja = new RepositorioFlujoCaja(pIdUsuario);
        }

        public List<VistaGastoGeneral> ObtenerGastosGeneralesPeriodo(byte pMes, short pAnio)
        {
            return mRepositorio.Find(pMes, pAnio).ToList();
        }

        public ConceptoGasto ObtenerConceptoGasto(int pIdConcepto)
        {
            return mRepositorio.ObtenerConceptoGasto(pIdConcepto);
        }

        public RespuestaDominio CrearGasto(GastoGeneral objGasto, bool mEsSocio)
        {
            var respuesta = PuedeCrearGasto(objGasto, mEsSocio);

            if (!respuesta.Ok)
                return respuesta;

            objGasto.Socio = string.IsNullOrWhiteSpace(objGasto.Socio) ? string.Empty : objGasto.Socio;

            /// 1. Crea el gasto general.
            int mIdGasto = mRepositorio.Insert(objGasto);

            /// 2. Crear el registro de historico flujo caja.
            mRepositorioFlujoCaja.InsertHistorial(CrearObjetoHistorio(objGasto));
            
            int idFlujoCaja = mRepositorioFlujoCaja.GetMaxId();
            string campo = "ValorFinal";

            switch (objGasto.OrigenPago)
            {
                case 'C':
                    campo = "ValorFinal";
                    break;                    
                case 'B':
                    campo = "ValorFinalBancos";
                    break;
                case 'S':
                    campo = "ValorFinalSocial";
                    break;
            }

            /// 3. Actualiza el valor del flujo de caja existente.
            mRepositorioFlujoCaja.ModificarValorFinal(idFlujoCaja, campo, objGasto.Valor);

            if (mIdGasto > 0)
            {
                return Ok($"El gasto se registro exitosamente.", mIdGasto);
            }
            else
                return Error("No se registro el gasto, intentelo de nuevo por favor.");

        }

        private HistoricoFlujoCaja CrearObjetoHistorio(GastoGeneral objGasto)
        {
            return new HistoricoFlujoCaja() 
            { 
                IdUsuario = objGasto.IdUsuario, 
                Mes = (byte)objGasto.FechaRegistro.Month,
                Anio = (short)objGasto.FechaRegistro.Year,
                Valor = objGasto.Valor * -1,
                OrigenPago = objGasto.OrigenPago,
                Accion = "Gastos Generales"
            };
        }

        private RespuestaDominio PuedeCrearGasto(GastoGeneral objGasto, bool mEsSocio)
        {
            decimal mTotalGastado = (decimal)mRepositorio.CalularTotalGastado(objGasto.IdConceptoGasto, (byte)objGasto.FechaRegistro.Month, (short)objGasto.FechaRegistro.Year);
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


