using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Modulos
    {
        public Modulos()
        {
            Clientesmodulos = new HashSet<ClienteModulo>();
        }

        public int IdModulo { get; set; }
        public int Numero { get; set; }
        public int Carton1 { get; set; }
        public string Serie1 { get; set; }
        public int Carton2 { get; set; }
        public string Serie2 { get; set; }
        public int Carton3 { get; set; }
        public string Serie3 { get; set; }
        public int Carton4 { get; set; }
        public string Serie4 { get; set; }
        public int Carton5 { get; set; }
        public string Serie5 { get; set; }
        public int Carton6 { get; set; }
        public string Serie6 { get; set; }

        public virtual ICollection<ClienteModulo> Clientesmodulos { get; set; }
    }
}
