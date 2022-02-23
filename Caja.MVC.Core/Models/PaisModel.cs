using Caja.Core.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Caja.MVC.Core.Models
{
    public class PaisModel
    {
        [DisplayName("Código")] 
        [ReadOnly(true)]
        public int IdPais { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        [MaxLength(30, ErrorMessage = "El nombre del pais no puede exceder de 30 caracteres.")]
        public string Nombre { get; set; }

        public PaisModel ToModel(Paises registro)
        {
            return new PaisModel() { IdPais = registro.IdPais, Nombre = registro.Descripcion };
        }

        public List<PaisModel> ToModelList(IEnumerable<Paises> listado)
        {
            List<PaisModel> modelo = new List<PaisModel>();

            listado.ToList().ForEach( x => modelo.Add(new PaisModel () { IdPais = x.IdPais, Nombre = x.Descripcion }));

            return modelo;
        }
    }
}
