using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Caja.Escritorio.Formularios.Juego
{
    public partial class FrmGeneracionCartonesVendidos : Base
    {
        DominioProgramacionJuego mDominioProgramacion;
        DominioVendedorHojas mDominioVendedorHojas;
        DominioHojasDevueltas mDominioHojasDevueltas;
        DominioProgramacionDevolucionCodigoBarra mDominioDevolucionCodigoBarra;
        DominioVendedorModulo mDominioVendedorModulo;
        DominioRoe mDominioRoe;
        List<ProgramacionJuego> mListaProgramacion;
        List<Listabla> mListaSeries;
        ProgramacionJuego mProgramacionJuego;

        public FrmGeneracionCartonesVendidos()
        {
            InitializeComponent();
            InstaciarObjetos();            
            InicializarControles();            
        }

        private void InstaciarObjetos()
        {
            mDominioProgramacion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioHojasDevueltas = new DominioHojasDevueltas(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorHojas = new DominioVendedorHojas(SesionActiva.UsuarioActual.IdUsuario);
            mDominioDevolucionCodigoBarra = new DominioProgramacionDevolucionCodigoBarra(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorModulo = new DominioVendedorModulo(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRoe = new DominioRoe();            
        }

        private void InicializarControles()
        {         
            mListaProgramacion = mDominioProgramacion.BuscarProgramacion();
            Base.CargaCombo(cmdProgramacion, mListaProgramacion, "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList);
        }              

        private void cmdProgramacion_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmdProgramacion.SelectedIndex >= 0)
            {
                mProgramacionJuego = mDominioProgramacion.ObtenerProgramacion(ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion).IdProgramacionJuego);

                var parametro = ObtenerParametroGeneral("Caja-CantidadCartonesHoja");
                var listaDevolucionCodigoBarras = mDominioDevolucionCodigoBarra.ObtenerPorProgramacion(mProgramacionJuego.IdProgramacionJuego);

                int pTotalHojasEntregadas = mDominioVendedorHojas.ObtenerHojasProgramacion(mProgramacionJuego.IdProgramacionJuego).Count();
                int pTotalHojasDevuelas = listaDevolucionCodigoBarras.Where(x => x.HojaCarton.StartsWithIgnoreCase("H")).Count();
                int pTotalCartonesDevuelas = listaDevolucionCodigoBarras.Where(x => x.HojaCarton.StartsWithIgnoreCase("C")).Count();
                int pTotalCartonesEntregados = ((pTotalHojasEntregadas - pTotalHojasDevuelas) * Convert.ToInt32(parametro.Valor)) - pTotalCartonesDevuelas;

                int pCantidadModulos = mDominioVendedorModulo.ObtenerModulosProgramacion(mProgramacionJuego.IdProgramacionJuego).Count();

                txtCantidad.Value = pTotalCartonesEntregados;
                txtCantidadModulos.Value = pCantidadModulos;

            }
        }

        private void ExportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                List<string> listaExportable = new List<string>();
                var parametro = ObtenerParametroGeneral("Caja-CantidadCartonesHoja");
                var pSerieProgramacion = mDominioRoe.FindAllSeries().FirstOrDefault(x => x.IdLisTablas == mProgramacionJuego.IdSerie);

                var listadoHojas = mDominioVendedorHojas.ObtenerHojasProgramacion(mProgramacionJuego.IdProgramacionJuego);

                foreach (var hoja in listadoHojas)
                {
                    /// Validar que la hoja este devuelta.
                    int pCantidad = mDominioHojasDevueltas.ObtenerHojasDevueltasProgramacion(mProgramacionJuego.IdProgramacionJuego).OrderByDescending(x => x.IdProgramacionJuegoHojaDevuelta).Count(x => x.NumeroHoja == hoja.NumeroHoja);

                    if (pCantidad.IsOn(0, 2, 4, 6, 8, 10))
                    {
                        for (int indice = 1; indice <= Convert.ToInt32(parametro.Valor); indice++)
                        {
                            int pNumeroCarton = (hoja.NumeroHoja * Convert.ToInt32(parametro.Valor)) - Convert.ToInt32(parametro.Valor) + indice;
                            string pCartonExportable = GenerarNumeroCarton(mProgramacionJuego.IdProgramacionJuego, pNumeroCarton, pSerieProgramacion.Simbolo);
                            var pCantidadDevueltoCodigoBarras = mDominioDevolucionCodigoBarra.ObtenerPorProgramacion(mProgramacionJuego.IdProgramacionJuego).Count(x => x.HojaCarton == pCartonExportable);

                            if (pCantidadDevueltoCodigoBarras == 0)
                            {
                                listaExportable.Add($"{pCartonExportable}-M---");
                            }
                        }
                    }
                }

                var listaModulosExportables = mDominioVendedorModulo.FindByExportables(mProgramacionJuego.IdProgramacionJuego);

                foreach (var exportable in listaModulosExportables)
                {
                    string pCartonExportable = GenerarNumeroCarton(mProgramacionJuego.IdProgramacionJuego, exportable.Carton1, exportable.Serie1);
                    listaExportable.Add($"{pCartonExportable}-M{exportable.IdModulo}-{exportable.Nombre}-{exportable.Celular}-{exportable.Barrio}");

                    pCartonExportable = GenerarNumeroCarton(mProgramacionJuego.IdProgramacionJuego, exportable.Carton2, exportable.Serie2);
                    listaExportable.Add($"{pCartonExportable}-M{exportable.IdModulo}-{exportable.Nombre}-{exportable.Celular}-{exportable.Barrio}");

                    pCartonExportable = GenerarNumeroCarton(mProgramacionJuego.IdProgramacionJuego, exportable.Carton3, exportable.Serie3);
                    listaExportable.Add($"{pCartonExportable}-M{exportable.IdModulo}-{exportable.Nombre}-{exportable.Celular}-{exportable.Barrio}");

                    pCartonExportable = GenerarNumeroCarton(mProgramacionJuego.IdProgramacionJuego, exportable.Carton4, exportable.Serie4);
                    listaExportable.Add($"{pCartonExportable}-M{exportable.IdModulo}-{exportable.Nombre}-{exportable.Celular}-{exportable.Barrio}");

                    pCartonExportable = GenerarNumeroCarton(mProgramacionJuego.IdProgramacionJuego, exportable.Carton5, exportable.Serie5);
                    listaExportable.Add($"{pCartonExportable}-M{exportable.IdModulo}-{exportable.Nombre}-{exportable.Celular}-{exportable.Barrio}");

                    pCartonExportable = GenerarNumeroCarton(mProgramacionJuego.IdProgramacionJuego, exportable.Carton6, exportable.Serie6);
                    listaExportable.Add($"{pCartonExportable}-M{exportable.IdModulo}-{exportable.Nombre}-{exportable.Celular}-{exportable.Barrio}");
                }

                this.Cursor = Cursors.Default;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FileName = $"Juego {mProgramacionJuego.IdProgramacionJuego} Exportacion Cartones Vendidos {DateTime.Now.ToString("ddMMyyyy")}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveFileDialog.FileName, listaExportable);
                    MostrarMensajeInformativo("Registros exportados exitosamente");
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MostrarMensajeError(ex.Message);
            }
        }

        private string GenerarNumeroCarton(int pIdProgramacion, int pNumeroCarton, string pSerie)
        {
            return $"C-{pIdProgramacion}-{pNumeroCarton.ToString().PadLeft(6, '0')}-{pSerie}";
        }
    }
}
