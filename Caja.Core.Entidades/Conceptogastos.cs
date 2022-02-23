using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Conceptogastos
    {
        public Conceptogastos()
        {
            Gastosgenerales = new HashSet<Gastosgenerales>();
            Gastosprogramacionjuegos = new HashSet<Gastosprogramacionjuegos>();
        }

        public int IdConceptoGasto { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public double ValorMaximo { get; set; }
        public short? Controlado { get; set; }
        public short? Socios { get; set; }

        public virtual ICollection<Gastosgenerales> Gastosgenerales { get; set; }
        public virtual ICollection<Gastosprogramacionjuegos> Gastosprogramacionjuegos { get; set; }
    }
}
