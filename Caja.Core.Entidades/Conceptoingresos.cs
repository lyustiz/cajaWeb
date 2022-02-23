using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Conceptoingresos
    {
        public Conceptoingresos()
        {
            Ingresosgenerales = new HashSet<Ingresosgenerales>();
            Ingresosprogramacionjuegos = new HashSet<Ingresosprogramacionjuegos>();
        }

        public int IdConceptoIngreso { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public short? Socios { get; set; }

        public virtual ICollection<Ingresosgenerales> Ingresosgenerales { get; set; }
        public virtual ICollection<Ingresosprogramacionjuegos> Ingresosprogramacionjuegos { get; set; }
    }
}
