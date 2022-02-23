using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Ciudades
    {
        public Ciudades()
        {
            Vendedores = new HashSet<Vendedores>();
            Vendedoresreferencias = new HashSet<Vendedoresreferencias>();
        }

        public int IdCiudad { get; set; }
        public int? IdPais { get; set; }
        public string Descripcion { get; set; }

        public virtual Paises IdPaisNavigation { get; set; }
        public virtual ICollection<Vendedores> Vendedores { get; set; }
        public virtual ICollection<Vendedoresreferencias> Vendedoresreferencias { get; set; }
    }
}
