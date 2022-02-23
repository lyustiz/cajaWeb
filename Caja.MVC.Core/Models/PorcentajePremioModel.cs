using Caja.Core.Entidades;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Caja.MVC.Core.Models
{
    public class PorcentajePremioModel
    {
        public int IdPorcentajePremio { get; set; }

        [DisplayName("Cartón")]
        [Range(1, 2000, ErrorMessage = "El valor de {0} debe estar entre {1} y {2}.")]
        public int Premio1Cartones { get; set; }
        
        [DisplayName("Porcentaje")]
        [Range(1, 100, ErrorMessage = "El valor de {0} debe estar entre {1} y {2}.")]
        public int Premio1Porcentaje { get; set; }

        [DisplayName("Cartón")]
        [Range(1, 2000, ErrorMessage = "El valor de {0} debe estar entre {1} y {2}.")]
        public int Premio2Cartones { get; set; }

        [DisplayName("Porcentaje")]
        [Range(1, 100, ErrorMessage = "El valor de {0} debe estar entre {1} y {2}.")]
        public int Premio2Porcentaje { get; set; }

        [DisplayName("Cartón")]
        [Range(1, 2000, ErrorMessage = "El valor de {0} debe estar entre {1} y {2}.")]
        public int Premio3Cartones { get; set; }

        [DisplayName("Porcentaje")]
        [Range(1, 100, ErrorMessage = "El valor de {0} debe estar entre {1} y {2}.")]
        public int Premio3Porcentaje { get; set; }

        [DisplayName("Cartón")]
        [Range(1, 2000, ErrorMessage = "El valor de {0} debe estar entre {1} y {2}.")]
        public int Premio4Cartones { get; set; }

        [DisplayName("Porcentaje")]
        [Range(1, 100, ErrorMessage = "El valor de {0} debe estar entre {1} y {2}.")]
        public int Premio4Porcentaje { get; set; }

        [DisplayName("Cartón")]
        [Range(1, 2000, ErrorMessage = "El valor de {0} debe estar entre {1} y {2}.")]
        public int Premio5Cartones { get; set; }

        [DisplayName("Porcentaje")]
        [Range(1, 100, ErrorMessage = "El valor de {0} debe estar entre {1} y {2}.")]
        public int Premio5Porcentaje { get; set; }

        [Required]
        public int IdUsuario { get; set; }       

        [DisplayName("Activo los descuentos por porcentaje")]
        public bool ActivoDescuento { get; set; }

        public PorcentajePremioModel ToModel(Porcentajepremios registro)
        {
            if (registro is null)
                return new PorcentajePremioModel();

            return new PorcentajePremioModel() {
                ActivoDescuento = registro.ActivoDescuento.Value != 0,
                Premio1Porcentaje = registro.Premio1Porcentaje.Value,
                Premio1Cartones = registro.Premio1Cartones.Value,
                Premio2Porcentaje = registro.Premio2Porcentaje.Value,
                Premio2Cartones = registro.Premio2Cartones.Value,
                Premio3Porcentaje = registro.Premio3Porcentaje.Value,
                Premio3Cartones = registro.Premio3Cartones.Value,
                Premio4Porcentaje = registro.Premio4Porcentaje.Value,
                Premio4Cartones = registro.Premio4Cartones.Value,
                Premio5Porcentaje = registro.Premio5Porcentaje.Value,
                Premio5Cartones = registro.Premio5Cartones.Value,
                IdUsuario = registro.IdUsuario.Value
            };
        }
    }
}
