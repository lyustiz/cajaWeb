using Caja.Core.Entidades;
using Caja.MVC.Core.Models;
using System.Collections.Generic;

namespace Caja.MVC.Core.Negocio
{
    public partial class NegocioVendedor
    {        
        public IEnumerable<Vendedoresreferencias> ConsultarReferencias(int pIdVendedor)
        {
            return repositorio.ObtenerRerencias(pIdVendedor);
        }

        public Vendedoresreferencias ConsultarReferencia(int pIdReferencia)
        {
            return repositorio.ObtenerRerencia(pIdReferencia);
        }

        public RespuestaNegocio<ReferenciaModel> GuardarReferencia(ReferenciaModel modelo)
        {
            RespuestaNegocio<ReferenciaModel> respuesta = new();
            ValidarReferencia(modelo, respuesta);

            if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                return respuesta;

            var referencia = new Vendedoresreferencias()
            {
                IdVendedorReferencia = modelo.Id,
                IdVendedor = modelo.IdVendedor,                
                Nombres = modelo.Nombres,
                Apellidos = modelo.Apellidos,
                Telefono = modelo.Telefono,
                Celular = modelo.Celular,
                Direccion = modelo.Direccion,
                IdCiudad = modelo.IdCiudad,                
                IdTipoRelacion = modelo.IdTipoRelacion,
                Documento = modelo.Documento,                
                IdUsuarioCreacion = modelo.IdUsuarioCrea
            };

            var operacion = modelo.Id > 0 ? repositorio.Modificar(referencia) : repositorio.Insertar(referencia);

            if (operacion)
                respuesta.RespuestaOK(modelo);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

        private void ValidarReferencia(ReferenciaModel model, RespuestaNegocio<ReferenciaModel> respuesta)
        {
            respuesta.Mensaje = string.Empty;
            respuesta.Ok = true;
        }
    }
}
