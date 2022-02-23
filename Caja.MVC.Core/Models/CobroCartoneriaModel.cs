
using Caja.Core.Entidades;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Caja.MVC.Core.Models
{
	public class CobroCartoneriaModel
	{
		[DisplayName("Número Juego")]
		public int IdProgramacionJuego { get; set; }

		[DisplayName("Criterio de Búsqueda")]
		public string FiltroBusqueda { get; set; }

		public int NumeroCartonesHoja { get; set; }

		public List<Vprogramacionjuegovendedores> Detalle { get; set; }

		public SelectList ListaProgramaciones { get; set; }
	}
	public class CobroHojasModel
    {
		public int IdVendedorCobroCarton{ get; set; }

		public int IdProgramacionJuego{ get; set; }

		public int IdVendedor{ get; set; }

		public int TotalCartones{ get; set; }

		public int CartonesDevueltos{ get; set; }

		public int NumeroHojasEntregadas{ get; set; }

		public double PorcentajeComision{ get; set; }

		public double TotalVentas{ get; set; }

		public int CartonesCortesia{ get; set; }

		public double ValorComision{ get; set; }

		public double Abonos{ get; set; }

		public double TotalPagado{ get; set; }

		public double Faltante{ get; set; }

		public double TotalRecibido{ get; set; }

		public double GastoCortesia{ get; set; }

		public double TotalModulos{ get; set; }

		public char Estado{ get; set; }

		public DateTime FechaHora{ get; set; }

		public int IdUsuario{ get; set; }
	}
}
