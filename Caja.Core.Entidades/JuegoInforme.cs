using System;
using System.Collections.Generic;

namespace Caja.Core.Entidades
{
    public partial class JuegoInforme
    {
        public int IdJuego { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public TimeSpan? Duracion { get; set; }
        public short? IdEmpresa { get; set; }
        public string Terminado { get; set; }
        public int IdUsuario { get; set; }
        public int totalCartones { get; set; }
        public int cartonesAsignados { get; set; }
        public int cartonesVendidos { get; set; }
        public int totalModulos { get; set; }
        public int modulosAsignados { get; set; }
        public int modulosVendidos { get; set; }
        public int numeroVendedores { get; set; }

        public virtual ICollection<Programacionjuegos> Programacionjuegos { get; set; }
        public virtual Configuracion Configuracion { get; set; }
    }
}


