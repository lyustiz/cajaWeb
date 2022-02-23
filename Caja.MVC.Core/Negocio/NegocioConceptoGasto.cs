using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Caja.MVC.Core.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Caja.MVC.Core.Negocio
{
    public sealed class NegocioConceptoGasto
    {
        private readonly RepositorioConceptoGasto repositorio = null;

        public NegocioConceptoGasto(IConfiguration pConfiguracion)
        {
            repositorio = new RepositorioConceptoGasto(pConfiguracion);
        }

        /// <summary>
        /// Consultar la información de los conceptos de gastos.
        /// </summary>        
        /// <returns><see cref="Conceptogastos"/></returns>
        public IEnumerable<ConceptoGastoModel> Consultar()
        {
            return new ConceptoGastoModel().ToModelList(repositorio.ObtenerConceptos());
        }

        public RespuestaNegocio<IEnumerable<ConceptoGastoModel>> GuardarConceptos(IEnumerable<ConceptoGastoModel> listaModelo)
        {
            RespuestaNegocio<IEnumerable<ConceptoGastoModel>> respuesta = new();
            ValidarDatos(listaModelo, respuesta);

            if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                return respuesta;

            List<Conceptogastos> listaConceptos = new();

            foreach (var modelo in listaModelo)
            {
                Conceptogastos concepto = new()
                {
                    IdConceptoGasto = modelo.IdConceptoGasto,
                    Controlado = modelo.Controlado ? (short)1 : (short)0,                                        
                    ValorMaximo = modelo.ValorMaximo
                };

                listaConceptos.Add(concepto);
            }

            var operacion = repositorio.GuardarConceptos(listaConceptos);

            if (operacion)
                respuesta.RespuestaOK(listaModelo);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

        private void ValidarDatos(IEnumerable<ConceptoGastoModel> listaModelo, RespuestaNegocio<IEnumerable<ConceptoGastoModel>> respuesta)
        {
            respuesta.Mensaje = string.Empty;
            respuesta.Ok = true;

           foreach (ConceptoGastoModel concepto in listaModelo)
            {
                if (concepto.ValorMaximo <= 0)
                {
                    respuesta.Ok = false;
                    respuesta.Mensaje = $"El límite máximo del concepto {concepto.Descripcion} debe ser mayor a cero.";
                    break;
                }
            }

        }
    }
}



