using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Caja.MVC.Core.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;


namespace Caja.MVC.Core.Negocio
{
    public sealed class NegocioParametroGeneral
    {
        private readonly RepositorioParametroGeneral repositorio = null;

        public NegocioParametroGeneral(IConfiguration pConfiguracion)
        {
            repositorio = new RepositorioParametroGeneral(pConfiguracion);
        }

        public IEnumerable<Parametrosgenerales> Consultar()
        {
            return repositorio.Obtener();
        }

        public string ObtenerValor(IEnumerable<Parametrosgenerales> parametrosgenerales, string referencia)
        {
            return parametrosgenerales.Where(pg => pg.Referencia == referencia).First().Valor;
        }

        /// <summary>
        /// Consultar la información de un parametro general
        /// </summary>
        /// <param name="referencia">Login unico del usuario.</param>        
        /// <returns><see cref="Parametrosgenerales"/></returns>
        public Parametrosgenerales Consultar(string referencia)
        {
            return repositorio.Obtener(referencia);           
        }

        public RespuestaNegocio<MonedaModel> ModificarMoneda(MonedaModel modelo)
        {
            RespuestaNegocio<MonedaModel> respuesta = new RespuestaNegocio<MonedaModel>();

            var parametroMoneda = Consultar("strModeda");
            var parametroFormato = Consultar("strFormato");

            parametroMoneda.Valor = modelo.Tipo;
            parametroFormato.Valor = modelo.Formato;

            var operacion = repositorio.ModificarMoneda(parametroMoneda, parametroFormato);

            if (operacion)
                respuesta.RespuestaOK(modelo);
            else
                respuesta.RespuestaError("No se logro actualizar la información. Intentelo nuevamente.");

            return respuesta;
        }
    }
}

