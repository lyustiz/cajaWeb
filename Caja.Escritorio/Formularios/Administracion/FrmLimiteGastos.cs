using Caja.Dominio;
using Caja.Escritorio.App;
using System.Windows.Forms;
using System.Linq;
using Caja.Escritorio.Formularios.General;
using Caja.Entidades;
using System;

namespace Caja.Escritorio.Formularios.Administracion
{
    public partial class FrmLimiteGastos : Base
    {
        readonly DominioConceptoGasto mDominio;
        public FrmLimiteGastos()
        {
            InitializeComponent();
            mDominio = new DominioConceptoGasto();
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
            var listaConceptos = mDominio.FetchAll();
            Grilla.Rows.Clear();

            foreach (var item in listaConceptos)
                Grilla.Rows.Add(new object[] { item.IdConceptoGasto, item.Descripcion, item.ValorMaximo, (item.Controlado == 1 ? "SI" : "NO") });

            CalcularTotal(listaConceptos.Sum(x => x.ValorMaximo));
        }

        private void CalcularTotal(decimal valor)
        {
            txtTotal.Text = string.Format(SesionActiva.FormatoMoneda, valor);
            txtTotal.TextAlign = HorizontalAlignment.Right;
        }

        private void CalcularTotal()
        {
            double valor = 0;

            foreach (DataGridViewRow fila in Grilla.Rows)
            {
                if (fila.Cells[2].Value == null)
                    continue;

                valor += System.Convert.ToDouble(fila.Cells[2].Value);
            }

            txtTotal.Text = string.Format(SesionActiva.FormatoMoneda, valor);
            txtTotal.TextAlign = HorizontalAlignment.Right;
        }

        private void Grilla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = Grilla.CurrentCell.RowIndex;
            int columna = Grilla.CurrentCell.ColumnIndex;

            string condicionadoSi = "SI";
            string condicionadoNo = "NO";

            if (columna == 3)
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

        private void Grilla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int fila = Grilla.CurrentCell.RowIndex;
                int columna = Grilla.CurrentCell.ColumnIndex;

                if (!double.TryParse(Convert.ToString(Grilla.Rows[fila].Cells[columna].Value), out double valorMaximo))
                {
                    Grilla.Rows[fila].Cells[columna].Value = Grilla.Rows[fila].Cells[columna].Tag;

                    MsgConfirm frmConfirm = new MsgConfirm();
                    frmConfirm.EsError = true;
                    frmConfirm.Mensaje = "El valor colocado debe ser numérico UNICAMENTE";
                    frmConfirm.Configurar();
                    frmConfirm.ShowDialog();
                }
                else
                {
                    if (Grilla.Rows[fila].Cells[columna].Tag != Grilla.Rows[fila].Cells[columna].Value)
                    {
                        Base.ColocarColorGrilla(Grilla, columna, fila, 2);
                        CalcularTotal();
                    }
                    else
                        Grilla.Rows[fila].Cells[columna].Tag = null;
                }
            }
            catch
            {
            }
        }

        private void BtnGuardar_Click(object sender, System.EventArgs e)
        {
            int cantidadCambios = 0;

            foreach (DataGridViewRow fila in Grilla.Rows)
            {
                /// Valor Máximo
                if (fila.Cells[2].Tag != null)
                {
                    var concepto = mDominio.FetchOne((int)fila.Cells[0].Value);
                    concepto.ValorMaximo = Convert.ToDecimal(fila.Cells[2].Value);

                    var auditoria = new AuditoriaHistoria
                    {
                        Acccion = 12,
                        ValorAnterior = Convert.ToString(fila.Cells[2].Tag),
                        ValorNuevo = Convert.ToString(fila.Cells[2].Value),
                        IdUsuario = SesionActiva.UsuarioActual.IdUsuario
                    };

                    mDominio.Save(concepto, auditoria);
                    cantidadCambios++;
                }

                /// Controlado
                if (fila.Cells[3].Tag != null)
                {
                    var concepto = mDominio.FetchOne((int)fila.Cells[0].Value);
                    var controlado = (string)fila.Cells[3].Value;
                    concepto.Controlado = (short)(controlado == "SI" ? 1 : 0);

                    var auditoria = new AuditoriaHistoria
                    {
                        Acccion = 12,
                        ValorAnterior = Convert.ToString(fila.Cells[3].Tag),
                        ValorNuevo = Convert.ToString(fila.Cells[3].Value),
                        IdUsuario = SesionActiva.UsuarioActual.IdUsuario
                    };

                    mDominio.Save(concepto, auditoria);
                    cantidadCambios++;
                }
            }

            MsgConfirm FrmConfirm = new MsgConfirm();

            if (cantidadCambios > 0)
            {                
                FrmConfirm.ShowDialog();
                CargarGrilla();
            }
            else
            {
                FrmConfirm.Mensaje = "No hay cambios para aplicar";
                FrmConfirm.Configurar();
                FrmConfirm.ShowDialog();
            }
        }
    }
}
