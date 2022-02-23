using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
    public partial class ConceptoGasto
    {
        private int mIdConceptoGasto;

        private string mDescripcion;

        private decimal mValor;

        private decimal mValorMaximo;

        private short mControlado;

        private short mSocios;
        
        public ConceptoGasto()
        {
        }

        public int IdConceptoGasto
        {
            get { return mIdConceptoGasto; }
            set { mIdConceptoGasto = value; }
        }

        public string Descripcion
        {
            get { return mDescripcion; }
            set { mDescripcion = value; }
        }

        public decimal Valor
        {
            get { return mValor; }
            set { mValor = value; }
        }

        public decimal ValorMaximo
        {
            get { return mValorMaximo; }
            set { mValorMaximo = value; }
        }

        public short Controlado
        {
            get { return mControlado; }
            set { mControlado = value; }
        }

        public short Socios
        {
            get { return mSocios; }
            set { mSocios = value; }
        }
    }
}
