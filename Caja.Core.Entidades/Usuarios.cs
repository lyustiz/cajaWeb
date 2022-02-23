using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Gastosgenerales = new HashSet<Gastosgenerales>();
            Gastosprogramacionjuegos = new HashSet<Gastosprogramacionjuegos>();
            Historicoflujocaja = new HashSet<Historicoflujocaja>();
            Ingresosgenerales = new HashSet<Ingresosgenerales>();
            Ingresosprogramacionjuegos = new HashSet<Ingresosprogramacionjuegos>();
            Nominadescuentos = new HashSet<Nominadescuentos>();
            Porcentajepremios = new HashSet<Porcentajepremios>();
            Recaudodetalles = new HashSet<Recaudodetalles>();
            Recaudofaltantes = new HashSet<Recaudofaltantes>();
            Recaudototales = new HashSet<Recaudototales>();
            Vendedores = new HashSet<Vendedores>();
            Vendedorespagoanticipados = new HashSet<Vendedorespagoanticipados>();
            Vendedoresreferencias = new HashSet<Vendedoresreferencias>();
        }

        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string Login { get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; }
        public bool Autenticado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string JustificacionBloqueo { get; set; }
        public DateTime? FechaBloqueo { get; set; }
        public DateTime? FechaUltimoIngreso { get; set; }
        public string ClaveAjustes { get; set; }
        public bool? EsSocio { get; set; }
        public bool? ModificaPremios { get; set; }
        public double Porcentaje { get; set; }

        public virtual ICollection<Gastosgenerales> Gastosgenerales { get; set; }
        public virtual ICollection<Gastosprogramacionjuegos> Gastosprogramacionjuegos { get; set; }
        public virtual ICollection<Historicoflujocaja> Historicoflujocaja { get; set; }
        public virtual ICollection<Ingresosgenerales> Ingresosgenerales { get; set; }
        public virtual ICollection<Ingresosprogramacionjuegos> Ingresosprogramacionjuegos { get; set; }
        public virtual ICollection<Nominadescuentos> Nominadescuentos { get; set; }
        public virtual ICollection<Porcentajepremios> Porcentajepremios { get; set; }
        public virtual ICollection<Recaudodetalles> Recaudodetalles { get; set; }
        public virtual ICollection<Recaudofaltantes> Recaudofaltantes { get; set; }
        public virtual ICollection<Recaudototales> Recaudototales { get; set; }
        public virtual ICollection<Vendedores> Vendedores { get; set; }
        public virtual ICollection<Vendedorespagoanticipados> Vendedorespagoanticipados { get; set; }
        public virtual ICollection<Vendedoresreferencias> Vendedoresreferencias { get; set; }
    }
}
