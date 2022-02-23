using Caja.Dominio;
using Caja.Escritorio.App;
using System;

namespace Caja.Escritorio.Formularios.General
{
    public partial class MsgClave : Base
    {
        public bool Valido { get; private set; }
        public MsgClave()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Valido = true;
            string mensaje = string.Empty;

            if (txtPass.Text.IsNullOrEmpty())
            {
                Valido = false;
                MostrarMensajeError("Debe ingregar una clave valida.");
                return;
            }

            DominioUsuario mDominioUsuario = new DominioUsuario();
            var ope = mDominioUsuario.Valid(SesionActiva.UsuarioActual.Login);

            if (ope == null)            
                mensaje = "El usuario es inválido o no existe. Ingrese un usuario válido.";            

            if (ope.ClaveAjustes != Seguridad.Encriptar(txtPass.Text))
                mensaje = "La contraseña es inválida. Ingrese una contraseña válida";

            if (ope.Estado != 'H')            
                mensaje = "El usuario esta deshabilitado, contacte al administrador del sistema.";

            if (mensaje.NotIsNullOrEmpty())
            {
                Valido = false;
                MostrarMensajeError(mensaje);
            }

            if (Valido)
                this.Close();
        }
    }
}
