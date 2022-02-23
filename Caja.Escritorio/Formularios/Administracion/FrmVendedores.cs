using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using Caja.Escritorio.Formularios.General;
using Caja.Escritorio.Model;
using System;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Administracion
{
    public partial class FrmVendedores : Base
    {
        private DominioPais mDominioPais;
        private DominioCiudad mDominioCiudad;
        private DominioVendedor mDominioVendedor;
        private Vendedor objVendedor;
        private string numeroDocumentoAnterior;
        public FrmVendedores()
        {
            InitializeComponent();
            InstanciarObjetos();
            InicializarControles();            
        }

        private void InstanciarObjetos()
        {
            mDominioPais = new DominioPais();
            mDominioCiudad = new DominioCiudad();
            mDominioVendedor = new DominioVendedor(SesionActiva.UsuarioActual.IdUsuario);
            objVendedor = new Vendedor();
        }

        private void InicializarControles()
        {
            var listaPaises = mDominioPais.FetchAll();
            Base.CargaCombo(cmdPaises, listaPaises, "Descripcion", "IdPais", ComboBoxStyle.DropDownList);

            var listaEstadoCivil = ListasGenericas.GenerarListaEstadoCivil();
            Base.CargaCombo(cmdEstadoCivil, listaEstadoCivil, "Nombre", "Id", ComboBoxStyle.DropDownList);

            RestablecerFormulario();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            var listaVendedores = mDominioVendedor.FetchWhere(txtFiltro.Text.Trim());
            Grilla.Rows.Clear();

            foreach (var vendedor in listaVendedores)
            {
                Grilla.Rows.Add(new object[] { vendedor.IdVendedor, vendedor.Documento, vendedor.Nombres, vendedor.Apellidos, vendedor.Celular, vendedor.Telefono, vendedor.Estado == 'A' ? "Activo": "Inactivo" });

                if (vendedor.Estado != 'A')
                    Base.ColocarColorGrilla(Grilla, -1, Grilla.RowCount - 1, 2);
            }
        }

        private void LimpiarControles()
        {
            txtCodigo.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cmdPaises.SelectedIndex = 0;
            dtpNacimiento.Value = DateTime.Now;
            cmdEstadoCivil.SelectedIndex = 0;            
            txtCelular.Text = string.Empty;
            txtDocumento.Text = string.Empty;
        }

        private void SugerirCodigo()
        {
            txtCodigo.Text = Convert.ToString(mDominioVendedor.GetMaxId());
        }

        private void Nuevo()
        {
            LimpiarControles();
            grbDatosVendedor.Enabled = true;
            SugerirCodigo();
            guardarToolStripMenuItem.Enabled = true;
            referenciasToolStripMenuItem.Enabled = false;
            inactivarToolStripMenuItem.Enabled = false;
            objVendedor = new Vendedor();
            numeroDocumentoAnterior = objVendedor.Documento;
        }

        private void RestablecerFormulario()
        {
            LimpiarControles();                        
            grbDatosVendedor.Enabled = false;
            guardarToolStripMenuItem.Enabled = false;
            referenciasToolStripMenuItem.Enabled = false;
            inactivarToolStripMenuItem.Enabled = false;
            objVendedor = new Vendedor();
        }

        private void Editar()
        {
            LimpiarControles();
            grbDatosVendedor.Enabled = true;
            guardarToolStripMenuItem.Enabled = true;
            referenciasToolStripMenuItem.Enabled = true;
            inactivarToolStripMenuItem.Enabled = true;   
            
            if (objVendedor != null)
            {
                if (objVendedor.Estado == 'A')
                    inactivarToolStripMenuItem.Text = "Inactivar";
                else
                    inactivarToolStripMenuItem.Text = "Activar";
            }
        }

        private void CargarDatosVendedor()
        {
            var ciudad = mDominioCiudad.FetchOne(objVendedor.IdCiudad);

            txtCodigo.Text = objVendedor.Codigo;
            txtNombres.Text = objVendedor.Nombres;
            txtApellidos.Text = objVendedor.Apellidos;
            txtDireccion.Text = objVendedor.Direccion;
            txtTelefono.Text = objVendedor.Telefono;
            txtCelular.Text = objVendedor.Celular;
            cmdPaises.SelectedValue = ciudad.IdPais;
            cmdCiudades.SelectedValue = ciudad.IdCiudad;
            dtpNacimiento.Value = objVendedor.FechaNacimiento;
            cmdEstadoCivil.SelectedValue = objVendedor.IdEstadoCivil;
            txtDocumento.Text = objVendedor.Documento;            
        }

        private void CmdPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idPais = Base.ObtenerItemCombo<Pais>(cmdPaises).IdPais;
            var listaCiudades = mDominioCiudad.FetchAllByPais(idPais);
            Base.CargaCombo(cmdCiudades, listaCiudades, "Descripcion", "IdCiudad", ComboBoxStyle.DropDownList);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                objVendedor.Codigo = txtCodigo.Text.Trim();
                objVendedor.Nombres = txtNombres.Text.Trim();
                objVendedor.Apellidos = txtApellidos.Text.Trim();
                objVendedor.Direccion = txtDireccion.Text.Trim();
                objVendedor.Telefono = txtTelefono.Text.Trim();
                objVendedor.Celular = txtCelular.Text.Trim();
                objVendedor.IdCiudad = ObtenerItemCombo<Ciudad>(cmdCiudades).IdCiudad;
                objVendedor.FechaNacimiento = dtpNacimiento.Value;
                objVendedor.IdEstadoCivil = ObtenerItemCombo<ItemCombo>(cmdEstadoCivil).Id;
                objVendedor.Documento = txtDocumento.Text.Trim();
                objVendedor.IdUsuarioCreacion = SesionActiva.UsuarioActual.IdUsuario;

                var resultado = mDominioVendedor.Save(objVendedor);

                MsgConfirm frmConfirm = new MsgConfirm();

                if (resultado > 0)
                {
                    frmConfirm.Mensaje = "El vendedor(a) fue creado correctamente.";

                    if (objVendedor.IdVendedor > 0)
                        frmConfirm.Mensaje = "El vendedor(a) fue modificado correctamente.";

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

        private bool ValidarDatos()
        {
            MsgConfirm frmConfirm = new MsgConfirm();
            frmConfirm.EsError = false;

            if (ObtenerItemCombo<Ciudad>(cmdCiudades) == null)
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = "Debe seleccionar una ciudad.";
            }
            else if (txtCodigo.Text.IsNullOrEmpty())
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = "Debe ingresar un código.";
            }
            else if (txtNombres.Text.IsNullOrEmpty())
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = "Debe ingresar los nombres.";
            }
            else if (txtApellidos.Text.IsNullOrEmpty())
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = "Debe ingresar los apellidos.";
            }
            else if (txtDocumento.Text.IsNullOrEmpty())
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = "Debe ingresar el número de documento.";
            }

            // Dedo validar que el documento no exista.
            if (txtDocumento.Text.NotIsNullOrEmpty())
            {
                if (objVendedor.IdVendedor.IsOn(0))
                {
                    var existe = mDominioVendedor.ExisteDocumento(txtDocumento.Text.Trim());

                    if (existe)
                    {
                        frmConfirm.EsError = true;
                        frmConfirm.Mensaje = "Ya existe un vendedor con el mismo número de documento, por favor verifique la información.";
                    }
                }
                else if (objVendedor.IdVendedor > 0 && (txtDocumento.Text.Trim() != numeroDocumentoAnterior.Trim()))
                {
                    var existe = mDominioVendedor.ExisteDocumento(txtDocumento.Text.Trim());

                    if (existe)
                    {
                        frmConfirm.EsError = true;
                        frmConfirm.Mensaje = "Ya existe un vendedor con el mismo número de documento, por favor verifique la información.";
                    }
                }
            }

            if (frmConfirm.EsError)
            {
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();

                return false;
            }

            return true;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            int fila = Grilla.CurrentCell.RowIndex;            
            int idVendedor  = Convert.ToInt32(Grilla.Rows[fila].Cells[0].Value);

            objVendedor = mDominioVendedor.FetchOne(idVendedor);
            numeroDocumentoAnterior = objVendedor.Documento;

            Editar();            
            CargarDatosVendedor();
        }

        private void inactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string operacion;
            if (objVendedor.Estado == 'A')
            {
                objVendedor.Estado = 'I';
                operacion = "Inactivado";
            }
            else
            {
                objVendedor.Estado = 'A';
                operacion = "Activado";
            }

            mDominioVendedor.Deshabilitar(objVendedor.IdVendedor, Convert.ToString(objVendedor.Estado));

            MsgConfirm frmConfirm = new MsgConfirm
            {
                Mensaje = $"El vendedor(a) fue {operacion} correctamente."
            };

            frmConfirm.Configurar();
            frmConfirm.ShowDialog();

            CargarGrilla();
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

        private void referenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objVendedor != null)
                AbrirFormularioModal(new FrmVendedorReferencias(objVendedor));
        }
    }
}
