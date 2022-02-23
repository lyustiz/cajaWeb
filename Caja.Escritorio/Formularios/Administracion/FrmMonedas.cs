using Caja.Entidades;
using Caja.Escritorio.App;
using Caja.Escritorio.Formularios.General;
using System;

namespace Caja.Escritorio.Formularios.Administracion
{
    public partial class FrmMonedas : Base
    {
        readonly string pesos = "$";
        readonly string dolares = "U$";
        readonly string euros = "€";

        ParametroGeneral parametroMoneda;
        ParametroGeneral parametroFormato;        

        public FrmMonedas()
        {
            InitializeComponent();            
            InicializarControles();
        }

        private void InicializarControles()
        {
            parametroMoneda = ObtenerParametroGeneral("strModeda");
            parametroFormato = ObtenerParametroGeneral("strFormato");

            if (parametroMoneda != null)
            {
                if (parametroMoneda.Valor == pesos)
                    rbtPesos.Checked = true;
                else if (parametroMoneda.Valor == dolares)
                    rbtDolares.Checked = true;
                else if (parametroMoneda.Valor == euros)
                    rbtEuros.Checked = true;                
            }
            else
                rbtPesos.Checked = true;

            if (parametroFormato != null)
                txtDecimales.Text = parametroFormato.Valor;            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtPesos.Checked)
                    parametroMoneda.Valor = pesos;
                else if (rbtDolares.Checked)
                    parametroMoneda.Valor = dolares;
                else if (rbtEuros.Checked)
                    parametroMoneda.Valor = euros;

                parametroFormato.Valor = txtDecimales.Text.Trim();

                var resMoneda = mDominioParametroGeneral.Save(parametroMoneda);
                var resFormato = mDominioParametroGeneral.Save(parametroFormato);

                MsgConfirm FrmConfirm = new MsgConfirm
                {
                    EsError = !(resMoneda > 0 && resFormato > 0)
                };

                if (FrmConfirm.EsError)
                    FrmConfirm.Mensaje = "La información no se registro correctamente, por favor intentelo de nuevo.";

                FrmConfirm.ShowDialog();

                SesionActiva.TipoMoneda = parametroMoneda.Valor;
                SesionActiva.FormatoMoneda = parametroFormato.Valor;

                Close();
            }
            catch (Exception ex)
            {                
                MsgExcepcion frmExcepcion = new MsgExcepcion(ex);
                frmExcepcion.ShowDialog();
            }
        }

        private void RbtPesos_CheckedChanged(object sender, EventArgs e)
        {
            txtDecimales.Text = "$ {0:#,##0}";
        }

        private void RbtDolares_CheckedChanged(object sender, EventArgs e)
        {
            txtDecimales.Text = "U$ {0:#,##0.00}";
        }

        private void RbtEuro_CheckedChanged(object sender, EventArgs e)
        {
            txtDecimales.Text = "{0:#,##0.00} €";
        }
    }
}
