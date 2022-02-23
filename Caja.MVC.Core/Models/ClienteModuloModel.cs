
using Caja.Core.Entidades;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Caja.MVC.Core.Models
{
    public class ClienteModuloModel
    {
        [DisplayName("Código")]
        [ReadOnly(true)]
        public int IdClienteModulo { get; set; }

        [DisplayName("Cliente")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public int IdCliente { get; set; }
        [DisplayName("Nombre Cliente")]
        public string NombreCliente { get; set; }

        [DisplayName("Módulo")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public int IdModulo { get; set; }

        [DisplayName("Juego Inicio")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public int IdJuegoInicio { get; set; }

        [DisplayName("Juego Fin")]
        [Required(ErrorMessage = "El campo es obligatorio.")]
        public int IdJuegoFin { get; set; }

        [DisplayName("Estado")]
        public string Estado { get; set; }

        [DisplayName("Clientes Disponibles")]
        public List<ClienteModel> ListaClientes { get; set; }

        [DisplayName("Módulos Disponibles")]
        public List<SelectListItem> ListaModulos { get; set; }

        [DisplayName("Juegos Disponibles")]
        //public List<ProgramacionJuegoModel> ListaJuegos { get; set; }
        public SelectList ListaJuegos { get; set; }
        [DisplayName("Módulos Seleccionados")]
        [ReadOnly(true)]
        //public MultiSelectList ListaModulosSeleccionados { get; set; }
        public List<SelectListItem> ListaModulosSeleccionados { get; set; }
        public List<int> ListaIdModulosSeleccionados { get; set; }

        public List<ComboModel> GetListaModulos(List<ModuloModel> listado)
        {
            List<ComboModel> lista = new();
            foreach (var item in listado)
            {
                lista.Add(new ComboModel(item.Id, item.Numero.ToString()));
            }

            return lista;
        }

        public List<ComboModel> GetListaJuegos(List<ProgramacionJuegoModel> listado)
        {
            List<ComboModel> lista = new();
            foreach (var item in listado)
            {
                lista.Add(new ComboModel(item.NumeroJuego, (item.NumeroJuego+" "+ item.FechaJuego.ToString())));
            }

            return lista;
        }

        public List<ComboModel> GetListaClientes(List<ClienteModel> listado)
        {
            List<ComboModel> lista = new();
            foreach (var item in listado)
            {
                lista.Add(new ComboModel(item.Id, item.Nombres));
            }

            return lista;
        }


        public ClienteModuloModel ToModel(ClienteModulo entity)
        {
            return new ClienteModuloModel()
            {
                IdClienteModulo = entity.IdClienteModulo,
                IdCliente = entity.IdCliente.Value,
                NombreCliente = entity.IdClienteNavigation?.Nombre,
                IdModulo = entity.IdModulo.Value,
                Estado = entity.Estado,
                IdJuegoInicio = entity.IdJuegoInicio.Value,
                IdJuegoFin = entity.IdJuegoFin.Value
            };
        }

        public List<ClienteModuloModel> ToModelList(IEnumerable<ClienteModulo> listado)
        {
            List<ClienteModuloModel> modelo = new();
            listado.ToList().ForEach(x => modelo.Add(ToModel(x)));

            return modelo;
        }
    }

}
