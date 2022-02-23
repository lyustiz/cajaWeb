using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Programacionjuegos
    {
        public Programacionjuegos()
        {
            Flujocaja = new HashSet<Flujocaja>();
            Gastosprogramacionjuegos = new HashSet<Gastosprogramacionjuegos>();
            Ingresosprogramacionjuegos = new HashSet<Ingresosprogramacionjuegos>();
            Nominadescuentos = new HashSet<Nominadescuentos>();
            Programaciondevolucioncodigobarras = new HashSet<Programaciondevolucioncodigobarras>();
            Programacionjuegosdineros = new HashSet<Programacionjuegosdineros>();
            Programacionjuegosfiguras = new HashSet<Programacionjuegosfiguras>();
            Programacionjuegoshojasdevueltas = new HashSet<Programacionjuegoshojasdevueltas>();
            Recaudodetalles = new HashSet<Recaudodetalles>();
            Recaudofaltantes = new HashSet<Recaudofaltantes>();
            Recaudototales = new HashSet<Recaudototales>();
            Vendedorescobrocartones = new HashSet<Vendedorescobrocartones>();
            Vendedorescuentascobrar = new HashSet<Vendedorescuentascobrar>();
            Vendedoreshojas = new HashSet<Vendedoreshojas>();
            Vendedoresmodulos = new HashSet<Vendedoresmodulos>();
            Vendedorespagoanticipados = new HashSet<Vendedorespagoanticipados>();
            Vendedoresresumen = new HashSet<Vendedoresresumen>();
        }

        public int IdProgramacionJuego { get; set; }
        public int? IdJuego { get; set; }
        public DateTime FechaProgramada { get; set; }
        public DateTime? FechaCierre { get; set; }
        public double ValorCarton { get; set; }
        public double TotalCartones { get; set; }
        public double ValorModulo { get; set; }
        public double TotalModulos { get; set; }
        public double TotalPremios { get; set; }
        public int IdSerie { get; set; }
        public int CartonInicial { get; set; }
        public int CartonFinal { get; set; }
        public int HojaInicial { get; set; }
        public int HojaFinal { get; set; }
        public double ResultadoFinal { get; set; }
        public string Estado { get; set; }

        public virtual Juegos IdJuegoNavigation { get; set; }
        public virtual Listablas IdSerieNavigation { get; set; }
        public virtual ICollection<Flujocaja> Flujocaja { get; set; }
        public virtual ICollection<Gastosprogramacionjuegos> Gastosprogramacionjuegos { get; set; }
        public virtual ICollection<Ingresosprogramacionjuegos> Ingresosprogramacionjuegos { get; set; }
        public virtual ICollection<Nominadescuentos> Nominadescuentos { get; set; }
        public virtual ICollection<Programaciondevolucioncodigobarras> Programaciondevolucioncodigobarras { get; set; }
        public virtual ICollection<Programacionjuegosdineros> Programacionjuegosdineros { get; set; }
        public virtual ICollection<Programacionjuegosfiguras> Programacionjuegosfiguras { get; set; }
        public virtual ICollection<Programacionjuegoshojasdevueltas> Programacionjuegoshojasdevueltas { get; set; }
        public virtual ICollection<Recaudodetalles> Recaudodetalles { get; set; }
        public virtual ICollection<Recaudofaltantes> Recaudofaltantes { get; set; }
        public virtual ICollection<Recaudototales> Recaudototales { get; set; }
        public virtual ICollection<Vendedorescobrocartones> Vendedorescobrocartones { get; set; }
        public virtual ICollection<Vendedorescuentascobrar> Vendedorescuentascobrar { get; set; }
        public virtual ICollection<Vendedoreshojas> Vendedoreshojas { get; set; }
        public virtual ICollection<Vendedoresmodulos> Vendedoresmodulos { get; set; }
        public virtual ICollection<Vendedorespagoanticipados> Vendedorespagoanticipados { get; set; }
        public virtual ICollection<Vendedoresresumen> Vendedoresresumen { get; set; }
    }
}
