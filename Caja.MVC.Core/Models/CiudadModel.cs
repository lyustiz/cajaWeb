using Caja.Core.Entidades;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Caja.MVC.Core.Models
{
    public class CiudadModel
    {
        [DisplayName("Código")]
        [ReadOnly(true)]
        public int IdCiudad { get; set; }

        [DisplayName("País")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public int IdPais { get; set; }

        [DisplayName("Nombre País")]        
        public string NombrePais { get; set; }

        [DisplayName("Ciudad")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        [MaxLength(30, ErrorMessage = "El nombre de la ciudad no puede exceder de 30 caracteres.")]
        public string Nombre { get; set; }

        public SelectList ListaPaises { get; set; }

        public CiudadModel ToModel(Ciudades registro)
        {
            return new CiudadModel() { IdCiudad = registro.IdCiudad, IdPais = registro.IdPais.Value, NombrePais = registro.IdPaisNavigation.Descripcion, Nombre = registro.Descripcion };
        }

        public List<CiudadModel> ToModelList(IEnumerable<Ciudades> listado)
        {
            List<CiudadModel> modelo = new List<CiudadModel>();

            listado.ToList().ForEach(x => modelo.Add(new CiudadModel() { IdCiudad = x.IdCiudad, IdPais = x.IdPais.Value, NombrePais = x.IdPaisNavigation.Descripcion, Nombre = x.Descripcion }));

            return modelo;
        }
    }
}
