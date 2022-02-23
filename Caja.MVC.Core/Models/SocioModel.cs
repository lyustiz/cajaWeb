using Caja.Core.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Caja.MVC.Core.Models
{
    public class SocioModel
    {
        public int Id { get; set; }

        [DisplayName("Código")]
        public string Codigo { get; set; }

        [DisplayName("Nombre Socio")]
        public string NombreSocio { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "El valor del {0} debe estar entre {1} y {2}.")]
        public double Porcentaje { get; set; }

        [DisplayName("Nivel de Acceso")]
        public string Permisos { get; set; }

        public List<SocioModel> ToModelList(IEnumerable<Usuarios> listado)
        {
            List<SocioModel> listaModelo = new();

            foreach (Usuarios socio in listado)
            {
                SocioModel modelo = new();

                modelo.Id = socio.IdUsuario;
                modelo.Codigo = socio.Login;
                modelo.NombreSocio = socio.NombreCompleto;
                modelo.Porcentaje = socio.Porcentaje;
                modelo.Permisos = "";

                listaModelo.Add(modelo);
            }

            return listaModelo;
        }
    }
}
