using System;

/// <summary>
/// Código autogenerado, no modificar.
/// </summary>

namespace Caja.Entidades
{
    public partial class Auditoria
    {
        public int IdAuditoria { get; set; }

        public DateTime FechaAuditoria { get; set; }

        public int IdUsuario { get; set; }

        public string Tabla { get; set; }

        public string Accion { get; set; }

        public string RegistroAnterior { get; set; }

        public string RegistroNuevo { get; set; }
    }
}
