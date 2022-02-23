using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Menus
    {
        public Menus()
        {
            Perfilpermisos = new HashSet<Perfilpermisos>();
        }

        public int IdMenu { get; set; }
        public string NombreMenu { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Perfilpermisos> Perfilpermisos { get; set; }
    }
}
