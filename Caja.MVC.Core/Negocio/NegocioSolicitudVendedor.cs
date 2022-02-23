using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Caja.MVC.Core.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;


namespace Caja.MVC.Core.Negocio
{
    public class NegocioSolicitudVendedor
    {
        private readonly RepositorioSolicitudVendedor repositorio  = null;

        public NegocioSolicitudVendedor(IConfiguration pConfiguracion)
        {
            repositorio = new RepositorioSolicitudVendedor(pConfiguracion);

        }
        public SolicitudesVendedores Consultar(int pIdSolicitudVendedor)
        {
            return repositorio.Obtener(pIdSolicitudVendedor);
        }

        public List<SolicitudesVendedores> ConsultarPorVendedor(int pIdVendedor)
        {
            return repositorio.ObtenerPorVendedor(pIdVendedor);
        }

        private void Validar(SolicitudVendedorModel model, RespuestaNegocio<SolicitudVendedorModel> respuesta)
        {
            respuesta.Mensaje = string.Empty;
            respuesta.Ok = true;
        }

        public RespuestaNegocio<SolicitudVendedorModel> Guardar(SolicitudesVendedores registro)
        {
            RespuestaNegocio<SolicitudVendedorModel> respuesta = new();

            SolicitudVendedorModel modelo = new();

            modelo = modelo.ToModel(registro);

            Validar(modelo, respuesta);

            if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                return respuesta;

            var operacion = registro.IdSolicitudVendedor > 0 ? repositorio.Modificar(registro) : repositorio.Insertar(registro);

            if (operacion)
                respuesta.RespuestaOK(modelo);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

        public SolicitudesVendedores GuardarRetornar(SolicitudesVendedores registro)
        {
            RespuestaNegocio<SolicitudVendedorModel> respuesta = new();

            SolicitudVendedorModel modelo = new();

            modelo = modelo.ToModel(registro);

            Validar(modelo, respuesta);

            if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                return null;

            return repositorio.InsertarRetornar(registro);
        }
    }
}
