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
    public partial class FrmDefinicionModulos : Base
    {
        private DominioRoe mDominioRoe;
        private DominioModulo mDominioModulo;
        private Modulo objModulo;
        private List<Listabla> listaSeries;
        private string numeroAnterior;

        public FrmDefinicionModulos()
        {
            InitializeComponent();
            InstanciarObjetos();
            InicializarControles();
        }

        private void InstanciarObjetos()
        {
            mDominioRoe = new DominioRoe();
            mDominioModulo = new DominioModulo();
            objModulo = new Modulo();
        }

        private void InicializarControles()
        {
            LimpiarControles();
            RestablecerFormulario();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            var listaModulos = mDominioModulo.FetchWhere(txtFiltro.Text.Trim());
            Grilla.Rows.Clear();

            foreach (var vendedor in listaModulos)
            {
                Grilla.Rows.Add(new object[] {
                    vendedor.IdModulo, vendedor.Numero, vendedor.Carton1, vendedor.Serie1,
                    vendedor.Carton2, vendedor.Serie2, vendedor.Carton3, vendedor.Serie3,
                    vendedor.Carton4, vendedor.Serie4, vendedor.Carton5, vendedor.Serie5,
                    vendedor.Carton6, vendedor.Serie6});
            }
        }

        private void RestablecerFormulario()
        {
            LimpiarControles();
            objModulo = new Modulo();
        }

        private void LimpiarControles()
        {
            txtNumero.Text = string.Empty;
            txtCarton1.Text = string.Empty;
            txtCarton2.Text = string.Empty;
            txtCarton3.Text = string.Empty;
            txtCarton4.Text = string.Empty;
            txtCarton5.Text = string.Empty;
            txtCarton6.Text = string.Empty;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (DatosRequeridos())
            {
                var objSerieDefecto = mDominioRoe.FindAllSeries().FirstOrDefault(x => x.Defecto == "S");

                RecuperarValores(txtCarton1.Text.Trim(), objModulo, objSerieDefecto.Simbolo, 1);
                RecuperarValores(txtCarton2.Text.Trim(), objModulo, objSerieDefecto.Simbolo, 2);
                RecuperarValores(txtCarton3.Text.Trim(), objModulo, objSerieDefecto.Simbolo, 3);
                RecuperarValores(txtCarton4.Text.Trim(), objModulo, objSerieDefecto.Simbolo, 4);
                RecuperarValores(txtCarton5.Text.Trim(), objModulo, objSerieDefecto.Simbolo, 5);
                RecuperarValores(txtCarton6.Text.Trim(), objModulo, objSerieDefecto.Simbolo, 6);

                objModulo.Numero = (int)txtNumero.Value;

                if (CartonesValidos())
                {
                    if (ValidarSeries())
                    {
                        var resultado = mDominioModulo.Save(objModulo);
                        ValidarResultado(resultado);
                    }                    
                }
            }
        }

        private void ValidarResultado(int resultado)
        {
            MsgConfirm frmConfirm = new MsgConfirm();

            if (resultado > 0)
            {
                frmConfirm.Mensaje = "El módulo fue creado correctamente.";

                if (objModulo.IdModulo > 0)
                    frmConfirm.Mensaje = "El módulo fue modificado correctamente.";

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

        private bool DatosRequeridos()
        {
            MsgConfirm frmConfirm = new MsgConfirm();
            listaSeries = mDominioRoe.FindAllSeries();

            if (txtNumero.Value <= 0)
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = "El número del módulo es invalido.";
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();
                return false;
            }

            if (mDominioModulo.ExisteModulo((int)txtNumero.Value, objModulo.IdModulo))
            {
                frmConfirm.EsError = true;
                frmConfirm.Mensaje = $"No se puede crear un módulo con este el número {txtNumero.Text.Trim()}, por que ya existe uno.";
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();
                return false;
            }

            ValidarCajasTexto(frmConfirm);

            if (frmConfirm.EsError)
            {
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();
            }

            return !frmConfirm.EsError;
        }

        private void ValidarCajasTexto(MsgConfirm frmConfirm)
        {
            if (txtCarton1.Text.IsNullOrEmpty() || txtCarton2.Text.IsNullOrEmpty()
                            || txtCarton2.Text.IsNullOrEmpty() || txtCarton4.Text.IsNullOrEmpty()
                            || txtCarton5.Text.IsNullOrEmpty() || txtCarton6.Text.IsNullOrEmpty())
            {

                frmConfirm.EsError = true;
                frmConfirm.Mensaje = "Debe completar todos los cartones";
            }
            else if (txtCarton1.Text.IsNumeric() || txtCarton2.Text.IsNumeric()
                || txtCarton2.Text.IsNumeric() || txtCarton4.Text.IsNumeric()
                || txtCarton5.Text.IsNumeric() || txtCarton6.Text.IsNumeric())
            {
                if (listaSeries.Where(x => x.Defecto == "S").ToList().IsNullOrZeroItems())
                {
                    frmConfirm.EsError = true;
                    frmConfirm.Mensaje = "Debe configurar en el sistema una serie por defecto para completar la serie de los cartones en donde solo se especifico el número del cartón, o puede completar el campo con el número de la serie.";
                }
            }
        }

        private bool CartonesValidos()
        {
            MsgConfirm frmConfirm = new MsgConfirm
            {
                Mensaje = string.Empty
            };
            
            bool carton1Existe = mDominioModulo.ExisteCartonSerie(objModulo.Carton1, objModulo.Serie1, objModulo.IdModulo);
            bool carton2Existe = mDominioModulo.ExisteCartonSerie(objModulo.Carton2, objModulo.Serie2, objModulo.IdModulo);
            bool carton3Existe = mDominioModulo.ExisteCartonSerie(objModulo.Carton3, objModulo.Serie3, objModulo.IdModulo);
            bool carton4Existe = mDominioModulo.ExisteCartonSerie(objModulo.Carton4, objModulo.Serie4, objModulo.IdModulo);
            bool carton5Existe = mDominioModulo.ExisteCartonSerie(objModulo.Carton5, objModulo.Serie5, objModulo.IdModulo);
            bool carton6Existe = mDominioModulo.ExisteCartonSerie(objModulo.Carton6, objModulo.Serie6, objModulo.IdModulo);

            if (carton1Existe)
                frmConfirm.Mensaje = $"El cartón 1 {objModulo.Carton1}{objModulo.Serie1.ToUpper()} ya está configurado en otro modulo.";

            if (carton2Existe)
                frmConfirm.Mensaje += $", El cartón 2 {objModulo.Carton2}{objModulo.Serie2.ToUpper()} ya está configurado en otro modulo.";

            if (carton3Existe)
                frmConfirm.Mensaje += $", El cartón 3 {objModulo.Carton3}{objModulo.Serie3.ToUpper()} ya está configurado en otro modulo.";

            if (carton4Existe)
                frmConfirm.Mensaje += $", El cartón 4 {objModulo.Carton4}{objModulo.Serie4.ToUpper()} ya está configurado en otro modulo.";

            if (carton5Existe)
                frmConfirm.Mensaje += $", El cartón 5 {objModulo.Carton5}{objModulo.Serie5.ToUpper()} ya está configurado en otro modulo.";

            if (carton6Existe)
                frmConfirm.Mensaje += $", El cartón 6 {objModulo.Carton6}{objModulo.Serie6.ToUpper()} ya está configurado en otro modulo.";

            if (frmConfirm.Mensaje.NotIsNullOrEmpty())
            {
                frmConfirm.EsError = true;
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();
            }

            return !frmConfirm.EsError;
        }

        private bool ValidarSeries()
        {
            MsgConfirm frmConfirm = new MsgConfirm
            {
                Mensaje = string.Empty
            };

            if (!listaSeries.Exists(x => x.Simbolo == objModulo.Serie1))
                frmConfirm.Mensaje = $"La serie {objModulo.Serie1} del cartón 1 no existe.";

            if (!listaSeries.Exists(x => x.Simbolo == objModulo.Serie2))
                frmConfirm.Mensaje += $", La serie {objModulo.Serie2} del cartón 2 no existe.";

            if (!listaSeries.Exists(x => x.Simbolo == objModulo.Serie3))
                frmConfirm.Mensaje += $", La serie {objModulo.Serie3} del cartón 3 no existe.";

            if (!listaSeries.Exists(x => x.Simbolo == objModulo.Serie4))
                frmConfirm.Mensaje += $", La serie {objModulo.Serie4} del cartón 4 no existe.";

            if (!listaSeries.Exists(x => x.Simbolo == objModulo.Serie5))
                frmConfirm.Mensaje += $", La serie {objModulo.Serie5} del cartón 5 no existe.";

            if (!listaSeries.Exists(x => x.Simbolo == objModulo.Serie6))
                frmConfirm.Mensaje += $", La serie {objModulo.Serie6} del cartón 6 no existe.";


            if (frmConfirm.Mensaje.NotIsNullOrEmpty())
            {
                frmConfirm.EsError = true;
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();
            }

            return !frmConfirm.EsError;
        }


        private void RecuperarValores(string valor, Modulo modulo, string serieDefecto, byte indice)
        {
            string serie = serieDefecto;
            string strCarton = "";

            foreach (var caracter in valor)
            {
                if (caracter.IsNumeric())
                    strCarton = $"{strCarton}{caracter}";
                else
                    serie = caracter.ToString();
            }

            switch (indice)
            {
                case 1:
                    modulo.Carton1 = Convert.ToInt32(strCarton);
                    modulo.Serie1 = serie;
                    break;
                case 2:
                    modulo.Carton2 = Convert.ToInt32(strCarton);
                    modulo.Serie2 = serie;
                    break;
                case 3:
                    modulo.Carton3 = Convert.ToInt32(strCarton);
                    modulo.Serie3 = serie;
                    break;
                case 4:
                    modulo.Carton4 = Convert.ToInt32(strCarton);
                    modulo.Serie4 = serie;
                    break;
                case 5:
                    modulo.Carton5 = Convert.ToInt32(strCarton);
                    modulo.Serie5 = serie;
                    break;
                case 6:
                    modulo.Carton6 = Convert.ToInt32(strCarton);
                    modulo.Serie6 = serie;
                    break;
            }
        }

        private void Grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = Grilla.CurrentCell.RowIndex;
            int idModulo = Convert.ToInt32(Grilla.Rows[fila].Cells[0].Value);

            objModulo = mDominioModulo.FetchOne(idModulo);
            numeroAnterior = Convert.ToString(objModulo.Numero);

            LimpiarControles();
            CargarDatosModulo();
        }

        private void CargarDatosModulo()
        {
            txtNumero.Text = Convert.ToString(objModulo.Numero);
            txtCarton1.Text = $"{objModulo.Carton1}{objModulo.Serie1}";
            txtCarton2.Text = $"{objModulo.Carton2}{objModulo.Serie2}";
            txtCarton3.Text = $"{objModulo.Carton3}{objModulo.Serie3}";
            txtCarton4.Text = $"{objModulo.Carton4}{objModulo.Serie4}";
            txtCarton5.Text = $"{objModulo.Carton5}{objModulo.Serie5}";
            txtCarton6.Text = $"{objModulo.Carton6}{objModulo.Serie6}";
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestablecerFormulario();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
