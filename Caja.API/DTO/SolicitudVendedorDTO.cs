using System;

namespace Caja.API.DTO
{
    public class SolicitudVendedorDTO
    {
		public int IdSolicitudVendedor { get; set; }
		public int IdVendedor { get; set; }
		public int IdJuego { get; set; }
		public string TipoSolicitud { get; set; }
		public int Cantidad { get; set; }
		public string Estado { get; set; }
		public DateTime FechaSolicitud { get; set; }
		public DateTime? FechaModificacion { get; set; }
	}
}
