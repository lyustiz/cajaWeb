using Alex75.JsonViewer.WindowsForm;
using Caja.Entidades;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Administracion
{
    public partial class FrmDetalleAuditoria : Base
    {
        private readonly Auditoria mRegistro;
        public FrmDetalleAuditoria(Auditoria registro)
        {
            InitializeComponent();
            mRegistro = registro;

            LoadJson(jsonTreeViewAnterior, mRegistro.RegistroAnterior, $"({mRegistro.Tabla}) [Registro Anterior]");
            LoadJson(jsonTreeViewNuevo, mRegistro.RegistroNuevo, $"({mRegistro.Tabla}) [Registro Nuevo]");

            InicializarResumen();
        }

        private void InicializarResumen()
        {
            lblResumenAuditoria.Text = $"Tabla: {mRegistro.Tabla} - Usuario Operación: {mRegistro.IdUsuario}{Environment.NewLine}Acción: {mRegistro.Accion} - Fecha: {mRegistro.FechaAuditoria}";
        }

        private void LoadJson(JsonTreeView control, string json, string tabla)
        {
            try
            {
                control.ShowJson(json.IsNullOrEmpty() ? JsonConvert.SerializeObject(new RegistroVacio()) : json, tabla);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Fail to show JSON. " + exc);
            }
        }
    }

    public class RegistroVacio
    {
        public string Mensaje { get; set; }

        public RegistroVacio()
        {
            Mensaje = "No existe registro Anterior";
        }
    }
}
