using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
    public partial class PorcentajePremio
    {
        private int mIdPorcentajePremio;
        private int mPremio1Cartones;
        private int mPremio1Porcentaje;
        private int mPremio2Cartones;
        private int mPremio2Porcentaje;
        private int mPremio3Cartones;
        private int mPremio3Porcentaje;
        private int mPremio4Cartones;
        private int mPremio4Porcentaje;
        private int mPremio5Cartones;
        private int mPremio5Porcentaje;
        private int mIdUsuario;
        private char mEstado;
        private short mActivoDescuento;

        public PorcentajePremio()
        {
        }

        public int IdPorcentajePremio
        {
            get { return mIdPorcentajePremio; }
            set { mIdPorcentajePremio = value; }
        }

        public int Premio1Cartones { get => mPremio1Cartones; set => mPremio1Cartones = value; }
        public int Premio1Porcentaje { get => mPremio1Porcentaje; set => mPremio1Porcentaje = value; }
        public int Premio2Cartones { get => mPremio2Cartones; set => mPremio2Cartones = value; }
        public int Premio2Porcentaje { get => mPremio2Porcentaje; set => mPremio2Porcentaje = value; }
        public int Premio3Cartones { get => mPremio3Cartones; set => mPremio3Cartones = value; }
        public int Premio3Porcentaje { get => mPremio3Porcentaje; set => mPremio3Porcentaje = value; }
        public int Premio4Cartones { get => mPremio4Cartones; set => mPremio4Cartones = value; }
        public int Premio4Porcentaje { get => mPremio4Porcentaje; set => mPremio4Porcentaje = value; }
        public int Premio5Cartones { get => mPremio5Cartones; set => mPremio5Cartones = value; }
        public int Premio5Porcentaje { get => mPremio5Porcentaje; set => mPremio5Porcentaje = value; }
        public int IdUsuario { get => mIdUsuario; set => mIdUsuario = value; }
        public char Estado { get => mEstado; set => mEstado = value; }
        public short ActivoDescuento { get => mActivoDescuento; set => mActivoDescuento = value; }
    }
}
