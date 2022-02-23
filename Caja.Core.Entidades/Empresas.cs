using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Empresas
    {
        public Empresas()
        {
            Activacionesno = new HashSet<Activacionesno>();
            Juegos = new HashSet<Juegos>();
        }

        public short IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Prefijo { get; set; }

        public virtual ICollection<Activacionesno> Activacionesno { get; set; }
        public virtual ICollection<Juegos> Juegos { get; set; }
    }
}
