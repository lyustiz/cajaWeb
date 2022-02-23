using Caja.Dominio;
using Caja.Entidades;
using Caja.Entidades.Vistas;
using Caja.Escritorio.App;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System;
using System.IO;

namespace Caja.Escritorio.Formularios.Juego.Reportes
{
    public partial class FrmListadoCartonesVendidosDetalle : Base
    {
        DominioProgramacionJuego mDominioProgramacion;
        DominioVendedorHojas mDominioVendedorHojas;
        DominioHojasDevueltas mDominioHojasDevueltas;
        DominioProgramacionDevolucionCodigoBarra mDominioDevolucionCodigoBarra;
        DominioVendedorModulo mDominioVendedorModulo;
        DominioVendedor mDominioVendedor;
        DominioRoe mDominioRoe;
        List<ProgramacionJuego> mListaProgramacion;
        List<VistaVendedoresProgramacion> mListasVendedores;
        List<VendedorHoja> mListasHojasProgramacion;
        List<Listabla> mListaSeries;
        List<ProgramacionJuegoHojaDevuelta> mListaHojasDevueltas;
        ProgramacionJuego mProgramacionJuego;
        int mNumeroCartonesHoja;

        public FrmListadoCartonesVendidosDetalle()
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
            mDominioVendedor = new DominioVendedor(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRoe = new DominioRoe();
        }

        private void InicializarControles()
        {
            mNumeroCartonesHoja = Convert.ToInt32(ObtenerValorParametroGeneral("Caja-CantidadCartonesHoja"));
            mListaProgramacion = mDominioProgramacion.BuscarProgramacion();
            Base.CargaCombo(cmdProgramacion, mListaProgramacion, "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList);
        }

        private void cmdProgramacion_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmdProgramacion.SelectedIndex >= 0)
            {
                mProgramacionJuego = ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion);
                mListasHojasProgramacion = mDominioVendedorHojas.ObtenerHojasProgramacion(mProgramacionJuego.IdProgramacionJuego);
                mListasVendedores = mDominioProgramacion.ObtenerVendedoresProgramacionJuego(string.Empty, mProgramacionJuego.IdProgramacionJuego);
                var lis = mDominioHojasDevueltas.ObtenerHojasDevueltasProgramacion(mProgramacionJuego.IdProgramacionJuego);
                Base.CargaCombo(cmdVendedores, mListasVendedores, "NombreCompleto", "IdVendedor", ComboBoxStyle.DropDownList);
            }
        }

        private void cmdVendedores_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmdVendedores.SelectedIndex >= 0)
            {
                int mTotalHojas = 0;
                int mTotalHojasValida = 0;
                int mTotalCartonesValida = 0;

                var serie = mDominioRoe.FindAllSeries().FirstOrDefault(x => x.IdLisTablas == mProgramacionJuego.IdSerie);

                lstHojas.Items.Clear();
                lstCartones.Items.Clear();

                foreach (VendedorHoja hoja in mListasHojasProgramacion)
                {
                    mTotalHojas += 1;

                    ProgramacionJuegoHojaDevuelta devolucion = mDominioHojasDevueltas.ObtenerHojasDevueltasProgramacion(mProgramacionJuego.IdProgramacionJuego).FirstOrDefault(x => x.NumeroHoja == hoja.NumeroHoja);

                    if (devolucion != null)
                    {
                        string mCodigoBarras = $"H-{mProgramacionJuego.IdProgramacionJuego}-{hoja.NumeroHoja.ToString().PadLeft(6, '0')}";

                        ProgramacionDevolucionCodigoBarra devolucionCodigoBarras = mDominioDevolucionCodigoBarra.ObtenerPorProgramacion(mProgramacionJuego.IdProgramacionJuego).FirstOrDefault(x => x.HojaCarton == mCodigoBarras);

                        if (devolucionCodigoBarras != null)
                        {
                            // Inicial y final de los cartones.
                            int mNumeroInicial = (hoja.NumeroHoja * mNumeroCartonesHoja) - mNumeroCartonesHoja + 1;
                            int mNumeroFinal = hoja.NumeroHoja * mNumeroCartonesHoja;

                            string mListaCartones = string.Empty;
                            // Lista todos los cartones.
                            for (int i = mNumeroInicial; i <= mNumeroFinal; i++)
                            {
                                mListaCartones += $"'C-{mProgramacionJuego.IdProgramacionJuego}-{i.ToString().PadLeft(6, '0')}-{serie.Simbolo}',";
                                lstCartones.Items.Add($"C-{mProgramacionJuego.IdProgramacionJuego}-{i.ToString().PadLeft(6, '0')}-M---");
                            }

                            int cantidadDevoluciones = mDominioDevolucionCodigoBarra.ObtenerPorProgramacion(mProgramacionJuego.IdProgramacionJuego).Count(x => x.HojaCarton.IsOnIgnoreCase(mListaCartones.Split(',')));

                            mTotalCartonesValida += cantidadDevoluciones;

                            if (cantidadDevoluciones > 0)
                                lstHojas.Items.Add($"{hoja.NumeroHoja} ***");
                            else
                            {
                                lstHojas.Items.Add($"{hoja.NumeroHoja}");
                                mTotalHojasValida += 1;
                            }
                        }
                        else
                            lstHojas.Items.Add($"{hoja.NumeroHoja}");
                    }
                    else
                        lstHojas.Items.Add($"{hoja.NumeroHoja}");
                }

                // Asignar los resultados
                int mTotalCartones = mTotalHojas * mNumeroCartonesHoja;
                txCartones.Text = Convert.ToString(mTotalCartones);
                txCartonesValidos.Text = Convert.ToString(mTotalCartones * mTotalCartonesValida);
                txHojas.Text = Convert.ToString(mTotalHojas);
                txHojasValidas.Text = Convert.ToString(mTotalCartonesValida);
            }
        }

        private void ExportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName = $"Juego {mProgramacionJuego.IdProgramacionJuego} Exportacion Cartones Vendidos Detalle {DateTime.Now.ToString("ddMMyyyy")}"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var lista = string.Empty;

                foreach (var item in lstCartones.Items)                
                    lista += $"{item},";                

                File.WriteAllLines(saveFileDialog.FileName, lista.Split(','));
                MostrarMensajeInformativo("Registros exportados exitosamente");
            }
        }
    }
}
