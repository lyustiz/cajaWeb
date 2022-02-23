using System;
/// <summary>
/// Agregar el codigo aqui (este archivo no se regenera)
/// </summary>

namespace Caja.Entidades
{
    public partial class GastoProgramacionJuego : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
