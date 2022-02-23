using Caja.Dominio;
using Caja.Entidades;
using Caja.Entidades.Vistas;
using Caja.Escritorio.App;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System;
using System.Data;
using Caja.Escritorio.Formularios.Reportes.DataSets;
using Caja.Escritorio.Formularios.Reportes;

namespace Caja.Escritorio.Formularios.Caja
{
    public partial class FrmReporteUsuario : Base
    {
        private DominioProgramacionJuego mDominioProgramacion;
        private DominioUsuario mDominioUsuario;
        private DominioGastoProgramacionJuego mDominioGastos;
        private DominioIngresoProgramacionJuego mDominioIngresos;
        private DominioRecaudoFaltante mDominioRecaudoFaltante;

        private DominioRecaudoTotal mDominioRecaudoTotal;        
        private DominioRoe mDominioRoe;   
        private ProgramacionJuego mProgramacionJuego;
        private Usuario mUsuario;
        private RecaudoTotal mRecaudoTotal;        

        private List<VistaVendedorCobroCartones> mListaVendedoresCobros;
        private List<RecaudoFaltante> mListaRecaudoFaltantes;
        private List<VistaGastosProgramacionJuego> mListaGastos;
        private List<VistaIngresosProgramacionJuego> mListaIngresos;

        private double mTotalGastos = 0;
        private double mTotalIngresos = 0;
        private double mTotalFaltante = 0;
        private double mTotalRecibido = 0;
        private int mTotalCartones = 0;
        private int mCartonesCortesia = 0;
        private double mTotalModulos = 0;
        private double mTotalFacturado = 0;
        private int mCartonesDevueltos = 0;
        private double mValorComision = 0;
        private double mVentaTotalCartones = 0;
        private double mTotalGastoCortesia = 0;
        private double mFaltantes = 0;

        public FrmReporteUsuario()
        {
            InitializeComponent();
            InstanciarObjetos();
            InicializarControles();
        }

        private void InstanciarObjetos()
        {
            mDominioProgramacion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioUsuario = new DominioUsuario();
            mDominioGastos = new DominioGastoProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioIngresos = new DominioIngresoProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRecaudoFaltante = new DominioRecaudoFaltante(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRecaudoTotal = new DominioRecaudoTotal(SesionActiva.UsuarioActual.IdUsuario);
            mDominioRoe = new DominioRoe();
                        
            mListaVendedoresCobros = new List<VistaVendedorCobroCartones>();
            mListaRecaudoFaltantes = new List<RecaudoFaltante>();
            mListaGastos = new List<VistaGastosProgramacionJuego>();
            mListaIngresos = new List<VistaIngresosProgramacionJuego>();
        }

        private void InicializarControles()
        {            
            CargaCombo(cmdUsuarios, mDominioUsuario.FetchAll(), "NombreCompleto", "IdUsuario", ComboBoxStyle.DropDownList);
        }

        private void LimpiarInformacion()
        {
            GrillaVendedores.Rows.Clear();
            GrillaGastos.Rows.Clear();
            GrillaIngresos.Rows.Clear();
            GrillaFaltantes.Rows.Clear();
            txFaltantes.Text = "0";
            txGastos.Text = "0";
            txIngresos.Text = "0";
            txTotalFaltantes.Text = "0";
            txDiferencia.Text = "0";
            txEntregado.Text = "0";
            txCartones.Text = "0";
            txCalculado.Text = "0";
            txFacturado.Text = "0";
        }

        private void CargarInformacionCompleta()
        {
            LimpiarInformacion();
            CargarVendedoresCobros();
            CargarGastos();
            CargarIngresos();
            CargarFaltante();
            CargarDatosCierre();
        }

        private void CargarVendedoresCobros()
        {
            mListaVendedoresCobros = mDominioRoe.FindAllVendedoresCobroCartones(mProgramacionJuego.IdProgramacionJuego, mUsuario.IdUsuario);

            foreach (var x in mListaVendedoresCobros)
            {
                GrillaVendedores.Rows.Add(new object[] {
                    $"{x.Nombres} {x.Apellidos}",
                    x.TotalCartones,
                    x.CartonesCortesia,
                    x.TotalModulos,
                    x.CartonesDevueltos,
                    x.PorcentajeComision,
                    string.Format(SesionActiva.FormatoMoneda, x.ValorComision),
                    string.Format(SesionActiva.FormatoMoneda, x.TotalVentas),
                    string.Format(SesionActiva.FormatoMoneda, x.Faltante),
                    string.Format(SesionActiva.FormatoMoneda, x.GastoCortesia),
                    string.Format(SesionActiva.FormatoMoneda, x.TotalRecibido),                    
                    (x.TotalCartones - x.CartonesDevueltos - x.CartonesCortesia)
                });

                mTotalRecibido += x.TotalRecibido;
                mTotalFacturado += x.TotalVentas;
                mFaltantes += x.Faltante;
                mTotalCartones += x.TotalCartones;
                mCartonesDevueltos += x.CartonesDevueltos;
                mVentaTotalCartones += (x.TotalCartones - x.CartonesDevueltos - x.CartonesCortesia);
                mTotalGastoCortesia += x.GastoCortesia;
                mValorComision += x.ValorComision;
                mCartonesCortesia += x.CartonesCortesia;
                mTotalModulos += x.TotalModulos;                
            }

            txCartones.Text = string.Format(SesionActiva.FormatoMoneda, mTotalRecibido);
            txFaltantes.Text = string.Format(SesionActiva.FormatoMoneda, mFaltantes);
            txFacturado.Text = string.Format(SesionActiva.FormatoMoneda, mTotalFacturado);

            if (!mListaVendedoresCobros.IsNullOrZeroItems())
            {
                GrillaVendedores.Rows.Add(new object[] {
                    string.Empty,
                    mTotalCartones,
                    mCartonesCortesia,
                    mTotalModulos,
                    mCartonesDevueltos,
                    string.Empty,
                    string.Format(SesionActiva.FormatoMoneda, mValorComision),
                    string.Format(SesionActiva.FormatoMoneda, mTotalFacturado),
                    string.Format(SesionActiva.FormatoMoneda, mFaltantes),
                    string.Format(SesionActiva.FormatoMoneda, mTotalGastoCortesia),
                    string.Format(SesionActiva.FormatoMoneda, mTotalRecibido),
                    mVentaTotalCartones
                });

                ColocarColorGrilla(GrillaVendedores, -1, GrillaVendedores.Rows.Count - 1, 3);
            }            
        }

        private void CargarGastos()
        {
            mTotalGastos = 0;
            mListaGastos = mDominioGastos.ObtenerGastosProgramacionJuego(mProgramacionJuego.IdProgramacionJuego, mUsuario.IdUsuario);

            foreach (var x in mListaGastos)
            {
                GrillaGastos.Rows.Add(new object[] { x.Descripcion, string.Format(SesionActiva.FormatoMoneda, x.Valor) });
                mTotalGastos += x.Valor;
            }

            if (!mListaGastos.IsNullOrZeroItems())
            {
                GrillaGastos.Rows.Add(new object[] { string.Empty, string.Format(SesionActiva.FormatoMoneda, mTotalGastos) });
                ColocarColorGrilla(GrillaGastos, -1, GrillaGastos.Rows.Count - 1, 3);
            }

            txGastos.Text = string.Format(SesionActiva.FormatoMoneda, mTotalGastos);
        }

        private void CargarIngresos()
        {
            mTotalIngresos = 0;
            mListaIngresos = mDominioIngresos.ObtenerIngresosProgramacionJuego(mProgramacionJuego.IdProgramacionJuego, mUsuario.IdUsuario);

            foreach (var x in mListaIngresos)
            {
                GrillaIngresos.Rows.Add(new object[] { x.Descripcion, string.Format(SesionActiva.FormatoMoneda, x.Valor) });
                mTotalIngresos += x.Valor;
            }

            if (!mListaIngresos.IsNullOrZeroItems())
            {
                GrillaIngresos.Rows.Add(new object[] { string.Empty, string.Format(SesionActiva.FormatoMoneda, mTotalIngresos) });
                ColocarColorGrilla(GrillaIngresos, -1, GrillaIngresos.Rows.Count - 1, 3);
            }

            txIngresos.Text = string.Format(SesionActiva.FormatoMoneda, mTotalIngresos);
        }

        private void CargarFaltante()
        {
            mTotalFaltante = 0;
            mListaRecaudoFaltantes = mDominioRecaudoFaltante.Obtener(mUsuario.IdUsuario, mProgramacionJuego.IdProgramacionJuego);

            foreach (var x in mListaRecaudoFaltantes)
            {
                GrillaFaltantes.Rows.Add(new object[] { x.IdVendedor, string.Format(SesionActiva.FormatoMoneda, x.ValorRecibido) });
                mTotalFaltante += x.ValorRecibido;
            }

            if (!mListaRecaudoFaltantes.IsNullOrZeroItems())
            {
                GrillaFaltantes.Rows.Add(new object[] { string.Empty, string.Format(SesionActiva.FormatoMoneda, mTotalIngresos) });
                ColocarColorGrilla(GrillaFaltantes, -1, GrillaFaltantes.Rows.Count - 1, 3);
            }

            txTotalFaltantes.Text = string.Format(SesionActiva.FormatoMoneda, mTotalFaltante);
        }

        private void CargarDatosCierre()
        {
            mRecaudoTotal = mDominioRecaudoTotal.Obtener(mProgramacionJuego.IdProgramacionJuego, mUsuario.IdUsuario);

            if (mRecaudoTotal != null)
            {
                txEntregado.Text = string.Format(SesionActiva.FormatoMoneda, mRecaudoTotal.RecuadoTotal);
                txCalculado.Text = string.Format(SesionActiva.FormatoMoneda, mRecaudoTotal.ValorRecaudoCalculado);
                txDiferencia.Text = string.Format(SesionActiva.FormatoMoneda, mRecaudoTotal.Diferencia);
            }
            else
            {
                txEntregado.Text = string.Format(SesionActiva.FormatoMoneda, 0);
                txCalculado.Text = string.Format(SesionActiva.FormatoMoneda, mTotalRecibido + mTotalIngresos - mTotalGastos + mTotalFaltante);
                txDiferencia.Text = string.Format(SesionActiva.FormatoMoneda, 0);
            }
        }

        private DataSet CargarDataSetReporte()
        {
            DtsEncabezadoCajaUsuario ds = new DtsEncabezadoCajaUsuario();
            var tablaEncabezado = ds.Encabezado;
            var tablaDetalle = ds.Detalle;

            DtsEncabezadoCajaUsuario.EncabezadoRow rowHeader = tablaEncabezado.NewEncabezadoRow();
            rowHeader.IdentificadorUsuario = $"{mUsuario.IdUsuario.ToString().PadLeft(3, '0')}-{mUsuario.NombreCompleto}";
            rowHeader.NumeroJuego = mProgramacionJuego.IdProgramacionJuego.ToString().PadLeft(7, '0');
            rowHeader.TotalCartones = mTotalCartones.ToString();
            rowHeader.TotalCartonesCortesia = mCartonesCortesia.ToString();
            rowHeader.TotalModulos = mTotalModulos.ToString();
            rowHeader.TotalCartonesDevueltos = mCartonesDevueltos.ToString();
            rowHeader.TotalValorComision = string.Format(SesionActiva.FormatoMoneda, mValorComision);
            rowHeader.TotalVentas = string.Format(SesionActiva.FormatoMoneda, mTotalFacturado);
            rowHeader.TotalFaltante = string.Format(SesionActiva.FormatoMoneda, mFaltantes);
            rowHeader.TotalGastoCortesia = string.Format(SesionActiva.FormatoMoneda, mTotalGastoCortesia);
            rowHeader.TotalRecibido = string.Format(SesionActiva.FormatoMoneda, mTotalRecibido);            

            tablaEncabezado.AddEncabezadoRow(rowHeader);

            foreach (var item in mListaVendedoresCobros)
            {
                /// Inserto en la tabla detalle.
                DtsEncabezadoCajaUsuario.DetalleRow detail = tablaDetalle.NewDetalleRow();
                detail.NombreVendedor = item.Nombres;
                detail.Cartones = item.TotalCartones.ToString();
                detail.CartonesCortesia = item.CartonesCortesia.ToString();
                detail.Modulos = item.TotalModulos.ToString();
                detail.Devueltos = item.CartonesDevueltos.ToString();
                detail.PorcentajeComision = $"{item.PorcentajeComision} %";
                detail.ValorComision = string.Format(SesionActiva.FormatoMoneda, item.ValorComision);
                detail.Ventas = string.Format(SesionActiva.FormatoMoneda, item.TotalVentas);
                detail.Faltante = string.Format(SesionActiva.FormatoMoneda, item.Faltante);
                detail.GastoCortesia = string.Format(SesionActiva.FormatoMoneda, item.GastoCortesia);                
                detail.Recibido = string.Format(SesionActiva.FormatoMoneda, item.TotalRecibido);
                tablaDetalle.AddDetalleRow(detail);
            }

            ds.AcceptChanges();

            return ds;
        }

        private void cmdUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdUsuarios.SelectedIndex >= 0)
            {
                mUsuario = mDominioUsuario.FetchOne(ObtenerItemCombo<Usuario>(cmdUsuarios).IdUsuario);
                List<ProgramacionJuego> mListaJuegos = mDominioRoe.FindAllVendedoresCobroCartonesPorUsuario(mUsuario.IdUsuario).Distinct().Select(x => new ProgramacionJuego() { IdProgramacionJuego = x }).ToList();
                LimpiarInformacion();
                CargaCombo(cmdProgramacion, mListaJuegos, "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList);                
            }
        }

        private void cmdProgramacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdProgramacion.SelectedIndex >= 0)
            {
                mProgramacionJuego = mDominioProgramacion.ObtenerProgramacion(ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion).IdProgramacionJuego);
                CargarInformacionCompleta();
            }
        }

        private void ReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EjecutarReporte(CargarDataSetReporte(), new ReporteCajaUsuario());
        }
    }
}

