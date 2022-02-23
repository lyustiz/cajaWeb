using Caja.Core.Entidades;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System;

namespace Caja.MVC.Core.Models
{
    public class SolicitudVendedorModel
    {
        public SolicitudVendedorModel()
        {
        }

        public int Id { get; set; }

        [DisplayName("Vendedor")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public int IdVendedor { get; set; }

        [DisplayName("Juego")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public int IdJuego { get; set; }

        [DisplayName("Tipo de Solicitud")]
        public string TipoSolicitud { get; set; }

        [DisplayName("Cantidad Solicitada")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public int Cantidad { get; set; }

        [DisplayName("Estado de la solicitud")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string Estado { get; set; }

        [DisplayName("Fecha Solicitud")]
        [BindProperty, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Campo Requerido.")]
        public DateTime FechaSolicitud { get; set; }

        [DisplayName("Fecha Modificacion")]
        [BindProperty, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Campo Requerido.")]
        public DateTime? FechaModificacion { get; set; }

        public SolicitudVendedorModel ToModel(SolicitudesVendedores registro)
        {
            SolicitudVendedorModel model = new()
            {
                Id = registro.IdSolicitudVendedor,
                IdVendedor = registro.IdVendedor,
                IdJuego = registro.IdJuego,
                TipoSolicitud = registro.TipoSolicitud,
                Cantidad = registro.Cantidad,
                Estado = registro.Estado,
                FechaSolicitud = registro.FechaSolicitud,
                FechaModificacion = registro.FechaModificacion
            };

            return model;
        }

        public List<SolicitudVendedorModel> ToModelList(IEnumerable<SolicitudesVendedores> listado)
        {
            List<SolicitudVendedorModel> modelos = new();

            listado.ToList().ForEach(x => modelos.Add(ToModel(x)));

            return modelos;
        }
    }
}

