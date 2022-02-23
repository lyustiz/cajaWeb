using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Perfilpermisos
    {
        public int IdPerfilPermisos { get; set; }
        public short? IdPerfil { get; set; }
        public int? IdMenu { get; set; }
        public bool? Lectura { get; set; }
        public bool? Escritura { get; set; }
        public bool? Eliminacion { get; set; }
        public bool? Habilitado { get; set; }

        public virtual Menus IdMenuNavigation { get; set; }
        public virtual Perfiles IdPerfilNavigation { get; set; }
    }
}
