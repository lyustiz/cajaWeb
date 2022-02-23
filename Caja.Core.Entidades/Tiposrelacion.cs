using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Tiposrelacion
    {
        public Tiposrelacion()
        {
            Vendedoresreferencias = new HashSet<Vendedoresreferencias>();
        }

        public int IdTipoRelacion { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Vendedoresreferencias> Vendedoresreferencias { get; set; }
    }
}
