using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Caja.MVC.Core.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caja.MVC.Core.Negocio
{
    public class NegocioProgramacionJuego
    {
        private readonly RepositorioProgramacionJuego repositorio = null;

        public NegocioProgramacionJuego(IConfiguration pConfiguracion)
        {
            repositorio = new RepositorioProgramacionJuego(pConfiguracion);
        }
        public List<Programacionjuegos> BuscarProgramacionActiva()
        {
            return repositorio.Find("A").ToList();
        }

        public Programacionjuegos BuscarProgramacion(int id)
        {
            return repositorio.Find(id);
        }

        public List<Programacionjuegosfiguras> BuscarFigurasProgramacion(int pIdProgramacion)
        {
            return repositorio.ObtenerFiguras(pIdProgramacion).ToList();
        }

        public int SiguienteIdProgramacion()
        {
            return repositorio.SiguienteIdProgramacion();
        }

        public IEnumerable<Vprogramacionjuegovendedores> FindProgramacionJuegoHojas(string filtro)
        {
            return repositorio.FindProgramacionJuegoHojas(filtro);
        }

        public RespuestaNegocio<ProgramacionJuegoModel> Guardar(ProgramacionJuegoModel modelo)
        {
            RespuestaNegocio<ProgramacionJuegoModel> respuesta = new();
            //Validar(modelo, respuesta);

            //if (respuesta.Ok == false && string.IsNullOrWhiteSpace(respuesta.Mensaje) == false)
            //    return respuesta;

            var programacion = new Programacionjuegos()
            {
                IdProgramacionJuego = 0,
                FechaProgramada = modelo.FechaJuego,
                ValorCarton = modelo.ValorCarton,
                ValorModulo = modelo.ValorModulo,
                TotalPremios = modelo.Figuras.Sum(x => x.ValorPremio),
                IdSerie = modelo.IdSerie,
                CartonInicial = modelo.CartonInicial,
                CartonFinal = modelo.CartonFinal,
                HojaInicial = modelo.HojaInicial,
                HojaFinal = modelo.HojaFinal,
                Estado = "A",
                Programacionjuegosfiguras = new List<Programacionjuegosfiguras>()
            };

            foreach (var figura in modelo.Figuras)
            {
                programacion.Programacionjuegosfiguras.Add(new Programacionjuegosfiguras() { IdPlenoAutomatico = figura.Id, ValorPremio = figura.ValorPremio, Estado = "A" });
            }

            var operacion = repositorio.Insertar(programacion);

            if (operacion)
                respuesta.RespuestaOK(modelo);
            else
                respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");

            return respuesta;
        }

    }
}
