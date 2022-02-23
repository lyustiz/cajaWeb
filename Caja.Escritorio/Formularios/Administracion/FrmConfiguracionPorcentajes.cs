using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using Caja.Escritorio.Formularios.General;
using System;

namespace Caja.Escritorio.Formularios.Administracion
{
    public partial class FrmConfiguracionPorcentajes : Base
    {
        readonly DominioPorcentajePremio mDominio;

        public FrmConfiguracionPorcentajes()
        {
            InitializeComponent();
            mDominio = new DominioPorcentajePremio();
            InicializarControles();
        }

        private void InicializarControles()
        {
            /// Validar permisos para poner el valor correspondiente a la siguiente propiedad            
            var datos = mDominio.FetchOne();

            if (datos != null)
            {
                chkActivo.Checked = datos.ActivoDescuento > 0;
                txCartones1.Text = datos.Premio1Cartones.ToString();
                txCartones2.Text = datos.Premio2Cartones.ToString();
                txCartones3.Text = datos.Premio3Cartones.ToString();
                txCartones4.Text = datos.Premio4Cartones.ToString();
                txCartones5.Text = datos.Premio5Cartones.ToString();
                txPorcentaje1.Text = datos.Premio1Porcentaje.ToString();
                txPorcentaje2.Text = datos.Premio2Porcentaje.ToString();
                txPorcentaje3.Text = datos.Premio3Porcentaje.ToString();
                txPorcentaje4.Text = datos.Premio4Porcentaje.ToString();
                txPorcentaje5.Text = datos.Premio5Porcentaje.ToString();
            }            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var informacion = new PorcentajePremio
            {
                Premio1Cartones = Convert.ToInt32(txCartones1.Text),
                Premio2Cartones = Convert.ToInt32(txCartones2.Text),
                Premio3Cartones = Convert.ToInt32(txCartones3.Text),
                Premio4Cartones = Convert.ToInt32(txCartones4.Text),
                Premio5Cartones = Convert.ToInt32(txCartones5.Text),
                Premio1Porcentaje = Convert.ToInt32(txPorcentaje1.Text),
                Premio2Porcentaje = Convert.ToInt32(txPorcentaje2.Text),
                Premio3Porcentaje = Convert.ToInt32(txPorcentaje3.Text),
                Premio4Porcentaje = Convert.ToInt32(txPorcentaje4.Text),
                Premio5Porcentaje = Convert.ToInt32(txPorcentaje5.Text),
                IdUsuario = SesionActiva.UsuarioActual.IdUsuario,
                ActivoDescuento = (short)(chkActivo.Checked ? 1 : 0)
            };

            if (ValidarDatos(informacion))
            {
                var res = mDominio.Save(informacion);
                MsgConfirm frmConfirm = new MsgConfirm
                {
                    EsError = res < 0
                };
                frmConfirm.Configurar();
                frmConfirm.ShowDialog();
            }                            
        }

        private bool ValidarDatos(PorcentajePremio data)
        {
            /// Aplicar validaciones de cantidades.
            /// Si la validación falla mostrar desde aqui mensaje al usuario.
            /// 
            var mensaje = string.Empty;
            var valido = true;

            if (data.Premio1Cartones >= data.Premio2Cartones)
            {
                valido = false;
                mensaje = "La cantidad de cartones para el premio 1, debe ser menor que la cantidad de cartones para el premio 2";
            }
            else if (data.Premio2Cartones >= data.Premio3Cartones)
            {
                valido = false;
                mensaje = "La cantidad de cartones para el premio 2, debe ser menor que la cantidad de cartones para el premio 3";
            }
            else if (data.Premio3Cartones >= data.Premio4Cartones)
            {
                valido = false;
                mensaje = "La cantidad de cartones para el premio 3, debe ser menor que la cantidad de cartones para el premio 4";
            }
            else if (data.Premio4Cartones >= data.Premio5Cartones)
            {
                valido = false;
                mensaje = "La cantidad de cartones para el premio 4, debe ser menor que la cantidad de cartones para el premio 5";
            }

            if (!valido)
            {
                MsgConfirm frmConfirm = new MsgConfirm
                {
                    EsError = valido,
                    Mensaje = mensaje
                };

                frmConfirm.Configurar();
                frmConfirm.ShowDialog();
            }

            return valido;           
        }
    }
}
