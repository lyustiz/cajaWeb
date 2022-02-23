using Caja.Dominio;
using Caja.Entidades;
using Caja.Entidades.Vistas;
using Caja.Escritorio.App;
using Caja.Escritorio.Formularios.Reportes;
using Caja.Escritorio.Formularios.Reportes.DataSets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Caja
{
    public partial class FrmPlanillaJuego : Base
    {
        private DominioGastoProgramacionJuego mDominioGastos;
        private DominioIngresoProgramacionJuego mDominioIngresos;
        private DominioProgramacionJuego mDominioProgramacion;
        private DominioProgramacionJuegoDinero mDominioProgramacionDinero;
        private DominioRoe mDominioRoe;
        private DominioAuditoria mDominioAuditoria;

        private ProgramacionJuego mProgramacionJuego;
        private ProgramacionJuegoDinero mProgramacionJuegoDinero;
        private Listabla mSerie;

        private List<VistaVendedorCobroCartones> mListaVendedoresCobros;
        private List<RecaudoTotal> mListaRecaudoTotal;
        private List<FiguraProgramacion> mListaFiguras;
        private List<VistaGastosProgramacionJuego> mListaGastos;
        private List<VistaIngresosProgramacionJuego> mListaIngresos;

        private double mGananciaJuego = 0;
        private double mTotalPremios = 0;
        private decimal mDiferencia = 0;
        private double mTotalGastos = 0;
        private double mTotalIngresos = 0;

        public FrmPlanillaJuego()
        {
            InitializeComponent();
            InstanciarObjetos();
            InicializarControles();
        }

        private void InstanciarObjetos()
        {
            mDominioGastos = new DominioGastoProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioIngresos = new DominioIngresoProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioProgramacion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioProgramacionDinero = new DominioProgramacionJuegoDinero(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRoe = new DominioRoe();
            mDominioAuditoria = new DominioAuditoria();

            mListaVendedoresCobros = new List<VistaVendedorCobroCartones>();
            mListaRecaudoTotal = new List<RecaudoTotal>();
            mListaFiguras = new List<FiguraProgramacion>();
        }

        private void InicializarControles()
        {
            CargaCombo(cmdProgramacion, mDominioProgramacion.BuscarProgramacionCerrada(), "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList);
        }

        private void CargarInformacionJuego()
        {
            GrillaVendedores.Rows.Clear();
            GrillaRecaudo.Rows.Clear();
            GrillaFiguras.Rows.Clear();

            txSocial.Text = string.Format(SesionActiva.FormatoMoneda, "0");

            mSerie = mDominioRoe.FindSerie(mProgramacionJuego.IdSerie);
            mProgramacionJuegoDinero = mDominioProgramacionDinero.FindByProgramacion(mProgramacionJuego.IdProgramacionJuego);


            txFechaJuego.Text = mProgramacionJuego.FechaProgramada.ToShortDateString();
            txInicial.Text = mProgramacionJuego.CartonInicial.ToString();
            txFinal.Text = mProgramacionJuego.CartonFinal.ToString();

            if (mSerie != null)
                txSerie.Text = $"{mSerie.Fabrica} Simbolo {mSerie.Simbolo}";

            if (mProgramacionJuegoDinero != null && mProgramacionJuegoDinero.AsistenciaSocial > 0)
                txSocial.Text = string.Format(SesionActiva.FormatoMoneda, mProgramacionJuegoDinero.AsistenciaSocial);

            CargarInformacion();
        }

        private void CargarInformacion()
        {
            CargarVendedoresCobrosJuego();
            CargarRecaudoJuego();
            CargarFigurasJuego();
            ConsultarValorSocial();
            CargarGastosJuego();
            CargarIngresosJuego();

            mGananciaJuego = mGananciaJuego + mTotalIngresos + mTotalGastos;
            txValorTotal.Text = string.Format(SesionActiva.FormatoMoneda, mGananciaJuego);
        }

        private void CargarIngresosJuego()
        {
            mTotalIngresos = 0;
            mListaIngresos = mDominioIngresos.ObtenerIngresosProgramacionJuego(mProgramacionJuego.IdProgramacionJuego);

            foreach (var x in mListaIngresos)
            {
                GrillaOtrosIngresos.Rows.Add(new object[] { x.FechaHora.ToString("G"), x.Concepto, x.Descripcion, string.Format(SesionActiva.FormatoMoneda, x.Valor) });
                mTotalIngresos += x.Valor;
            }

            if (!mListaIngresos.IsNullOrZeroItems())
            {
                GrillaOtrosIngresos.Rows.Add(new object[] { string.Empty, string.Empty, string.Empty, string.Format(SesionActiva.FormatoMoneda, mTotalIngresos) });
                ColocarColorGrilla(GrillaOtrosIngresos, -1, GrillaOtrosIngresos.Rows.Count - 1, 3);
            }
        }

        private void CargarGastosJuego()
        {
            mTotalGastos = 0;
            mListaGastos = mDominioGastos.ObtenerGastosProgramacionJuego(mProgramacionJuego.IdProgramacionJuego);

            foreach (var x in mListaGastos)
            {
                grillaGastos.Rows.Add(new object[] { x.FechaHora.ToString("G"), x.Concepto, x.Descripcion, string.Format(SesionActiva.FormatoMoneda, x.Valor) });
                mTotalGastos += x.Valor;
            }

            if (!mListaGastos.IsNullOrZeroItems())
            {
                grillaGastos.Rows.Add(new object[] { string.Empty, string.Empty, string.Empty, string.Format(SesionActiva.FormatoMoneda, mTotalGastos) });
                ColocarColorGrilla(grillaGastos, -1, grillaGastos.Rows.Count - 1, 3);
            }
        }

        private void ConsultarValorSocial()
        {
            double mValorAsistenciaSocial = 0;
            mProgramacionJuegoDinero = mDominioProgramacionDinero.FindByProgramacion(mProgramacionJuego.IdProgramacionJuego);

            if (mProgramacionJuegoDinero != null)
            {
                txSocial.Text = string.Format(SesionActiva.FormatoMoneda, mProgramacionJuegoDinero.AsistenciaSocial);
                mValorAsistenciaSocial = mProgramacionJuegoDinero.AsistenciaSocial;
            }

            mGananciaJuego = mGananciaJuego - mTotalPremios - mValorAsistenciaSocial + (double)mDiferencia;

            mProgramacionJuego.ResultadoFinal = mGananciaJuego;
            mDominioProgramacion.ModificarResultadoFinal(mProgramacionJuego);

        }

        private void CargarFigurasJuego()
        {
            mTotalPremios = 0;
            mListaFiguras = mDominioRoe.FindFigurasProgramacion(mProgramacionJuego.IdProgramacionJuego);

            foreach (var x in mListaFiguras)
            {
                GrillaFiguras.Rows.Add(new object[] { x.Nombre, string.Format(SesionActiva.FormatoMoneda, x.ValorPremio) });
                mTotalPremios += x.ValorPremio;
            }

            if (!mListaFiguras.IsNullOrZeroItems())
            {
                GrillaFiguras.Rows.Add(new object[] { string.Empty, string.Format(SesionActiva.FormatoMoneda, mTotalPremios) });
                ColocarColorGrilla(GrillaFiguras, -1, GrillaFiguras.Rows.Count - 1, 3);
            }
        }

        private void CargarRecaudoJuego()
        {
            decimal mGastos = 0;
            decimal mIngresos = 0;
            decimal mRecaudoTotal = 0;
            decimal mValorRecaudoCalculado = 0;
            mDiferencia = 0;

            mListaRecaudoTotal = mDominioRoe.FindRecaudoProgramacion(mProgramacionJuego.IdProgramacionJuego);

            foreach (var x in mListaRecaudoTotal)
            {
                GrillaRecaudo.Rows.Add(new object[] {
                    x.NombreUsuario,
                    string.Format(SesionActiva.FormatoMoneda, x.Gastos),
                    string.Format(SesionActiva.FormatoMoneda, x.Ingresos),
                    string.Format(SesionActiva.FormatoMoneda, x.RecuadoTotal),
                    string.Format(SesionActiva.FormatoMoneda, x.ValorRecaudoCalculado),
                    string.Format(SesionActiva.FormatoMoneda, x.Diferencia)
                });

                mGastos += x.Gastos;
                mIngresos += x.Ingresos;
                mRecaudoTotal += x.RecuadoTotal;
                mValorRecaudoCalculado += x.ValorRecaudoCalculado;
                mDiferencia += x.Diferencia;
            }

            if (!mListaRecaudoTotal.IsNullOrZeroItems())
            {
                GrillaRecaudo.Rows.Add(new object[] {
                    string.Empty,
                    string.Format(SesionActiva.FormatoMoneda, mGastos),
                    string.Format(SesionActiva.FormatoMoneda, mIngresos),
                    string.Format(SesionActiva.FormatoMoneda, mRecaudoTotal),
                    string.Format(SesionActiva.FormatoMoneda, mValorRecaudoCalculado),
                    string.Format(SesionActiva.FormatoMoneda, mDiferencia)
                });

                ColocarColorGrilla(GrillaRecaudo, -1, GrillaRecaudo.Rows.Count - 1, 3);
            }
        }

        private DataSet CargarDataSetReporte()
        {
            DtsEncabezadoPlanillaJuego ds = new DtsEncabezadoPlanillaJuego();
            var tablaEncabezado = ds.Encabezado;
            var tablaDetalleVendedores = ds.DetalleVendedores;
            var tablaDetalleRecaudo = ds.DetalleRecaudo;
            var tablaDetallePremios = ds.DetallePremios;

            DtsEncabezadoPlanillaJuego.EncabezadoRow rowHeader = tablaEncabezado.NewEncabezadoRow();
            rowHeader.NumeroJuego = mProgramacionJuego.IdProgramacionJuego.ToString().PadLeft(7, '0');
            rowHeader.Fecha = mProgramacionJuego.FechaProgramada.ToString("d");
            rowHeader.Usuario = mDominioAuditoria.ConsultarUsuarioAccion("programacionjuegos", $"\"IdProgramacionJuego\":{mProgramacionJuego.IdProgramacionJuego}")?.Login;
            rowHeader.Serie = $"{mSerie.Fabrica} del {mProgramacionJuego.CartonInicial} al {mProgramacionJuego.CartonFinal}";
            rowHeader.ValorCarton = string.Format(SesionActiva.FormatoMoneda, mProgramacionJuego.ValorCarton);
            rowHeader.ValorModulos = string.Format(SesionActiva.FormatoMoneda, mProgramacionJuego.ValorModulo);
            rowHeader.TotalPremios = string.Format(SesionActiva.FormatoMoneda, mProgramacionJuego.TotalPremios);
            rowHeader.TotalCartones = mProgramacionJuegoDinero.TotalCartones.ToString();
            rowHeader.AsistenciaSocial = string.Format(SesionActiva.FormatoMoneda, mProgramacionJuegoDinero.AsistenciaSocial);
            rowHeader.CuentasCobrar = string.Format(SesionActiva.FormatoMoneda, mProgramacionJuegoDinero.TotalCuentasCobrar);
            rowHeader.TotalVentas = string.Format(SesionActiva.FormatoMoneda, mProgramacionJuegoDinero.TotalVentas);
            rowHeader.TotalRecaudo = string.Format(SesionActiva.FormatoMoneda, mProgramacionJuegoDinero.TotalRecaudoJuego);
            rowHeader.Faltante = string.Format(SesionActiva.FormatoMoneda, mListaRecaudoTotal.Where(x => x.Diferencia < 0).Sum(x => x.Diferencia));
            rowHeader.Efectivo = string.Format(SesionActiva.FormatoMoneda, mProgramacionJuegoDinero.Efectivo);
            rowHeader.Banco = string.Format(SesionActiva.FormatoMoneda, mProgramacionJuegoDinero.DineroBanco);
            rowHeader.Sobrante = string.Format(SesionActiva.FormatoMoneda, mListaRecaudoTotal.Where(x => x.Diferencia > 0).Sum(x => x.Diferencia));
            rowHeader.TotalGastos = string.Format(SesionActiva.FormatoMoneda, mListaGastos.Sum(x => x.Valor));
            rowHeader.ResultadoFinal = string.Format(SesionActiva.FormatoMoneda, mProgramacionJuegoDinero.DineroBanco + mProgramacionJuegoDinero.Efectivo);
            rowHeader.TotalValorComision = string.Format(SesionActiva.FormatoMoneda, mListaVendedoresCobros.Sum(x => x.ValorComision));
            rowHeader.TotalValorRecibido = string.Format(SesionActiva.FormatoMoneda, mListaVendedoresCobros.Sum(x => x.TotalRecibido));
            rowHeader.TotalValorRecaudoCalculado = string.Format(SesionActiva.FormatoMoneda, mListaRecaudoTotal.Sum(x => x.ValorRecaudoCalculado));
            rowHeader.TotalValorDiferencia = string.Format(SesionActiva.FormatoMoneda, mListaRecaudoTotal.Sum(x => x.Diferencia));
            rowHeader.TotalValorPremios = string.Format(SesionActiva.FormatoMoneda, mListaFiguras.Sum(x => x.ValorPremio));

            tablaEncabezado.AddEncabezadoRow(rowHeader);

            foreach (var item in mListaVendedoresCobros)
            {
                /// Inserto en la tabla detalle vendedores.
                DtsEncabezadoPlanillaJuego.DetalleVendedoresRow detail = tablaDetalleVendedores.NewDetalleVendedoresRow();
                detail.NumeroJuego = mProgramacionJuego.IdProgramacionJuego.ToString().PadLeft(7, '0');
                detail.NombreVendedor = item.Nombres;
                detail.Cartones = item.TotalCartones.ToString();
                detail.Modulos = item.TotalModulos.ToString();
                detail.CartonesCortesia = item.CartonesCortesia.ToString();
                detail.TotalVentas = string.Format(SesionActiva.FormatoMoneda, item.TotalVentas);
                detail.CartonesDevueltos = item.CartonesDevueltos.ToString();
                detail.PorcentajeComision = $"{item.PorcentajeComision} %";
                detail.GastosCortesia = string.Format(SesionActiva.FormatoMoneda, item.GastoCortesia);
                detail.ValorComision = string.Format(SesionActiva.FormatoMoneda, item.ValorComision);
                detail.Recibido = string.Format(SesionActiva.FormatoMoneda, item.TotalRecibido);
                tablaDetalleVendedores.AddDetalleVendedoresRow(detail);
            }

            foreach (var item in mListaRecaudoTotal)
            {
                /// Inserto en la tabla detalle vendedores.
                DtsEncabezadoPlanillaJuego.DetalleRecaudoRow detail = tablaDetalleRecaudo.NewDetalleRecaudoRow();
                detail.NumeroJuego = mProgramacionJuego.IdProgramacionJuego.ToString().PadLeft(7, '0');
                detail.NombreUsuario = item.NombreUsuario;
                detail.Ingresos = string.Format(SesionActiva.FormatoMoneda, item.Ingresos);
                detail.Gastos = string.Format(SesionActiva.FormatoMoneda, item.Gastos);
                detail.RecaudoTotal = string.Format(SesionActiva.FormatoMoneda, item.RecuadoTotal);
                detail.ValorRecaudoTotal = string.Format(SesionActiva.FormatoMoneda, item.ValorRecaudoCalculado);
                detail.Diferencia = string.Format(SesionActiva.FormatoMoneda, item.Diferencia);
                tablaDetalleRecaudo.AddDetalleRecaudoRow(detail);
            }

            foreach (var item in mListaFiguras)
            {
                /// Inserto en la tabla detalle vendedores.
                DtsEncabezadoPlanillaJuego.DetallePremiosRow detail = tablaDetallePremios.NewDetallePremiosRow();
                detail.NumeroJuego = mProgramacionJuego.IdProgramacionJuego.ToString().PadLeft(7, '0');
                detail.NombreFigura = item.Nombre;
                detail.ValorFigura = string.Format(SesionActiva.FormatoMoneda, item.ValorPremio);
                tablaDetallePremios.AddDetallePremiosRow(detail);
            }

            ds.AcceptChanges();

            return ds;
        }

        private void CargarVendedoresCobrosJuego()
        {
            GrillaVendedores.Rows.Clear();
            mListaVendedoresCobros = mDominioRoe.FindAllVendedoresCobroCartones(mProgramacionJuego.IdProgramacionJuego);

            int mTotalCartones = 0;
            int mCartonesCortesia = 0;
            double mTotalModulos = 0;
            double mTotalVentas = 0;
            int mCartonesDevueltos = 0;
            double mValorComision = 0;
            double mTotalPagado = 0;
            double mVentaTotalCartones = 0;
            double mTotalGastoCortesia = 0;
            double mFaltantes = 0;
            double mTotalRecibido = 0;

            foreach (var x in mListaVendedoresCobros)
            {
                GrillaVendedores.Rows.Add(new object[] {
                    $"{x.Nombres} {x.Apellidos}",
                    x.TotalCartones,
                    x.CartonesCortesia,
                    x.TotalModulos,
                    string.Format(SesionActiva.FormatoMoneda, x.TotalVentas),
                    x.CartonesDevueltos,
                    x.PorcentajeComision,
                    string.Format(SesionActiva.FormatoMoneda, x.GastoCortesia),
                    string.Format(SesionActiva.FormatoMoneda, x.ValorComision),
                    string.Format(SesionActiva.FormatoMoneda, x.Abonos + x.TotalPagado),
                    string.Format(SesionActiva.FormatoMoneda, x.Faltante),
                    string.Format(SesionActiva.FormatoMoneda, x.TotalRecibido),
                    (x.TotalCartones - x.CartonesCortesia - x.CartonesDevueltos)
                });

                mTotalCartones += x.TotalCartones;
                mCartonesCortesia += x.CartonesCortesia;
                mTotalModulos += x.TotalModulos;
                mTotalVentas += x.TotalVentas;
                mCartonesDevueltos += x.CartonesDevueltos;
                mTotalGastoCortesia += x.GastoCortesia;
                mValorComision += x.ValorComision;
                mTotalPagado += (x.Abonos + x.TotalPagado);
                mFaltantes += x.Faltante;
                mTotalRecibido += x.TotalRecibido;
                mVentaTotalCartones += (x.TotalCartones - x.CartonesCortesia - x.CartonesDevueltos);

                mGananciaJuego += x.TotalRecibido;
            }

            if (!mListaVendedoresCobros.IsNullOrZeroItems())
            {
                GrillaVendedores.Rows.Add(new object[] {
                    string.Empty,
                    mTotalCartones,
                    mCartonesCortesia,
                    mTotalModulos,
                    string.Format(SesionActiva.FormatoMoneda, mTotalVentas),
                    mCartonesDevueltos,
                    string.Empty,
                    string.Format(SesionActiva.FormatoMoneda, mTotalGastoCortesia),
                    string.Format(SesionActiva.FormatoMoneda, mValorComision),
                    string.Format(SesionActiva.FormatoMoneda, mTotalPagado),
                    string.Format(SesionActiva.FormatoMoneda, mFaltantes),
                    string.Format(SesionActiva.FormatoMoneda, mTotalRecibido),
                    mVentaTotalCartones
                });

                ColocarColorGrilla(GrillaVendedores, -1, GrillaVendedores.Rows.Count - 1, 3);
            }
        }

        private void cmdProgramacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdProgramacion.SelectedIndex >= 0)
            {
                mProgramacionJuego = mDominioProgramacion.ObtenerProgramacion(ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion).IdProgramacionJuego);
                CargarInformacionJuego();
            }
        }

        private void ReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EjecutarReporte(CargarDataSetReporte(), new ReportePlanillaJuego());            
        }
    }
}
