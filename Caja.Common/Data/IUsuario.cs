using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public interface IUsuario
    {
        int IdUsuario { get; set; }

        string NombreCompleto { get; set; }

        string Login { get; set; }

        string Clave { get; set; }

        char Estado { get; set; }

        bool Autenticado { get; set; }

        DateTime FechaCreacion { get; set; }

        string JustificacionBloqueo { get; set; }

        DateTime? FechaBloqueo { get; set; }

        DateTime? FechaUltimoIngreso { get; set; }
        string ClaveAjustes { get; set; }
    }
}

