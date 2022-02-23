using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Caja.Escritorio.Formularios.Reportes;
using System.Data;
using Caja.Escritorio.Formularios.Reportes.DataSets;

namespace Caja.Escritorio.Formularios.Juego
{
    public partial class FrmImpresionHojas : Base
    {
        DominioProgramacionJuego mDominioProgramacion;
        DominioRoe mDominioRoe;
        List<ProgramacionJuego> mListaProgramacion;
        List<Listabla> mListaSeries;
        ProgramacionJuego mProgramacionJuego;

        public FrmImpresionHojas()
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
            CargaCombo(cmdProgramacion, mListaProgramacion, "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList);

            ImprimirToolStripMenuItem.Enabled = !mListaProgramacion.IsNullOrZeroItems();

            if (!mListaProgramacion.IsNullOrZeroItems())
            {
                mListaSeries = mDominioRoe.FindAllSeries();
                CargaCombo(cmdSeries, mListaSeries, "Fabrica", "IdLisTablas", ComboBoxStyle.DropDownList);
            }
        }

        private void Imprimir()
        {
            if (chkSoloCodigo.Checked)
                EjecutarReporte(CargarDataSetReporte(), new ReporteHojasJuego());
            else
                EjecutarReporte(CargarDataSetReporte(), new ReporteHojasJuego());
        }

        private DataSet CargarDataSetReporte()
        {
            DtsImpresionCartones ds = new DtsImpresionCartones();
            var tablaEncabezado = ds.Encabezado;
            var tablaDetalle = ds.Detalle;

            int mNumeroCartonesHoja = Convert.ToInt32(ObtenerValorParametroGeneral("Caja-CantidadCartonesHoja"));

            string nombreHoja = string.Empty;
            string nombreCarton = string.Empty;
            int numeroCarton = 1;

            for (int hoja = mProgramacionJuego.HojaInicial; hoja <= mProgramacionJuego.HojaFinal; hoja++)
            {
                nombreHoja = $"H-{mProgramacionJuego.IdProgramacionJuego}-{hoja}";

                /// Inserto en la tabla encabezado.
                DtsImpresionCartones.EncabezadoRow rowHeader = tablaEncabezado.NewEncabezadoRow();
                rowHeader.IdHoja = hoja;
                rowHeader.NombreHoja = nombreHoja;
                rowHeader.FechaProgramada = mProgramacionJuego.FechaProgramada.ToLongDateString();
                rowHeader.NumeroHoja = hoja.ToString();
                tablaEncabezado.AddEncabezadoRow(rowHeader);

                for (int indice = 1; indice <= mNumeroCartonesHoja; indice++)
                {
                    nombreCarton = $"C-{mProgramacionJuego.IdProgramacionJuego}-{numeroCarton:D6}-{txtSimbolo.Text.Trim()}";

                    /// Inserto en la tabla detalle.
                    DtsImpresionCartones.DetalleRow detail = tablaDetalle.NewDetalleRow();
                    detail.IdHoja = hoja;
                    detail.NombreCarton = nombreCarton;
                    detail.NumeroCarton = numeroCarton.ToString();                    
                    tablaDetalle.AddDetalleRow(detail);

                    numeroCarton++;
                }
            }

            ds.AcceptChanges();

            return ds;
        }

        private void ImprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de realizar la impresión de cartones?", "Confirmación", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        Imprimir();
                        break;
                    }
            }
        }

        private void cmdProgramacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdProgramacion.SelectedIndex >= 0)
            {
                mProgramacionJuego = mDominioProgramacion.ObtenerProgramacion(ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion).IdProgramacionJuego);

                cmdSeries.SelectedValue = mProgramacionJuego.IdSerie;
                txtCartonInicial.Value = mProgramacionJuego.CartonInicial;
                txtCartonFinal.Value = mProgramacionJuego.CartonFinal;
            }
        }

        private void cmdSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdSeries.SelectedIndex >= 0)
                txtSimbolo.Text = ObtenerItemCombo<Listabla>(cmdSeries).Simbolo;
        }
    }
}
