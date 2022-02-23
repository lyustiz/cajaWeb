﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Caja.Core.Entidades
{
    public partial class Paises
    {
        public Paises()
        {
            Ciudades = new HashSet<Ciudades>();
        }

        public int IdPais { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Ciudades> Ciudades { get; set; }
    }
}
