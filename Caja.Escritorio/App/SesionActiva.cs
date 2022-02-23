using Caja.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Escritorio.App
{
    public class SesionActiva
    {
        public static IUsuario UsuarioActual { get; set; }

        public static List<Perfil> UsuarioActualPerfiles { get; set; }

        public static string TipoMoneda { get; set; }

        public static string FormatoMoneda { get; set; }

        public static string TextoTipoMoneda
        {
            get
            {
                if (TipoMoneda == "$")
                    return "PESOS";
                else if (TipoMoneda == "U$")
                    return "DOLARES";
                else if (TipoMoneda == "€")
                    return "EUROS";

                return "PESOS";
            }
        }

        public static bool EsSocio 
        { 
            get
            {
                return UsuarioActualPerfiles.Exists(x => x.Nombre.ContainsIgnoreCase("SOCIO"));
            }
        }
    }
}
