using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using Caja.Escritorio.Formularios.General;
using System;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Administracion
{
    public partial class FrmPermisos : Base
    {
        readonly DominioPerfilPermiso mDominioPerfilPermiso;
        public FrmPermisos()
        {
            InitializeComponent();
            mDominioPerfilPermiso = new DominioPerfilPermiso();           
            InicializarControles();
        }

        private void InicializarControles()
        {
            /// Validar permisos para poner el valor correspondiente a la siguiente propiedad
            /// Grilla.AllowUserToAddRows = false;

            var listaPerfiles = mDominioPerfilPermiso.FindPerfiles(SesionActiva.UsuarioActual.IdUsuario);
            Base.CargaCombo(cmdPerfil, listaPerfiles, "Nombre", "IdPerfil", ComboBoxStyle.DropDownList);
        }

        private void CargarGrilla()
        {
            var listaPermisos = mDominioPerfilPermiso.FetchByPerfil(Base.ObtenerItemCombo<Perfil>(cmdPerfil).IdPerfil);

            Grilla.Rows.Clear();

            foreach (var permiso in listaPermisos)
            {
                Grilla.Rows.Add(new object[] { permiso.IdPerfilPermisos, permiso.Descripcion, (permiso.Habilitado ? "SI": "NO")});
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int cantidadCambios = 0;

            foreach (DataGridViewRow fila in Grilla.Rows)
            {
                if (fila.Cells[2].Tag != null)
                {
                    var objPerfilPermiso = new PerfilPermiso
                    {
                        IdPerfilPermisos = (int)fila.Cells[0].Value
                    };

                    var habilitado = (string)fila.Cells[2].Value;
                    objPerfilPermiso.Habilitado = (bool)(habilitado == "SI" ? true : false);

                    mDominioPerfilPermiso.Save(objPerfilPermiso);

                    cantidadCambios++;
                }
            }

            if (cantidadCambios > 0)
            {
                MsgConfirm frmConfirm = new MsgConfirm();
                frmConfirm.ShowDialog();
                CargarGrilla();
            }
        }       

        private void cmdPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void Grilla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = Grilla.CurrentCell.RowIndex;
            int columna = Grilla.CurrentCell.ColumnIndex;

            string condicionadoSi = "SI";
            string condicionadoNo = "NO";

            if (columna == 2)
            {
                if ((string)Grilla.Rows[fila].Cells[columna].Value == condicionadoSi)
                {
                    Grilla.Rows[fila].Cells[columna].Value = condicionadoNo;
                    Grilla.Rows[fila].Cells[columna].Tag = condicionadoSi;
                }
                else
                {
                    Grilla.Rows[fila].Cells[columna].Value = condicionadoSi;
                    Grilla.Rows[fila].Cells[columna].Tag = condicionadoNo;
                }

                Base.ColocarColorGrilla(Grilla, columna, fila, 2);
            }
        }

        private void Grilla_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int fila = Grilla.CurrentCell.RowIndex;
            int columna = Grilla.CurrentCell.ColumnIndex;

            Grilla.Rows[fila].Cells[columna].Tag = Grilla.Rows[fila].Cells[columna].Value;
        }
    }
}
