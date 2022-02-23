using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Juego
{
    public partial class FrmCartonesFaltantse : Base
    {
        DominioProgramacionJuego mDominioProgramacion;
        DominioHojasDevueltas mDominioHojasDevueltas;
        DominioRoe mDominioRoe;
        List<ProgramacionJuego> mListaProgramacion;
        List<Listabla> mListaSeries;
        ProgramacionJuego mProgramacionJuego;

        public FrmCartonesFaltantse()
        {
            InitializeComponent();
            InstaciarObjetos();            
            InicializarControles();            
        }

        private void InstaciarObjetos()
        {
            mDominioProgramacion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioHojasDevueltas = new DominioHojasDevueltas(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRoe = new DominioRoe();            
        }

        private void InicializarControles()
        {         
            mListaProgramacion = mDominioProgramacion.BuscarProgramacion();
            Base.CargaCombo(cmdProgramacion, mListaProgramacion, "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList);

            if (!mListaProgramacion.IsNullOrZeroItems())
            {
                mListaSeries = mDominioRoe.FindAllSeries();
                Base.CargaCombo(cmdSeries, mListaSeries, "Fabrica", "IdLisTablas", ComboBoxStyle.DropDownList);
            }
        }       

        private void ValidarCartones()
        {
            lstHojas.Items.Clear();

            var parametro =  ObtenerParametroGeneral("Caja-CantidadCartonesHoja");            
            var consulta = mDominioProgramacion.ConsultarListadoCartones(mProgramacionJuego.IdProgramacionJuego);

            for (var hoja = mProgramacionJuego.HojaInicial; hoja <= mProgramacionJuego.HojaFinal; hoja++)
            {
                if (!consulta.Exists(x => x.NumeroHoja == hoja))                
                    lstHojas.Items.Add(hoja);                
            }
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

                ValidarCartones();
            }
        }

        private void realizarDevoluciónHojasNOEntregadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mBoxResult = MessageBox.Show($"¿Está seguro de realizar la devolución de las hojas NO ENTREGADAS?", "Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (mBoxResult)
            {
                case DialogResult.Yes:
                    var consulta = mDominioProgramacion.ConsultarListadoCartones(mProgramacionJuego.IdProgramacionJuego);
                    var listaHojas = new List<int>();

                    for (var hoja = mProgramacionJuego.HojaInicial; hoja <= mProgramacionJuego.HojaFinal; hoja++)
                    {
                        if (!consulta.Exists(x => x.NumeroHoja == hoja))
                        {
                            /// Agregar el cartón como una devolución.
                            listaHojas.Add(Convert.ToInt32(hoja));
                        }
                    }

                    if (listaHojas.Count > 0)
                    {
                        var resultado = mDominioHojasDevueltas.Guardar(mProgramacionJuego.IdProgramacionJuego, listaHojas);

                        if (resultado.Ok)
                        {
                            MostrarMensajeInformativo(resultado.Mensaje);
                            ValidarCartones();                            
                        }
                        else
                            MostrarMensajeError(resultado.Mensaje);
                    }
                    else
                        MostrarMensajeInformativo("Ya no hay hojas disponibles para la devolución.");

                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
