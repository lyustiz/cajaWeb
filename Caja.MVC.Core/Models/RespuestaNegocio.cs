using System;

namespace Caja.MVC.Core.Models
{
    public sealed class RespuestaNegocio<T>
    {
        public string Mensaje { get; set; }

        public bool Ok { get; set; }

        public long Codigo { get; set; }

        public T Informacion { get; set; }

        public void RespuestaNull(string mensaje = "No existe informacón para los filtros de búsqueda")
        {
            Mensaje = mensaje;
            Ok = false;
            Codigo = 404;            
        }

        public void RespuestaOK(T informacion)
        {
            Mensaje = string.Empty;
            Ok = true;
            Codigo = 200;
            Informacion = informacion;
        }

        public void RespuestaError(string mensaje = "No se cumple con alguna regla de negocio.")
        {
            Mensaje = mensaje;
            Ok = false;
            Codigo = 100;            
        }

        public void RespuestaExcepcion(Exception ex)
        {
            Mensaje = ex.Message;
            Ok = false;
            Codigo = 500;
        }
    }
}
