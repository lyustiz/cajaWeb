using Caja.Dominio;
using Caja.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Administracion
{
    public partial class FrmGuardarUsuario : Base
    {
        private readonly int idUsuarioModificar = 0;
        private Usuario objUsuario;
        private DominioUsuario mDominioUsuario;
        private DominioPerfilPermiso mDominioPerfilPermiso;
        private List<Perfil> mListaPerfil;

        public FrmGuardarUsuario()
        {
            InitializeComponent();
            InstanciarObjetos();
            CargarPerfiles();
        }

        public FrmGuardarUsuario(int pId)
        {
            InitializeComponent();
            InstanciarObjetos();
            CargarPerfiles();

            this.idUsuarioModificar = pId;

            if (this.idUsuarioModificar > 0)
            {
                this.Text = $"Modificar Usuario Id {pId}";
                this.btnGuardar.Text = "Modificar";
                this.objUsuario = mDominioUsuario.FetchOne(idUsuarioModificar);

                this.txtNombreCompleto.Text = objUsuario.NombreCompleto;
                this.txtLogin.Text = objUsuario.Login;
                this.txtClave.Text = Seguridad.DesEncriptar(objUsuario.Clave);
                this.txtConfirmarClave.Text = Seguridad.DesEncriptar(objUsuario.Clave);
                this.txtClaveAjustes.Text = Seguridad.DesEncriptar(objUsuario.ClaveAjustes);

                // Marcar los perfiles del usuario.
                var perfilesUsuario = mDominioUsuario.FindPerfilesByUsuario(objUsuario.IdUsuario);

                foreach (var perfil in perfilesUsuario)
                {
                    var index = mListaPerfil.FindIndex(x => x.IdPerfil == perfil.IdPerfil);
                    chkPerfiles.SetItemCheckState(index, CheckState.Checked);
                }

                foreach (var perfil in mListaPerfil.Where(x => !x.IdPerfil.IsOn(perfilesUsuario.Select(y => y.IdPerfil).ToArray())))
                {
                    var index = mListaPerfil.FindIndex(x => x.IdPerfil == perfil.IdPerfil);
                    chkPerfiles.SetItemCheckState(index, CheckState.Unchecked);
                }
            }
        }

        private void InstanciarObjetos()
        {
            this.KeyPreview = true;
            objUsuario = new Usuario();
            mDominioUsuario = new DominioUsuario();
            mDominioPerfilPermiso = new DominioPerfilPermiso();
        }

        private void CargarPerfiles()
        {
            mListaPerfil = mDominioPerfilPermiso.FindPerfiles();
            Base.CargaCheckedListBox<Perfil>(chkPerfiles, mListaPerfil, "Nombre", "IdPerfil");
        }

        private void FrmGuardarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Vailidar datos
            var strMensajeValidacion = string.Empty;
            var listaPerfiles = new List<Perfil>();

            if (txtNombreCompleto.Text.IsNullOrEmpty())
                strMensajeValidacion += $"Debe ingresar el nombre completo del usuario. {Environment.NewLine}";

            if (txtLogin.Text.IsNullOrEmpty())
                strMensajeValidacion += $"Debe ingresar el login del usuario. {Environment.NewLine}";

            if (txtClave.Text.IsNullOrEmpty())
                strMensajeValidacion += $"Debe ingresar una clave para el usuario. {Environment.NewLine}";

            if (txtClave.Text.IsNullOrEmpty())
                strMensajeValidacion += $"Debe confirmar la clave usuario. {Environment.NewLine}";

            if (txtClave.Text.NotIsNullOrEmpty() && txtConfirmarClave.Text.NotIsNullOrEmpty())
            {
                if (txtClave.Text != txtConfirmarClave.Text)
                    strMensajeValidacion += $"Las claves no coinciden. {Environment.NewLine}";
            }

            foreach (var item in this.chkPerfiles.CheckedItems)
            {
                listaPerfiles.Add((Perfil)item);
            }

            if (listaPerfiles.IsNullOrZeroItems())
                strMensajeValidacion += $"Debe marcar por lo menos un perfil. {Environment.NewLine}";

            if (strMensajeValidacion.NotIsNullOrEmpty())
            {
                MessageBox.Show(strMensajeValidacion, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult mBoxResult = MessageBox.Show($"¿Está seguro de guardar el usuario?", "USUARIOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (mBoxResult)
                {
                    case DialogResult.Yes:

                        objUsuario.NombreCompleto = txtNombreCompleto.Text.Trim().ToUpper();
                        objUsuario.Login = txtLogin.Text.Replace(" ", "").Trim();
                        objUsuario.Clave = txtClave.Text.Replace(" ", "").Trim();
                        objUsuario.ClaveAjustes = txtClaveAjustes.Text.Replace(" ", "").Trim();

                        if (mDominioUsuario.GuardarConPerfiles(objUsuario, listaPerfiles) > 0)
                        {
                            MessageBox.Show("El usuario se guardó exitosamente.", "USUARIOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                            MessageBox.Show("El usuario no se guardó.", "USUARIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void BtnVerClave_Click(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = !txtClave.UseSystemPasswordChar;
            txtConfirmarClave.UseSystemPasswordChar = !txtConfirmarClave.UseSystemPasswordChar;
            txtClaveAjustes.UseSystemPasswordChar = !txtClaveAjustes.UseSystemPasswordChar;
        }
    }
}
