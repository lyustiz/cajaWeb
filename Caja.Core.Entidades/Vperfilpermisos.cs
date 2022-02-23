using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Vperfilpermisos
    {
        public int IdPerfilPermisos { get; set; }
        public short? IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public int? IdMenu { get; set; }
        public string NombreMenu { get; set; }
        public string Descripcion { get; set; }
        public bool? Lectura { get; set; }
        public bool? Escritura { get; set; }
        public bool? Eliminacion { get; set; }
        public bool? Habilitado { get; set; }
    }
}
