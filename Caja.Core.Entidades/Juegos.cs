using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Juegos
    {
        public Juegos()
        {
            Programacionjuegos = new HashSet<Programacionjuegos>();
            Cartones = new HashSet<Cartones>();
            Rondas = new HashSet<Rondas>();
        }

        public int IdJuego { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public TimeSpan? Duracion { get; set; }
        public short? IdEmpresa { get; set; }
        public string Terminado { get; set; }
        public int IdUsuario { get; set; }

        public virtual Empresas IdEmpresaNavigation { get; set; }
        public virtual ICollection<Programacionjuegos> Programacionjuegos { get; set; }
        public ICollection<Cartones> Cartones { get; }
        public virtual Configuracion Configuracion  { get; set; }
        public virtual ICollection<Rondas> Rondas { get; set; }
    }
}
