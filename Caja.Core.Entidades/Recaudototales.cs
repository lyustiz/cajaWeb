using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Recaudototales
    {
        public int IdRecaudoTotal { get; set; }
        public int IdProgramacionJuego { get; set; }
        public int IdUsuario { get; set; }
        public double RecuadoTotal { get; set; }
        public string Estado { get; set; }
        public double ValorRecaudoCalculado { get; set; }
        public double Diferencia { get; set; }
        public int IncluirGastosGenerales { get; set; }
        public double Gastos { get; set; }
        public double Ingresos { get; set; }
        public int RegistroGastos { get; set; }
        public int RegistroIngresos { get; set; }

        public virtual Programacionjuegos IdProgramacionJuegoNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
