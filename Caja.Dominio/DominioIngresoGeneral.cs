using Caja.Datos;
using Caja.Entidades;
using Caja.Entidades.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioIngresoGeneral : DominioBase
    {
        readonly RepositorioIngresoGeneral mRepositorio;
        readonly RepositorioFlujoCaja mRepositorioFlujoCaja;

        public DominioIngresoGeneral(int pIdUsuario)
        {
            mRepositorio = new RepositorioIngresoGeneral(pIdUsuario);
            mRepositorioFlujoCaja = new RepositorioFlujoCaja(pIdUsuario);
        }

        public List<VistaIngresoGeneral> ObtenerIngresosGeneralesPeriodo(byte pMes, short pAnio)
        {
            return mRepositorio.Find(pMes, pAnio).ToList();
        }

        public ConceptoIngreso ObtenerConceptoIngreso(int pIdConcepto)
        {
            return mRepositorio.ObtenerConceptoIngreso(pIdConcepto);
        }

        public RespuestaDominio CrearIngreso(IngresoGeneral objIngreso, bool mEsSocio)
        {
            objIngreso.Socio = string.IsNullOrWhiteSpace(objIngreso.Socio) ? string.Empty : objIngreso.Socio;

            /// 1. Crea el ingreso general.
            int mIdIngreso = mRepositorio.Insert(objIngreso);

            /// 2. Crear el registro de historico flujo caja.
            mRepositorioFlujoCaja.InsertHistorial(CrearObjetoHistorio(objIngreso));

            int idFlujoCaja = mRepositorioFlujoCaja.GetMaxId();
            string campo = "ValorFinal";

            switch (objIngreso.OrigenPago)
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
            mRepositorioFlujoCaja.ModificarValorFinal(idFlujoCaja, campo, objIngreso.Valor);

            if (mIdIngreso > 0)
            {
                return Ok($"El ingreso se registro exitosamente.", mIdIngreso);
            }
            else
                return Error("No se registro el ingreso, intentelo de nuevo por favor.");

        }

        private HistoricoFlujoCaja CrearObjetoHistorio(IngresoGeneral objIngreso)
        {
            return new HistoricoFlujoCaja()
            {
                IdUsuario = objIngreso.IdUsuario,
                Mes = (byte)objIngreso.FechaRegistro.Month,
                Anio = (short)objIngreso.FechaRegistro.Year,
                Valor = objIngreso.Valor,
                OrigenPago = objIngreso.OrigenPago,
                Accion = "Ingresos Generales"
            };
        }
    }
}



