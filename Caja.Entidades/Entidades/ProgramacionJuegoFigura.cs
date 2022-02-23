
using System;
/// <summary>
/// Agregar el codigo aqui (este archivo no se regenera)
/// </summary>
namespace Caja.Entidades
{
    public partial class ProgramacionJuegoFigura : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class FiguraProgramacion
    {
        public string Nombre { get; set; }

        public double ValorPremio { get; set; }
    }
}

