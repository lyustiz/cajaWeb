using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using Caja.Escritorio.Formularios.General;
using Caja.Escritorio.Formularios.Reportes;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios
{
    public class Base : Form
    {
        public readonly DominioParamentroGeneral mDominioParametroGeneral;
        public readonly DominioPerfilPermiso mDominioPermisos;

        public static readonly int SinSeleccion = -1;
        public Base()
        {
            this.KeyPreview = true;
            this.KeyPress += Base_KeyPress;

            mDominioParametroGeneral = new DominioParamentroGeneral();
            mDominioPermisos = new DominioPerfilPermiso();
        }

        private void Base_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
                this.Close();
        }

        public string ObtenerValorParametroGeneral(string referencia)
        {
            ParametroGeneral parametro = mDominioParametroGeneral.FetchBy(TipoBusquedaParametroGeneral.Referencia, referencia);

            if (!(parametro is null))
                return parametro.Valor;

            return string.Empty;
        }

        public bool ValidarSegundaClave()
        {
            DialogResult dr = new DialogResult();
            MsgClave frmClave = new MsgClave();

        reintento:
            dr = frmClave.ShowDialog();

            if (dr == DialogResult.OK && frmClave.Valido)
                return frmClave.Valido;
            else if (dr != DialogResult.OK)
                return false;
            else
                goto reintento; 
        }

        public bool PuedeAcceder(string pNombre, string pDescripcion = "")
        {
            Entidades.Menu objMenu = new Entidades.Menu() { NombreMenu = pNombre, Descripcion = pDescripcion };
            objMenu.IdMenu = mDominioPermisos.ObtenerOCrearPermiso(objMenu, SesionActiva.UsuarioActual.IdUsuario);
            bool tienePermiso = mDominioPermisos.TienePermiso(objMenu.IdMenu, SesionActiva.UsuarioActual.IdUsuario);

            return tienePermiso;
        }

        public void MostrarMensajeError(string pMensaje)
        {
            MessageBox.Show(pMensaje, "Caja", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //MsgConfirm frmConfirm = new MsgConfirm
            //{
            //    EsError = true,
            //    Mensaje = pMensaje
            //};

            //frmConfirm.Configurar();
            //frmConfirm.ShowDialog();
        }

        public void MostrarMensajeInformativo(string pMensaje)
        {
            MessageBox.Show(pMensaje, "Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //MsgConfirm frmConfirm = new MsgConfirm
            //{
            //    EsError = false,
            //    Mensaje = pMensaje
            //};

            //frmConfirm.Configurar();
            //frmConfirm.ShowDialog();
        }

        public Tuple<int, int> GenerarNumeroCartonInicial(int pValor, int cantidadPorHoja)
        {
            int valorCartonInicial = pValor;

            int numeroComenzar = (valorCartonInicial / cantidadPorHoja) * cantidadPorHoja + 1;

            numeroComenzar = numeroComenzar == 0 ? 1 : numeroComenzar;

            if (numeroComenzar != valorCartonInicial)
                valorCartonInicial = numeroComenzar;

            int valorHojaInicial = (valorCartonInicial / cantidadPorHoja) + 1;
            valorHojaInicial = valorHojaInicial == 0 ? 1 : valorHojaInicial;

            return new Tuple<int, int>(valorCartonInicial, valorHojaInicial);
        }

        public Tuple<int, int> GenerarNumeroCartonFinal(int pValorFinal, int pValorIncial, int cantidadPorHoja)
        {
            int valorCartonFinal = pValorFinal;
            int numeroComenzar = cantidadPorHoja;

            if ((valorCartonFinal / cantidadPorHoja) * cantidadPorHoja != valorCartonFinal)
                numeroComenzar = ((valorCartonFinal / cantidadPorHoja) + 1) * cantidadPorHoja;
            else
                numeroComenzar = valorCartonFinal;

            if (numeroComenzar < pValorIncial)
                valorCartonFinal = numeroComenzar;

            if (numeroComenzar != valorCartonFinal)
                valorCartonFinal = numeroComenzar;

            int valorHojaFinal = valorCartonFinal / cantidadPorHoja;
            valorHojaFinal = valorHojaFinal == 0 ? 1 : valorHojaFinal;

            return new Tuple<int, int>(valorCartonFinal, valorHojaFinal);
        }

        public ParametroGeneral ObtenerParametroGeneral(string referencia)
        {
            return mDominioParametroGeneral.FetchBy(TipoBusquedaParametroGeneral.Referencia, referencia);
        }

        public Form AbrirFormulario(Form formulario)
        {
            if (PuedeAcceder(formulario.Name, formulario.Text))
            {
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.MaximizeBox = false;
                formulario.MinimizeBox = false;
                formulario.MinimumSize = formulario.Size;
                formulario.MaximumSize = formulario.Size;
                formulario.Show();

                return formulario;
            }
            else
                MostrarMensajeError("No tiene permiso para acceder a este funcionalidad");

            return null;
        }

        public Form AbrirFormularioModal(Form formulario)
        {
            if (PuedeAcceder(formulario.Name, formulario.Text))
            {
                formulario.StartPosition = FormStartPosition.CenterParent;
                formulario.MaximizeBox = false;
                formulario.MinimizeBox = false;
                formulario.MinimumSize = formulario.Size;
                formulario.MaximumSize = formulario.Size;
                formulario.ShowDialog();

                return formulario;
            }
            else
                MostrarMensajeError("No tiene permiso para acceder a este funcionalidad");

            return null;
        }

        public void EjecutarReporte(DataSet data, ReportClass reporte)
        {
            FrmVisor visorReporte = new FrmVisor();
            reporte.SetDataSource(data);
            reporte.VerifyDatabase();

            visorReporte.rvVisorReportes.ReportSource = reporte;
            visorReporte.rvVisorReportes.RefreshReport();
            visorReporte.rvVisorReportes.Dock = DockStyle.Fill;

            visorReporte.StartPosition = FormStartPosition.CenterParent;
            visorReporte.WindowState = FormWindowState.Maximized;
            visorReporte.Show();
        }

        public void EjecutarReporte(DataSet data, ReportClass reporte, List<ReportClass> listaSubReportes)
        {
            FrmVisor visorReporte = new FrmVisor();
            reporte.SetDataSource(data);
            reporte.VerifyDatabase();

            foreach (var subReporte in listaSubReportes)
            {
                subReporte.SetDataSource(data);
                subReporte.VerifyDatabase();
            }

            //reporte.OpenSubreport("SubReportePlanillaJuegoVendedores");

            visorReporte.rvVisorReportes.ReportSource = reporte;
            visorReporte.rvVisorReportes.RefreshReport();
            visorReporte.rvVisorReportes.Dock = DockStyle.Fill;

            visorReporte.StartPosition = FormStartPosition.CenterParent;
            visorReporte.WindowState = FormWindowState.Maximized;
            visorReporte.Show();
        }

        public static void ColocarColorGrilla(DataGridView grilla, int columna, int fila, int colorcito)
        {
            int I;

            if (columna == -1)
            {
                for (I = 0; I <= grilla.ColumnCount - 1; I++)
                {
                    switch (colorcito)
                    {
                        case 0:
                            {
                                // Gris con letra blanca
                                grilla.Rows[fila].Cells[I].Style.BackColor = Color.Gray;
                                grilla.Rows[fila].Cells[I].Style.ForeColor = Color.White;
                                break;
                            }

                        case 1:
                            {
                                // Fondo azul letra blanca
                                grilla.Rows[fila].Cells[I].Style.BackColor = Color.Blue;
                                grilla.Rows[fila].Cells[I].Style.ForeColor = Color.White;
                                break;
                            }

                        case 2:
                            {
                                // Fondo Rojo letra blanca
                                grilla.Rows[fila].Cells[I].Style.BackColor = Color.Red;
                                grilla.Rows[fila].Cells[I].Style.ForeColor = Color.White;
                                break;
                            }

                        case 3:
                            {
                                // Fondo naranja oscuro letra blanca
                                grilla.Rows[fila].Cells[I].Style.BackColor = Color.DarkOrange;
                                grilla.Rows[fila].Cells[I].Style.ForeColor = Color.White;
                                break;
                            }

                        case 4:
                            {
                                // Fondo azul oscuro letra blanca
                                grilla.Rows[fila].Cells[I].Style.BackColor = Color.DarkBlue;
                                grilla.Rows[fila].Cells[I].Style.ForeColor = Color.White;
                                break;
                            }

                        case 5:
                            {
                                // Fondo Blanco letra Negra
                                grilla.Rows[fila].Cells[I].Style.BackColor = Color.White;
                                grilla.Rows[fila].Cells[I].Style.ForeColor = Color.Black;
                                break;
                            }

                        case 6:
                            {
                                // Fondo Negro letra Roja
                                grilla.Rows[fila].Cells[I].Style.BackColor = Color.Black;
                                grilla.Rows[fila].Cells[I].Style.ForeColor = Color.Red;
                                break;
                            }

                        case 7:
                            {
                                // Fondo Blanco letra azul
                                grilla.Rows[fila].Cells[I].Style.BackColor = Color.White;
                                grilla.Rows[fila].Cells[I].Style.ForeColor = Color.Blue;
                                break;
                            }

                        case 8:
                            {
                                // Fondo Naranja oscuro letra negro
                                grilla.Rows[fila].Cells[I].Style.BackColor = Color.Green;
                                grilla.Rows[fila].Cells[I].Style.ForeColor = Color.Black;
                                break;
                            }

                        case 9:
                            {
                                // Fondo Amarillo verdoso letra negro
                                grilla.Rows[fila].Cells[I].Style.BackColor = Color.YellowGreen;
                                grilla.Rows[fila].Cells[I].Style.ForeColor = Color.Black;
                                break;
                            }
                    }
                }
            }
            else
                switch (colorcito)
                {
                    case 0:
                        {
                            // Gris con letra blanca
                            grilla.Rows[fila].Cells[columna].Style.BackColor = Color.Gray;
                            grilla.Rows[fila].Cells[columna].Style.ForeColor = Color.White;
                            break;
                        }

                    case 1:
                        {
                            // Fondo azul letra blanca
                            grilla.Rows[fila].Cells[columna].Style.BackColor = Color.Blue;
                            grilla.Rows[fila].Cells[columna].Style.ForeColor = Color.White;
                            break;
                        }

                    case 2:
                        {
                            // Fondo Rojo letra blanca
                            grilla.Rows[fila].Cells[columna].Style.BackColor = Color.Red;
                            grilla.Rows[fila].Cells[columna].Style.ForeColor = Color.White;
                            break;
                        }

                    case 3:
                        {
                            // Fondo naranja oscuro letra blanca
                            grilla.Rows[fila].Cells[columna].Style.BackColor = Color.DarkOrange;
                            grilla.Rows[fila].Cells[columna].Style.ForeColor = Color.White;
                            break;
                        }

                    case 4:
                        {
                            // Fondo azul oscuro letra blanca
                            grilla.Rows[fila].Cells[columna].Style.BackColor = Color.DarkBlue;
                            grilla.Rows[fila].Cells[columna].Style.ForeColor = Color.White;
                            break;
                        }

                    case 5:
                        {
                            // Fondo Blanco letra Negra
                            grilla.Rows[fila].Cells[columna].Style.BackColor = Color.White;
                            grilla.Rows[fila].Cells[columna].Style.ForeColor = Color.Black;
                            break;
                        }

                    case 6:
                        {
                            // Fondo Negro letra Roja
                            grilla.Rows[fila].Cells[columna].Style.BackColor = Color.Black;
                            grilla.Rows[fila].Cells[columna].Style.ForeColor = Color.Red;
                            break;
                        }

                    case 7:
                        {
                            // Fondo Blanco letra azul
                            grilla.Rows[fila].Cells[columna].Style.BackColor = Color.White;
                            grilla.Rows[fila].Cells[columna].Style.ForeColor = Color.Blue;
                            break;
                        }

                    case 8:
                        {
                            // Fondo Naranja oscuro letra negro
                            grilla.Rows[fila].Cells[columna].Style.BackColor = Color.Green;
                            grilla.Rows[fila].Cells[columna].Style.ForeColor = Color.Black;
                            break;
                        }

                    case 9:
                        {
                            // Fondo Amarillo verdoso letra negro
                            grilla.Rows[fila].Cells[columna].Style.BackColor = Color.YellowGreen;
                            grilla.Rows[fila].Cells[columna].Style.ForeColor = Color.Black;
                            break;
                        }
                }
        }

        public static void CargaCombo<T>(ComboBox combo, List<T> datos, string campoTexto, string campoValor, ComboBoxStyle estilo, bool seleccionPrimerItem = true) where T : class
        {
            combo.DataSource = null;
            combo.DataSource = datos;
            combo.DisplayMember = campoTexto;
            combo.ValueMember = campoValor;
            combo.DropDownStyle = estilo;

            if (!seleccionPrimerItem)
                combo.SelectedIndex = SinSeleccion;
        }

        public static void CargaCheckedListBox<T>(CheckedListBox chkList, List<T> datos, string campoTexto, string campoValor) where T : class
        {
            chkList.DataSource = null;
            chkList.DataSource = datos;
            chkList.DisplayMember = campoTexto;
            chkList.ValueMember = campoValor;
        }

        public static void ValidarItemSeleccionado(ComboBox combo)
        {
            if (combo.SelectedIndex.IsOn(-1))
                combo.BackColor = Color.Coral;
            else
                combo.BackColor = Color.DarkSeaGreen;
        }

        public static T ObtenerItemCombo<T>(ComboBox combo) where T : class
        {
            return (T)combo.SelectedItem;
        }

        public static Tuple<bool, string> ValidarRangoFechas(DateTimePicker dtpInicio, DateTimePicker dtpFin)
        {
            string mensaje = string.Empty;

            if (dtpInicio.Value.Date < DateTime.Today)
                mensaje += "La Fecha de inicio debe ser mayor a la fecha actual";

            if (dtpFin.Value.Date < DateTime.Today)
                mensaje += "La Fecha de fin debe ser mayor a la fecha actual";

            if (dtpFin.Value.Date < dtpInicio.Value.Date)
                mensaje += "La Fecha de fin debe ser mayor o igual a la fecha de inicio";

            return new Tuple<bool, string>(mensaje.IsNullOrEmpty(), mensaje);
        }
    }
}
