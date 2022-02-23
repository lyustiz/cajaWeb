using Caja.Dominio;
using System;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Administracion
{
    public partial class FrmConsultarAuditoria : Base
    {
        private DominioAuditoria mDominioAuditoria;
        public FrmConsultarAuditoria()
        {
            InitializeComponent();
            InstanciarObjetos();
            CargarGrilla();
        }

        private void InstanciarObjetos()
        {
            mDominioAuditoria = new DominioAuditoria();
        }

        private void CargarGrilla()
        {
            var listaRegistros = mDominioAuditoria.ConsultarAuditoria();
            Grilla.Rows.Clear();
            
            foreach (var item in listaRegistros)
                Grilla.Rows.Add(new object[] { item.IdAuditoria, item.FechaAuditoria, item.IdUsuario, item.Tabla, item.Accion, item.RegistroAnterior, item.RegistroNuevo });
                       
        }

        private void Grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = Grilla.Rows[e.RowIndex].Cells["IdAuditoria"].FormattedValue.ToString();

                if (e.ColumnIndex == 7)
                {
                    var registro = mDominioAuditoria.ObtenerAuditoria(Convert.ToInt32(id));
                    AbrirFormularioModal(new FrmDetalleAuditoria(registro));
                }
            }
        }
    }
}
