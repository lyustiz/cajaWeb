using Caja.Dominio;
using Caja.Escritorio.App;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Administracion
{
    public partial class FrmUsuarios : Base
    {
        readonly DominioUsuario mDominio;
        bool blnAjustarCeldas = true;
        public FrmUsuarios()
        {
            InitializeComponent();
            mDominio = new DominioUsuario();
            InicializarControles();
        }

        private void InicializarControles()
        {
            /// Validar permisos para poner el valor correspondiente a la siguiente propiedad
            /// Grilla.AllowUserToAddRows = false;

            CargarGrilla();
        }

        private void CargarGrilla()
        {
            var listaUsuarios = mDominio.FetchAll();
            Grilla.Rows.Clear();

            foreach (var usuario in listaUsuarios)
            {
                var perfiles = mDominio.FindPerfilesByUsuario(usuario.IdUsuario);
                var textoPerfiles = "";

                if (perfiles.Any())
                    textoPerfiles = string.Join(",", perfiles.Select(i => i.Nombre));

                Grilla.Rows.Add(new object[] { usuario.IdUsuario, usuario.Login, usuario.NombreCompleto, usuario.Estado == 'H' ? "Activo" : "Inactivo", textoPerfiles });
            }
        }

        private void Grilla_Paint(object sender, PaintEventArgs e)
        {
            if (blnAjustarCeldas)
            {
                blnAjustarCeldas = false;
                Grilla.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
            }
        }

        private void Grilla_Scroll(object sender, ScrollEventArgs e)
        {
            Grilla.AutoResizeRows(DataGridViewAutoSizeRowsMode.DisplayedCells);
        }

        private void Grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = Grilla.Rows[e.RowIndex].Cells["IdUsuario"].FormattedValue.ToString();

                if (e.ColumnIndex == 5)
                {
                    AbrirFormularioModal(new FrmGuardarUsuario(Convert.ToInt32(id)));
                    SesionActiva.UsuarioActualPerfiles = new DominioUsuario().FindPerfilesByUsuario(SesionActiva.UsuarioActual.IdUsuario);
                    CargarGrilla();
                }

                if (e.ColumnIndex == 6)
                {
                    var estado = Grilla.Rows[e.RowIndex].Cells["Estado"].FormattedValue.ToString();

                    DialogResult mBoxResult = MessageBox.Show($"¿Está seguro de {(estado == "Activo" ? "deshabilitar" : "habilitar")} el usuario?", "USUARIOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (mBoxResult)
                    {
                        case DialogResult.Yes:
                            var charEstado = estado == "Activo" ? "D" : "H";
                            mDominio.Deshabilitar(Convert.ToInt32(id), charEstado);
                            break;
                        case DialogResult.No:
                            break;
                    }

                    CargarGrilla();
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AbrirFormularioModal(new FrmGuardarUsuario());
            SesionActiva.UsuarioActualPerfiles = new DominioUsuario().FindPerfilesByUsuario(SesionActiva.UsuarioActual.IdUsuario);
            CargarGrilla();
        }
    }
}
