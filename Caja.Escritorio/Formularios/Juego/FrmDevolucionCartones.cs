using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Juego
{
    public partial class FrmDevolucionCartones : Base
    {
        DominioVendedor mDominioVendedor;
        DominioHojasDevueltas mDominioHojasDevueltas;
        DominioVendedorHojas mDominioVendedorHojas;
        DominioVendedorModulo mDominioVendedorModulo;
        DominioVendedorResumen mDominioVendedorResumen;
        DominioProgramacionJuego mDominioProgramacion;
        ProgramacionJuego mProgramacionJuego;
        VendedorHoja mVendedorHoja;

        public FrmDevolucionCartones()
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

        private void AgregarHoja()
        {
            if (DatosRequeridosAgregar())
            {
                if (lstHojas.Items.Contains(txtHoja.Text))
                {
                    VolverCampoHoja();
                    MostrarMensajeInformativo("La hoja ya se encuentra en el listado.");
                    return; // Ya esta la hoja agregada.
                }

                if (!mDominioVendedorHojas.ExisteHoja(mProgramacionJuego.IdProgramacionJuego, (int)txtHoja.Value) == false)
                {
                    /// Valida que la hoja no se encuentre en la devolucion de cartones
                    var listadoHoja = mDominioHojasDevueltas.ObtenerHojasDevueltasProgramacion(mProgramacionJuego.IdProgramacionJuego)
                        .Where(x => x.Estado == 'A' && x.NumeroHoja == (int)txtHoja.Value).ToList();

                    if (listadoHoja.IsNullOrZeroItems())
                    {
                        lstHojas.Items.Add(txtHoja.Text);
                        lblTotalHojas.Text = $"Total Hojas: {lstHojas.Items.Count}";
                    }
                    else
                        MostrarMensajeError("La hoja esta registrada como DEVUELTA dentro del mismo juego.");
                }
                else
                {
                    var hoja = mDominioVendedorHojas.ObtenerHojasProgramacion(mProgramacionJuego.IdProgramacionJuego).ToList()
                        .FirstOrDefault(x => x.NumeroHoja == (int)txtHoja.Value);

                    if (hoja != null)
                    {
                        var vendedor = mDominioVendedor.FetchOne(hoja.IdVendedor);

                        MostrarMensajeError($"La hoja digitada ya ha sido asignada previamente.{Environment.NewLine}Vendedor: {vendedor.Nombres} {vendedor.Apellidos}" +
                            $"{Environment.NewLine}Código: {vendedor.Codigo}");
                    }
                    else
                    {
                        MostrarMensajeError($"La hoja {(int)txtHoja.Value} no ha sido entregada, por tal motivo no se puede devolver.");
                    }
                }

                VolverCampoHoja();
            }
        }

        private bool DatosRequeridosAgregar()
        {
            string mensaje = string.Empty;

            if (txtHoja.Text.IsNullOrEmpty() || !txtHoja.Text.IsNumeric())
                mensaje = "Escriba un numero de hoja VALIDO para entregar por favor.";
            else if (txtHoja.Value < mProgramacionJuego.HojaInicial || txtHoja.Value > mProgramacionJuego.HojaFinal)
                mensaje = "No se puede entregar una hoja que no ha sido impresa, verifique la cantidad de hojas que se entregaron";

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
                // mDominioHojasDevueltas.Deshabilitar(mProgramacionJuego.IdProgramacionJuego, Convert.ToInt32(lstHojas.SelectedItem.ToString()));
                lstHojas.Items.Remove(lstHojas.SelectedItem);
                lblTotalHojas.Text = $"Total Hojas: {lstHojas.Items.Count}";               
            }
        }

        private bool DatosRequeridosEliminar()
        {
            string mensaje = string.Empty;

            if (lstHojas.SelectedIndex.IsOn(-1))
                mensaje = "Debe seleccionar la hoja que desea ELIMINAR.";

            if (mensaje.NotIsNullOrEmpty())
                MostrarMensajeError(mensaje);

            return mensaje.IsNullOrEmpty();
        }

        private void VolverCampoHoja()
        {
            txtHoja.ResetText();
            txtHoja.Focus();
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstHojas.Items.Count > 0)
            {
                var listaHojas = new List<int>();
                foreach (var hoja in lstHojas.Items)
                    listaHojas.Add(Convert.ToInt32(hoja));

                var resultado = mDominioHojasDevueltas.Guardar(mProgramacionJuego.IdProgramacionJuego, listaHojas);

                if (resultado.Ok)
                {
                    MostrarMensajeInformativo(resultado.Mensaje);
                    LimpiarControles();
                    CargarLista();
                }
                else
                    MostrarMensajeError(resultado.Mensaje);
            }
        }

        private void cmdProgramacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            mProgramacionJuego = ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion);
            
            LimpiarControles();
            CargarLista();
        }

        public void LimpiarControles()
        {           
            txtHoja.Text = "";
            lstHojas.Items.Clear();
            lblTotalHojas.Text = "";
        }

        public void CargarLista()
        {
            var listado = mDominioHojasDevueltas.ObtenerHojasDevueltasProgramacion(mProgramacionJuego.IdProgramacionJuego);
            listado.ForEach(x => lstHojas.Items.Add(x.NumeroHoja.ToString()));

            lblTotalHojas.Text = $"Total Hojas: {lstHojas.Items.Count}";
        }
    }
}
