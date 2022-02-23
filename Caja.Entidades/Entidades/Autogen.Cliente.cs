using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
    public partial class Cliente
    {
        private int mIdCliente;

        private string mNombre;

        private string mCelular;

        private string mBarrio;

        public Cliente()
        {
        }

        public int IdCliente
        {
            get { return mIdCliente; }
            set { mIdCliente = value; }
        }

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public string Celular
        {
            get { return mCelular; }
            set { mCelular = value; }
        }

        public string Barrio
        {
            get { return mBarrio; }
            set { mBarrio = value; }
        }
    }
}
