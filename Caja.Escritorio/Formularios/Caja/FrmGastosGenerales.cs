using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Caja
{
    public partial class FrmGastosGenerales : Base
    {
        private DominioGastoGeneral mDominioGasto;
        private DominioRoe mDominioRoe;

        public FrmGastosGenerales()
        {
            InitializeComponent();
            lblNombreUsuario.Text = SesionActiva.UsuarioActual.NombreCompleto;

            InstaciarObjetos();
            InicializarControles();
        }

        private void InstaciarObjetos()
        {
            mDominioGasto = new DominioGastoGeneral(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRoe = new DominioRoe();
        }

        private void InicializarControles()
        {
            CargaCombo(cmdConceptos, mDominioRoe.FindAllConceptoGastos(), "Nombre", "Id", ComboBoxStyle.DropDownList, seleccionPrimerItem: false);
            CargaCombo(cmdSocios, mDominioRoe.FindAllSocios(), "Nombre", "Id", ComboBoxStyle.DropDownList, seleccionPrimerItem: false);
            dtpFechaRegsitro.Value = DateTime.Now;
        }

        private void CargarGrilla()
        {
            Grilla.Rows.Clear();

            var mListaGastos = mDominioGasto.ObtenerGastosGeneralesPeriodo((byte)dtpFechaRegsitro.Value.Month, (short)dtpFechaRegsitro.Value.Year);

            foreach (var gasto in mListaGastos)
                Grilla.Rows.Add(new object[] { gasto.IdGastoGeneral, gasto.FechaRegistro, gasto.NombreUsuario, gasto.Concepto, string.Format(SesionActiva.FormatoMoneda, gasto.Valor) });
        }

        private bool DatosRequeridos()
        {
            string mensaje = string.Empty;

            if (cmdConceptos.SelectedIndex < 0)
                mensaje = "Debe seleccionar un concepto.";
            else if (txtValorGasto.Value < 1)
                mensaje = $"Debe ingresar un valor para el gasto.";
            else if (txtDescripcion.Text.IsNullOrEmpty())
                mensaje = $"Debe ingresar una descripción del gasto.";

            if (mensaje.NotIsNullOrEmpty())
            {
                MostrarMensajeError(mensaje);
            }

            return mensaje.IsNullOrEmpty();
        }

        private void LimpiarControles()
        {
            dtpFechaRegsitro.Value = DateTime.Now;
            txtDescripcion.ResetText();
            txtValorGasto.Value = 0;
            cmdConceptos.SelectedIndex = -1;
            cmdSocios.SelectedIndex = -1;
            rbCaja.Checked = true;
        }

        private char ObtenerOrigenPago()
        {
            if (rbCaja.Checked)
                return 'C';
            if (rbBancos.Checked)
                return 'B';
            if (rbSocial.Checked)
                return 'S';

            return 'C';
        }

        private void dtpFechaRegsitro_ValueChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void cmdConceptos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdConceptos.SelectedIndex >= 0)
            {
                var mConcepto = mDominioGasto.ObtenerConceptoGasto(ObtenerItemCombo<ItemLista>(cmdConceptos).Id);

                if (mConcepto != null && mConcepto.Socios.IsOn((short)1))
                    cmdSocios.Enabled = true;
                else
                {
                    cmdSocios.SelectedIndex = -1;
                    cmdSocios.Enabled = false;
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatosRequeridos())
            {
                GastoGeneral mGasto = new GastoGeneral()
                {
                    IdUsuario = SesionActiva.UsuarioActual.IdUsuario,
                    IdConceptoGasto = ObtenerItemCombo<ItemLista>(cmdConceptos).Id,
                    Descripcion = txtDescripcion.Text.Trim(),
                    Valor = (decimal)txtValorGasto.Value,
                    Socio = ObtenerItemCombo<ItemLista>(cmdSocios)?.Nombre,
                    FechaRegistro = dtpFechaRegsitro.Value,
                    Mes = (byte)dtpFechaRegsitro.Value.Month,
                    Anio = (short)dtpFechaRegsitro.Value.Year,
                    OrigenPago = ObtenerOrigenPago()
                };

                RespuestaDominio respuesta = mDominioGasto.CrearGasto(mGasto, SesionActiva.EsSocio);

                if (respuesta.Ok)
                {
                    MostrarMensajeInformativo(respuesta.Mensaje);
                    CargarGrilla();
                    LimpiarControles();                    
                }
                else
                    MostrarMensajeError(respuesta.Mensaje);
            }
        }
    }
}
