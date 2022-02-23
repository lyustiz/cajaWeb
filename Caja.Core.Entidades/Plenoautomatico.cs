using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Plenoautomatico
    {
        public Plenoautomatico()
        {
            Programacionjuegosfiguras = new HashSet<Programacionjuegosfiguras>();
        }

        public int IdPlenoAutomatico { get; set; }
        public string Nombre { get; set; }
        public short? F01 { get; set; }
        public short? F02 { get; set; }
        public short? F03 { get; set; }
        public short? F04 { get; set; }
        public short? F05 { get; set; }
        public short? F06 { get; set; }
        public short? F07 { get; set; }
        public short? F08 { get; set; }
        public short? F09 { get; set; }
        public short? F10 { get; set; }
        public short? F11 { get; set; }
        public short? F12 { get; set; }
        public short? F13 { get; set; }
        public short? F14 { get; set; }
        public short? F15 { get; set; }
        public short? F16 { get; set; }
        public short? F17 { get; set; }
        public short? F18 { get; set; }
        public short? F19 { get; set; }
        public short? F20 { get; set; }
        //public short? F21 { get; set; }
        //public short? F22 { get; set; }
        //public short? F23 { get; set; }
        //public short? F24 { get; set; }
        //public short? F25 { get; set; }
        public decimal? Record { get; set; }
        public short? Modaenable { get; set; }
        public double? Valor { get; set; }
        public short? Activo { get; set; }
        public int? Verificado { get; set; }
        public bool Preestablecida { get; set; }
        public int Predecesor { get; set; }
        public bool? EsSencillo { get; set; }

        public string Name {
            get { 
                if (EsSencillo.GetValueOrDefault() == true)
                {
                    return $"{Nombre} (FIGURA SENCILLA)";
                }

                return Nombre;
            }
        }

        public virtual ICollection<Programacionjuegosfiguras> Programacionjuegosfiguras { get; set; }
    }
}
