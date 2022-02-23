namespace Caja.Entidades.Vistas
{
    public class VistaPerfilPermisos
    {
		public int IdPerfilPermisos { get; set; }
				
		public int IdPerfil { get; set; }

		public string NombrePerfil { get; set; }

		public int IdMenu { get; set; }

		public string NombreMenu { get; set; }

		public string Descripcion { get; set; }

		public bool Lectura { get; set; }

		public bool Escritura { get; set; }

		public bool Eliminacion { get; set; }

		public bool Habilitado { get; set; }
	}
}
