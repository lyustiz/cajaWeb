using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Listablas
    {
        public Listablas()
        {
            Programacionjuegos = new HashSet<Programacionjuegos>();
        }

        public int IdLisTablas { get; set; }
        public string Fabrica { get; set; }
        public string Simbolo { get; set; }
        public string Tabla { get; set; }
        public string Visible { get; set; }
        public string SqlConsulta { get; set; }
        public string Defecto { get; set; }

        public string Name {
            get {
                return $"{Simbolo} - {Fabrica}";
            }
        }

        public virtual ICollection<Programacionjuegos> Programacionjuegos { get; set; }
    }
}
