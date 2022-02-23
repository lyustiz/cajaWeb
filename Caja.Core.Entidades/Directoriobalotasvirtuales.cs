using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Directoriobalotasvirtuales
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Principal { get; set; }
        public string Descripcion { get; set; }
    }
}
