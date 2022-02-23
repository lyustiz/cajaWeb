using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Caja
{
    public partial class FrmCuadreCierre : Base
    {
        private DominioRoe mDominioRoe;
        private DominioProgramacionJuego mDominioProgramacion;
        private DominioRecaudoTotal mDominioRecaudoTotal;
        private DominioRecaudoDetalle mDominioRecaudoDetalle;
        private DominioRecaudoFaltante mDominioRecaudoFaltante;
        private DominioVendedorCobroCarton mDominioVendedorCobroCarton;
        private DominioVendedorPagoAnticipado mDominioVendedorPagoAnticipado;
        private DominioNominaDescuento mDominioNominaDescuento;
        private DominioGastoProgramacionJuego mDominioGastoProgramacionJuego;
        private DominioIngresoProgramacionJuego mDominioIngresoProgramacionJuego;
        private DominioGastoGeneral mDominioGastoGeneral;
        private DominioIngresoGeneral mDominioIngresoGeneral;
        private DominioProgramacionJuegoDinero mDominioProgramacionJuegoDinero;

        private ProgramacionJuego mProgramacionJuegoDefault;
        private byte mIncluirGastosIngresos = 0;

        public FrmCuadreCierre()
        {
            InitializeComponent();
            InstanciarObjetos();
            CargarUsuario();
            CargarDatosMoneda();
            CargarCombos();
        }

        private void InstanciarObjetos()
        {
            this.mDominioRoe = new DominioRoe();
            mDominioProgramacion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRecaudoTotal = new DominioRecaudoTotal(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRecaudoDetalle = new DominioRecaudoDetalle(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRecaudoFaltante = new DominioRecaudoFaltante(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorCobroCarton = new DominioVendedorCobroCarton(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorPagoAnticipado = new DominioVendedorPagoAnticipado(SesionActiva.UsuarioActual.IdUsuario);
            mDominioNominaDescuento = new DominioNominaDescuento(SesionActiva.UsuarioActual.IdUsuario);
            mDominioGastoProgramacionJuego = new DominioGastoProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioIngresoProgramacionJuego = new DominioIngresoProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioGastoGeneral = new DominioGastoGeneral(SesionActiva.UsuarioActual.IdUsuario);
            mDominioIngresoGeneral = new DominioIngresoGeneral(SesionActiva.UsuarioActual.IdUsuario);
            mDominioProgramacionJuegoDinero = new DominioProgramacionJuegoDinero(SesionActiva.UsuarioActual.IdUsuario);
        }

        private void CargarUsuario()
        {
            lblNombreUsuario.Text = SesionActiva.UsuarioActual.NombreCompleto;
        }

        private void CargarDatosMoneda()
        {
            List<DefinicionMoneda> registros = mDominioRoe.FindAllDefinicionMoneda();
            CargarGrilla(registros);
        }

        private void CargarCombos()
        {
            CargaCombo(cmdProgramacion, mDominioProgramacion.BuscarProgramacion(), "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList);
        }

        public bool ValidarJuegos()
        {
            var listaProgramacion = mDominioProgramacion.BuscarProgramacion();

            if (listaProgramacion.Count(x => x.Estado == "C") == 0)
            {
                MostrarMensajeInformativo($"Debe exitir algún juego cerrado.{Environment.NewLine}Valide nuevamente por favor.");
                return false;
            }
            else
            {
                var mIdJuego = listaProgramacion.Where(y => y.Estado == "C").Max(x => x.IdProgramacionJuego);
                mProgramacionJuegoDefault = listaProgramacion.First(x => x.IdProgramacionJuego == mIdJuego);

                if (mProgramacionJuegoDefault != null)
                {
                    lbJuego.Text = Convert.ToString(mProgramacionJuegoDefault.IdProgramacionJuego);
                    cmdProgramacion.SelectedIndex = listaProgramacion.FindIndex(x => x.IdProgramacionJuego == mProgramacionJuegoDefault.IdProgramacionJuego);
                }
            }

            return true;
        }

        private void CargarGrilla(List<DefinicionMoneda> registros)
        {
            Grilla.Rows.Clear();

            foreach (var item in registros)
                Grilla.Rows.Add(new object[] { item.IdDefinicionMoneda, item.Tipo, item.Nominal, 0, item.Equivalencia, 0, item.GrupoSuma });
        }



        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal mGastos = 0;
            decimal mIngresos = 0;
            decimal mValorCierre = 0;
            decimal mValorRecaudoPrevio = 0;
            decimal mPagoFaltantes = 0;

            if (mProgramacionJuegoDefault?.IdProgramacionJuego != Convert.ToInt32(lbJuego.Text))
            {
                MostrarMensajeInformativo($"Solamente se puede almacenar el juego que se encuentra registrado.{Environment.NewLine}Anteriores a ese se carga la informacion del pago{Environment.NewLine}Posteriores NO se procesan.");
                return;
            }

            mIncluirGastosIngresos = Convert.ToByte(ObtenerValorParametroGeneral("Caja-IncluirGastosIngresos"));

            var listaRecaudoTotal = mDominioRecaudoTotal.Consultar(mProgramacionJuegoDefault.IdProgramacionJuego, SesionActiva.UsuarioActual.IdUsuario);

            if (listaRecaudoTotal.Count != 0)
            {
                MostrarMensajeInformativo($"Ya se tiene el registro de este Juego almacenado.{Environment.NewLine}Se procede a cargar la informacion almacenada, pero no se puede modificar.");
                CargarDatosJuego();
                return;
            }

            int contador = 0;

            foreach (DataGridViewRow row in Grilla.Rows)
            {
                if (row.Cells[5].Value != null && Convert.ToDouble(row.Cells[5].Value) > 0)
                {
                    RecaudoDetalle objDetalle = new RecaudoDetalle
                    {
                        IdProgramacionJuego = mProgramacionJuegoDefault.IdProgramacionJuego,
                        IdUsuario = SesionActiva.UsuarioActual.IdUsuario,
                        IdDefinicionMoneda = Convert.ToInt32(row.Cells[0].Value),
                        Cantidad = Convert.ToInt32(row.Cells[3].Value),
                        TotalRecaudo = Convert.ToDouble(row.Cells[5].Value)
                    };

                    var resDetalle = mDominioRecaudoDetalle.Save(objDetalle);

                    if (resDetalle.Ok)
                        contador++;
                }
            }

            if (contador.IsOn(0))
            {
                MostrarMensajeError("No se guardo ningun recaudo detalle, por favor intentelo nuevamente.");
                return;
            }

            if (mIncluirGastosIngresos.IsOn((byte)1))
            {
                // Gatos
                var mListaGastos = mDominioGastoProgramacionJuego.ObtenerGastosProgramacionJuego(mProgramacionJuegoDefault.IdProgramacionJuego).Where(x => x.IdUsuario == SesionActiva.UsuarioActual.IdUsuario);
                mGastos = mListaGastos.Sum(x => Convert.ToDecimal(x.Valor));

                // Ingresos
                var mListaIngresos = mDominioIngresoProgramacionJuego.ObtenerIngresosProgramacionJuego(mProgramacionJuegoDefault.IdProgramacionJuego).Where(x => x.IdUsuario == SesionActiva.UsuarioActual.IdUsuario);
                mIngresos = mListaIngresos.Sum(x => Convert.ToDecimal(x.Valor));
            }

            // Almacena el registro final del total del valor
            var objRecaudoTotal = new RecaudoTotal
            {
                IdProgramacionJuego = mProgramacionJuegoDefault.IdProgramacionJuego,
                IdUsuario = SesionActiva.UsuarioActual.IdUsuario,
                RecuadoTotal = Convert.ToDecimal(txTotalRecaudo.Tag),
                ValorRecaudoCalculado = 0,
                Diferencia = 0,
                IncluirGastosGenerales = mIncluirGastosIngresos,
                Gastos = mGastos,
                Ingresos = mIngresos,
                RegistroGastos = 0,
                RegistroIngresos = 0
            };

            var res = mDominioRecaudoTotal.Save(objRecaudoTotal);

            if (res.Ok)
                objRecaudoTotal.IdRecaudoTotal = res.IdConfirmacion;
            else
            {
                MostrarMensajeError("No se guardo el registo en Recaudo Total" + res.Mensaje);
                return;
            }

            var mListaVendedoresCartones = mDominioVendedorCobroCarton.ObtenerPorUsuario(SesionActiva.UsuarioActual.IdUsuario, mProgramacionJuegoDefault.IdProgramacionJuego);
            mValorCierre = mListaVendedoresCartones.Sum(x => Convert.ToDecimal(x.TotalRecibido));

            var mListaVendedoresPagoAnticipado = mDominioVendedorPagoAnticipado.Obtener(SesionActiva.UsuarioActual.IdUsuario, mProgramacionJuegoDefault.IdProgramacionJuego);
            mValorRecaudoPrevio = mListaVendedoresPagoAnticipado.Sum(x => Convert.ToDecimal(x.ValorAnticipo));

            objRecaudoTotal.ValorRecaudoCalculado = mValorCierre + mValorRecaudoPrevio - mGastos + mIngresos;
            objRecaudoTotal.Diferencia = objRecaudoTotal.RecuadoTotal - (mValorCierre + mValorRecaudoPrevio - mGastos + mIngresos);

            mDominioRecaudoTotal.Save(objRecaudoTotal);

            var mListaRecaudoFaltantes = mDominioRecaudoFaltante.Obtener(SesionActiva.UsuarioActual.IdUsuario, mProgramacionJuegoDefault.IdProgramacionJuego);
            mPagoFaltantes = mListaRecaudoFaltantes.Sum(x => Convert.ToDecimal(x.ValorRecibido));

            var mTotalRecaudo = Convert.ToDecimal(txTotalRecaudo.Tag);

            var mValorCalculado = mValorCierre + mValorRecaudoPrevio - mGastos + mIngresos + mPagoFaltantes;

            if (mTotalRecaudo - mValorCalculado == 0)
            {
                MostrarMensajeInformativo($"El valor entregado corresponde al calculado{Environment.NewLine}Proceso exitoso.");
            }
            else
            {
                decimal mDiferencia = mTotalRecaudo - (mValorCierre + mValorRecaudoPrevio - mGastos + mIngresos);
                RegistrarSobrantesFaltantesCaja(mDiferencia);
                MostrarMensajeInformativo($"El valor calculado es {string.Format(SesionActiva.FormatoMoneda, mValorCalculado)} Diferencia {string.Format(SesionActiva.FormatoMoneda, mDiferencia)}");
            }

            LimpiarCampos();
        }

        private void CargarDatosJuego()
        {
            CargarUsuario();            
            LimpiarCampos();
            Grilla.Rows.Clear();
            int contador = 0;

            List<DefinicionMoneda> registros = mDominioRoe.FindAllDefinicionMoneda();
            List<RecaudoDetalle> registroRecaudoDetalle = mDominioRecaudoDetalle.Obtener(ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion).IdProgramacionJuego, SesionActiva.UsuarioActual.IdUsuario);

            if (registroRecaudoDetalle.IsNullOrZeroItems())
            {
                var mProgramacionDinero = mDominioProgramacionJuegoDinero.FindByProgramacion(ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion).IdProgramacionJuego);

                if (mProgramacionDinero != null && mProgramacionDinero.CerradoBanco == 'A')                
                    lbJuego.Text = Convert.ToString(mProgramacionDinero.IdProgramacionJuego);                
            }

            foreach (var item in registros)
            {
                var detalle = registroRecaudoDetalle.FirstOrDefault(x => x.IdDefinicionMoneda == item.IdDefinicionMoneda);

                if (detalle != null)
                {
                    Grilla.Rows.Add(new object[] { item.IdDefinicionMoneda, item.Tipo, item.Nominal, detalle.Cantidad, item.Equivalencia, detalle.TotalRecaudo, item.GrupoSuma });
                    CalcularValorFila(contador);                    
                }
                else                
                    Grilla.Rows.Add(new object[] { item.IdDefinicionMoneda, item.Tipo, item.Nominal, 0, item.Equivalencia, 0, item.GrupoSuma });

                contador++;
            }            
        }

        private void LimpiarCampos()
        {
            txTotal1.Text = string.Empty;
            txTotal2.Text = string.Empty;
            txTotalRecaudo.Text = string.Empty;
        }

        private void RegistrarSobrantesFaltantesCaja(decimal mValorSobrante)
        {
            int mMes = DateTime.Now.Month;
            int mAnio = DateTime.Now.Year;

            decimal mMaximoToleranciaCaja = Convert.ToDecimal(ObtenerValorParametroGeneral("Caja-MaximaToleranciaCaja"));

            if (mValorSobrante > 0)
            {
                var objIngresoGeneral = new IngresoGeneral
                {
                    IdUsuario = SesionActiva.UsuarioActual.IdUsuario,
                    IdConceptoIngreso = 6,
                    Descripcion = $"Programación Juego {mProgramacionJuegoDefault.IdProgramacionJuego}, diferencia NO aceptable.",
                    Valor = mValorSobrante,
                    Mes = (byte)mMes,
                    Anio = (short)mAnio,
                    OrigenPago = 'C',
                    FechaHora = DateTime.Now,
                    FechaRegistro = DateTime.Now
                };

                mDominioIngresoGeneral.CrearIngreso(objIngresoGeneral, false);
            }
            else
            {
                var objGastoGeneral = new GastoGeneral
                {
                    IdUsuario = SesionActiva.UsuarioActual.IdUsuario,
                    IdConceptoGasto = 40,
                    Descripcion = $"Programación Juego {mProgramacionJuegoDefault.IdProgramacionJuego}, diferencia aceptable.",
                    Valor = mValorSobrante,
                    Mes = (byte)mMes,
                    Anio = (short)mAnio,
                    OrigenPago = 'C',
                    FechaHora = DateTime.Now,
                    FechaRegistro = DateTime.Now
                };

                if (Math.Abs(mValorSobrante) <= Math.Abs(mMaximoToleranciaCaja))
                {
                    mDominioGastoGeneral.CrearGasto(objGastoGeneral, false);
                }
                else
                {
                    objGastoGeneral.IdConceptoGasto = 41;
                    mDominioGastoGeneral.CrearGasto(objGastoGeneral, false);

                    var objNominaDescuento = new NominaDescuento
                    {
                        IdUsuario = SesionActiva.UsuarioActual.IdUsuario,
                        IdProgramacionJuego = mProgramacionJuegoDefault.IdProgramacionJuego,
                        Mes = (byte)mMes,
                        Anio = (short)mAnio,
                        Concepto = "Valor pendiente por cobrar.",
                        Valor = mValorSobrante
                    };

                    mDominioNominaDescuento.Save(objNominaDescuento);
                }
            }
        }

        private void Grilla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcularValorFila(Grilla.CurrentCell.RowIndex);
        }

        private void CalcularValorFila(int indice)
        {
            int fila = indice;

            Grilla.Rows[fila].Cells[3].Tag = 1;
            ColocarColorGrilla(Grilla, 3, fila, 2);

            // Calcula el valor digitado en el momento

            if (!double.TryParse(Convert.ToString(Grilla.Rows[fila].Cells[3].Value), out double valorMaximo))
            {
                MostrarMensajeInformativo("El valor digitado debe ser numerico unicamente.");
                Grilla.Rows[fila].Cells[3].Value = "0";
                Grilla.Rows[fila].Cells[5].Value = "0";
            }
            else
            {
                Grilla.Rows[fila].Cells[5].Value = Convert.ToDouble(Grilla.Rows[fila].Cells[3].Value) * Convert.ToDouble(Grilla.Rows[fila].Cells[4].Value);
            }

            // Efectua la suma del total aportado
            double valorTotal = 0;
            double valorTotalGrupoSuma1 = 0;
            double valorTotalGrupoSuma2 = 0;

            foreach (DataGridViewRow row in Grilla.Rows)
            {
                if (row.Cells[5].Value == null)
                    continue;

                valorTotal += Convert.ToDouble(row.Cells[5].Value);

                if (Convert.ToInt32(row.Cells[6].Value) == 1)
                    valorTotalGrupoSuma1 = valorTotalGrupoSuma1 + Convert.ToDouble(row.Cells[5].Value);
                else
                    valorTotalGrupoSuma2 = valorTotalGrupoSuma2 + Convert.ToDouble(row.Cells[5].Value);
            }

            txTotalRecaudo.Text = string.Format(SesionActiva.FormatoMoneda, valorTotal);
            txTotalRecaudo.Tag = valorTotal;

            txTotal1.Text = string.Format(SesionActiva.FormatoMoneda, valorTotalGrupoSuma1);
            txTotal1.TextAlign = HorizontalAlignment.Center;

            txTotal2.Text = string.Format(SesionActiva.FormatoMoneda, valorTotalGrupoSuma2);
            txTotal2.TextAlign = HorizontalAlignment.Center;

        }

        private void cmdProgramacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdProgramacion.SelectedIndex >= 0)            
                CargarDatosJuego();            
        }
    }
}
