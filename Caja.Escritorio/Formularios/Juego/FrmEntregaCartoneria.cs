using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using Caja.Escritorio.Formularios.Reportes;
using Caja.Escritorio.Formularios.Reportes.DataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Juego
{
    public partial class FrmEntregaCartoneria : Base
    {
        DominioVendedor mDominioVendedor;
        DominioHojasDevueltas mDominioHojasDevueltas;
        DominioVendedorHojas mDominioVendedorHojas;
        DominioVendedorModulo mDominioVendedorModulo;
        DominioVendedorResumen mDominioVendedorResumen;
        DominioProgramacionJuego mDominioProgramacion;
        ProgramacionJuego mProgramacionJuego;
        VendedorHoja mVendedorHoja;

        int mNumeroCartonesHoja;
        int mMaximoHojaEntregar;

        public FrmEntregaCartoneria()
        {
            InitializeComponent();
            InstanciarObjetos();
            InicializaControles();
        }

        public void InstanciarObjetos()
        {
            mDominioVendedor = new DominioVendedor(SesionActiva.UsuarioActual.IdUsuario);
            mDominioHojasDevueltas = new DominioHojasDevueltas(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorHojas = new DominioVendedorHojas(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorModulo = new DominioVendedorModulo(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorResumen = new DominioVendedorResumen(SesionActiva.UsuarioActual.IdUsuario);
            mDominioProgramacion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
        }

        public void InicializaControles()
        {
            var listaProgramaciones = mDominioProgramacion.BuscarProgramacionActiva();
            CargaCombo(cmdProgramacion, listaProgramaciones, "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList);
        }

        public void LimpiarControles()
        {
            txtFiltro.ResetText();
            Grilla.Rows.Clear();
            lblNombreVendedor.Text = string.Empty;
            txtCartones.Text = "0";
            txtCortesia.Text = "0";
            txtHoja.Text = "";
            lstHojas.Items.Clear();

            ConfigurarControlesCobrado(pHabilitar: true);
        }

        public void CargarGrilla()
        {
            var listaResultado = mDominioProgramacion.ObtenerProgramacionJuegoHojas(txtFiltro.Text.Trim());
            Grilla.Rows.Clear();

            foreach (var registro in listaResultado)
            {
                Grilla.Rows.Add(new object[] { registro.IdVendedor, registro.Codigo, registro.Nombres, registro.Apellidos, registro.IdProgramacionJuego, registro.CantidadHojas });

                var resumen = mDominioVendedorResumen.ObtenerResumenVendedor(registro.IdVendedor, registro.IdProgramacionJuego);

                if (resumen != null)
                {
                    if (resumen.Cobrado.IsOn(1) && (resumen.IdProgramacionJuego == mProgramacionJuego.IdProgramacionJuego))
                        ColocarColorGrilla(Grilla, -1, Grilla.RowCount - 1, 2);
                }
            }
        }

        public void CargarDatosVendedor(int pIndice)
        {
            RecuperarDatosGrilla(pIndice);
            LimpiarDatosVendedor();

            if (mVendedorHoja.IdProgramacionJuego > 0)
            {
                var resumen = mDominioVendedorResumen.ObtenerResumenVendedor(mVendedorHoja.IdVendedor, mVendedorHoja.IdProgramacionJuego);

                if (resumen != null)
                {
                    txtCortesia.Value = resumen.CartonesCortesia;

                    if (resumen.Cobrado.IsOn(1))
                        ConfigurarControlesCobrado(pHabilitar: false);
                }
            }
            else
                txtCortesia.Text = "0";

            CargarHojasVendedor();
        }

        public void RecuperarDatosGrilla(int pIndice)
        {
            mVendedorHoja = new VendedorHoja
            {
                IdVendedor = Convert.ToInt32(Grilla.Rows[pIndice].Cells["IdVendedor"].FormattedValue.ToString()),
                IdProgramacionJuego = Convert.ToInt32(Grilla.Rows[pIndice].Cells["IdProgramacionJuego"].FormattedValue.ToString())
            };

            lblNombreVendedor.Text = $"{Grilla.Rows[pIndice].Cells["Codigo"].FormattedValue} - " +
                $"{Grilla.Rows[pIndice].Cells["Nombres"].FormattedValue} " +
                $"{Grilla.Rows[pIndice].Cells["Apellidos"].FormattedValue}";
        }

        private void LimpiarDatosVendedor()
        {
            txtCartones.Text = "0";
            txtCortesia.Text = "0";
            txtHoja.Text = "";

            txtCortesia.Enabled = true;
            txtHoja.Enabled = true;
            btnAgregar.Enabled = true;
            btnQuitar.Enabled = true;
        }

        private void ConfigurarControlesCobrado(bool pHabilitar) 
        {
            txtCortesia.Enabled = pHabilitar;
            txtHoja.Enabled = pHabilitar;
            btnAgregar.Enabled = pHabilitar;
            btnQuitar.Enabled = pHabilitar;
        }
        
        private void CargarHojasVendedor()
        {
            lstHojas.Items.Clear();

            var mListaHojasVendedor = mDominioVendedorHojas.ObtenerHojasVendedor(mVendedorHoja.IdVendedor, mVendedorHoja.IdProgramacionJuego);

            foreach (var hoja in mListaHojasVendedor)
            {
                lstHojas.Items.Add(hoja.NumeroHoja);
                txtCartones.Value += mNumeroCartonesHoja;
            }
        }

        private void AgregarHoja()
        {
            if (DatosRequeridosAgregar())
            {
                if (lstHojas.Items.Contains(txtHoja.Text))
                {
                    VolverCampoHoja();
                    return; // Ya esta la hoja agregada.
                }                    

                if (mDominioVendedorHojas.ExisteHoja(mProgramacionJuego.IdProgramacionJuego, (int)txtHoja.Value) == false)
                {
                    lstHojas.Items.Add(txtHoja.Text);
                    txtCartones.Value += mNumeroCartonesHoja;

                    /// Falta: Implementar cuando se realice la pantalla de devoluciones.
                    ///TODO: Debo validar que en caso de encontrarse devuelta la hoja, anule la transaccion devolución.
                }
                else
                {
                    var listadoHoja = new List<VendedorHoja>();

                    if (mVendedorHoja != null && mVendedorHoja.IdProgramacionJuego > 0)
                        listadoHoja = mDominioVendedorHojas.ObtenerHojasProgramacion(mVendedorHoja.IdProgramacionJuego);
                    else
                        listadoHoja = mDominioVendedorHojas.ObtenerHojasProgramacion(mProgramacionJuego.IdProgramacionJuego);

                    if (!listadoHoja.IsNullOrZeroItems())
                    {
                        var datosHoja = listadoHoja.FirstOrDefault(x => x.NumeroHoja == (int)txtHoja.Value);

                        if (datosHoja != null)
                        {
                            var vendedor = mDominioVendedor.FetchOne(datosHoja.IdVendedor);

                            MostrarMensajeError($"La hoja digitada ya ha sido asignada previamente, valide nuevamente la información.{Environment.NewLine}" +
                                $"Código: {vendedor.Codigo} - Vendedor: {vendedor.Nombres} {vendedor.Apellidos}");
                        }
                    }
                }

                VolverCampoHoja();
            }            
        }

        private void VolverCampoHoja()
        {
            txtHoja.ResetText();
            txtHoja.Focus();
        }

        private bool DatosRequeridosAgregar()
        {
            string mensaje = string.Empty;

            if (mVendedorHoja == null)
                mensaje = "Debe seleccionar un VENDEDOR antes de agregar hojas.";
            else if (mVendedorHoja.IdVendedor < 0)
                mensaje = "Debe seleccionar un VENDEDOR antes de agregar hojas.";
            else if (txtHoja.Text.IsNullOrEmpty() || !txtHoja.Text.IsNumeric())
                mensaje = "Escriba un numero de hoja VALIDO para entregar por favor.";
            else if (txtHoja.Value < mProgramacionJuego.HojaInicial || txtHoja.Value > mProgramacionJuego.HojaFinal)
                mensaje = "No se puede entregar una hoja que no ha sido impresa, verifique la cantidad de hojas que se entregaron";

            if (mensaje.NotIsNullOrEmpty())
            {
                MostrarMensajeError(mensaje);
            }

            return mensaje.IsNullOrEmpty();
        }

        private void GuardarEntrega()
        {
            if (DatosRequeridosGuardar())
            {
                var listaHojas = new List<int>();

                foreach (var hoja in lstHojas.Items)
                    listaHojas.Add(Convert.ToInt32(hoja));

                var mVendedorResumen = new VendedorResumen() 
                {
                    TotalCartones = (int)txtCartones.Value,
                    CartonesCortesia = (int)txtCortesia.Value,                    
                };

                if (mVendedorHoja.IdProgramacionJuego.IsOn(0))
                    mVendedorHoja.IdProgramacionJuego = mProgramacionJuego.IdProgramacionJuego;

                mVendedorResumen.ValorTotal = (mVendedorResumen.TotalCartones - mVendedorResumen.CartonesCortesia) * mProgramacionJuego.ValorCarton;                

                var resultado = mDominioVendedorHojas.RegistrarHojaVendedor(mVendedorResumen, mVendedorHoja, listaHojas);

                if (resultado.Ok)
                {
                    MostrarMensajeInformativo(resultado.Mensaje);
                    LimpiarControles();
                    CargarGrilla();
                }
                else
                    MostrarMensajeError(resultado.Mensaje);                
            }
        }

        private bool DatosRequeridosGuardar()
        {
            string mensaje = string.Empty;

            if (mVendedorHoja == null)
                mensaje = "Debe seleccionar un VENDEDOR antes de agregar hojas.";
            else if (mVendedorHoja.IdVendedor < 0)
                mensaje = "Debe seleccionar un VENDEDOR antes de agregar hojas.";
            else if (lstHojas.Items.IsNullOrZeroItems())
                mensaje = "Debe entregar mínimo 1 HOJA al vendedor.";            
            else if (txtCortesia.Value > txtCartones.Value)
                mensaje = "El número de cartones de cortesia NO PUEDE SUPERAR el número de cartones de venta.";

            var resumen = mDominioVendedorResumen.ObtenerResumenVendedor(mVendedorHoja.IdVendedor, mVendedorHoja.IdProgramacionJuego);

            if (resumen != null && resumen.Cobrado.IsOn(1))
            {
                mensaje = "El vendedor se encuentra BLOQUEADO para este juego";
                LimpiarControles();
            }

            if (mensaje.NotIsNullOrEmpty())
            {
                MostrarMensajeError(mensaje);
            }

            return mensaje.IsNullOrEmpty();
        }

        private bool DatosRequeridosEliminar()
        {
            string mensaje = string.Empty;
            
            if (lstHojas.SelectedIndex.IsOn(-1))
                mensaje = "Debe seleccinar la hoja que desea ELIMINAR.";

            if (mensaje.IsNullOrEmpty())
            {
                var resumen = mDominioVendedorResumen.ObtenerResumenVendedor(mVendedorHoja.IdVendedor, mVendedorHoja.IdProgramacionJuego);

                if (resumen != null && resumen.Cobrado.IsOn(1))
                    mensaje = "El jugador ya realizó el pago, no se puede eliminar esta hoja.";
            }

            if (mensaje.NotIsNullOrEmpty())
            {
                MostrarMensajeError(mensaje);
            }

            return mensaje.IsNullOrEmpty();
        }

        private void EliminarHoja()
        {
            if (DatosRequeridosEliminar())
            {
                if (ValidarSegundaClave())
                {
                    var vendedorResumen = mDominioVendedorResumen.ObtenerResumenVendedor(mVendedorHoja.IdVendedor, mVendedorHoja.IdProgramacionJuego);
                    mVendedorHoja.NumeroHoja = Convert.ToInt32(lstHojas.SelectedItem.ToString());

                    var hojaExistente = mDominioVendedorHojas.ObtenerHojaVendedor(mVendedorHoja.IdVendedor, mVendedorHoja.IdProgramacionJuego, mVendedorHoja.NumeroHoja);

                    if (hojaExistente == null)
                    {
                        //La hoja no existe en la base de datos, solo la borramos del control.
                        lstHojas.Items.Remove(lstHojas.SelectedItem);
                        txtCartones.Value -= mNumeroCartonesHoja;
                        MostrarMensajeInformativo("La hoja se eliminó correctamente.");
                        return;
                    }
                    
                    if (mVendedorHoja.IdProgramacionJuego.IsOn(0))
                        mVendedorHoja.IdProgramacionJuego = mProgramacionJuego.IdProgramacionJuego;

                    vendedorResumen.TotalCartones -= mNumeroCartonesHoja;
                    vendedorResumen.ValorTotal = vendedorResumen.TotalCartones * mProgramacionJuego.ValorCarton;
                    vendedorResumen.ValorPendiente = vendedorResumen.ValorTotal - vendedorResumen.PagoAnticipado;
                                        
                    var resultado = mDominioVendedorHojas.EliminarHojaVendedor(vendedorResumen, mVendedorHoja);

                    if (resultado.Ok)
                    {
                        MostrarMensajeInformativo(resultado.Mensaje);
                        CargarDatosVendedor(Grilla.CurrentCell.RowIndex);
                    }
                    else
                        MostrarMensajeError(resultado.Mensaje);
                }
            }
        }

        private void ImprimirPlanilla()
        {
            EjecutarReporte(CargarDataSetReporte(), new ReportePlanillasVendedor());
        }

        private DataSet CargarDataSetReporte()
        {
            DtsPlanilla ds = new DtsPlanilla();
            var tablaEncabezado = ds.EncabezadoPlanilla;
            var tablaDetalle = ds.DetallePlanilla;

            var listaVendedores = mDominioVendedorHojas.ObtenerHojasProgramacion(mProgramacionJuego.IdProgramacionJuego).ToList();
            var listaHojas = listaVendedores;

            foreach (var vendedor in listaVendedores.GroupBy(x => x.IdVendedor).ToList())
            {
                var listaHojasVendedor = listaHojas.Where(x => x.IdVendedor == vendedor.Key).OrderBy(x => x.NumeroHoja).Take(15);                
                var indice = 1;

                DtsPlanilla.DetallePlanillaRow row = tablaDetalle.NewDetallePlanillaRow();

                var objVendedor = new DominioVendedor(SesionActiva.UsuarioActual.IdUsuario).FetchOne(vendedor.Key);

                row.CodigoVendedor = objVendedor.Codigo;
                row.NombreVendedor = $"{objVendedor.Nombres} {objVendedor.Apellidos}";
                row.Total = listaHojasVendedor.Count();

                foreach (var hoja in listaHojasVendedor)
                {
                    switch (indice)
                    {
                        case 1:
                            row.Hoja1 = hoja.NumeroHoja;
                            break;
                        case 2:
                            row.Hoja2 = hoja.NumeroHoja;
                            break;
                        case 3:
                            row.Hoja3 = hoja.NumeroHoja;
                            break;
                        case 4:
                            row.Hoja4 = hoja.NumeroHoja;
                            break;
                        case 5:
                            row.Hoja5 = hoja.NumeroHoja;
                            break;
                        case 6:
                            row.Hoja6 = hoja.NumeroHoja;
                            break;
                        case 7:
                            row.Hoja7 = hoja.NumeroHoja;
                            break;
                        case 8:
                            row.Hoja8 = hoja.NumeroHoja;
                            break;
                        case 9:
                            row.Hoja9 = hoja.NumeroHoja;
                            break;
                        case 10:
                            row.Hoja10 = hoja.NumeroHoja;
                            break;
                        case 11:
                            row.Hoja11 = hoja.NumeroHoja;
                            break;
                        case 12:
                            row.Hoja12 = hoja.NumeroHoja;
                            break;
                        case 13:
                            row.Hoja13 = hoja.NumeroHoja;
                            break;
                        case 14:
                            row.Hoja14 = hoja.NumeroHoja;
                            break;
                        case 15:
                            row.Hoja15 = hoja.NumeroHoja;
                            break;
                    }

                    indice++;
                }

                tablaDetalle.AddDetallePlanillaRow(row);                
            }

            DtsPlanilla.EncabezadoPlanillaRow rowHeader = tablaEncabezado.NewEncabezadoPlanillaRow();
            rowHeader.IdProgramacionJuego = mProgramacionJuego.IdProgramacionJuego.ToString();
            tablaEncabezado.AddEncabezadoPlanillaRow(rowHeader);

            ds.AcceptChanges();

            return ds;
        }

        private void CmdProgramacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            mNumeroCartonesHoja = Convert.ToInt32(ObtenerValorParametroGeneral("Caja-CantidadCartonesHoja"));
            mProgramacionJuego = ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion);
            mMaximoHojaEntregar = ((mProgramacionJuego.CartonFinal - mProgramacionJuego.CartonInicial) / mNumeroCartonesHoja) + 1;

            LimpiarControles();
            CargarGrilla();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CargarGrilla();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void Grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosVendedor(Grilla.CurrentCell.RowIndex);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarHoja();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            EliminarHoja();
        }

        private void txtHoja_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AgregarHoja();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarEntrega();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprimirPlanilla();
        }
    }
}
