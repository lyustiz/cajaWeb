using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Juego
{
    public partial class FrmDevolucionCodigoBarras : Base
    {
        DominioProgramacionDevolucionCodigoBarra mDominioDevolucionCodigoBarra;
        DominioVendedorHojas mDominioVendedorHoja;
        DominioProgramacionJuego mDominioProgramaion;
        

        int mNumeroCartonesHoja;
        int mIdVendedor;
        int mIdProgramacionJuego;
        DateTime mHoraCartones;
        DateTime mHoraHojas;

        public int TotalCartonesDevueltos { get; private set; }

        public FrmDevolucionCodigoBarras(string pDatosVendedor, int pIdVendedor, int pIdProgramacionJuego)
        {
            InitializeComponent();

            lblNombreVendedor.Text = pDatosVendedor;
            mIdVendedor = pIdVendedor;
            mIdProgramacionJuego = pIdProgramacionJuego;

            InstanciarObjetos();
            InicializarObjetos();
        }

        private void InstanciarObjetos()
        {
            mDominioDevolucionCodigoBarra = new DominioProgramacionDevolucionCodigoBarra(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorHoja = new DominioVendedorHojas(SesionActiva.UsuarioActual.IdUsuario);
            mDominioProgramaion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);            
        }

        private void InicializarObjetos()
        {
            mNumeroCartonesHoja = Convert.ToInt32(ObtenerValorParametroGeneral("Caja-CantidadCartonesHoja"));
            lstCartones.Items.Clear();
            lstHojas.Items.Clear();
            LstOrden.Items.Clear();
            mHoraCartones = DateTime.Now;
            mHoraHojas = DateTime.Now;

            CargarDevoluciones();

            txtRegistro.ResetText();
            txtRegistro.Select();
        }

        private void CargarDevoluciones()
        {
            var mCartonesDevueltos = mDominioDevolucionCodigoBarra.ObtenerPorVendedor(mIdVendedor, mIdProgramacionJuego);

            if (!mCartonesDevueltos.IsNullOrZeroItems())
            {
                foreach (var carton in mCartonesDevueltos)
                {
                    if (carton.HojaCarton.StartsWithIgnoreCase("H-"))
                        lstHojas.Items.Add(carton.HojaCarton);
                    else
                        LstOrden.Items.Add(carton.HojaCarton);
                }

                lstCartones.Items.Clear();
                txtRegistro.ResetText();

                for (var indice = LstOrden.Items.Count - 1; indice >= 0; indice--)                
                    lstCartones.Items.Add(LstOrden.Items[indice]);                
            }

            mHoraCartones = DateTime.Now;
            mHoraHojas = DateTime.Now;

            txtCartonesDevueltos.Text = lstCartones.Items.Count.ToString();
            txtHojasDevueltas.Text = lstHojas.Items.Count.ToString();
            txtRegistro.Select();

            TotalCartonesDevueltos = (lstHojas.Items.Count * mNumeroCartonesHoja) + lstCartones.Items.Count;
        }

        private void GuardarDevolucion()
        {
            int mTotalCartones = (lstHojas.Items.Count * mNumeroCartonesHoja) + lstCartones.Items.Count;

            if (mTotalCartones.IsOn(0))
                Close();

            mDominioDevolucionCodigoBarra.Eliminar(mIdVendedor, mIdProgramacionJuego);

            foreach (var carton in lstCartones.Items)
            {
                var mDevolucion = new ProgramacionDevolucionCodigoBarra() { IdVendedor = mIdVendedor, IdProgramacionJuego = mIdProgramacionJuego, HojaCarton = carton.ToString() };
                mDominioDevolucionCodigoBarra.Save(mDevolucion);
            }

            TotalCartonesDevueltos = mTotalCartones;

            MostrarMensajeInformativo("La devolución se realizó correctamente");

            Close();
        }

        private void AgregarCarton()
        {
            bool continuar = true;

            if (txtRegistro.Text.IsNullOrEmpty())
                return;                

            txtRegistro.Text = txtRegistro.Text.ToUpper().Replace(".", string.Empty).Replace(",", string.Empty).Replace("'", "-");

            if (!txtRegistro.Text.StartsWithIgnoreCase("C-")) //&& !txtRegistro.Text.StartsWithIgnoreCase("H-"))
            {
                continuar = NoPuedeContinuar("Se ha hecho mal un registro, vuelva a intentarlo por favor.");
                return;
            }   
            
            if (txtRegistro.Text.StartsWithIgnoreCase("H-"))
            {
                /// Revisamos las hojas.
                var arrDatos = txtRegistro.Text.Split('-');
                int mNumeroJuego = Convert.ToInt32(arrDatos[1]);
                int mNumeroHoja = Convert.ToInt32(arrDatos[2]);

                if (mNumeroJuego != mIdProgramacionJuego)                
                    continuar = NoPuedeContinuar("La hoja que se desea devolver pertenece a otro juego.");
                    
                var hoja = mDominioVendedorHoja.ObtenerHojaVendedor(mIdVendedor, mIdProgramacionJuego, mNumeroHoja);

                if (hoja is null)                
                    continuar = NoPuedeContinuar("La hoja no se encuentra asignada al vendedor, valide nuevamente la información.");                

                if (lstHojas.Items.Contains(txtRegistro.Text))
                    continuar = NoPuedeContinuar($"La hoja {txtRegistro.Text} ya se registro anteriormente.");
                
                if (continuar)
                {
                    lstHojas.Items.Add(txtRegistro.Text);
                    txtRegistro.ResetText();
                    mHoraHojas = DateTime.Now;
                    txtHojasDevueltas.Text = lstHojas.Items.Count.ToString();
                    txtRegistro.Select();
                }
            }
            else if (txtRegistro.Text.StartsWithIgnoreCase("C-"))
            {
                /// Revisamos los cartones.
                var arrDatos = txtRegistro.Text.Split('-');
                int mNumeroJuego = Convert.ToInt32(arrDatos[1]);
                int mNumeroCarton = Convert.ToInt32(arrDatos[2]);
                string mSerie = arrDatos[3];

                if (mNumeroJuego != mIdProgramacionJuego)
                    continuar = NoPuedeContinuar("El cartón que se desea devolver pertenece a otro juego.");

                if (lstCartones.Items.Contains(txtRegistro.Text))
                    continuar = NoPuedeContinuar($"El cartón {txtRegistro.Text} ya se registro anteriormente.");

                var serie = mDominioProgramaion.ObtenerSerieProgramacion(mIdProgramacionJuego);

                if (serie != mSerie)
                    continuar = NoPuedeContinuar($"La serie digitada {mSerie} NO CORRESPONDE a la definida inicialmente para el juego {mIdProgramacionJuego}.");

                int mNumeroHoja = mNumeroCarton / mNumeroCartonesHoja;

                if (mNumeroCarton % mNumeroCartonesHoja != 0)
                    mNumeroHoja += 1;

                var hoja = mDominioVendedorHoja.ObtenerHojaVendedor(mIdVendedor, mIdProgramacionJuego, mNumeroHoja);

                if (hoja is null)
                    continuar = NoPuedeContinuar("La hoja a la que corresponde el carton no esta asignada al vendedor.");

                if (continuar)
                {
                    LstOrden.Items.Add(txtRegistro.Text);
                    lstCartones.Items.Clear();
                    txtRegistro.ResetText();

                    for (var indice = LstOrden.Items.Count - 1; indice >= 0; indice--)                    
                        lstCartones.Items.Add(LstOrden.Items[indice]);                    

                    mHoraCartones = DateTime.Now;
                    txtCartonesDevueltos.Text = lstCartones.Items.Count.ToString();
                    txtRegistro.Select();
                }
            }
        }       
        
        private bool NoPuedeContinuar(string pMensaje)
        {
            MostrarMensajeError(pMensaje);
            txtRegistro.ResetText();
            txtRegistro.Select();

            return false;
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de borrar la información?", "Confirmación", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        lstCartones.Items.Clear();
                        lstHojas.Items.Clear();
                        LstOrden.Items.Clear();
                        txtCartonesDevueltos.ResetText();
                        txtHojasDevueltas.ResetText();
                        mHoraCartones = DateTime.Now;
                        mHoraHojas = DateTime.Now;
                        break;
                    }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de guardar la información?", "Confirmación", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        GuardarDevolucion();
                        break;
                    }
            }
        }

        private void txtRegistro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AgregarCarton();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            txtRelojCartones.Text = DateTime.Now.Subtract(mHoraCartones).ToString();
            txtRelojHojas.Text = DateTime.Now.Subtract(mHoraHojas).ToString();
        }
    }
}

