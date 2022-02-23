using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Vendedoresreferencias
    {
        public int IdVendedorReferencia { get; set; }
        public int? IdVendedor { get; set; }
        public int? IdTipoRelacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public int IdCiudad { get; set; }
        public string Documento { get; set; }
        public int IdUsuarioCreacion { get; set; }

        public virtual Ciudades IdCiudadNavigation { get; set; }
        public virtual Tiposrelacion IdTipoRelacionNavigation { get; set; }
        public virtual Usuarios IdUsuarioCreacionNavigation { get; set; }
    }
}
