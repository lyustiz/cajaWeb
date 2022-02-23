using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using Caja.Escritorio.Formularios.General;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Caja.Escritorio.Formularios.Administracion
{
    public partial class FrmVendedorReferencias : Base
    {
        private DominioPais mDominioPais;
        private DominioCiudad mDominioCiudad;
        private DominioVendedorReferencia mDominioVendedorReferencia;        
        private DominioRoe mDominioRoe;
        private Vendedor objVendedor;
        private VendedorReferencia objReferencia;
        private List<TipoRelacion> listaRelaciones;
        public FrmVendedorReferencias(Vendedor pVendedor)
        {
            InitializeComponent();
            objVendedor = pVendedor;
            InstanciarObjetos();
            InicializarControles();
        }

        private void InstanciarObjetos()
        {
            mDominioPais = new DominioPais();
            mDominioCiudad = new DominioCiudad();
            mDominioVendedorReferencia = new DominioVendedorReferencia();
            mDominioRoe = new DominioRoe();
            objReferencia = new VendedorReferencia();
        }

        private void InicializarControles()
        {
            lblNombreVendedor.Text = $"{objVendedor.Apellidos} {objVendedor.Nombres}".ToUpperInvariant().Trim();

            listaRelaciones = mDominioRoe.FetchAllTiposRelacion();
            CargaCombo(cmdTipoRelacion, listaRelaciones, "Descripcion", "IdTipoRelacion", ComboBoxStyle.DropDownList);

            var listaPaises = mDominioPais.FetchAll();
            CargaCombo(cmdPaises, listaPaises, "Descripcion", "IdPais", ComboBoxStyle.DropDownList);

            RestablecerFormulario();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            var listaReferencias = mDominioVendedorReferencia.Fetch(objVendedor.IdVendedor);
            Grilla.Rows.Clear();

            foreach (var referencia in listaReferencias)
            {
                var relacion = string.Empty;

                if (!listaRelaciones.IsNullOrZeroItems())
                    relacion = listaRelaciones.FirstOrDefault(x => x.IdTipoRelacion == referencia.IdTipoRelacion)?.Descripcion;

                Grilla.Rows.Add(new object[] { referencia.IdVendedorReferencia, referencia.Documento, referencia.Nombres, referencia.Apellidos, referencia.Celular, referencia.Telefono, relacion });                                
            }
        }

        private void LimpiarControles()
        {
            cmdTipoRelacion.SelectedIndex = 0;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;            
            cmdPaises.SelectedIndex = 0;
            txtCelular.Text = string.Empty;
            txtDocumento.Text = string.Empty;
        }

        private void Nuevo()
        {
            LimpiarControles();
            grbDatosReferencia.Enabled = true;            
            guardarToolStripMenuItem.Enabled = true;            
            objReferencia = new VendedorReferencia();
        }

        private void RestablecerFormulario()
        {
            LimpiarControles();
            grbDatosReferencia.Enabled = false;
            guardarToolStripMenuItem.Enabled = false;
            objReferencia = new VendedorReferencia();
        }

        private void Editar()
        {
            LimpiarControles();
            grbDatosReferencia.Enabled = true;
            guardarToolStripMenuItem.Enabled = true;          
        }

        private void CargarDatosReferecia()
        {
            var ciudad = mDominioCiudad.FetchOne(objReferencia.IdCiudad);

            cmdTipoRelacion.SelectedValue = objReferencia.IdTipoRelacion;
            txtNombres.Text = objReferencia.Nombres;
            txtApellidos.Text = objReferencia.Apellidos;
            txtDireccion.Text = objReferencia.Direccion;
            txtTelefono.Text = objReferencia.Telefono;
            txtCelular.Text = objReferencia.Celular;
            cmdPaises.SelectedValue = ciudad.IdPais;
            cmdCiudades.SelectedValue = ciudad.IdCiudad;
            txtDocumento.Text = objVendedor.Documento;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                objReferencia.IdTipoRelacion = Base.ObtenerItemCombo<TipoRelacion>(cmdTipoRelacion).IdTipoRelacion;
                objReferencia.IdVendedor = objVendedor.IdVendedor;
                objReferencia.Nombres = txtNombres.Text.Trim();
                objReferencia.Apellidos = txtApellidos.Text.Trim();
                objReferencia.Direccion = txtDireccion.Text.Trim();
                objReferencia.Telefono = txtTelefono.Text.Trim();
                objReferencia.Celular = txtCelular.Text.Trim();
                objReferencia.IdCiudad = Base.ObtenerItemCombo<Ciudad>(cmdCiudades).IdCiudad;
                objReferencia.Documento = txtDocumento.Text.Trim();
                objReferencia.IdUsuarioCreacion = SesionActiva.UsuarioActual.IdUsuario;

                var resultado = mDominioVendedorReferencia.Save(objReferencia);

                MsgConfirm frmConfirm = new MsgConfirm();

                if (resultado > 0)
                {
                    frmConfirm.Mensaje = "La referencia fue creada correctamente.";

                    if (objReferencia.IdVendedorReferencia > 0)
                        frmConfirm.Mensaje = "La referencia fue modificada correctamente.";

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
            int idReferencia = Convert.ToInt32(Grilla.Rows[fila].Cells[0].Value);

            objReferencia = mDominioVendedorReferencia.FetchOne(idReferencia);

            Editar();
            CargarDatosReferecia();
        }

        private void cmdPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idPais = Base.ObtenerItemCombo<Pais>(cmdPaises).IdPais;
            var listaCiudades = mDominioCiudad.FetchAllByPais(idPais);
            CargaCombo(cmdCiudades, listaCiudades, "Descripcion", "IdCiudad", ComboBoxStyle.DropDownList);
        }
    }
}
