using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using Caja.Escritorio.Formularios;
using Caja.Escritorio.Formularios.Administracion;
using Caja.Escritorio.Formularios.Administracion.Modulos;
using Caja.Escritorio.Formularios.Caja;
using Caja.Escritorio.Formularios.General;
using Caja.Escritorio.Formularios.Juego;
using Caja.Escritorio.Formularios.Juego.Reportes;
using Caja.Escritorio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Caja.Escritorio
{
    public partial class FrmPrincipal : Base
    {
        readonly DominioParamentroGeneral mDominio;
        readonly DominioConceptoGasto mDominioConceptoGasto;
        readonly DominioProgramacionJuego mDominioProgramacionJuego;
        readonly DominioVendedorCobroCarton mDominioVendedorCobroCarton;
        readonly DominioProgramacionJuegoDinero mDominioProgramacionJuegoDinero;
        readonly DominioFlujoCaja mDominioFlujoCaja;

        public FrmPrincipal()
        {
            InitializeComponent();
            mDominio = new DominioParamentroGeneral();
            mDominioConceptoGasto = new DominioConceptoGasto();
            mDominioProgramacionJuego = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorCobroCarton = new DominioVendedorCobroCarton(SesionActiva.UsuarioActual.IdUsuario);
            mDominioProgramacionJuegoDinero = new DominioProgramacionJuegoDinero(SesionActiva.UsuarioActual.IdUsuario);
            mDominioFlujoCaja = new DominioFlujoCaja(SesionActiva.UsuarioActual.IdUsuario);
            InicializarControles();
        }
        private void InicializarControles()
        {
            this.CenterToScreen();
            CargarDatosSesion();
            CargarCombos();
            CargarGrillaGastos();
        }

        private void CargarCombos()
        {
            var listaMeses = ListasGenericas.GenerarListaMeses();
            Base.CargaCombo(cmdMeses, listaMeses, "Nombre", "Id", ComboBoxStyle.DropDownList);

            var listasAnios = new List<ItemCombo>();
            var rangoAnios = mDominioProgramacionJuego.ObtenerRangoAniosProgramaciones();

            var listaAuxiliar = new List<int>
            {
                rangoAnios.Item1,
                rangoAnios.Item2
            };

            listaAuxiliar.Distinct().ToList().ForEach(x => listasAnios.Add(new ItemCombo(x, x.ToString())));
            Base.CargaCombo(cmdAnios, listasAnios.OrderByDescending(x => x.Id).ToList(), "Nombre", "Id", ComboBoxStyle.DropDownList);
            cmdMeses.SelectedIndex = DateTime.Now.Month - 1;
        }

        public void CargarDatosSesion()
        {
            var parametroMoneda = mDominio.FetchBy(TipoBusquedaParametroGeneral.Referencia, "strModeda");
            var parametroFormato = mDominio.FetchBy(TipoBusquedaParametroGeneral.Referencia, "strFormato");

            string mPerfiles = string.Empty;

            if (SesionActiva.UsuarioActualPerfiles != null)
                mPerfiles = string.Join(", ", SesionActiva.UsuarioActualPerfiles.Select(x=> x.Nombre)).Trim();

            if (SesionActiva.UsuarioActual != null)
                lblUsuarioActivo.Text = $"Nombre de Usuario: {SesionActiva.UsuarioActual.NombreCompleto}{Environment.NewLine}Cargo: {mPerfiles}";

            if (parametroMoneda != null)
            {
                SesionActiva.TipoMoneda = parametroMoneda.Valor;                
                lblUsuarioActivo.Text += $"{Environment.NewLine}Tipo Moneda Caja: {SesionActiva.TextoTipoMoneda}";
            }

            if (parametroFormato != null)            
                SesionActiva.FormatoMoneda = parametroFormato.Valor;            
        }

        public void CargarGrillaGastos()
        {
            var listado = mDominioConceptoGasto.FetchAllEstadistica();
            var listadoGrafico = listado.OrderByDescending(x => x.ValorMaximo).ThenByDescending(y => y.Valor).Take(8);

            GrillaGastos.Rows.Clear();
            chBarras.Series["Consumo Mes"].Points.Clear();
            chBarras.Series["Limite Máximo"].Points.Clear();

            foreach (var registro in listado.OrderByDescending(x => x.ValorMaximo).ThenByDescending(y => y.Valor))
                GrillaGastos.Rows.Add(new object[] { registro.Descripcion, string.Format(SesionActiva.FormatoMoneda, registro.Valor), string.Format(SesionActiva.FormatoMoneda, registro.ValorMaximo) });            

            foreach (var registro in listadoGrafico)
            {
                chBarras.Series["Consumo Mes"].Points.AddXY(registro.Descripcion, string.Format(SesionActiva.FormatoMoneda, registro.Valor));
                chBarras.Series["Limite Máximo"].Points.AddXY(registro.Descripcion, string.Format(SesionActiva.FormatoMoneda, registro.ValorMaximo));                
            }

            CargarJuegos();
        }

        public void CargarJuegos()
        {
            var listado = mDominioProgramacionJuego.ObtenerProgramacionEstadisticas(ObtenerItemCombo<ItemCombo>(cmdAnios).Id, ObtenerItemCombo<ItemCombo>(cmdMeses).Id);

            Grilla.Rows.Clear();

            foreach (var registro in listado)
            {
                Grilla.Rows.Add(new object[] { registro.IdProgramacionJuego, registro.FechaProgramada, registro.Estado, string.Format(SesionActiva.FormatoMoneda, registro.TotalPremios) });

                if (registro.Estado.IsOn("C"))
                    ColocarColorGrilla(Grilla, -1, Grilla.RowCount - 1, 2);
            }
        }

        private void MonedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmMonedas());
            CargarDatosSesion();
        }

        private void PaisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmPaises());
        }

        private void CiudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmCiudades());
        }

        private void PorcentajesPremiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmConfiguracionPorcentajes());
        }

        private void LimiteGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmLimiteGastos());
        }

        private void PorcentajeDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmSocios());
        }

        private void AsignacionDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmPermisos());
        }

        private void FrmPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F12)
            {
                mDominio.GenerarPermisos();

                MsgConfirm frmConfirm = new MsgConfirm();
                frmConfirm.Mensaje = "Configuraciones aplicadas";
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();
            }
                
        }

        private void DefiniciónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmUsuarios());
            CargarDatosSesion();
        }

        private void DefinicionDeVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmVendedores());
        }

        private void DefinicionDeModulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmDefinicionModulos());
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmClientes());
        }

        private void EntregaModulosAClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmRelacionModulosClientes());
        }

        private void AuditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmConsultarAuditoria());
        }

        private void FinalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void iniciarJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = AbrirFormulario(new FrmProgramarJuego());

            if (formulario != null)
            {
                RespuestaDominio validacion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario).PuedeCrearNuevaProgramacion();

                if (!validacion.Ok)
                {
                    MostrarMensajeError(validacion.Mensaje);
                    formulario.Close();
                }
            }            
        }

        private void entregaCartoneríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEntregaCartoneria());
        }

        private void modificarRangoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmModificarRangoCartones());
        }

        private void cobroDeCartonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCobroCartones());
        }

        private void impresiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmImpresionHojas());
        }

        private void reporteGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmGastosJuego());
            CargarGrillaGastos();
        }

        private void reportarOtrosIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmIngresosJuego());
            CargarGrillaGastos();
        }

        private void registroDeGastosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmGastosGenerales());
            CargarGrillaGastos();
        }

        private void registroDeIngresosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmIngresosGenerales());
            CargarGrillaGastos();
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            CargarGrillaGastos();
        }

        private void CerrarJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int mNumeroCartonesHoja = Convert.ToInt32(ObtenerValorParametroGeneral("Caja-CantidadCartonesHoja"));

                var validarionJuegosDisponibles = mDominioProgramacionJuego.ExisteJuegoParaCerrar();

                if (!validarionJuegosDisponibles.Ok)
                {
                    MostrarMensajeError(validarionJuegosDisponibles.Mensaje);
                    return;
                }

                /// Toma el numero del primer juego que se encuentre pendiente
                int mJuegoMasAntiguo = mDominioProgramacionJuego.ObtenerProgramacionMasAntigua();

                DialogResult mBoxResult = MessageBox.Show($"Se cierra el primer juego abierto.{Environment.NewLine}" +
                    $"El juego a cerrar es el No. {mJuegoMasAntiguo}{Environment.NewLine} " +
                    $"¿Desea seguir con el procedimiento para cierre del juego.?", "Cierre Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (mBoxResult)
                {
                    case DialogResult.No:
                        MessageBox.Show("Operación Cancelada", "Cierre Juego", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                var validacionHojas = mDominioProgramacionJuego.ValidarHojas(mNumeroCartonesHoja, mJuegoMasAntiguo);

                if (!validacionHojas.Ok)
                {
                    MostrarMensajeError(validacionHojas.Mensaje);
                    return;
                }

                mBoxResult = MessageBox.Show($"Está seguro de tener registrado gastos, otros ingresos y faltantes para el juego?", "Cierre Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (mBoxResult)
                {
                    case DialogResult.No:
                        MessageBox.Show("Operación Cancelada", "Cierre Juego", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                var validacioVendedoresSinPago = mDominioProgramacionJuego.ValidarVendedoresSinPago(mJuegoMasAntiguo);

                if (!validacioVendedoresSinPago.Ok)
                {
                    MostrarMensajeError(validacioVendedoresSinPago.Mensaje);
                    return;
                }

                var validacionCerrar = mDominioProgramacionJuego.CerrarProgramacion(mJuegoMasAntiguo);

                if (!validacionCerrar.Ok)
                {
                    MostrarMensajeError(validacionCerrar.Mensaje);
                    return;
                }

                RegistrarValoresAsistenciaSocial(mJuegoMasAntiguo);

                MostrarMensajeInformativo("Proceso realizado Exitosamente.");               
            }
            catch (Exception ex)
            {
                MostrarMensajeError(ex.Message);
            }
        }

        private void RegistrarValoresAsistenciaSocial(int pIdProgramacion)
        {
            double mAsistenciaSocial = Convert.ToDouble(ObtenerValorParametroGeneral("Caja-AsistenciaSocial"));
            var sumatoria = mDominioVendedorCobroCarton.CalcularSumatoriaValores(pIdProgramacion);

            double mValorSocial = sumatoria.TotalCartones * mAsistenciaSocial;

            mDominioProgramacionJuegoDinero.Deshabilitar(pIdProgramacion);

            ProgramacionJuegoDinero objRegistro = new ProgramacionJuegoDinero() { 
                IdProgramacionJuego = pIdProgramacion,
                TotalCartones = sumatoria.TotalCartones,
                AsistenciaSocial = mValorSocial,
                TotalVentas = sumatoria.TotalPagado,
                TotalCuentasCobrar = sumatoria.Faltante,
                TotalRecaudoJuego = sumatoria.TotalRecibido,
                DineroBanco = 0,
                Efectivo = 0
            };

            mDominioProgramacionJuegoDinero.Crear(objRegistro);

            double mValorInicialCaja = 0;
            double mValorInicialBancos = 0;
            double mValorInicialSocial = 0;

            var flujoCajaNuevo = mDominioFlujoCaja.FindByProgramacion(pIdProgramacion);

            if (flujoCajaNuevo == null)            
                flujoCajaNuevo = new FlujoCaja() { IdProgramacionJuego = pIdProgramacion };

            if (pIdProgramacion > 1)
            {
                var flujoCajaAnterior = mDominioFlujoCaja.FindByProgramacion(pIdProgramacion - 1);
                
                if (flujoCajaAnterior != null)
                {
                    mValorInicialCaja = flujoCajaAnterior.ValorFinal;
                    mValorInicialBancos = flujoCajaAnterior.ValorFinalBancos;
                    mValorInicialSocial = flujoCajaAnterior.ValorFinalSocial;
                }                
            }

            flujoCajaNuevo.ValorInicial = mValorInicialCaja;
            flujoCajaNuevo.ValorInicialBancos = mValorInicialBancos;
            flujoCajaNuevo.ValorInicialSocial = mValorInicialSocial;
            flujoCajaNuevo.ValorFinal += (sumatoria.TotalRecibido - sumatoria.TotalPremios - mValorSocial);            
            flujoCajaNuevo.ValorFinalSocial += mValorSocial;

            mDominioFlujoCaja.Save(flujoCajaNuevo);
        }

        private void DevolucionDeHojasNoVendidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmDevolucionCartones());
        }

        private void cartonesEntregadosEnElJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmListadoCartones());
        }

        private void listadoDeCartonesSinRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmCartonesFaltantse());
        }

        private void archivoDeCartonesVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmGeneracionCartonesVendidos());
        }

        private void listadoDeCartonesPorVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmListadoCartonesVendidosDetalle());
        }

        private void entregaCartoneríaCódigoDeBarrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmEntregaCartoneriaCodigoBarras());
        }

        private void agregarMódulosJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmAgregarModulosProgramacion());
        }

        private void cuadreParaCierreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCuadreCierre = new FrmCuadreCierre();            

            if (frmCuadreCierre.ValidarJuegos())
                AbrirFormulario(frmCuadreCierre);
        }

        private void pagoFaltantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDineroBancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmDineroBancos());
        }

        private void planillaPorJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPlanillaJuego());
        }

        private void flujoDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informeDeCajaPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReporteUsuario());
        }

        private void planillaVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informeCajaMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informeGeneralDeGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informeDeCuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
