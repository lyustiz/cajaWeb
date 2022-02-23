using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Caja.MVC.Core.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Caja.MVC.Core.Negocio
{
    public partial class NegocioVendedor
    {
        private readonly RepositorioVendedor repositorio = null;

        public NegocioVendedor(IConfiguration pConfiguracion)
        {
            repositorio = new RepositorioVendedor(pConfiguracion);
        }

        /// <summary>
        /// Consultar un vendedor.
        /// </summary>
        /// <param name="pIdVendedor">Identificador unido de un vendedor.</param>        
        public Vendedores ConsultarVendedor(int pIdVendedor)
        {
            return repositorio.Obtener(pIdVendedor);
        }

        public IEnumerable<Vendedores> ConsultarVendedores()
        {
            return repositorio.ObtenerVendedores();
        }

        public IEnumerable<Vendedores> ConsultarVendedores(string filtro = "")
        {
            if (string.IsNullOrWhiteSpace(filtro))            
                return repositorio.ObtenerVendedores();
            else
                return repositorio.ObtenerVendedores(filtro);
        }

        public RespuestaNegocio<VendedorModel> Guardar(VendedorModel modelo)
        {
            RespuestaNegocio<VendedorModel> respuesta = new();
            ValidarVendedor(modelo, respuesta);

            if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                return respuesta;

            var vendedor = new Vendedores()
            {
                IdVendedor = modelo.Id,
                Codigo = modelo.Id.ToString(),
                Nombres = modelo.Nombres,
                Apellidos = modelo.Apellidos,
                Telefono = modelo.Telefono,
                Celular = modelo.Celular,
                Direccion = modelo.Direccion,
                IdCiudad = modelo.IdCiudad,
                FechaNacimiento = modelo.FechaNacimiento,
                IdEstadoCivil = modelo.IdEstadoCivil,
                Documento = modelo.Documento,
                Estado = "A",
                IdUsuarioCreacion = modelo.IdUsuarioCrea
            };
           
            var operacion = modelo.Id > 0 ? repositorio.Modificar(vendedor) : repositorio.Insertar(vendedor);

            if (operacion)
                respuesta.RespuestaOK(modelo);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

        public RespuestaNegocio<bool> CambiarEstado(int idVendedor)
        {
            RespuestaNegocio<bool> respuesta = new();

            var operacion = repositorio.ModificarEstado(idVendedor);

            if (operacion)
                respuesta.RespuestaOK(operacion);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

        public Vendedores ConsultarVendedorPorCelular(string pCelular)
        {
            return repositorio.ObtenerPorCelular(pCelular);
        }

        public Vendedores login(string celular, string password)
        {
            return repositorio.Login(celular, password);
        }

        private void ValidarVendedor(VendedorModel model, RespuestaNegocio<VendedorModel> respuesta)
        {
            respuesta.Mensaje = string.Empty;
            respuesta.Ok = true;
        }
    }
}
