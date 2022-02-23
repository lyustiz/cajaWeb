using Caja.Core.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Caja.MVC.Core.Models
{
    public class VendedorModel
    {
        public VendedorModel()
        {
            this.Referencias = new List<ReferenciaModel>();
        }

        public int Id { get; set; }

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

        [DisplayName("Fecha Nacimiento")]
        [BindProperty, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Campo Requerido.")]        
        public DateTime FechaNacimiento { get; set; }

        [DisplayName("Estado Civil")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public int IdEstadoCivil { get; set; }

        [DisplayName("Nro. Documento")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string Documento { get; set; }

        public string Estado { get; set; }

        public DateTime FechaCreacion { get; set; }
                    
        public List<ReferenciaModel> Referencias { get; set; }

        public SelectList ListaCiudades { get; set; }

        public SelectList ListaEstadosCivil { get; set; }

        public int IdUsuarioCrea { get; set; }

        public VendedorModel ToModel(Vendedores registro, IEnumerable<Vendedoresreferencias> referencias = null)
        {
            var vendedor = new VendedorModel()
            {
                Id = registro.IdVendedor,
                Nombres = registro.Nombres,
                Apellidos = registro.Apellidos,
                Direccion = registro.Direccion,
                Telefono = registro.Telefono,
                Celular = registro.Celular,
                IdCiudad = registro.IdCiudad,
                FechaNacimiento = registro.FechaNacimiento,
                IdEstadoCivil = registro.IdEstadoCivil,
                Documento = registro.Documento,
                Estado = registro.Estado
            };

            if (referencias != null)
            {
                foreach (var referencia in referencias)
                {
                    vendedor.Referencias.Add(new ReferenciaModel());
                }
            }

            return vendedor;
        }

        public List<VendedorModel> ToModelList(IEnumerable<Vendedores> listado)
        {
            List<VendedorModel> modelo = new();

            listado.ToList().ForEach(x => modelo.Add(ToModel(x)));

            return modelo;
        }
    }
}
