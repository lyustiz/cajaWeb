using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Juego
{
    public partial class FrmProgramarJuego : Base
    {
        private DominioProgramacionJuego mDominioProgramacion;
        private DominioRoe mDominioRoe;
        private List<Listabla> mListaSeries;
        private List<ItemLista> mListaFiguras;
        private ProgramacionJuego mProgramacionJuego;
        private List<ProgramacionJuegoFigura> mListaFigurasProgramacion;
        private List<ProgramacionJuego> mListaProgramacion;
        private bool mEsNuevo;
        private ParametroGeneral parametro;

        public FrmProgramarJuego()
        {
            InitializeComponent();
            InstaciarObjetos();
            InicializarControles();
        }
        private void InstaciarObjetos()
        {
            mDominioProgramacion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRoe = new DominioRoe();
            mListaFigurasProgramacion = new List<ProgramacionJuegoFigura>();

            txtCartonInicial.LostFocus += TxtCartonInicial_LostFocus;
            txtCartonFinal.LostFocus += TxtCartonFinal_LostFocus;        
        }

        private void InicializarControles()
        {
            parametro = ObtenerParametroGeneral("Caja-CantidadCartonesHoja");

            lblTotalPremios.ResetText();

            mListaSeries = mDominioRoe.FindAllSeries();
            Base.CargaCombo(cmdSeries, mListaSeries, "Fabrica", "IdLisTablas", ComboBoxStyle.DropDownList, seleccionPrimerItem: false);

            mListaFiguras = mDominioRoe.FindAllFiguras();
            Base.CargaCombo(cmdFiguras, mListaFiguras, "Nombre", "Id", ComboBoxStyle.DropDownList, seleccionPrimerItem: false);

            CargarComboProgramacion();
        }

        private void CargarComboProgramacion(bool adicionarProgramacion = false, bool seleccionPrimerItem = true)
        {
            mListaProgramacion = mDominioProgramacion.BuscarProgramacionActiva();

            if (adicionarProgramacion && mProgramacionJuego != null)
                mListaProgramacion.Add(mProgramacionJuego);

            Base.CargaCombo(cmdProgramacion, mListaProgramacion, "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList, seleccionPrimerItem: seleccionPrimerItem);
        }

        private void CargarGrillaFiguras()
        {            
            GrillaFiguras.Rows.Clear();

            foreach (var figura in mListaFigurasProgramacion.Where(x => x.Estado == "A")) 
                GrillaFiguras.Rows.Add(new object[] { figura.IdProgramacionJuegoFigura, mListaFiguras.FirstOrDefault(x => x.Id == figura.IdPlenoAutomatico).Nombre, figura.ValorPremio});

            lblTotalPremios.Text = $"Total Premios: {string.Format(SesionActiva.FormatoMoneda, mListaFigurasProgramacion.Where(x => x.Estado == "A").Sum(x => x.ValorPremio))}";
        }

        public bool DatosRequeridosFigura()
        {
            string mensaje = string.Empty;

            if (mProgramacionJuego == null)
                mensaje = "El juego aun no se ha creado, por favor hacer click en el boton de Nuevo.";
            if (cmdFiguras.SelectedIndex < 0)            
                mensaje = "Debe seleccionar una figura.";            
            else if (txtValorFigura.Value < 1)            
                mensaje = $"Debe ingresar un valor de figura válido";            
            else if(mListaFigurasProgramacion.Exists(x => x.IdPlenoAutomatico == ObtenerItemCombo<ItemLista>(cmdFiguras).Id && x.Estado == "A"))            
                mensaje = $"La figura seleccionada ya existe, seleccione una diferente.";
            

            if (mensaje.NotIsNullOrEmpty())
            {
                MostrarMensajeError(mensaje);                
            }

            return mensaje.IsNullOrEmpty();
        }

        public bool DatosRequeridosProgramacion()
        {
            string mensaje = string.Empty;

            if (dtpFechaProgramacion.Value <= DateTime.Now)
                mensaje = "Debe seleccionar una fecha superior a la fecha hora actual.";
            else if (txtValorCarton.Value < 1)
                mensaje = $"Debe ingresar un valor de cartón válido.";
            else if (txtValorModulo.Value < 1)
                mensaje = $"Debe ingresar un valor de módulo válido.";
            else if (txtCartonInicial.Value < 1)
                mensaje = $"Debe ingresar un cartón inicial válido.";
            else if (txtCartonFinal.Value < 1)
                mensaje = $"Debe ingresar un cartón final válido.";
            else if (txtCartonInicial.Value >= txtCartonFinal.Value)
                mensaje = $"El cartón inicial debe ser menor al cartón final.";
            else if (cmdSeries.SelectedIndex == SinSeleccion)
                mensaje = $"Debe seleccionar una serie valida.";
            else if (mListaFigurasProgramacion.IsNullOrZeroItems())
                mensaje = $"Debe agregar mínimo una figura a la programación.";

            if (mensaje.NotIsNullOrEmpty())
            {
                MostrarMensajeError(mensaje);
            }

            return mensaje.IsNullOrEmpty();
        }

        public void LimpiarControles()
        {
            dtpFechaProgramacion.ResetText();
            txtValorCarton.Value = txtValorCarton.Minimum;
            txtValorModulo.Value = txtValorModulo.Minimum;
            cmdSeries.SelectedIndex = SinSeleccion;
            txtCartonInicial.Value = txtCartonInicial.Minimum;
            txtCartonFinal.Value = txtCartonFinal.Minimum;
            txtHojaInicial.Value = txtHojaInicial.Minimum;
            txtHojaFinal.Value = txtHojaFinal.Minimum;
            cmdFiguras.SelectedIndex = SinSeleccion;
            txtValorFigura.Value = txtValorFigura.Minimum;
            mListaFigurasProgramacion.Clear();
            GrillaFiguras.Rows.Clear();
        }

        public void ConfigurarControlesNuevo()
        {
            mEsNuevo = true;
            LimpiarControles();
            cmdProgramacion.Enabled = false;
            nuevoToolStripMenuItem.Enabled = false;
            guardarToolStripMenuItem.Enabled = true;
            AjustarPremiosToolStripMenuItem.Enabled = false;

            dtpFechaProgramacion.Enabled = true;
            txtValorCarton.Enabled = true;
            txtValorModulo.Enabled = true;
            cmdSeries.Enabled = true;
            txtCartonInicial.Enabled = true;
            txtCartonFinal.Enabled = true;
            dtpFechaProgramacion.Focus();

            cmdFiguras.SelectedIndex = SinSeleccion;
            txtValorFigura.Value = txtValorFigura.Minimum;            
            grbNuevaFigura.Enabled = true;
            GrillaFiguras.Enabled = true;
        }

        public void ConfigurarControlesEditar()
        {
            mEsNuevo = false;            
            cmdProgramacion.Enabled = true;
            nuevoToolStripMenuItem.Enabled = true;
            guardarToolStripMenuItem.Enabled = false;
            AjustarPremiosToolStripMenuItem.Enabled = true;
            dtpFechaProgramacion.Enabled = false;
            txtValorCarton.Enabled = false;
            txtValorModulo.Enabled = false;
            cmdSeries.Enabled = false;
            txtCartonInicial.Enabled = false;
            txtCartonFinal.Enabled = false;

            cmdFiguras.SelectedIndex = SinSeleccion;
            txtValorFigura.Value = txtValorFigura.Minimum;            
            grbNuevaFigura.Enabled = false;
            GrillaFiguras.Enabled = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (DatosRequeridosFigura())
            {
                ProgramacionJuegoFigura objFigura = new ProgramacionJuegoFigura()
                {
                    IdPlenoAutomatico = ObtenerItemCombo<ItemLista>(cmdFiguras).Id,
                    ValorPremio = (double)txtValorFigura.Value,
                    Estado = "A"                    
                };

                if (mListaFigurasProgramacion is null)
                    mListaFigurasProgramacion = new List<ProgramacionJuegoFigura>();

                if (!mEsNuevo)
                {
                    objFigura.IdProgramacionJuego = mProgramacionJuego.IdProgramacionJuego;
                    var resultado = mDominioProgramacion.AgregarFigura(objFigura);

                    if (!resultado.Ok)
                        MostrarMensajeError(resultado.Mensaje);
                    else
                        mListaFigurasProgramacion.Add(objFigura);
                }
                else
                    mListaFigurasProgramacion.Add(objFigura);                

                CargarGrillaFiguras();
                cmdFiguras.Focus();
            }
        }

        private void GrillaFiguras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = GrillaFiguras.Rows[e.RowIndex].Cells["IdProgramacionJuegoFigura"].FormattedValue.ToString();
                var nombreFigura = GrillaFiguras.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();

                if (e.ColumnIndex == 3)
                {
                    var figura = mListaFigurasProgramacion.FirstOrDefault(x => x.IdProgramacionJuegoFigura == Convert.ToInt32(id) && x.Estado == "A");

                    DialogResult mBoxResult = MessageBox.Show($"¿Está seguro de remover el permio [{nombreFigura}], por un valor de {string.Format(SesionActiva.FormatoMoneda, figura.ValorPremio)}?", "Programación Juegos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (mBoxResult)
                    {
                        case DialogResult.Yes:
                            int indice = mListaFigurasProgramacion.FindIndex(x => x.IdProgramacionJuegoFigura == Convert.ToInt32(id) && x.Estado == "A");
                            mListaFigurasProgramacion[indice].Estado = "I";

                            if (!mEsNuevo)                            
                                mDominioProgramacion.EliminarFigura(mProgramacionJuego.IdProgramacionJuego, Convert.ToInt32(id));
                            
                            break;
                        case DialogResult.No:
                            break;
                    }

                    CargarGrillaFiguras();
                }
            }
        }

        private void cmdJuegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdProgramacion.SelectedIndex >= 0 && !mEsNuevo) 
            {
                mProgramacionJuego = mDominioProgramacion.ObtenerProgramacion(ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion).IdProgramacionJuego);

                dtpFechaProgramacion.Value = mProgramacionJuego.FechaProgramada;
                txtValorCarton.Value = (decimal)mProgramacionJuego.ValorCarton;
                txtValorModulo.Value = (decimal)mProgramacionJuego.ValorModulo;
                cmdSeries.SelectedValue = mProgramacionJuego.IdSerie;
                txtCartonInicial.Value = mProgramacionJuego.CartonInicial;
                txtCartonFinal.Value = mProgramacionJuego.CartonFinal;
                txtHojaInicial.Value = mProgramacionJuego.HojaInicial;
                txtHojaFinal.Value = mProgramacionJuego.HojaFinal;

                mListaFigurasProgramacion = mDominioProgramacion.ObtenerFigurasProgramacion(mProgramacionJuego.IdProgramacionJuego);
                CargarGrillaFiguras();
                ConfigurarControlesEditar();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RespuestaDominio validacion = mDominioProgramacion.PuedeCrearNuevaProgramacion();

            if (validacion.Ok)
            {
                ConfigurarControlesNuevo();
                mProgramacionJuego = new ProgramacionJuego() { IdProgramacionJuego = mDominioProgramacion.ObtenerSiguientIdProgramacion() };                
                CargarComboProgramacion(adicionarProgramacion: true, seleccionPrimerItem: false);
                cmdProgramacion.SelectedIndex = mListaProgramacion.FindIndex(x => x.IdProgramacionJuego == mProgramacionJuego.IdProgramacionJuego);                
            }
            else            
                MostrarMensajeError(validacion.Mensaje);            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatosRequeridosProgramacion())
            {
                TxtCartonFinal_LostFocus(sender, e);

                mProgramacionJuego.FechaProgramada = dtpFechaProgramacion.Value;
                mProgramacionJuego.ValorCarton = (double)txtValorCarton.Value;
                mProgramacionJuego.ValorModulo = (double)txtValorModulo.Value;
                mProgramacionJuego.IdSerie = ObtenerItemCombo<Listabla>(cmdSeries).IdLisTablas;
                mProgramacionJuego.CartonInicial = (int)txtCartonInicial.Value;
                mProgramacionJuego.CartonFinal = (int)txtCartonFinal.Value;
                mProgramacionJuego.HojaInicial = (int)txtHojaInicial.Value;
                mProgramacionJuego.HojaFinal = (int)txtHojaFinal.Value;

                RespuestaDominio respuesta = mDominioProgramacion.CrearProgramacion(mProgramacionJuego, mListaFigurasProgramacion);

                if (respuesta.Ok)
                {
                    mEsNuevo = false;
                    MostrarMensajeInformativo(respuesta.Mensaje);
                    CargarComboProgramacion();
                    cmdProgramacion.SelectedValue = respuesta.IdConfirmacion;
                }
                else
                    MostrarMensajeError(respuesta.Mensaje);
            }
        }

        private void TxtCartonFinal_LostFocus(object sender, EventArgs e)
        {
            

            if (parametro != null)
            {
                var valores = GenerarNumeroCartonFinal((int)txtCartonFinal.Value, (int)txtCartonInicial.Value, Convert.ToInt32(parametro.Valor));
                txtCartonFinal.Value = valores.Item1;
                txtHojaFinal.Value = valores.Item2;
            }
            else
                MostrarMensajeError("No esta configurado el parametro de CantidadCartonesHoja, configurelo para calcular las hojas.");
        }

        private void TxtCartonInicial_LostFocus(object sender, EventArgs e)
        {
            if (txtCartonInicial.Value > txtCartonFinal.Value)
            {
                txtCartonInicial.Value = txtCartonInicial.Minimum;
                MostrarMensajeError("El cartón inicial debe ser menor al cartón final.");
            }
            else
            {     
                if (parametro != null)
                {
                    var valores = GenerarNumeroCartonInicial((int)txtCartonInicial.Value, Convert.ToInt32(parametro.Valor));
                    txtCartonInicial.Value = valores.Item1;
                    txtHojaInicial.Value = valores.Item2;
                    TxtCartonFinal_LostFocus(sender, e);
                }
                else
                    MostrarMensajeError("No esta configurado el parametro de CantidadCartonesHoja, configurelo para calcular las hojas.");
            }
           
        }

        private void AjustarPremiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pedir segunda clave

            cmdFiguras.SelectedIndex = SinSeleccion;
            txtValorFigura.Value = txtValorFigura.Minimum;
            grbNuevaFigura.Enabled = true;
            GrillaFiguras.Enabled = true;
        }
    }
}
