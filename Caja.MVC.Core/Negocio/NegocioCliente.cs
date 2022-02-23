using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Caja.MVC.Core.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Caja.MVC.Core.Negocio
{
    public partial class NegocioCliente
    {
        private readonly RepositorioCliente repositorio = null;
        

        public NegocioCliente(IConfiguration pConfiguracion)
        {
            repositorio = new RepositorioCliente(pConfiguracion);
        }

        /// <summary>
        /// Consultar un vendedor.
        /// </summary>
        /// <param name="pIdVendedor">Identificador unido de un vendedor.</param>        
        public IEnumerable<Clientes> ConsultarPorVendedor(int pIdVendedor)
        {
            return repositorio.ObtenerPorVendedor(pIdVendedor);
        }

        public Clientes Consultar(int id)
        {
            return repositorio.Obtener(id);
        }

        public IEnumerable<Clientes> Consultar(string filtro = "")
        {
            if (string.IsNullOrWhiteSpace(filtro))
                return repositorio.ObtenerClientes();
            else
                return repositorio.ObtenerClientes(filtro);
        }

        public RespuestaNegocio<ClienteModel> Guardar(ClienteModel modelo)
        {
            RespuestaNegocio<ClienteModel> respuesta = new();
            Validar(modelo, respuesta);

            if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                return respuesta;

            var cliente = new Clientes()
            {
                IdCliente = modelo.Id,
                Nombre = modelo.Nombres,
                Celular = modelo.Celular,
                Barrio = modelo.Barrio
            };

            var operacion = modelo.Id > 0 ? repositorio.Modificar(cliente) : repositorio.Insertar(cliente);

            if (operacion)
                respuesta.RespuestaOK(modelo);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

        private void Validar(ClienteModel model, RespuestaNegocio<ClienteModel> respuesta)
        {
            respuesta.Mensaje = string.Empty;
            respuesta.Ok = true;
        }

        public RespuestaNegocio<ClienteModel> GuardarActualizarLote(List<Clientes> clientes)
        { 
            RespuestaNegocio<ClienteModel> respuesta = new();

            foreach (var cliente in clientes) {

                ClienteModel clienteModel = new ClienteModel().ToModel(cliente);

                Validar(clienteModel, respuesta);

                if (!respuesta.Ok && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                {
                    return respuesta;
                }
                
            }

            bool operacion = repositorio.GuardarActualizarLote(clientes);
            

            if (operacion)
                respuesta.RespuestaOK(new ClienteModel());
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }
    }
}

