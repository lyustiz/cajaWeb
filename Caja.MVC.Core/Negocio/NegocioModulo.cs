using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Caja.MVC.Core.App;
using Caja.MVC.Core.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System;

namespace Caja.MVC.Core.Negocio
{
    public partial class NegocioModulo
    {
        private readonly RepositorioModulos repositorio = null;
        private readonly RepositorioRoe repositorioRoe = null;

        public NegocioModulo(IConfiguration pConfiguracion)
        {
            repositorio = new RepositorioModulos(pConfiguracion);
            repositorioRoe = new RepositorioRoe(pConfiguracion);
        }

        public Modulos Consultar(int id)
        {
            return repositorio.ObtenerModulo(id);
        }

        public IEnumerable<Modulos> Consultar()
        {
            return repositorio.ObtenerModulos();
        }

        public RespuestaNegocio<ModuloModel> Guardar(ModuloModel modelo)
        {
            RespuestaNegocio<ModuloModel> respuesta = new();
            Validar(modelo, respuesta);

            if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
                return respuesta;

            var registro = new Modulos()
            {
                IdModulo = modelo.Id,
                Numero = modelo.Numero,
                Carton1 = Convert.ToInt32(modelo.Carton1),
                Serie1 = modelo.Serie1,
                Carton2 = Convert.ToInt32(modelo.Carton2),
                Serie2 = modelo.Serie2,
                Carton3 = Convert.ToInt32(modelo.Carton3),
                Serie3 = modelo.Serie3,
                Carton4 = Convert.ToInt32(modelo.Carton4),
                Serie4 = modelo.Serie4,
                Carton5 = Convert.ToInt32(modelo.Carton5),
                Serie5 = modelo.Serie5,
                Carton6 = Convert.ToInt32(modelo.Carton6),
                Serie6 = modelo.Serie6
            };

            var operacion = modelo.Id > 0 ? repositorio.Modificar(registro) : repositorio.Insertar(registro);

            if (operacion)
                respuesta.RespuestaOK(modelo);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

        private void Validar(ModuloModel model, RespuestaNegocio<ModuloModel> respuesta)
        {
            respuesta.Mensaje = string.Empty;
            respuesta.Ok = true;

            if (repositorio.ExistePorNumero(model.Numero, model.Id))
            {
                respuesta.Ok = false;
                respuesta.Mensaje = $"No se puede crear un módulo con el número {model.Numero}, por que ya existe uno.";

                return;
            }

            var serieDefecto = repositorioRoe.ObtenerSerieDefecto();

            if (model.Carton1.IsNumeric() || model.Carton2.IsNumeric()
                || model.Carton3.IsNumeric() || model.Carton4.IsNumeric()
                || model.Carton5.IsNumeric() || model.Carton6.IsNumeric())
            {
                if (serieDefecto.IsNullOrEmpty())
                {
                    respuesta.Ok = false;
                    respuesta.Mensaje = "Debe configurar en el sistema una serie por defecto para completar la serie de los cartones en donde solo se especifico el número del cartón, o puede completar el campo con el número de la serie.";

                    return;
                }
            }

            RecuperarValores(model.Carton1, model, serieDefecto, 1);
            RecuperarValores(model.Carton2, model, serieDefecto, 2);
            RecuperarValores(model.Carton3, model, serieDefecto, 3);
            RecuperarValores(model.Carton4, model, serieDefecto, 4);
            RecuperarValores(model.Carton5, model, serieDefecto, 5);
            RecuperarValores(model.Carton6, model, serieDefecto, 6);

            bool carton1Existe = repositorio.ExisteCartonSerie(Convert.ToInt32(model.Carton1), model.Serie1, model.Id);
            bool carton2Existe = repositorio.ExisteCartonSerie(Convert.ToInt32(model.Carton2), model.Serie2, model.Id);
            bool carton3Existe = repositorio.ExisteCartonSerie(Convert.ToInt32(model.Carton3), model.Serie3, model.Id); 
            bool carton4Existe = repositorio.ExisteCartonSerie(Convert.ToInt32(model.Carton4), model.Serie4, model.Id);
            bool carton5Existe = repositorio.ExisteCartonSerie(Convert.ToInt32(model.Carton5), model.Serie5, model.Id);
            bool carton6Existe = repositorio.ExisteCartonSerie(Convert.ToInt32(model.Carton6), model.Serie6, model.Id);

            if (carton1Existe)
                respuesta.Mensaje = $"El cartón 1 {model.Carton1}{model.Serie1.ToUpper()} ya está configurado en otro modulo.";

            if (carton2Existe)
                respuesta.Mensaje += $", El cartón 2 {model.Carton2}{model.Serie2.ToUpper()} ya está configurado en otro modulo.";

            if (carton3Existe)
                respuesta.Mensaje += $", El cartón 3 {model.Carton3}{model.Serie3.ToUpper()} ya está configurado en otro modulo.";

            if (carton4Existe)
                respuesta.Mensaje += $", El cartón 4 {model.Carton4}{model.Serie4.ToUpper()} ya está configurado en otro modulo.";

            if (carton5Existe)
                respuesta.Mensaje += $", El cartón 5 {model.Carton5}{model.Serie5.ToUpper()} ya está configurado en otro modulo.";

            if (carton6Existe)
                respuesta.Mensaje += $", El cartón 6 {model.Carton6}{model.Serie6.ToUpper()} ya está configurado en otro modulo.";

            respuesta.Ok = respuesta.Mensaje.IsNullOrEmpty();

            if (!respuesta.Ok)
                return;

            // Validar Series.
            var listaSeries = repositorioRoe.ObtenerSeries();

            if (!listaSeries.Exists(x => x.Simbolo == model.Serie1))
                respuesta.Mensaje = $"La serie {model.Serie1} del cartón 1 no existe.";

            if (!listaSeries.Exists(x => x.Simbolo == model.Serie2))
                respuesta.Mensaje += $", La serie {model.Serie2} del cartón 2 no existe.";

            if (!listaSeries.Exists(x => x.Simbolo == model.Serie3))
                respuesta.Mensaje += $", La serie {model.Serie3} del cartón 3 no existe.";

            if (!listaSeries.Exists(x => x.Simbolo == model.Serie4))
                respuesta.Mensaje += $", La serie {model.Serie4} del cartón 4 no existe.";

            if (!listaSeries.Exists(x => x.Simbolo == model.Serie5))
                respuesta.Mensaje += $", La serie {model.Serie5} del cartón 5 no existe.";

            if (!listaSeries.Exists(x => x.Simbolo == model.Serie6))
                respuesta.Mensaje += $", La serie {model.Serie6} del cartón 6 no existe.";

            respuesta.Ok = respuesta.Mensaje.IsNullOrEmpty();
        }

        private void RecuperarValores(string valor, ModuloModel modulo, string serieDefecto, byte indice)
        {
            string serie = serieDefecto;
            string strCarton = "";

            foreach (var caracter in valor)
            {
                if (caracter.IsNumeric())
                    strCarton = $"{strCarton}{caracter}";
                else
                    serie = caracter.ToString();
            }

            switch (indice)
            {
                case 1:
                    modulo.Carton1 = strCarton;
                    modulo.Serie1 = serie;
                    break;
                case 2:
                    modulo.Carton2 =strCarton;
                    modulo.Serie2 = serie;
                    break;
                case 3:
                    modulo.Carton3 = strCarton;
                    modulo.Serie3 = serie;
                    break;
                case 4:
                    modulo.Carton4 = strCarton;
                    modulo.Serie4 = serie;
                    break;
                case 5:
                    modulo.Carton5 = strCarton;
                    modulo.Serie5 = serie;
                    break;
                case 6:
                    modulo.Carton6 = strCarton;
                    modulo.Serie6 = serie;
                    break;
            }
        }
    }
}

