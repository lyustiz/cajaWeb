using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.Formularios.General;
using System.Windows.Forms;
using System;

namespace Caja.Escritorio.Formularios.Administracion
{
    public partial class FrmPaises : Base
    {
        readonly DominioPais mDominio;

        public FrmPaises()
        {
            InitializeComponent();
            mDominio = new DominioPais();
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
            var listaPaises = mDominio.FetchAll();
            Grilla.Rows.Clear();

            foreach (var pais in listaPaises)
            {
                Grilla.Rows.Add(new object[] { pais.IdPais, pais.Descripcion });
            }
        }

        private void Grilla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int fila = Grilla.CurrentCell.RowIndex;
            int columna = Grilla.CurrentCell.ColumnIndex;

            Grilla.Rows[fila].Tag = 1;
            Base.ColocarColorGrilla(Grilla, columna, fila, 2);   
        }

        private void BtnGuardar_Click(object sender, System.EventArgs e)
        {
            int cantidadCambios = 0;

            foreach (DataGridViewRow fila in Grilla.Rows)
            {
                if (fila.Tag == null)
                    continue;

                int.TryParse(fila.Tag.ToString(), out int numeroTag);

                if (numeroTag == 1)
                {
                    cantidadCambios++;

                    var objPais = new Pais
                    {
                        Descripcion = (string)fila.Cells[1].Value,
                    };

                    if (objPais.Descripcion.IsNullOrEmpty())
                        continue;

                    if (fila.Cells[0].Value != null)
                        objPais.IdPais = (int)fila.Cells[0].Value;

                    mDominio.Save(objPais);
                }
            }

            if (cantidadCambios > 0)
            {
                MsgConfirm FrmConfirm = new MsgConfirm();
                FrmConfirm.ShowDialog();
                CargarGrilla();
            }           
        }
    }
}
