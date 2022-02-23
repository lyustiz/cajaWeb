using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Juego
{
    public partial class FrmModificarRangoCartones : Base
    {
        DominioProgramacionJuego mDominioProgramacion;
        DominioRoe mDominioRoe;
        List<ProgramacionJuego> mListaProgramacion;
        List<Listabla> mListaSeries;
        ProgramacionJuego mProgramacionJuego;

        public FrmModificarRangoCartones()
        {
            InitializeComponent();
            InstaciarObjetos();            
            InicializarControles();            
        }

        private void InstaciarObjetos()
        {
            mDominioProgramacion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRoe = new DominioRoe();            
        }

        private void InicializarControles()
        {         
            mListaProgramacion = mDominioProgramacion.BuscarProgramacionActiva();
            Base.CargaCombo(cmdProgramacion, mListaProgramacion, "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList);

            guardarToolStripMenuItem.Enabled = !mListaProgramacion.IsNullOrZeroItems();

            if (!mListaProgramacion.IsNullOrZeroItems())
            {
                mListaSeries = mDominioRoe.FindAllSeries();
                Base.CargaCombo(cmdSeries, mListaSeries, "Fabrica", "IdLisTablas", ComboBoxStyle.DropDownList);

                ConfigurarEventos();
            }
        }

        private void ConfigurarEventos()
        {
            txtNuevoCartonFinal.LostFocus += TxtNuevoCartonFinal_LostFocus;            
        }

        private void CalcularNuevosValores()
        {
            var parametro =  ObtenerParametroGeneral("Caja-CantidadCartonesHoja");

            if (parametro != null)
            {
                var valores = GenerarNumeroCartonFinal((int)txtNuevoCartonFinal.Value, (int)txtCartonInicial.Value, Convert.ToInt32(parametro.Valor));
                txtNuevoCartonFinal.Value = valores.Item1;
                txtHojaFinal.Value = valores.Item2;
            }
            else
                MostrarMensajeError("No esta configurado el parametro de CantidadCartonesHoja, configurelo para calcular las hojas.");
        }

        private bool DatosRequeridos()
        {
            string mensaje = string.Empty;
                       
            if (txtCartonFinal.Value >= txtNuevoCartonFinal.Value)
                mensaje = "El número nuevo de cartones debe ser SUPERIOR al valor anterior.";
            
            if (mensaje.NotIsNullOrEmpty())
            {
                MostrarMensajeError(mensaje);
            }

            return mensaje.IsNullOrEmpty();
        }

        private void TxtNuevoCartonFinal_LostFocus(object sender, EventArgs e)
        {
            CalcularNuevosValores();
        }

        private void cmdProgramacion_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmdProgramacion.SelectedIndex >= 0)
            {
                mProgramacionJuego = mDominioProgramacion.ObtenerProgramacion(ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion).IdProgramacionJuego);

                cmdSeries.SelectedValue = mProgramacionJuego.IdSerie;
                txtCartonInicial.Value = mProgramacionJuego.CartonInicial;
                txtCartonFinal.Value = mProgramacionJuego.CartonFinal;
                txtHojaInicial.Value = mProgramacionJuego.HojaInicial;
                txtHojaFinal.Value = mProgramacionJuego.HojaFinal;
                txtNuevoCartonFinal.Value = mProgramacionJuego.CartonFinal;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatosRequeridos())
            {
                var programacion = mDominioProgramacion.ObtenerProgramacion(ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion).IdProgramacionJuego);
                programacion.CartonFinal = (int)txtNuevoCartonFinal.Value;
                programacion.HojaFinal = (int)txtHojaFinal.Value;

                var resultado = mDominioProgramacion.ModificarRangosProgramacion(programacion);

                if (resultado.Ok)
                {
                    MostrarMensajeInformativo(resultado.Mensaje);
                    txtCartonFinal.Value = txtNuevoCartonFinal.Value;
                }
                else
                    MostrarMensajeError(resultado.Mensaje);
            }
        }
    }
}
