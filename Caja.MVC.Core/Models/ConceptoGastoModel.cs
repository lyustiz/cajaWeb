using Caja.Core.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Caja.MVC.Core.Models
{
    public class ConceptoGastoModel
    {
        [DisplayName("Id")]
        public int IdConceptoGasto { get; set; }

        [DisplayName("Concepto")]
        public string Descripcion { get; set; }

        [DisplayName("Consumo Mes")]
        public double Valor { get; set; }

        [Required]
        [Range(1, 100000000, ErrorMessage = "El valor de {0} debe estar entre {1} y {2:C}.")]
        [DisplayName("Límite Máximo")]
        public double ValorMaximo { get; set; }

        [DisplayName("Es Controlado")]
        public bool Controlado { get; set; }

        public List<ConceptoGastoModel> ToModelList(IEnumerable<Conceptogastos> listado)
        {
            List<ConceptoGastoModel> listaModelo = new();

            foreach (Conceptogastos concepto in listado)
            {
                ConceptoGastoModel modelo = new();

                modelo.IdConceptoGasto = concepto.IdConceptoGasto;
                modelo.Descripcion = concepto.Descripcion;
                modelo.Valor = concepto.Valor;
                modelo.ValorMaximo = concepto.ValorMaximo;
                modelo.Controlado = concepto.Controlado > 0;                

                listaModelo.Add(modelo);
            }

            return listaModelo;
        }
    }
}
