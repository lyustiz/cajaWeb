using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Vendedores
    {
        public Vendedores()
        {
            Programaciondevolucioncodigobarras = new HashSet<Programaciondevolucioncodigobarras>();
            Recaudofaltantes = new HashSet<Recaudofaltantes>();
            Vendedorescobrocartones = new HashSet<Vendedorescobrocartones>();
            Vendedorescuentascobrar = new HashSet<Vendedorescuentascobrar>();
            Vendedoreshojas = new HashSet<Vendedoreshojas>();
            Vendedoresmodulos = new HashSet<Vendedoresmodulos>();
            Vendedorespagoanticipados = new HashSet<Vendedorespagoanticipados>();
            Vendedoresresumen = new HashSet<Vendedoresresumen>();
        }

        public int IdVendedor { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public int IdCiudad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdEstadoCivil { get; set; }
        public string Documento { get; set; }
        public string Estado { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Ciudades IdCiudadNavigation { get; set; }
        public virtual Usuarios IdUsuarioCreacionNavigation { get; set; }
        public virtual ICollection<Programaciondevolucioncodigobarras> Programaciondevolucioncodigobarras { get; set; }
        public virtual ICollection<Recaudofaltantes> Recaudofaltantes { get; set; }
        public virtual ICollection<Vendedorescobrocartones> Vendedorescobrocartones { get; set; }
        public virtual ICollection<Vendedorescuentascobrar> Vendedorescuentascobrar { get; set; }
        public virtual ICollection<Vendedoreshojas> Vendedoreshojas { get; set; }
        public virtual ICollection<Vendedoresmodulos> Vendedoresmodulos { get; set; }
        public virtual ICollection<Vendedorespagoanticipados> Vendedorespagoanticipados { get; set; }
        public virtual ICollection<Vendedoresresumen> Vendedoresresumen { get; set; }
    }
}
