using System;

namespace Caja.Entidades.Vistas
{
    public class VistaVendedorCobroCartones : VendedorCobroCarton
    {
		private string mNombres;

		private string mApellidos;

		private int mIdVendedorCobroCarton;

		private int mIdProgramacionJuego;

		private int mIdVendedor;

		private int mTotalCartones;

		private int mCartonesDevueltos;

		private int mNumeroHojasEntregadas;

		private double mPorcentajeComision;

		private double mTotalVentas;

		private int mCartonesCortesia;

		private double mValorComision;

		private double mAbonos;

		private double mTotalPagado;

		private double mFaltante;

		private double mTotalRecibido;

		private double mGastoCortesia;

		private double mTotalModulos;

		private char mEstado;

		private DateTime mFechaHora;

		private int mIdUsuario;

		public VistaVendedorCobroCartones()
		{
		}

		public string Nombres
		{
			get { return mNombres; }
			set { mNombres = value; }
		}

		public string Apellidos
		{
			get { return mApellidos; }
			set { mApellidos = value; }
		}

		public int IdVendedorCobroCarton
		{
			get { return mIdVendedorCobroCarton; }
			set { mIdVendedorCobroCarton = value; }
		}

		public int IdProgramacionJuego
		{
			get { return mIdProgramacionJuego; }
			set { mIdProgramacionJuego = value; }
		}

		public int IdVendedor
		{
			get { return mIdVendedor; }
			set { mIdVendedor = value; }
		}

		public int TotalCartones
		{
			get { return mTotalCartones; }
			set { mTotalCartones = value; }
		}

		public int CartonesDevueltos
		{
			get { return mCartonesDevueltos; }
			set { mCartonesDevueltos = value; }
		}

		public int NumeroHojasEntregadas
		{
			get { return mNumeroHojasEntregadas; }
			set { mNumeroHojasEntregadas = value; }
		}

		public double PorcentajeComision
		{
			get { return mPorcentajeComision; }
			set { mPorcentajeComision = value; }
		}

		public double TotalVentas
		{
			get { return mTotalVentas; }
			set { mTotalVentas = value; }
		}

		public int CartonesCortesia
		{
			get { return mCartonesCortesia; }
			set { mCartonesCortesia = value; }
		}

		public double ValorComision
		{
			get { return mValorComision; }
			set { mValorComision = value; }
		}

		public double Abonos
		{
			get { return mAbonos; }
			set { mAbonos = value; }
		}

		public double TotalPagado
		{
			get { return mTotalPagado; }
			set { mTotalPagado = value; }
		}

		public double Faltante
		{
			get { return mFaltante; }
			set { mFaltante = value; }
		}

		public double TotalRecibido
		{
			get { return mTotalRecibido; }
			set { mTotalRecibido = value; }
		}

		public double GastoCortesia
		{
			get { return mGastoCortesia; }
			set { mGastoCortesia = value; }
		}

		public double TotalModulos
		{
			get { return mTotalModulos; }
			set { mTotalModulos = value; }
		}

		public char Estado
		{
			get { return mEstado; }
			set { mEstado = value; }
		}

		public DateTime FechaHora
		{
			get { return mFechaHora; }
			set { mFechaHora = value; }
		}

		public int IdUsuario
		{
			get { return mIdUsuario; }
			set { mIdUsuario = value; }
		}		
    }
}
