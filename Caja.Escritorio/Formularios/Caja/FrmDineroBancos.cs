using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using Caja.Escritorio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Caja
{
    public partial class FrmDineroBancos : Base
    {
        private DominioRoe mDominioRoe;
        private DominioProgramacionJuego mDominioProgramacionJuego;
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
        private DominioFlujoCaja mDominioFlujoCaja;

        private List<ProgramacionJuego> mListaProgramacionJuegos;
        private ProgramacionJuego mProgramacionJuego;

        private double mValorTotalPremios = 0;
        private double mValorGastos = 0;
        private double mValorIngresos = 0;
        private double mValorDiferencia = 0;
        private double mValorTotal = 0;
        private double mValorJuego = 0;
        private double mValorAyuda = 0;
        private double mValorBancos = 0;
        private double mValorEfectivo = 0;

        public FrmDineroBancos()
        {
            InitializeComponent();
            InstanciarObjetos();
            CargarListas();
        }

        private void InstanciarObjetos()
        {
            mDominioRoe = new DominioRoe();
            mDominioProgramacionJuego = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
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
            mDominioFlujoCaja = new DominioFlujoCaja(SesionActiva.UsuarioActual.IdUsuario);

            txBancos.LostFocus += TxBancos_LostFocus;
        }

        private void TxBancos_LostFocus(object sender, EventArgs e)
        {
            CalcularDiferencia();
        }

        private void CargarListas()
        {
            mListaProgramacionJuegos = mDominioProgramacionJuego.BuscarProgramacion();
            List<ItemCombo> mListaAnios = new List<ItemCombo>();

            foreach (var programacion in mListaProgramacionJuegos)
            {
                var item = programacion.FechaProgramada.Year;
                if (!mListaAnios.Exists(x => x.Id == item))
                    mListaAnios.Add(new ItemCombo() { Id = item, Nombre = Convert.ToString(item) });
            }

            CargaCombo<ItemCombo>(cmdAnios, mListaAnios, "Nombre", "Id", ComboBoxStyle.DropDownList, true);
        }

        private void CargarValoresIniciales()
        {
            if (mProgramacionJuego != null)
            {
                lblMensaje.Text = "NO";
                var mListaRecaudoDetalle = mDominioRecaudoDetalle.Obtener(mProgramacionJuego.IdProgramacionJuego);

                if (mListaRecaudoDetalle.IsNullOrZeroItems())
                {
                    MostrarMensajeError($"IMPORTANTE{Environment.NewLine}Para poder hacer el registro del dinero, primero debe realizar el CUADRE DE CIERRE para el juego No. {mProgramacionJuego.IdProgramacionJuego}");
                    txBancos.Enabled = false;

                    return;
                }

                var mFluoCaja = mDominioFlujoCaja.FindByProgramacion(mProgramacionJuego.IdProgramacionJuego);

                if (mFluoCaja != null)
                    txInicial.Text = Convert.ToString(mFluoCaja.ValorInicial);
                else
                    txInicial.Text = "0";

                var mListaFigurasProgramacion = mDominioProgramacionJuego.ObtenerFigurasProgramacion(mProgramacionJuego.IdProgramacionJuego).Where(x => x.Estado == "A");
                mValorTotalPremios = mListaFigurasProgramacion.Sum(x => x.ValorPremio);
                txPremios.Text = string.Format(SesionActiva.FormatoMoneda, mValorTotalPremios);

                var mListaGastos = mDominioGastoProgramacionJuego.ObtenerGastosProgramacionJuego(mProgramacionJuego.IdProgramacionJuego);
                mValorGastos = mListaGastos.Sum(x => x.Valor);
                txGastos.Text = string.Format(SesionActiva.FormatoMoneda, mValorGastos);

                var mListaIngresos = mDominioIngresoProgramacionJuego.ObtenerIngresosProgramacionJuego(mProgramacionJuego.IdProgramacionJuego);
                mValorIngresos = mListaIngresos.Sum(x => x.Valor);
                txIngresos.Text = string.Format(SesionActiva.FormatoMoneda, mValorIngresos);

                var mListaRecaudoTotal = mDominioRecaudoTotal.Consultar(mProgramacionJuego.IdProgramacionJuego);
                mValorDiferencia = mListaRecaudoTotal.Sum(x => Convert.ToDouble(x.Diferencia));
                txCuadreCierre.Text = string.Format(SesionActiva.FormatoMoneda, mValorDiferencia);

                var mJuegoDinero = mDominioProgramacionJuegoDinero.FindByProgramacion(mProgramacionJuego.IdProgramacionJuego);
                mValorJuego = mJuegoDinero.TotalRecaudoJuego;
                mValorTotal = mValorTotal + mValorJuego;
                mValorAyuda = mJuegoDinero.AsistenciaSocial;

                mValorBancos = 0;
                mValorTotal = mValorTotal - mValorTotalPremios + mValorIngresos - mValorGastos + mValorDiferencia - mValorAyuda;
                mValorEfectivo = mValorTotal - mValorTotalPremios + mValorIngresos - mValorGastos + mValorDiferencia - mValorAyuda;

                txJuego.Text = string.Format(SesionActiva.FormatoMoneda, mValorJuego);
                txAyuda.Text = string.Format(SesionActiva.FormatoMoneda, mValorAyuda);
                txTotal.Text = string.Format(SesionActiva.FormatoMoneda, mValorTotal);
                txBancos.Text = string.Format(SesionActiva.FormatoMoneda, mValorBancos);
                txEfectivo.Text = string.Format(SesionActiva.FormatoMoneda, mValorEfectivo);

                List<DefinicionMoneda> registros = mDominioRoe.FindAllDefinicionMoneda();
                List<RecaudoDetalle> registroRecaudoDetalle = mDominioRecaudoDetalle.Obtener(mProgramacionJuego.IdProgramacionJuego);

                double mTotalDetalleRecaudo = 0;

                foreach (var item in registros)
                {
                    var detalle = registroRecaudoDetalle.FirstOrDefault(x => x.IdDefinicionMoneda == item.IdDefinicionMoneda);

                    if (detalle != null && item.GrupoSuma == 1)
                        mTotalDetalleRecaudo += detalle.TotalRecaudo;
                }

                mValorBancos = mTotalDetalleRecaudo;
                txBancos.Text = string.Format(SesionActiva.FormatoMoneda, mValorBancos);

                CalcularDiferencia();

                if (mJuegoDinero.CerradoBanco == 'C')
                {
                    mValorBancos = mJuegoDinero.DineroBanco;
                    mValorEfectivo = mJuegoDinero.Efectivo;
                    txBancos.Text = string.Format(SesionActiva.FormatoMoneda, mValorBancos);
                    txEfectivo.Text = string.Format(SesionActiva.FormatoMoneda, mValorEfectivo);

                    AlmacenarToolStripMenuItem.Enabled = false;
                    txBancos.Enabled = false;
                }
                else
                {
                    AlmacenarToolStripMenuItem.Enabled = true;
                    txBancos.Enabled = true;
                    txBancos.Focus();
                }
            }
        }

        private void CalcularDiferencia()
        {
            var mValor = mValorTotal - mValorBancos;
            mValorEfectivo = mValor;
            txEfectivo.Text = string.Format(SesionActiva.FormatoMoneda, mValorEfectivo);
        }

        private bool ValidarUsuariosRegistro()
        {
            List<int> mLista = mDominioVendedorCobroCarton.FindProgramacionGroupByUsuario(mProgramacionJuego.IdProgramacionJuego);
            lblMensaje.Text = "NO";
            lblMensaje.Visible = false;

            if (!mLista.IsNullOrZeroItems())
            {
                foreach (var registro in mLista){
                    List<RecaudoTotal> mListaRecaudoTotal = mDominioRecaudoTotal.Consultar(mProgramacionJuego.IdProgramacionJuego, registro);

                    if (mListaRecaudoTotal.IsNullOrZeroItems())
                    {
                        if (lblMensaje.Text == "NO")
                        {
                            lblMensaje.Text = $"Códigos usuarios SIN Cuadre de caja:{Environment.NewLine}{registro}";
                            lblMensaje.Visible = true;
                            return false;
                        }
                        else                        
                            lblMensaje.Text = lblMensaje.Text + $"{Environment.NewLine}{registro}";                        
                    }
                }                
            }

            return true;
        }

        private void cmdAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ItemCombo> mListaMeses = new List<ItemCombo>();
            var listaMeses = ListasGenericas.GenerarListaMeses();

            int mAnioSeleccionado = ObtenerItemCombo<ItemCombo>(cmdAnios).Id;

            foreach (var programacion in mListaProgramacionJuegos.Where(x => x.FechaProgramada.Year == mAnioSeleccionado))
            {
                var item = programacion.FechaProgramada.Month;
                if (!mListaMeses.Exists(x => x.Id == item))
                    mListaMeses.Add(new ItemCombo() { Id = item, Nombre = listaMeses.FirstOrDefault(x => x.Id == item).Nombre });
            }

            CargaCombo<ItemCombo>(cmdMeses, mListaMeses, "Nombre", "Id", ComboBoxStyle.DropDownList, true);
        }

        private void cmdMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ProgramacionJuego> mListaJuegos = new List<ProgramacionJuego>();
            var listaMeses = ListasGenericas.GenerarListaMeses();

            int mAnioSeleccionado = ObtenerItemCombo<ItemCombo>(cmdAnios).Id;
            int mMesSeleccionado = ObtenerItemCombo<ItemCombo>(cmdMeses).Id;

            foreach (var programacion in mListaProgramacionJuegos.Where(x => x.FechaProgramada.Year == mAnioSeleccionado && x.FechaProgramada.Month == mMesSeleccionado))
                mListaJuegos.Add(programacion);

            CargaCombo<ProgramacionJuego>(cmdProgramacion, mListaJuegos, "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList, true);
        }

        private void cmdProgramacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdProgramacion.SelectedIndex >= 0)
            {
                mProgramacionJuego = ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion);
                CargarValoresIniciales();
            }
        }

        private void AlmacenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidarUsuariosRegistro())
            {
                var mListaRecaudoDetalle = mDominioRecaudoDetalle.Obtener(mProgramacionJuego.IdProgramacionJuego);

                if (mListaRecaudoDetalle.IsNullOrZeroItems())
                {
                    MostrarMensajeError($"IMPORTANTE{Environment.NewLine}Para poder hacer el registro del dinero, primero debe realizar el CUADRE DE CIERRE para el juego No. {mProgramacionJuego.IdProgramacionJuego}");
                    txBancos.Enabled = false;

                    return;
                }

                if (mValorBancos < 0)
                {
                    MostrarMensajeError($"El valor en BANCOS no puede ser negativo.{Environment.NewLine}Realice nuevamente el proceso");
                    mValorBancos = 0;
                    txBancos.Text = string.Format(SesionActiva.FormatoMoneda, mValorBancos);
                }
                else
                {
                    if (mValorEfectivo < 0)
                    {
                        MostrarMensajeError($"El valor en EFECTIVO no puede ser negativo.{Environment.NewLine}Realice nuevamente el proceso");
                        mValorEfectivo = 0;
                        txEfectivo.Text = string.Format(SesionActiva.FormatoMoneda, mValorEfectivo);
                    }
                    else
                    {
                        var mJuegoDinero = mDominioProgramacionJuegoDinero.FindByProgramacion(mProgramacionJuego.IdProgramacionJuego);

                        if (mJuegoDinero != null)
                        {
                            mJuegoDinero.DineroBanco = mValorBancos;
                            mJuegoDinero.Efectivo = mValorEfectivo;
                            mJuegoDinero.CerradoBanco = 'C';

                            mDominioProgramacionJuegoDinero.Modificar(mJuegoDinero);
                        }

                        var mFlujoCaja = mDominioFlujoCaja.FindByProgramacion(mProgramacionJuego.IdProgramacionJuego);

                        if (mFlujoCaja != null)
                        {
                            mFlujoCaja.ValorFinal = mValorEfectivo;
                            mFlujoCaja.ValorFinalBancos = mValorBancos;
                            mFlujoCaja.ValorFinalSocial = mValorAyuda;

                            mDominioFlujoCaja.Save(mFlujoCaja);
                        }

                        mProgramacionJuego.ResultadoFinal = mValorEfectivo + mValorBancos;
                        mDominioProgramacionJuego.ModificarResultadoFinal(mProgramacionJuego);

                        var objHistoricoFlujoCaja = new HistoricoFlujoCaja();
                        objHistoricoFlujoCaja.IdUsuario = SesionActiva.UsuarioActual.IdUsuario;
                        objHistoricoFlujoCaja.Mes = (byte)DateTime.Now.Month;
                        objHistoricoFlujoCaja.Anio = (short)DateTime.Now.Year;
                        objHistoricoFlujoCaja.Valor = Convert.ToDecimal(mValorEfectivo);
                        objHistoricoFlujoCaja.OrigenPago = 'C';
                        objHistoricoFlujoCaja.Accion = "Dinero Bancos";
                        mDominioFlujoCaja.SaveHistorico(objHistoricoFlujoCaja);
                                                
                        objHistoricoFlujoCaja.Valor = Convert.ToDecimal(mValorBancos);
                        objHistoricoFlujoCaja.OrigenPago = 'B';
                        mDominioFlujoCaja.SaveHistorico(objHistoricoFlujoCaja);

                        objHistoricoFlujoCaja.Valor = Convert.ToDecimal(mValorAyuda);
                        objHistoricoFlujoCaja.OrigenPago = 'S';
                        mDominioFlujoCaja.SaveHistorico(objHistoricoFlujoCaja);

                        MostrarMensajeInformativo("Proceso realizado Exitosamente");
                        this.Close();
                    }
                }
            }
        }
    }
}
