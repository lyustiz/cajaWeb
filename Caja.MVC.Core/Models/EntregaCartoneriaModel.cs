using Caja.Core.Entidades;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Caja.MVC.Core.Models
{
    public class EntregaCartoneriaModel
    {
        [DisplayName("Número Juego")]
        public int IdProgramacionJuego { get; set; }

        [DisplayName("Criterio de Búsqueda")]
        public string FiltroBusqueda { get; set; }

        public int NumeroCartonesHoja { get; set; }

        public List<Vprogramacionjuegovendedores> Detalle { get; set; }

        public SelectList ListaProgramaciones { get; set; }
    }

    public class EntregaHojasModel
    {
        public int IdVendedor { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int TotalCartones { get; set; }
        public int CartonesCortesia { get; set; }        

        public List<int> Hojas { get; set; }
    }
}
