using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
	public partial class FlujoCaja
	{
		public int IdFlujoCaja { get; set; }
		public int IdProgramacionJuego { get; set; }
		public double ValorInicial { get; set; }
		public double ValorFinal { get; set; }
		public double ValorInicialBancos { get; set; }
		public double ValorFinalBancos { get; set; }
		public double ValorInicialSocial { get; set; }
		public double ValorFinalSocial { get; set; }
		public string Estado { get; set; }
	}
}