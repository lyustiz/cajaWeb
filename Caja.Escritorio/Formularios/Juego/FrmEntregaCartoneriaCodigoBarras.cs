using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Juego
{
    public partial class FrmEntregaCartoneriaCodigoBarras : Base
    {
        DominioVendedorHojas mDominioVendedorHojas;
        DominioProgramacionJuego mDominioProgramacionJuego;
        DominioHojasDevueltas mDominioHojasDevueltas;
        DominioVendedorResumen mDominioVendedorResumen;
        DominioVendedor mDominioVendedor;
        DominioProgramacionDevolucionCodigoBarra mDominioProgramacionDevolucionCodigoBarra;

        private int mNumeroCartonesHoja;
        private int mIdVendedor;

        public FrmEntregaCartoneriaCodigoBarras()
        {
            InitializeComponent();
            InstanciarObjetos();
            InicializarControles();            
        }

        private void InstanciarObjetos()
        {
            mDominioVendedorHojas = new DominioVendedorHojas(SesionActiva.UsuarioActual.IdUsuario);
            mDominioProgramacionJuego = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
            mDominioHojasDevueltas = new DominioHojasDevueltas(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorResumen = new DominioVendedorResumen(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedor = new DominioVendedor(SesionActiva.UsuarioActual.IdUsuario);
            mDominioProgramacionDevolucionCodigoBarra = new DominioProgramacionDevolucionCodigoBarra(SesionActiva.UsuarioActual.IdUsuario);
        }

        private void InicializarControles()
        {
            mNumeroCartonesHoja = Convert.ToInt32(ObtenerValorParametroGeneral("Caja-CantidadCartonesHoja"));
            CargarGrilla();
        }

        private void LimpiarControles()
        {
            mIdVendedor = 0;
            lblNombreVendedor.Text = string.Empty;
            txHoja.Text = string.Empty;            
        }

        private void CargarGrilla()
        {
            var listaVendedores = mDominioVendedorHojas.FindVendedoresEntregaCartones(txtFiltro.Text.Trim());

            LimpiarControles();
            Grilla.Rows.Clear();

            foreach (var vendedor in listaVendedores)            
                Grilla.Rows.Add(new object[] { vendedor.IdVendedor, vendedor.Codigo, vendedor.Nombres, vendedor.Apellidos, vendedor.IdProgramacionJuego, vendedor.SumaDeNumeroHoja });               
            
            if (listaVendedores.Count == 1)
            {
                CargarDatosVendedor(0);
            }
        }

        public void CargarDatosVendedor(int pIndice)
        {
            mIdVendedor = Convert.ToInt32(Grilla.Rows[pIndice].Cells["IdVendedor"].FormattedValue.ToString());

            lblNombreVendedor.Text = $"{Grilla.Rows[pIndice].Cells["Codigo"].FormattedValue} - " +
                $"{Grilla.Rows[pIndice].Cells["Nombres"].FormattedValue} " +
                $"{Grilla.Rows[pIndice].Cells["Apellidos"].FormattedValue}";

            txHoja.Select();
        }

        private void EliminarHoja()
        {
            if (txHoja.Text.IsNullOrEmpty())
                return;

            txHoja.Text = txHoja.Text.ToUpper().Replace(".", string.Empty).Replace(",", string.Empty).Replace("'", "-");

            if (!txHoja.Text.StartsWithIgnoreCase("H-"))
            {
                NoPuedeContinuar("Se ha hecho mal un registro, vuelva a intentarlo por favor.");
                return;
            }

            if (mIdVendedor <= 0)
            {
                NoPuedeContinuar("Debe seleccionar un vendedor antes de agregar hojas.");
                return;
            }

            var arrDatos = txHoja.Text.Split('-');
            int mNumeroJuego = Convert.ToInt32(arrDatos[1]);
            int mNumeroHoja = Convert.ToInt32(arrDatos[2]);

            ProgramacionJuego mProgramacionJuego = mDominioProgramacionJuego.ObtenerProgramacion(mNumeroJuego);

            if (mProgramacionJuego.Estado != "A")
            {
                NoPuedeContinuar($"El juego se encuentra CERRADO{Environment.NewLine}.No se puede realizar el procedimiento.");
                return;
            }

            // Valida que el vendedor no tenga el juego cerrado            
            VendedorResumen mVendedorResumen = mDominioVendedorResumen.ObtenerResumenVendedor(mIdVendedor, mProgramacionJuego.IdProgramacionJuego);

            if (mVendedorResumen != null && mVendedorResumen.Estado == 'A' && mVendedorResumen.Cobrado.IsOn(1))
            {
                NoPuedeContinuar($"El Vendedor ya realizo el CIERRE de cartoneria para este juego.");
                return;
            }

            // Valida que la hoja no se encuentre entregada anteriormente
            VendedorHoja mHojaVendedor = mDominioVendedorHojas.ObtenerHojasProgramacion(mProgramacionJuego.IdProgramacionJuego).FirstOrDefault(x => x.NumeroHoja == mNumeroHoja && x.Estado == 'A');
        
            if (mHojaVendedor == null)
            {
                // No esta registrada la hoja que se quiere devolver
                NoPuedeContinuar($"No se puede realizar la devolución porque no se encuentra registrada la hoja para este juego.");
                return;
            }
            else
            {
                // Realiza la devolucion
                //Determina quien lo tiene registrado el carton
                var vendedor = mDominioVendedor.FetchOne(mHojaVendedor.IdVendedor);
                lblNombreVendedor.Text = $"{vendedor.Codigo} - {vendedor.Nombres} {vendedor.Apellidos}";

                // Inactiva el registro
                mDominioVendedorHojas.Deshabilitar(mHojaVendedor);
                ProgramacionDevolucionCodigoBarra objDevolucion = new ProgramacionDevolucionCodigoBarra
                {
                    IdProgramacionJuego = mProgramacionJuego.IdProgramacionJuego,
                    IdVendedor = mIdVendedor,
                    HojaCarton = mNumeroHoja.ToString()
                };

                mDominioProgramacionDevolucionCodigoBarra.Save(objDevolucion);

                // Disminuye el registro del vendedor
                int mCantidad = mDominioVendedorHojas.ObtenerHojasProgramacion(mProgramacionJuego.IdProgramacionJuego).Count(x => x.IdVendedor == mIdVendedor && x.Estado == 'A');
                mCantidad *= mNumeroCartonesHoja;

                VendedorResumen objVendedorResumen = mDominioVendedorResumen.ObtenerResumenVendedor(mIdVendedor, mProgramacionJuego.IdProgramacionJuego);
                objVendedorResumen.TotalCartones = mCantidad;
                objVendedorResumen.ValorTotal = mCantidad * mProgramacionJuego.ValorCarton;
                objVendedorResumen.ValorPendiente = (mCantidad * mProgramacionJuego.ValorCarton) - objVendedorResumen.PagoAnticipado;

                mDominioVendedorResumen.RegistrarResumenVendedor(objVendedorResumen);

            }

            CargarGrilla();
            txHoja.Text = string.Empty;
            txHoja.Select();
        }

        private void AgregarHoja()
        {
            if (txHoja.Text.IsNullOrEmpty())
                return;

            txHoja.Text = txHoja.Text.ToUpper().Replace(".", string.Empty).Replace(",", string.Empty).Replace("'", "-");

            if (!txHoja.Text.StartsWithIgnoreCase("H-"))
            {
                NoPuedeContinuar("Se ha hecho mal un registro, vuelva a intentarlo por favor.");
                return;
            }

            if (mIdVendedor <= 0)
            {
                NoPuedeContinuar("Debe seleccionar un vendedor antes de agregar hojas.");
                return;
            }

            var arrDatos = txHoja.Text.Split('-');
            int mNumeroJuego = Convert.ToInt32(arrDatos[1]);
            int mNumeroHoja = Convert.ToInt32(arrDatos[2]);

            // Obtener la informacion de la programación.

            ProgramacionJuego mProgramacionJuego = mDominioProgramacionJuego.ObtenerProgramacion(mNumeroJuego);

            if (mProgramacionJuego.Estado == "A")
            {
                NoPuedeContinuar("No esta habilitado el juego para el que se esta haciendo el registro. Verifique nuevamente.");
                return;
            }

            // Valida que el vendedor no se encuentre bloqueado
            VendedorResumen mVendedorResumen = mDominioVendedorResumen.ObtenerResumenVendedor(mIdVendedor, mProgramacionJuego.IdProgramacionJuego);

            if (mVendedorResumen != null)
            {
                if (mVendedorResumen.Cobrado.IsOn(0))
                {
                    VendedorHoja mHojaVendedor = mDominioVendedorHojas.ObtenerHojasProgramacion(mProgramacionJuego.IdProgramacionJuego).FirstOrDefault(x => x.NumeroHoja == mNumeroHoja && x.Estado == 'A');

                    if (mHojaVendedor == null)
                    {
                        // Agrega la hoja
                        ProgramacionJuegoHojaDevuelta mHojaDevuelta = mDominioHojasDevueltas.ObtenerHojasDevueltasProgramacion(mProgramacionJuego.IdProgramacionJuego).FirstOrDefault(x => x.NumeroHoja == mNumeroHoja && x.Estado == 'A');

                        if (mHojaDevuelta != null)
                        {
                            // Inactiva el registro
                            mDominioHojasDevueltas.Deshabilitar(mProgramacionJuego.IdProgramacionJuego, mNumeroHoja);
                        }

                        txHoja.Text = string.Empty;
                        txHoja.Select();
                    }
                    else
                    {
                        // Determina quien lo tiene registrado el carton
                        var vendedor = mDominioVendedor.FetchOne(mHojaVendedor.IdVendedor);

                        MostrarMensajeError($"La hoja digitada ya ha sido asignada previamente. Valide nuevamenete la información{Environment.NewLine}Vendedor: {vendedor.Nombres} {vendedor.Apellidos}" +
                            $"{Environment.NewLine}Código: {vendedor.Codigo}");

                        txHoja.Text = string.Empty;
                        txHoja.Select();

                        return;
                    }

                    // Almacena informacion en vendedor por hoja
                    VendedorHoja objNuevoVendedorHoja = new VendedorHoja();
                    objNuevoVendedorHoja.IdProgramacionJuego = mProgramacionJuego.IdProgramacionJuego;
                    objNuevoVendedorHoja.IdVendedor = mIdVendedor;
                    objNuevoVendedorHoja.Estado = 'A';
                    objNuevoVendedorHoja.NumeroHoja = mNumeroHoja;
                    mDominioVendedorHojas.RegistrarHojaVendedor(objNuevoVendedorHoja);

                    // Valida cuantos cartones tiene el vendedor
                    int mCantidad = mDominioVendedorHojas.ObtenerHojasProgramacion(mProgramacionJuego.IdProgramacionJuego).Count(x => x.IdVendedor == mIdVendedor && x.Estado == 'A');
                    mCantidad *= mNumeroCartonesHoja;

                    VendedorResumen objVendedorResumen = mDominioVendedorResumen.ObtenerResumenVendedor(mIdVendedor, mProgramacionJuego.IdProgramacionJuego);
                    objVendedorResumen.TotalCartones = mCantidad;
                    objVendedorResumen.ValorTotal = mCantidad * mProgramacionJuego.ValorCarton;
                    objVendedorResumen.ValorPendiente = (mCantidad * mProgramacionJuego.ValorCarton) - objVendedorResumen.PagoAnticipado;

                    mDominioVendedorResumen.RegistrarResumenVendedor(objVendedorResumen);

                    CargarGrilla();
                    txHoja.Select();
                }
                else
                    txHoja.Text = string.Empty;
            }
            else
            {
                // Continua el proceso normal
                // Valida que la hoja no se encuentre entregada anteriormente
                VendedorHoja mHojaVendedor = mDominioVendedorHojas.ObtenerHojasProgramacion(mProgramacionJuego.IdProgramacionJuego).FirstOrDefault(x => x.NumeroHoja == mNumeroHoja && x.Estado == 'A');

                if (mHojaVendedor == null)
                {
                    // Agrega la hoja
                    ProgramacionJuegoHojaDevuelta mHojaDevuelta = mDominioHojasDevueltas.ObtenerHojasDevueltasProgramacion(mProgramacionJuego.IdProgramacionJuego).FirstOrDefault(x => x.NumeroHoja == mNumeroHoja && x.Estado == 'A');

                    if (mHojaDevuelta != null)
                    {
                        // Inactiva el registro
                        mDominioHojasDevueltas.Deshabilitar(mProgramacionJuego.IdProgramacionJuego, mNumeroHoja);
                    }

                    txHoja.Text = string.Empty;
                    txHoja.Select();
                }
                else
                {
                    // Determina quien lo tiene registrado el carton
                    var vendedor = mDominioVendedor.FetchOne(mHojaVendedor.IdVendedor);

                    MostrarMensajeError($"La hoja digitada ya ha sido asignada previamente. Valide nuevamenete la información{Environment.NewLine}Vendedor: {vendedor.Nombres} {vendedor.Apellidos}" +
                        $"{Environment.NewLine}Código: {vendedor.Codigo}");

                    txHoja.Text = string.Empty;
                    txHoja.Select();

                    return;
                }

                // Procede a almacenar la informacion
                // Valida si ya existe el registro resumen del vendedor                
                if (mVendedorResumen == null)
                {
                    // Insertar registro en resumen.
                    VendedorResumen objNuevoResumenVendedor = new VendedorResumen
                    {
                        IdProgramacionJuego = mProgramacionJuego.IdProgramacionJuego,
                        IdVendedor = mIdVendedor,
                        Estado = 'A'
                    };
                    mDominioVendedorResumen.RegistrarResumenVendedor(objNuevoResumenVendedor);
                }

                // Almacena informacion en vendedor por hoja
                VendedorHoja objNuevoVendedorHoja = new VendedorHoja();
                objNuevoVendedorHoja.IdProgramacionJuego = mProgramacionJuego.IdProgramacionJuego;
                objNuevoVendedorHoja.IdVendedor = mIdVendedor;
                objNuevoVendedorHoja.Estado = 'A';
                objNuevoVendedorHoja.NumeroHoja = mNumeroHoja;
                mDominioVendedorHojas.RegistrarHojaVendedor(objNuevoVendedorHoja);

                // Valida cuantos cartones tiene el vendedor
                int mCantidad = mDominioVendedorHojas.ObtenerHojasProgramacion(mProgramacionJuego.IdProgramacionJuego).Count(x => x.IdVendedor == mIdVendedor && x.Estado == 'A');
                mCantidad *= mNumeroCartonesHoja;

                VendedorResumen objVendedorResumen = mDominioVendedorResumen.ObtenerResumenVendedor(mIdVendedor, mProgramacionJuego.IdProgramacionJuego);
                objVendedorResumen.TotalCartones = mCantidad;
                objVendedorResumen.ValorTotal = mCantidad * mProgramacionJuego.ValorCarton;
                objVendedorResumen.ValorPendiente = (mCantidad * mProgramacionJuego.ValorCarton) - objVendedorResumen.PagoAnticipado;

                mDominioVendedorResumen.RegistrarResumenVendedor(objVendedorResumen);
            }
        }

        private bool NoPuedeContinuar(string pMensaje)
        {
            MostrarMensajeError(pMensaje);
            txHoja.Text = string.Empty;
            txHoja.Select();

            return false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CargarGrilla();
        }

        private void GrillaBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosVendedor(Grilla.CurrentCell.RowIndex);
        }

        private void txHoja_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkDevoluciones.Checked == false)                
                    AgregarHoja();                
                else                
                    EliminarHoja();                
            }                
        }       
    }
}
