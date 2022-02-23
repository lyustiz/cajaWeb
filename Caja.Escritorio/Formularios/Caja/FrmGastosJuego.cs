using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Caja
{
    public partial class FrmGastosJuego : Base
    {
        private DominioGastoProgramacionJuego mDominioGasto;
        private DominioProgramacionJuego mDominioProgramacion;
        private DominioRoe mDominioRoe;
        private ProgramacionJuego mProgramacionJuego;

        public FrmGastosJuego()
        {
            InitializeComponent();

            lblNombreUsuario.Text = SesionActiva.UsuarioActual.NombreCompleto;

            InstaciarObjetos();
            InicializarControles();
        }

        private void InstaciarObjetos()
        {
            mDominioGasto = new DominioGastoProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioProgramacion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRoe = new DominioRoe();
        }

        private void InicializarControles()
        {
            CargaCombo(cmdProgramacion, mDominioProgramacion.BuscarProgramacionActiva(), "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList);
            CargaCombo(cmdConceptos, mDominioRoe.FindAllConceptoGastos(), "Nombre", "Id", ComboBoxStyle.DropDownList, seleccionPrimerItem: false);
            CargaCombo(cmdSocios, mDominioRoe.FindAllSocios(), "Nombre", "Id", ComboBoxStyle.DropDownList, seleccionPrimerItem: false);
        }

        private void CargarGrilla()
        {
            Grilla.Rows.Clear();

            var mListaGastos = mDominioGasto.ObtenerGastosProgramacionJuego(mProgramacionJuego.IdProgramacionJuego);

            foreach (var gasto in mListaGastos)
                Grilla.Rows.Add(new object[] { gasto.IdGastoJuego, gasto.FechaHora, gasto.NombreUsuario, gasto.Concepto, string.Format(SesionActiva.FormatoMoneda, gasto.Valor) });
        }

        private bool DatosRequeridos()
        {
            string mensaje = string.Empty;

            if (cmdProgramacion.SelectedIndex < 0)
                mensaje = "Debe seleccionar un juego.";
            else if (cmdConceptos.SelectedIndex < 0)
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
            txtDescripcion.ResetText();
            txtValorGasto.Value = 0;
            cmdConceptos.SelectedIndex = -1;
            cmdSocios.SelectedIndex = -1;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatosRequeridos())
            {
                GastoProgramacionJuego mGasto = new GastoProgramacionJuego()
                {
                    IdProgramacionJuego = mProgramacionJuego.IdProgramacionJuego,
                    IdUsuario = SesionActiva.UsuarioActual.IdUsuario,
                    Descripcion = txtDescripcion.Text.Trim(),
                    IdConceptoGasto = ObtenerItemCombo<ItemLista>(cmdConceptos).Id,
                    Valor = (decimal)txtValorGasto.Value,
                    Socio = ObtenerItemCombo<ItemLista>(cmdSocios)?.Nombre
                };

                RespuestaDominio respuesta = mDominioGasto.CrearGasto(mGasto, mProgramacionJuego.FechaProgramada, SesionActiva.EsSocio);

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

        private void cmdProgramacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdProgramacion.SelectedIndex >= 0)
            {
                mProgramacionJuego = mDominioProgramacion.ObtenerProgramacion(ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion).IdProgramacionJuego);
                CargarGrilla();
            }
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
    }
}
