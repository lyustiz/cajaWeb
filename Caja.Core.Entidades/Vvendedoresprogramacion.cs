using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Vvendedoresprogramacion
    {
        public int IdVendedor { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public string Celular { get; set; }
        public int IdProgramacionJuego { get; set; }
        public byte Cobrado { get; set; }
        public string NombreCompleto { get; set; }
    }
}
