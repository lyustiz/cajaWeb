using System;

namespace Caja.Escritorio.Formularios.General
{
    public partial class MsgExcepcion : Base
    {
        public MsgExcepcion(Exception exception)
        {
            InitializeComponent();

            lblError.Text = $"Error: {exception.Message}{Environment.NewLine}StackTrace: {exception.StackTrace}";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
