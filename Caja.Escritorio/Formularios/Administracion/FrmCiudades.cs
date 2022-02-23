using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.Formularios.General;
using System;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Administracion
{
    public partial class FrmCiudades : Base
    {
        readonly DominioPais mDominioPais;
        readonly DominioCiudad mDominioCiudad;
        public FrmCiudades()
        {
            InitializeComponent();
            mDominioPais = new DominioPais();
            mDominioCiudad = new DominioCiudad();
            InicializarControles();
        }

        private void InicializarControles()
        {
            /// Validar permisos para poner el valor correspondiente a la siguiente propiedad
            /// Grilla.AllowUserToAddRows = false;

            var listaPaises = mDominioPais.FetchAll();
            Base.CargaCombo(cmdPaises, listaPaises, "Descripcion", "IdPais", ComboBoxStyle.DropDownList);
        }

        private void CargarGrilla()
        {
            var listaCiudades = mDominioCiudad.FetchAllByPais(Base.ObtenerItemCombo<Pais>(cmdPaises).IdPais);

            Grilla.Rows.Clear();

            foreach (var ciudad in listaCiudades)
            {
                Grilla.Rows.Add(new object[] { ciudad.IdPais, ciudad.IdCiudad, ciudad.Descripcion });
            }
        }
             
        private void BtnGuardar_Click(object sender, EventArgs e)
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

                    var objCuidad = new Ciudad
                    {
                        Descripcion = (string)fila.Cells[2].Value,
                        IdPais = fila.Cells[0].Value == null ? Base.ObtenerItemCombo<Pais>(cmdPaises).IdPais : (int)fila.Cells[0].Value
                    };

                    if (objCuidad.Descripcion.IsNullOrEmpty())
                        continue;

                    if (fila.Cells[1].Value != null)
                        objCuidad.IdCiudad = (int)fila.Cells[1].Value;

                    mDominioCiudad.Save(objCuidad);
                }
            }

            if (cantidadCambios > 0)
            {
                MsgConfirm FrmConfirm = new MsgConfirm();
                FrmConfirm.ShowDialog();
                CargarGrilla();
            }
        }

        private void CmdPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void Grilla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int fila = Grilla.CurrentCell.RowIndex;
            int columna = Grilla.CurrentCell.ColumnIndex;

            Grilla.Rows[fila].Tag = 1;
            Base.ColocarColorGrilla(Grilla, columna, fila, 2);
        }
    }
}
