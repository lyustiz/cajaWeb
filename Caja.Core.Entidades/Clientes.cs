using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Clientes
    {
        public Clientes()
        {
            Clientesmodulos = new HashSet<ClienteModulo>();
        }

        public int IdCliente { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string NumeroDocumento  { get; set; }
        public string Celular { get; set; }
        public string Barrio { get; set; }
        public string Estado  { get; set; }
        public int IdVendedor { get; set; }

        public virtual ICollection<ClienteModulo> Clientesmodulos { get; set; }
    }
}
