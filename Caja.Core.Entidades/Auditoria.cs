using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Auditoria
    {
        public int IdAuditoria { get; set; }
        public int IdUsuario { get; set; }
        public string Tabla { get; set; }
        public string Accion { get; set; }
        public string RegistroAnterior { get; set; }
        public string RegistroNuevo { get; set; }
    }
}
