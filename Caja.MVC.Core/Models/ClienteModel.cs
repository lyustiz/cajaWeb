using Caja.Core.Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Caja.MVC.Core.Models
{
    public class ClienteModel
    {
        public ClienteModel()
        {
        }

        public int Id { get; set; }

        [DisplayName("Nombre Completo")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string Nombres { get; set; }

        [DisplayName("Celular")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string Celular { get; set; }

        [DisplayName("Barrio")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string Barrio { get; set; }
        [DisplayName("Número Documento")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string NumeroDocumento { get; set; }
        public bool Selected { get; set; }
        public ClienteModel ToModel(Clientes registro)
        {
            var cliente = new ClienteModel()
            {
                Id = registro.IdCliente,
                Nombres = registro.Nombre,
                Celular = registro.Celular,
                Barrio = registro.Barrio
            };                       

            return cliente;
        }

        public List<ClienteModel> ToModelList(IEnumerable<Clientes> listado)
        {
            List<ClienteModel> modelo = new();

            listado.ToList().ForEach(x => modelo.Add(ToModel(x)));

            return modelo;
        }
    }
}

