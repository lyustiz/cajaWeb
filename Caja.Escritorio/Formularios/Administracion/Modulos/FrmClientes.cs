using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.Formularios.General;
using System;
using System.Windows.Forms;
using System.Linq;

namespace Caja.Escritorio.Formularios.Administracion.Modulos
{
    public partial class FrmClientes : Base
    {
        private DominioCliente mDominioCliente;
        private Cliente objCliente;

        public FrmClientes()
        {
            InitializeComponent();
            InstanciarObjetos();
            InicializarControles();
        }

        private void InstanciarObjetos()
        {
            mDominioCliente = new DominioCliente();
            objCliente = new Cliente();
        }

        private void InicializarControles()
        {
            RestablecerFormulario();
            CargarGrilla();
        }

        private void RestablecerFormulario()
        {
            LimpiarControles();
            objCliente = new Cliente();
        }

        private void LimpiarControles()
        {
            txtNombre.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtBarrio.Text = string.Empty;
        }

        private void Nuevo()
        {
            LimpiarControles();
            objCliente = new Cliente();
        }

        private void Editar()
        {
            LimpiarControles();
        }

        private void CargarGrilla()
        {
            var listaClientes = mDominioCliente.FetchWhere(txtFiltro.Text.Trim());
            Grilla.Rows.Clear();

            foreach (var cliente in listaClientes)
                Grilla.Rows.Add(new object[] { cliente.IdCliente, cliente.Nombre, cliente.Celular, cliente.Barrio });

            lblTotalClientes.Text = $"Total Clientes: {listaClientes.Count}";
        }

        private void CargarDatosCliente()
        {
            txtNombre.Text = objCliente.Nombre;
            txtCelular.Text = objCliente.Celular;
            txtBarrio.Text = objCliente.Barrio;
        }

        private bool ValidarDatos()
        {
            MsgConfirm frmConfirm = new MsgConfirm();
            frmConfirm.EsError = false;

            if (txtNombre.Text.IsNullOrEmpty())
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = "Debe ingresar el nombre.";
            }
            else if (txtCelular.Text.IsNullOrEmpty())
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = "Debe ingresar el celular.";
            }
            else if (txtBarrio.Text.IsNullOrEmpty())
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = "Debe ingresar el barrio.";
            }
           
            if (frmConfirm.EsError)
            {
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();

                return false;
            }

            return true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                objCliente.Nombre = txtNombre.Text.Trim();
                objCliente.Celular = txtCelular.Text.Trim();
                objCliente.Barrio = txtBarrio.Text.Trim();
                
                var resultado = mDominioCliente.Save(objCliente);

                MsgConfirm frmConfirm = new MsgConfirm();

                if (resultado > 0)
                {
                    frmConfirm.Mensaje = "El cliente fue creado correctamente.";

                    if (objCliente.IdCliente > 0)
                        frmConfirm.Mensaje = "El cliente fue modificado correctamente.";

                    frmConfirm.Configurar();
                    frmConfirm.ShowDialog();
                    CargarGrilla();
                    RestablecerFormulario();
                }
                else
                {
                    frmConfirm.Mensaje = "La informacion no se registro correctamente, por intentelo de nuevo.";
                    frmConfirm.EsError = true;
                    frmConfirm.Configurar();
                    frmConfirm.ShowDialog();
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo();
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

        private void Grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = Grilla.CurrentCell.RowIndex;
            int idCliente = Convert.ToInt32(Grilla.Rows[fila].Cells[0].Value);

            objCliente = mDominioCliente.FetchOne(idCliente);
            Editar();
            CargarDatosCliente();
        }
    }
}
