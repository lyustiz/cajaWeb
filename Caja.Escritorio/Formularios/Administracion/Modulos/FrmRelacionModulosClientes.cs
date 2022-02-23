using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.Formularios.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Administracion.Modulos
{
    public partial class FrmRelacionModulosClientes : Base
    {
        private DominioCliente mDominioCliente;
        private DominioModulo mDominioModulo;
        private Cliente objCliente;
        private List<Modulo> listaModulos;

        public FrmRelacionModulosClientes()
        {
            InitializeComponent();
            InstanciarObjetos();
            InicializarControles();
        }

        private void InstanciarObjetos()
        {
            mDominioCliente = new DominioCliente();
            mDominioModulo = new DominioModulo();
            objCliente = new Cliente();
        }

        private void InicializarControles()
        {            
            CargarGrilla();
            listaModulos = mDominioModulo.FetchAll();
            dtpFechaInicio.MinDate = DateTime.Today;
            dtpFechaFin.MinDate = DateTime.Today;
            lblTotalModulos.Text = string.Empty;
        }

        private void CargarGrilla()
        {
            var listaClientes = mDominioCliente.FetchWhere(txtFiltro.Text.Trim());
            Grilla.Rows.Clear();

            foreach (var cliente in listaClientes)
                Grilla.Rows.Add(new object[] { cliente.IdCliente, cliente.Nombre, cliente.Celular, cliente.Barrio });            
        
            if (listaClientes.Count.IsOn(1))
            {
                objCliente = listaClientes.FirstOrDefault();
                CargarDatosCliente();
            }
        }

        private void CargarGrillaClientesModulos()
        {
            var listaClientesModulos = mDominioCliente.FindByCliente(objCliente.IdCliente);
            GrillaModulos.Rows.Clear();

            foreach (var cliente in listaClientesModulos)
                GrillaModulos.Rows.Add(new object[] { cliente.IdClienteModulo, cliente.NumeroModulo, cliente.FechaInicio, cliente.FechaFin });

            lblTotalModulos.Text = $"Total Módulos = {listaClientesModulos.Count}";
        }

        private void CargarDatosCliente()
        {
            txtNombre.Text = objCliente.Nombre;
            CargarGrillaClientesModulos();
        }

        private bool ValidarDatos()
        {
            MsgConfirm frmConfirm = new MsgConfirm();
            frmConfirm.EsError = false;

            var resultadoFechas = Base.ValidarRangoFechas(dtpFechaInicio, dtpFechaFin);

            if (objCliente.IdCliente <= 0)
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = "Debe seleccionar un cliente.";
            }
            else if (!mDominioModulo.ExisteModulo((int)txtNumeroModulo.Value)){
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = $"El modulo {txtNumeroModulo.Value} no existe.";
            }
            else if (mDominioCliente.ExisteModuloCliente(objCliente.IdCliente, (int)txtNumeroModulo.Value))
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = $"El módulo ya esta asignado al cliente.";
            }
            else if (mDominioCliente.ExisteModuloEnOtroCliente(objCliente.IdCliente, (int)txtNumeroModulo.Value))
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = $"El módulo ya esta asignado a otro cliente.";
            }
            else if (dtpFechaInicio.Value <= DateTime.MinValue)
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = $"Debe ingresar una fecha de inicio valida.";
            }
            else if (!resultadoFechas.Item1)
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = resultadoFechas.Item2;
            }

            if (frmConfirm.EsError)
            {
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();

                return false;
            }

            return true;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void Grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = Grilla.CurrentCell.RowIndex;
            int idCliente = Convert.ToInt32(Grilla.Rows[fila].Cells[0].Value);

            objCliente = mDominioCliente.FetchOne(idCliente);            
            CargarDatosCliente();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                MsgConfirm frmConfirm = new MsgConfirm();
                var modulo = mDominioModulo.Find((int)txtNumeroModulo.Value);

                if (modulo is null)
                {                   
                    frmConfirm.EsError = true;
                    frmConfirm.Mensaje = $"El módulo seleccionado no existe";
                    frmConfirm.Configurar();
                    frmConfirm.ShowDialog();

                    return;
                }

                ClienteModulo objclienteModulo = new ClienteModulo();
                objclienteModulo.IdCliente = objCliente.IdCliente;
                objclienteModulo.IdModulo = modulo.IdModulo;
                objclienteModulo.FechaInicio = dtpFechaInicio.Value.Date;
                objclienteModulo.FechaFin = dtpFechaFin.Value.Date;

                var resultado = mDominioCliente.AddClienteModulo(objclienteModulo);

                frmConfirm = new MsgConfirm();

                if (resultado > 0)
                {
                    frmConfirm.Mensaje = $"El módulo se asigno correctamente al cliente {objCliente.Nombre}";
                    frmConfirm.Configurar();
                    frmConfirm.ShowDialog();
                    CargarGrillaClientesModulos();
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

        private void BtnBuscarModulo_Click(object sender, EventArgs e)
        {
            // Consultar en ClietesModulos
            var listaClientesModulos = mDominioCliente.FindByNumero(Convert.ToInt32(txtModuloAsignado.Value));

            if (!listaClientesModulos.IsNullOrZeroItems())
            {
                txtFiltro.Text = listaClientesModulos.FirstOrDefault().NombreCliente;
                CargarGrilla();
            }
            else
            {
                MsgConfirm frmConfirm = new MsgConfirm();
                frmConfirm.Mensaje = "El módulo no existe.";
                frmConfirm.EsError = true;
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();
            }
            
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CargarGrilla();
        }

        private void txtModuloAsignado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnBuscarModulo.PerformClick();
        }

        private void GrillaModulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = GrillaModulos.Rows[e.RowIndex].Cells["IdClienteModulo"].FormattedValue.ToString();

                if (e.ColumnIndex == 4)
                {
                    DialogResult mBoxResult = MessageBox.Show($"¿Está seguro de remover el módulo?", "Relación Módulos Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (mBoxResult)
                    {
                        case DialogResult.Yes:
                            mDominioCliente.DeshabilitarClienteModulo("I", Convert.ToInt32(id));
                            break;
                        case DialogResult.No:
                            break;
                    }

                    CargarGrillaClientesModulos();
                }
            }
        }
    }
}
