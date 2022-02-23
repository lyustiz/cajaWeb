using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Caja.MVC.Core.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

using System.Linq;

namespace Caja.MVC.Core.Negocio
{
    public class NegocioCarton
    {
        private readonly RepositorioCarton repositorioCarton = null;
        private readonly RepositorioJuego repositorioJuego = null;

        public NegocioCarton(IConfiguration pConfiguracion)
        {
            repositorioJuego = new RepositorioJuego(pConfiguracion);
            repositorioCarton = new RepositorioCarton(pConfiguracion);
        }
        public List<CartonJuego> ObtenerCartonesJuegos(int pIdVendedor, int limite = 15)
        {
            List<int> rangoJuegos = repositorioJuego.ObtenerRangoJuegosVendedor(pIdVendedor, limite);

            return repositorioCarton.Obtener(rangoJuegos.First(), rangoJuegos.Last(), pIdVendedor).ToList(); 
        }

        private void Validar(CartonJuego model, RespuestaNegocio<CartonJuego> respuesta)
        {
            respuesta.Mensaje = string.Empty;
            respuesta.Ok = true;
        }

        public RespuestaNegocio<CartonJuego> GuardarActualizarLote(List<CartonJuego> cartones)
        {
            RespuestaNegocio<CartonJuego> respuesta = new();

            foreach (var carton in cartones)
            {
                Validar(carton, respuesta);

                if (!respuesta.Ok && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                {
                    return respuesta;
                }
            }

            bool operacion = repositorioCarton.GuardarActualizarLote(cartones);

            if (operacion)
                respuesta.RespuestaOK(new CartonJuego());
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }
    }
}
