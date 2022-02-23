using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Definicionmonedas
    {
        public Definicionmonedas()
        {
            Recaudodetalles = new HashSet<Recaudodetalles>();
        }

        public int IdDefinicionMoneda { get; set; }
        public string Moneda { get; set; }
        public string Tipo { get; set; }
        public double Nominal { get; set; }
        public double Equivalencia { get; set; }
        public int GrupoSuma { get; set; }

        public virtual ICollection<Recaudodetalles> Recaudodetalles { get; set; }
    }
}
