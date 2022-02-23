using Caja.Dominio;
using Caja.Escritorio.Formularios.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Administracion
{
    public partial class FrmSocios : Base
    {
        readonly List<int> mPerfilesValidos;
        readonly DominioUsuario mDominio;

        public FrmSocios()
        {
            InitializeComponent();
            mDominio = new DominioUsuario();
            mPerfilesValidos = new List<int>
            {
                3, /// Admin
                8  /// Socio
            };
            
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
            var listaUsuarios = mDominio.FetchByPerfil(mPerfilesValidos.ToArray());
            Grilla.Rows.Clear();

            foreach (var usuario in listaUsuarios)
            {
                var perfiles = mDominio.FindPerfilesByUsuario(usuario.IdUsuario);
                var textoPerfiles = "";

                if (perfiles.Any())                
                    textoPerfiles = string.Join(",", perfiles.Select(i => i.Nombre));                

                Grilla.Rows.Add(new object[] { usuario.IdUsuario, usuario.Login, usuario.NombreCompleto, usuario.Porcentaje, textoPerfiles });
            }            
        }

        private void Grilla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int fila = Grilla.CurrentCell.RowIndex;
                int columna = Grilla.CurrentCell.ColumnIndex;

                if (!int.TryParse(Convert.ToString(Grilla.Rows[fila].Cells[columna].Value), out int valorMaximo))
                {
                    Grilla.Rows[fila].Cells[columna].Value = Grilla.Rows[fila].Cells[columna].Tag;

                    MsgConfirm frmConfirm = new MsgConfirm
                    {
                        EsError = true,
                        Mensaje = "El valor colocado debe ser numérico UNICAMENTE"
                    };
                    frmConfirm.Configurar();
                    frmConfirm.ShowDialog();
                }
                else
                {
                    if (valorMaximo > 100 || valorMaximo < 0)
                    {
                        Grilla.Rows[fila].Cells[columna].Value = Grilla.Rows[fila].Cells[columna].Tag;
                    }
                    else
                    {
                        if (CalcularTotalPorcentaje() > 100)
                        {
                            MsgConfirm frmConfirm = new MsgConfirm
                            {
                                EsError = true,
                                Mensaje = "La suma total de porcentaje no puede superar el 100% entre los socios."
                            };
                            frmConfirm.Configurar();
                            frmConfirm.ShowDialog();
                        }
                        else
                        {
                            if (Grilla.Rows[fila].Cells[columna].Tag != Grilla.Rows[fila].Cells[columna].Value)
                                Base.ColocarColorGrilla(Grilla, columna, fila, 2);
                            else
                                Grilla.Rows[fila].Cells[columna].Tag = null;
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void Grilla_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int fila = Grilla.CurrentCell.RowIndex;
            int columna = Grilla.CurrentCell.ColumnIndex;

            Grilla.Rows[fila].Cells[columna].Tag = Grilla.Rows[fila].Cells[columna].Value;
        }

        private int CalcularTotalPorcentaje()
        {
            int valor = 0;

            foreach (DataGridViewRow fila in Grilla.Rows)
            {
                if (fila.Cells[3].Value == null)
                    continue;

                valor += Convert.ToInt32(fila.Cells[3].Value);
            }

            return valor;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int cantidadCambios = 0;
            var totalPorcentaje = CalcularTotalPorcentaje();
            MsgConfirm frmConfirm = new MsgConfirm();

            if (totalPorcentaje > 100)
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = "La suma total de porcentaje no puede superar el 100% entre los socios.";                
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();

                return;
            }
            else if (totalPorcentaje < 100)
            {
                frmConfirm.EsError = false;
                frmConfirm.Mensaje = "No se ha asignado el 100%, pero esto no evita que se realice el proceso.";
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();
            }

            foreach (DataGridViewRow fila in Grilla.Rows)
            {
                if (fila.Cells[3].Tag != null)
                {
                    int.TryParse(Convert.ToString(fila.Cells[0].Value), out int idUsuario);
                    int.TryParse(Convert.ToString(fila.Cells[3].Value), out int valorPorcentaje);

                    var usuario = mDominio.FetchOne(idUsuario);
                    usuario.Porcentaje = valorPorcentaje;
                    mDominio.UpdatePorcentaje(usuario.IdUsuario, usuario.Porcentaje);

                    cantidadCambios++;
                }                
            }

            frmConfirm = new MsgConfirm();

            if (cantidadCambios > 0)
            {
                frmConfirm.ShowDialog();
                CargarGrilla();
            }
            else
            {
                frmConfirm.Mensaje = "No hay cambios para aplicar";
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();
            }
        }
    }
}
