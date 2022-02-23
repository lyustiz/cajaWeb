using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Juego
{
    public partial class FrmCobroCartones : Base
    {
        DominioProgramacionJuego mDominioProgramacion;
        DominioHojasDevueltas mDominioHojasDevueltas;
        DominioVendedorCobroCarton mDominioVendedorCobroCarton;        
        DominioVendedorHojas mDominioVendedorHojas;
        DominioVendedorModulo mDominioVendedorModulo;
        DominioVendedorResumen mDominioVendedorResumen;
        DominioProgramacionDevolucionCodigoBarra mDominioDevolucionCodigoBarra;
        DominioPorcentajePremio mDominioPorcentajes;
        DominioRoe mDominioRoe;
        List<ProgramacionJuego> mListaProgramacion;
        ProgramacionJuego mProgramacionJuego;
        List<VendedorModulo> mListaVendedorModulo;
        int mIdVendedor;

        public FrmCobroCartones()
        {
            InitializeComponent();
            InstaciarObjetos();
            InicializarControles();
            ConfigurarEventos();
        }

        private void InstaciarObjetos()
        {            
            mDominioHojasDevueltas = new DominioHojasDevueltas(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorCobroCarton = new DominioVendedorCobroCarton(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorHojas = new DominioVendedorHojas(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorModulo = new DominioVendedorModulo(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorResumen = new DominioVendedorResumen(SesionActiva.UsuarioActual.IdUsuario);
            mDominioProgramacion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioDevolucionCodigoBarra = new DominioProgramacionDevolucionCodigoBarra(SesionActiva.UsuarioActual.IdUsuario);
            mDominioPorcentajes = new DominioPorcentajePremio();
            mDominioRoe = new DominioRoe();
            mListaVendedorModulo = new List<VendedorModulo>();
        }

        private void InicializarControles()
        {
            lblNombreVendedor.ResetText();

            mListaProgramacion = mDominioProgramacion.BuscarProgramacionActiva();
            Base.CargaCombo(cmdProgramacion, mListaProgramacion, "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList);

            guardarToolStripMenuItem.Enabled = !mListaProgramacion.IsNullOrZeroItems();

            if (mListaProgramacion.IsNullOrZeroItems())
            {
                grbBusquedaVendedor.Enabled = false;
                grbRegistro.Enabled = false;
                grbResumenVendedor.Enabled = false;
            }
        }

        private void ConfigurarEventos()
        {
            txtFiltro.KeyUp += TxtFiltro_KeyUp;            
        }

        private void TxResumenFaltante_LostFocus(object sender, EventArgs e)
        {
            CalcularValorTotal();
            txResumenFaltante.Enabled = false;
        }

        private void TxtRegistroGastosCortesia_LostFocus(object sender, EventArgs e)
        {
            CalcularValorTotal();
            txtRegistroGastosCortesia.Enabled = false;
        }

        private void TxtRegistroCartonesCortesia_LostFocus(object sender, EventArgs e)
        {
            CalcularValorTotal();
            txtRegistroCartonesCortesia.Enabled = false;
        }

        private void CargarGrilla()
        {
            LimpiarControles();

            if (mProgramacionJuego != null && mProgramacionJuego.IdProgramacionJuego > 0)
            {
                lblNombreVendedor.ResetText();
                mIdVendedor = 0;

                var listaResultado = mDominioProgramacion.ObtenerVendedoresProgramacionJuego(txtFiltro.Text.Trim(), mProgramacionJuego.IdProgramacionJuego);
                Grilla.Rows.Clear();

                foreach (var registro in listaResultado)
                {
                    Grilla.Rows.Add(new object[] { registro.IdVendedor, registro.Codigo, registro.Nombres, registro.Apellidos, registro.Documento, registro.Cobrado });

                    if (registro.Cobrado.IsOn(1))
                        ColocarColorGrilla(Grilla, -1, Grilla.RowCount - 1, 2);
                }

                if (listaResultado.Count == 1)
                    CargarDatosVendedor(0);
            }
        }

        public void CargarDatosVendedor(int pIndice)
        {
            RecuperarDatosGrilla(pIndice);
            LimpiarControles();

            // Consultar los valores para mostrar.
            mListaVendedorModulo = mDominioVendedorModulo.ObtenerModulosVendedor(mIdVendedor, mProgramacionJuego.IdProgramacionJuego);
            var resumen = mDominioVendedorResumen.ObtenerResumenVendedor(mIdVendedor, mProgramacionJuego.IdProgramacionJuego);
            var devolucionesConPistola = mDominioDevolucionCodigoBarra.ObtenerPorVendedor(mIdVendedor, mProgramacionJuego.IdProgramacionJuego);

            if (resumen != null)
            {
                resumen.CantidadModulos = mListaVendedorModulo.Count();
                /// Actualizar la cantidad de módulos asociados al resumen del vendedor.
                mDominioVendedorResumen.RegistrarResumenVendedor(resumen);

                /// Limpiar los controles del grupo Registro
                txtRegistroCartonesDevueltos.ResetText();
                txtRegistroHojasDevueltas.ResetText();
                txtRegistroPorcentajaComision.ResetText();
                txtRegistroCartonesCortesia.ResetText();
                txtRegistroGastosCortesia.ResetText();

                /// Asignar valores a los controles del grupo Registro
                txtRegistroHojasDevueltas.Value = resumen.NumeroHojasDevueltas;
                txtRegistroPorcentajaComision.Value = (decimal)resumen.PorcentajeComision;
                txtRegistroCartonesCortesia.Value = resumen.CartonesCortesia;
                txtRegistroGastosCortesia.Value = (decimal)resumen.GastoCortesia;
                                
                if (resumen.CartonesDevueltos > 0)
                    txtRegistroCartonesDevueltos.Value = resumen.CartonesDevueltos;
                else
                    txtRegistroCartonesDevueltos.Value = devolucionesConPistola.Count();

                /// Asignar valores a los controles del grupo Resumen
                txtResumenTotalCartones.Value = resumen.TotalCartones;
                txResumenTotalCartonesEfectivos.Value = resumen.TotalCartones - resumen.CartonesDevueltos;
                lblInfoModulos.Text = $"Cantidad: {resumen.CantidadModulos} Valor: {resumen.ValorModulos}";
                txResumenTotalVentas.Text = string.Format(SesionActiva.FormatoMoneda, resumen.ValorTotal);
                txResumenCartonesCortesia.Value = resumen.CartonesCortesia;

                txResumenCartonesDevueltos.Value = resumen.CartonesDevueltos;
                txResumenValorComision.Text = "0";
                txResumenAbonos.Text = string.Format(SesionActiva.FormatoMoneda, resumen.PagoAnticipado);
                txResumenGastosCortesia.Text = string.Format(SesionActiva.FormatoMoneda, resumen.GastoCortesia);
                txResumenTotalPagar.Text = string.Format(SesionActiva.FormatoMoneda, resumen.ValorPendiente);

                txResumenFaltante.Text = resumen.Faltante.ToString();
                txResumenTotalRecibido.Text = string.Format(SesionActiva.FormatoMoneda, 0);

                if (resumen.Cobrado.IsOn(1))
                {
                    txtRegistroGastosCortesia.Enabled = false;
                    txtRegistroCartonesCortesia.Enabled = false;
                    txResumenFaltante.Enabled = false;
                }
                else
                {
                    txtRegistroGastosCortesia.Enabled = true;
                    txtRegistroCartonesCortesia.Enabled = true;
                    txResumenFaltante.Enabled = true;
                }

            }
            else
                txtRegistroCartonesDevueltos.Value = devolucionesConPistola.Count();

            CalcularValorTotal();
        }

        private void CalcularValorTotal()
        {
            txResumenCartonesDevueltos.Value = txtRegistroCartonesDevueltos.Value;
            txResumenCartonesCortesia.Value = txtRegistroCartonesCortesia.Value;
            int faltante = txResumenFaltante.Text.IsNumeric() ? Convert.ToInt32(txResumenFaltante.Text) : 0;

            int modulosEnCartones = 0;
            int cartonesValidos = (int)(txtResumenTotalCartones.Value - txResumenCartonesCortesia.Value - txResumenCartonesDevueltos.Value);
            cartonesValidos = cartonesValidos < 0 ? 0 : cartonesValidos;

            int cantidadModulos = mListaVendedorModulo.IsNullOrZeroItems() ? 0 : mListaVendedorModulo.Count();

            double valorTotal = (cartonesValidos * mProgramacionJuego.ValorCarton) + (mProgramacionJuego.ValorModulo * cantidadModulos);
            txResumenTotalVentas.Text = string.Format(SesionActiva.FormatoMoneda, valorTotal);

            if (true) /// TODO: Aqui va la llave de codigo de barras.
            {
                txtRegistroCartonesDevueltos.Enabled = false;

                if (mIdVendedor > 0)
                {
                    var hojasVendedor = mDominioVendedorHojas.ObtenerHojasVendedor(mIdVendedor, mProgramacionJuego.IdProgramacionJuego);

                    txtRegistroHojasDevueltas.Value = hojasVendedor.Count();
                    txtRegistroHojasDevueltas.Enabled = false;

                    modulosEnCartones = (int)(cantidadModulos * mProgramacionJuego.ValorModulo / mProgramacionJuego.ValorCarton);

                    var porcentaje = mDominioPorcentajes.CalcularPorcentaje((int)txResumenTotalCartonesEfectivos.Value + modulosEnCartones);

                    if (porcentaje.IsOn(-1))
                        porcentaje = (int)txtRegistroPorcentajaComision.Value;

                    txtRegistroPorcentajaComision.Value = porcentaje;
                    txtRegistroPorcentajaComision.Enabled = !(txtRegistroPorcentajaComision.Value > 0);

                    int comisionPersonal = (int)((cartonesValidos * mProgramacionJuego.ValorCarton) + (mProgramacionJuego.ValorModulo * cantidadModulos)) * porcentaje / 100;
                    int valorFinal = (int)((cartonesValidos * mProgramacionJuego.ValorCarton) + (mProgramacionJuego.ValorModulo * cantidadModulos)) - comisionPersonal - ObtenerValorEntero(txResumenAbonos.Text);
                    txResumenValorComision.Text = string.Format(SesionActiva.FormatoMoneda, comisionPersonal);

                    valorFinal = valorFinal - (int)txtRegistroGastosCortesia.Value;
                    txResumenTotalPagar.Text = string.Format(SesionActiva.FormatoMoneda, valorFinal);
                    faltante = valorFinal - faltante;
                    txResumenTotalRecibido.Text = string.Format(SesionActiva.FormatoMoneda, faltante);
                    txResumenGastosCortesia.Text = string.Format(SesionActiva.FormatoMoneda, (int)txtRegistroGastosCortesia.Value);
                    txResumenTotalCartonesEfectivos.Value = cartonesValidos;
                }
            }
        }

        private int ObtenerValorEntero(string texto)
        {
            var strValor = texto.Replace("U$", string.Empty).Replace("$", string.Empty).Replace("€", string.Empty).Trim();
            decimal.TryParse(strValor, out decimal valorEntero);

            return (int)valorEntero;
        }

        private void RecuperarDatosGrilla(int pIndice)
        {
            mIdVendedor = Convert.ToInt32(Grilla.Rows[pIndice].Cells["IdVendedor"].FormattedValue.ToString());

            lblNombreVendedor.Text = $"{Grilla.Rows[pIndice].Cells["Codigo"].FormattedValue} - " +
                $"{Grilla.Rows[pIndice].Cells["Nombres"].FormattedValue} " +
                $"{Grilla.Rows[pIndice].Cells["Apellidos"].FormattedValue}";
        }

        private void LimpiarControles()
        {
            txResumenAbonos.Text = "";
            txtRegistroHojasDevueltas.Value = 0;
            txResumenCartonesCortesia.Value = 0;
            txtRegistroCartonesCortesia.Value = 0;
            txtRegistroCartonesDevueltos.Value = 0;
            txResumenCartonesDevueltos.Value = 0;
            txResumenFaltante.Text = "";
            txResumenGastosCortesia.Text = "";
            txtRegistroGastosCortesia.Value = 0;
            txtRegistroPorcentajaComision.Value = 0;
            txtResumenTotalCartones.Value = 0;
            txResumenTotalCartonesEfectivos.Value = 0;
            txResumenTotalPagar.Text = "";
            txResumenTotalRecibido.Text = "";
            txResumenTotalVentas.Text = "";
            txResumenValorComision.Text = "";
            lblInfoModulos.Text = "";

            mListaVendedorModulo.Clear();
        }

        private void GuardarCobro()
        {
            if (mProgramacionJuego is null || mProgramacionJuego.IdProgramacionJuego <= 0)
                return;

            if (mIdVendedor <= 0)
                return;

            CalcularValorTotal();

            double totalVentas = ObtenerValorEntero(txResumenTotalVentas.Text);
            double totalPagar = ObtenerValorEntero(txResumenTotalPagar.Text);
            double valorComision = ObtenerValorEntero(txResumenValorComision.Text);
            double abonos = ObtenerValorEntero(txResumenAbonos.Text);
            double porcentaje = (double)txtRegistroPorcentajaComision.Value;

            double faltante = ObtenerValorEntero(txResumenFaltante.Text);
            double valorRecolectado = totalPagar - faltante;
            double gastoCortesia = (double)txtRegistroGastosCortesia.Value;

            VendedorCobroCarton cobroCarton = new VendedorCobroCarton()
            {
                IdProgramacionJuego = mProgramacionJuego.IdProgramacionJuego,
                IdVendedor = mIdVendedor,
                Abonos = abonos,
                CartonesCortesia = (int)txtRegistroCartonesCortesia.Value,
                CartonesDevueltos = (int)txtRegistroCartonesDevueltos.Value,
                Faltante = faltante,
                GastoCortesia = gastoCortesia,
                NumeroHojasEntregadas = (int)txtRegistroHojasDevueltas.Value,
                PorcentajeComision = porcentaje,
                TotalCartones = (int)txtResumenTotalCartones.Value,
                TotalModulos = mListaVendedorModulo.Count(),
                TotalPagado = totalPagar,
                TotalRecibido = valorRecolectado,
                TotalVentas = totalVentas,
                ValorComision = valorComision
            };

            /// Insertar registro de cobro carton.
            RespuestaDominio resultado = mDominioVendedorCobroCarton.GuardarRegistro(cobroCarton);

            if (resultado.Ok)
            {
                MostrarMensajeInformativo(resultado.Mensaje);
                LimpiarControles();
                CargarGrilla();
            }
            else
                MostrarMensajeError(resultado.Mensaje);            
        }

        private void TxtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CargarGrilla();
        }

        private void BtnRecibirCartones_Click(object sender, EventArgs e)
        {
            if (mIdVendedor > 0) 
            {
                string cobrado = Grilla.Rows[Grilla.CurrentCell.RowIndex].Cells["Cobrado"].FormattedValue.ToString();

                if (cobrado.IsOn("1"))
                    MostrarMensajeInformativo("El vendedor ya se encuentra cerrado, no se aceptan devoluciones.");
                else
                {
                    var frmDevolucion = new FrmDevolucionCodigoBarras(lblNombreVendedor.Text, mIdVendedor, mProgramacionJuego.IdProgramacionJuego);
                    AbrirFormularioModal(frmDevolucion);
                    txtRegistroCartonesDevueltos.Value = frmDevolucion.TotalCartonesDevueltos;
                    txtRegistroCartonesDevueltos.Enabled = false;

                    CalcularValorTotal();
                    txResumenCartonesCortesia.Focus();
                }
            }
            else
                MostrarMensajeError("Debe seleccionar un vendedor.");
        }

        private void cmdProgramacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdProgramacion.SelectedIndex >= 0)
            {
                mProgramacionJuego = mDominioProgramacion.ObtenerProgramacion(ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion).IdProgramacionJuego);
                CargarGrilla();
            }
        }

        private void Grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRegistroCartonesCortesia.LostFocus += TxtRegistroCartonesCortesia_LostFocus;
            txtRegistroGastosCortesia.LostFocus += TxtRegistroGastosCortesia_LostFocus;
            txResumenFaltante.LostFocus += TxResumenFaltante_LostFocus;
            CargarDatosVendedor(Grilla.CurrentCell.RowIndex);
        }
        
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void BtnRecalcular_Click(object sender, EventArgs e)
        {
            CalcularValorTotal();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de guardar la información?", "Confirmación",MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        GuardarCobro();
                        break;
                    }                
            }            
        }

    }
}
