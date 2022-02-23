using System;

namespace Caja.MVC.Core.Models
{
    public class VendedorModuloModel
	{
		public int IdVendedorModulo{ get; set; }

		public int IdProgramacionJuego{ get; set; }

		public int IdVendedor{ get; set; }

		public DateTime FechaHora{ get; set; }

		public int IdClienteModulo{ get; set; }

		public char Estado{ get; set; }
	}
}
