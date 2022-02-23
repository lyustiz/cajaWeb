using System;
using System.Drawing;

namespace Caja.Escritorio.Formularios.General
{
    public partial class MsgConfirm : Base
    {
        public bool EsError = false;
        public string Mensaje = string.Empty;
        public MsgConfirm()
        {
            InitializeComponent();
            lblMensaje.TextAlign = ContentAlignment.MiddleLeft;
        }

        public void Configurar()
        {
            if (Mensaje.NotIsNullOrEmpty())
                lblMensaje.Text = Mensaje;

            if (EsError)
            {
                BtnAceptar.BackColor = System.Drawing.Color.Goldenrod;

                if (Mensaje.IsNullOrEmpty())
                    lblMensaje.Text = "La operación no se completo correctamente, por favor intentelo de nuevo.";
            }
            else
                BtnAceptar.BackColor = System.Drawing.Color.SeaGreen;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
