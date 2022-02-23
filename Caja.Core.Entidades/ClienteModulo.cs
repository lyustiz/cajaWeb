using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class ClienteModulo
    {
        public ClienteModulo()
        {
            Vendedoresmodulos = new HashSet<Vendedoresmodulos>();
        }

        public int IdClienteModulo { get; set; }
        public int? IdCliente { get; set; }
        public int? IdModulo { get; set; }
        public string Estado { get; set; }
        public int? IdJuegoInicio{ get; set; }
        public int? IdJuegoFin{ get; set; }

        public virtual Clientes IdClienteNavigation { get; set; }
        public virtual Modulos IdModuloNavigation { get; set; }
        public virtual ICollection<Vendedoresmodulos> Vendedoresmodulos { get; set; }
    }
}
