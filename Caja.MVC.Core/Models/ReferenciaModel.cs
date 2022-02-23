using Caja.Core.Entidades;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Caja.MVC.Core.Models
{
    public class ReferenciaModel
    {
        public int Id { get; set; }

        public int IdVendedor { get; set; }

        [DisplayName("Tipo Relación")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public int IdTipoRelacion { get; set; }

        [DisplayName("Nombres")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string Nombres { get; set; }

        [DisplayName("Apellidos")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string Apellidos { get; set; }

        [DisplayName("Dirección")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string Direccion { get; set; }

        [DisplayName("Teléfono")]
        public string Telefono { get; set; }

        [DisplayName("Celular")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string Celular { get; set; }

        [DisplayName("Ciudad")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public int IdCiudad { get; set; }        

        [DisplayName("Nro. Documento")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string Documento { get; set; }

        public SelectList ListaCiudades { get; set; }

        public SelectList ListaTipoRelacion { get; set; }

        public int IdUsuarioCrea { get; set; }

        public ReferenciaModel ToModel(Vendedoresreferencias registro)
        {
            var refrencia = new ReferenciaModel()
            {
                Id = registro.IdVendedorReferencia,
                IdVendedor = registro.IdVendedor.Value,
                Nombres = registro.Nombres,
                Apellidos = registro.Apellidos,
                Direccion = registro.Direccion,
                Telefono = registro.Telefono,
                Celular = registro.Celular,
                IdCiudad = registro.IdCiudad,                
                IdTipoRelacion = registro.IdTipoRelacion.Value,
                Documento = registro.Documento             
            };           

            return refrencia;
        }

        public List<ReferenciaModel> ToModelList(IEnumerable<Vendedoresreferencias> listado)
        {
            List<ReferenciaModel> modelo = new();

            listado.ToList().ForEach(x => modelo.Add(ToModel(x)));

            return modelo;
        }
    }
}
