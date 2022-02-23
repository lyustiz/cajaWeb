using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Perfiles
    {
        public Perfiles()
        {
            Perfilpermisos = new HashSet<Perfilpermisos>();
        }

        public short IdPerfil { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? EsVisible { get; set; }

        public virtual ICollection<Perfilpermisos> Perfilpermisos { get; set; }
    }
}
