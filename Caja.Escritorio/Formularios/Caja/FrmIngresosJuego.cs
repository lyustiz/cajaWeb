using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Caja
{
    public partial class FrmIngresosJuego : Base
    {
        private DominioIngresoProgramacionJuego mDominioIngreso;
        private DominioProgramacionJuego mDominioProgramacion;
        private DominioRoe mDominioRoe;
        private ProgramacionJuego mProgramacionJuego;
        public FrmIngresosJuego()
        {
            InitializeComponent();
            lblNombreUsuario.Text = SesionActiva.UsuarioActual.NombreCompleto;

            InstaciarObjetos();
            InicializarControles();
        }

        private void InstaciarObjetos()
        {
            mDominioIngreso = new DominioIngresoProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioProgramacion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRoe = new DominioRoe();
        }

        private void InicializarControles()
        {
            CargaCombo(cmdProgramacion, mDominioProgramacion.BuscarProgramacionActiva(), "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList);
            CargaCombo(cmdConceptos, mDominioRoe.FindAllConceptoIngresos(), "Nombre", "Id", ComboBoxStyle.DropDownList, seleccionPrimerItem: false);            
        }

        private void CargarGrilla()
        {
            Grilla.Rows.Clear();

            var mListaIngresos = mDominioIngreso.ObtenerIngresosProgramacionJuego(mProgramacionJuego.IdProgramacionJuego);

            foreach (var ingresos in mListaIngresos)
                Grilla.Rows.Add(new object[] { ingresos.IdIngresoJuego, ingresos.FechaHora, ingresos.NombreUsuario, ingresos.Concepto, string.Format(SesionActiva.FormatoMoneda, ingresos.Valor) });
        }

        private bool DatosRequeridos()
        {
            string mensaje = string.Empty;

            if (cmdProgramacion.SelectedIndex < 0)
                mensaje = "Debe seleccionar un juego.";
            if (cmdConceptos.SelectedIndex < 0)
                mensaje = "Debe seleccionar un concepto.";
            else if (txtValorIngreso.Value < 1)
                mensaje = $"Debe ingresar un valor para el ingreso.";
            else if (txtDescripcion.Text.IsNullOrEmpty())
                mensaje = $"Debe ingresar una descripción del ingreso.";

            if (mensaje.NotIsNullOrEmpty())
            {
                MostrarMensajeError(mensaje);
            }

            return mensaje.IsNullOrEmpty();
        }

        private void LimpiarControles()
        {
            txtDescripcion.ResetText();
            txtValorIngreso.Value = 0;
            cmdConceptos.SelectedIndex = -1;             
        }

        private void cmdProgramacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdProgramacion.SelectedIndex >= 0)
            {
                mProgramacionJuego = mDominioProgramacion.ObtenerProgramacion(ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion).IdProgramacionJuego);
                CargarGrilla();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatosRequeridos())
            {
                IngresoProgramacionJuego mIngreso = new IngresoProgramacionJuego()
                {
                    IdProgramacionJuego = mProgramacionJuego.IdProgramacionJuego,
                    IdUsuario = SesionActiva.UsuarioActual.IdUsuario,
                    Descripcion = txtDescripcion.Text.Trim(),
                    IdConceptoIngreso = ObtenerItemCombo<ItemLista>(cmdConceptos).Id,
                    Valor = (double)txtValorIngreso.Value                    
                };

                RespuestaDominio respuesta = mDominioIngreso.CrearIngreso(mIngreso);

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
