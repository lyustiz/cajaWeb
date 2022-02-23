using Caja.Core.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Caja.MVC.Core.Models
{
    public class ModuloModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        [Range(1, 1000000, ErrorMessage = "El valor de {0} debe estar entre {1} y {2}.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]        
        public string Carton1 { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        
        public string Carton2 { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        
        public string Carton3 { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        
        public string Carton4 { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        
        public string Carton5 { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio.")]
        
        public string Carton6 { get; set; }

        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string Serie3 { get; set; }
        public string Serie4 { get; set; }
        public string Serie5 { get; set; }
        public string Serie6 { get; set; }

        public ModuloModel ToModel(Modulos registro)
        {
            return new ModuloModel() { 
                Id = registro.IdModulo,
                Numero = registro.Numero,
                Carton1 = registro.Carton1.ToString(),
                Serie1 = registro.Serie1,
                Carton2 = registro.Carton2.ToString(),
                Serie2 = registro.Serie2,
                Carton3 = registro.Carton3.ToString(),
                Serie3 = registro.Serie3,
                Carton4 = registro.Carton4.ToString(),
                Serie4 = registro.Serie4,
                Carton5 = registro.Carton5.ToString(),
                Serie5 = registro.Serie5,
                Carton6 = registro.Carton6.ToString(),
                Serie6 = registro.Serie6
            };
        }

        public List<ModuloModel> ToModelList(IEnumerable<Modulos> listado)
        {
            List<ModuloModel> modelo = new();
            listado.ToList().ForEach(x => modelo.Add(ToModel(x)));

            return modelo;
        }
    }
}
