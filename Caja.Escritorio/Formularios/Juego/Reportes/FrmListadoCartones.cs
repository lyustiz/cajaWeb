using Caja.Dominio;
using Caja.Entidades;
using Caja.Escritorio.App;
using System.Windows.Forms;

namespace Caja.Escritorio.Formularios.Juego.Reportes
{
    public partial class FrmListadoCartones : Base
    {
        DominioVendedor mDominioVendedor;
        DominioHojasDevueltas mDominioHojasDevueltas;
        DominioVendedorHojas mDominioVendedorHojas;
        DominioVendedorModulo mDominioVendedorModulo;
        DominioVendedorResumen mDominioVendedorResumen;
        DominioProgramacionJuego mDominioProgramacion;
        ProgramacionJuego mProgramacionJuego;
        VendedorHoja mVendedorHoja;

        public FrmListadoCartones()
        {
            InitializeComponent();
            InstanciarObjetos();
            InicializaControles();
        }

        public void InstanciarObjetos()
        {
            mDominioVendedor = new DominioVendedor(SesionActiva.UsuarioActual.IdUsuario);
            mDominioHojasDevueltas = new DominioHojasDevueltas(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorHojas = new DominioVendedorHojas(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorModulo = new DominioVendedorModulo(SesionActiva.UsuarioActual.IdUsuario);
            mDominioVendedorResumen = new DominioVendedorResumen(SesionActiva.UsuarioActual.IdUsuario);
            mDominioProgramacion = new DominioProgramacionJuego(SesionActiva.UsuarioActual.IdUsuario);
        }

        public void InicializaControles()
        {
            var listaProgramaciones = mDominioProgramacion.BuscarProgramacion();
            CargaCombo(cmdProgramacion, listaProgramaciones, "IdProgramacionJuego", "IdProgramacionJuego", ComboBoxStyle.DropDownList);
        }

        private void cmdProgramacion_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            mProgramacionJuego = ObtenerItemCombo<ProgramacionJuego>(cmdProgramacion);
            var listaResultado = mDominioProgramacion.ConsultarListadoCartones(mProgramacionJuego.IdProgramacionJuego);
            Grilla.Rows.Clear();

            foreach (var registro in listaResultado)            
                Grilla.Rows.Add(new object[] { registro.NumeroHoja, $"{registro.Nombres} {registro.Apellidos}".Trim() });   
        }
    }
}
