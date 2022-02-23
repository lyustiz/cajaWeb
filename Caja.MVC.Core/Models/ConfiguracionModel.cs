using Caja.Core.Entidades;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System;

namespace Caja.MVC.Core.Models
{
    public class ConfiguracionModel
    {
        public ConfiguracionModel()
        {
        }

        public int Id { get; set; }

        [DisplayName("Nmero del Juego")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public int NumeroJuego { get; set; }

        [DisplayName("Carton")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public int Carton { get; set; }

        [DisplayName("Serie")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string Serie { get; set; }

        [DisplayName("Balota")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public int Balotas { get; set; }

        [DisplayName("Fecha de Registro")]
        [BindProperty, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Campo Requerido.")]
        public DateTime? FechaRegistro { get; set; }

        [DisplayName("Usuario")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public int? IdUsuario { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string Estado { get; set; }

        [DisplayName("Fecha Modificacion")]
        [BindProperty, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Campo Requerido.")]
        public DateTime? FechaModificacion { get; set; }

        [DisplayName("Esta Reconfigurado")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public int Reconfigurado { get; set; }


        public bool Selected { get; set; }
        public ConfiguracionModel ToModel(Configuracion registro)
        {
            ConfiguracionModel configuracion = new()
            {
                Id = registro.IdConfiguracion,
                NumeroJuego = registro.NumeroJuego,
                Carton = registro.Carton,
                Serie = registro.Serie,
                Balotas = registro.Balotas ,
                FechaRegistro = registro.FechaRegistro,
                IdUsuario = registro.IdUsuario ,
                Estado = registro.Estado ,
                FechaModificacion = registro.FechaModificacion ,
                Reconfigurado = registro.Reconfigurado,
            };

            return configuracion;
        }

        public List<ConfiguracionModel> ToModelList(IEnumerable<Configuracion> listado)
        {
            List<ConfiguracionModel> modelo = new();

            listado.ToList().ForEach(x => modelo.Add(ToModel(x)));

            return modelo;
        }
    }
}

