using Caja.Datos;
using Caja.Entidades;
using Caja.Entidades.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioProgramacionJuego : DominioBase
    {
        readonly RepositorioProgramacionJuego mRepositorio;
        readonly RepositorioProgramacionJuegoFigura mRepositorioFiguras;
        readonly RepositorioParametroGeneral mRepositorioParametros;

        readonly DominioFlujoCaja mDominioFlujoCaja;

        public DominioProgramacionJuego(int pIdUsuario)
        {
            mRepositorio = new RepositorioProgramacionJuego(pIdUsuario);
            mRepositorioFiguras = new RepositorioProgramacionJuegoFigura(pIdUsuario);
            mRepositorioParametros = new RepositorioParametroGeneral();

            mDominioFlujoCaja = new DominioFlujoCaja(pIdUsuario);
        }

        public List<ProgramacionJuego> BuscarProgramacionActiva()
        {
            string filtro = " Estado = 'A' ";
            return mRepositorio.Find(filtro).ToList();
        }

        public List<ProgramacionJuego> BuscarProgramacionCerrada()
        {
            string filtro = " Estado = 'C' ";
            return mRepositorio.Find(filtro).ToList();
        }

        public List<ProgramacionJuego> BuscarProgramacion()
        {
            return mRepositorio.Find(string.Empty).ToList();
        }

        public ProgramacionJuego ObtenerProgramacion(int pIdProgramacion)
        {            
            return mRepositorio.FindOne(pIdProgramacion);
        }

        public string ObtenerSerieProgramacion(int pIdProgramacion)
        {
            return mRepositorio.FindSerieProgramacion(pIdProgramacion);
        }

        public List<ProgramacionJuegoFigura> ObtenerFigurasProgramacion(int pIdProgramacion)
        {
            return mRepositorioFiguras.Find(pIdProgramacion).ToList();
        }

        public List<ProgramacionJuego> ObtenerProgramacionEstadisticas(int anio, int mes)
        {
            return mRepositorio.FindEstadistica(anio, mes).ToList();
        }
        public List<VistaProgramacionJuegoVendedores> ObtenerProgramacionJuegoHojas(string pFiltro)
        {
            return mRepositorio.FindProgramacionJuegoHojas(pFiltro).ToList();
        }

        public List<VistaVendedoresProgramacion> ObtenerVendedoresProgramacionJuego(string pFiltro, int pIdProgramacion)
        {
            return mRepositorio.FindVendedoresProgramacion(pFiltro, pIdProgramacion).ToList();
        }

        public RespuestaDominio PuedeCrearNuevaProgramacion()
        {
            int cantidadActual = mRepositorio.CantidadProgramacionesAbiertas();
            ParametroGeneral objMaximoJuegosAbiertos = mRepositorioParametros.FindBy(TipoBusquedaParametroGeneral.Referencia, "Caja-MaximoJuegosAbiertos");

            if (objMaximoJuegosAbiertos != null)
            {
                if (cantidadActual >= Convert.ToInt32(objMaximoJuegosAbiertos.Valor))
                    return Error("Ha excedido el número máximo de juegos ABIERTOS permitidos");
            }

            return Ok();
        }

        public int ObtenerSiguientIdProgramacion()
        {
            return mRepositorio.SiguienteIdProgramacion();
        }

        public int ObtenerProgramacionMasAntigua()
        {
            return mRepositorio.ProgramacionMasAntigua();
        }

        public Tuple<int, int> ObtenerRangoAniosProgramaciones()
        {
            return mRepositorio.ObtenerRangoAniosProgramaciones();
        }

        public RespuestaDominio CrearProgramacion(ProgramacionJuego objProgramacion, List<ProgramacionJuegoFigura> figuras)
        {
            objProgramacion.TotalPremios = figuras.Where(x => x.Estado == "A").Sum(x => x.ValorPremio);

            int idProgramacion = mRepositorio.Insert(objProgramacion);

            if (idProgramacion > 0)
            {
                // Guardar las figuras
                foreach (ProgramacionJuegoFigura figura in figuras)
                {
                    figura.IdProgramacionJuego = idProgramacion;
                    mRepositorioFiguras.Insert(figura);
                }

                FlujoCaja objFlujoCaja = new FlujoCaja()
                {
                    IdProgramacionJuego = idProgramacion
                };

                mDominioFlujoCaja.Save(objFlujoCaja);

                return Ok($"El juego se programo exitosamente y se generó con el número {idProgramacion}", idProgramacion);
            }
            else
                return Error("No se creó el juego programado, intentelo de nuevo por favor.");                
            
        }

        public RespuestaDominio CerrarProgramacion(int pIdProgramacion)
        {
            try
            {
                mRepositorio.Cerrar(new ProgramacionJuego() { IdProgramacionJuego = pIdProgramacion });
                return Ok();
            }
            catch (Exception ex)
            {
                return Error(ex.Message);
            }          
        }

        public RespuestaDominio ModificarRangosProgramacion(ProgramacionJuego objProgramacion)
        {
            int idProgramacion = mRepositorio.Update(objProgramacion);

            if (idProgramacion > 0)
            {
                return Ok($"El rango de cartones ds modificó exitosamente.", idProgramacion);
            }
            else
                return Error("El rango de cartones de NO se modificó, intentelo de nuevo por favor.");
        }

        public RespuestaDominio ModificarResultadoFinal(ProgramacionJuego objProgramacion)
        {
            int idProgramacion = mRepositorio.UpdateResultadoFinal(objProgramacion);

            if (idProgramacion > 0)
            {
                return Ok($"El resultado final se modificó exitosamente.", idProgramacion);
            }
            else
                return Error("El resultado final NO se modificó, intentelo de nuevo por favor.");
        }

        public RespuestaDominio EliminarFigura(int idProgramacion, int idFigura)
        {
            mRepositorioFiguras.Deshabilitar(idFigura);
            var totalPremios = ObtenerFigurasProgramacion(idProgramacion).Where(x => x.Estado == "A").Sum(x => x.ValorPremio);                        
            mRepositorio.ActualizarTotalPremios(idProgramacion, totalPremios);
            
            return Ok();
        }

        public RespuestaDominio AgregarFigura(ProgramacionJuegoFigura objFigura)
        {
            var idFigura = mRepositorioFiguras.Insert(objFigura);
            if (idFigura > 0)
            {
                var totalPremios = ObtenerFigurasProgramacion(objFigura.IdProgramacionJuego).Where(x => x.Estado == "A").Sum(x => x.ValorPremio);
                mRepositorio.ActualizarTotalPremios(objFigura.IdProgramacionJuego, totalPremios);

                return Ok("La figura se creo exitosamente.");
            }
            else
                return Error("La figura  no se creo, por favor intentelo de nuevo.");
        }

        public RespuestaDominio ExisteJuegoParaCerrar()
        {
            if (mRepositorio.ExistenJuegosParaCerrar() <= 0)
            {
                return new RespuestaDominio()
                {
                    Mensaje = $"No hay ningun juego disponible para cerrar."
                };
            }
            else
                return new RespuestaDominio() { Ok = true };
        }

        public RespuestaDominio ValidarHojas(int pCartonesHoja, int pIdProgramacion)
        {
            int mHojasImpresas = mRepositorio.CantidadHojasImpresas(pCartonesHoja, pIdProgramacion);
            int mHojasEntregadas = mRepositorio.CantidadHojasEntregadas(pIdProgramacion);

            if (mHojasImpresas != mHojasEntregadas)
            {
                return new RespuestaDominio()
                {
                    Mensaje = $"El número de hojas registradas y devueltas es diferente al número de hojas impresas. {Environment.NewLine}" +
                    $"Total Hojas definidas para el juego {mHojasImpresas}.{Environment.NewLine}" +
                    $"Total Hojas registradas en el juego {mHojasEntregadas}.{Environment.NewLine}" +
                    $"Valide por favor."
                };
            }
            else
                return new RespuestaDominio() { Ok = true };
        }

        public RespuestaDominio ValidarVendedoresSinPago(int pIdProgramacion)
        {
            int mVendedoresSinPago = mRepositorio.CantidadVendedoresSinPago(pIdProgramacion);
            
            if (mVendedoresSinPago != 0)
            {
                return new RespuestaDominio()
                {
                    Mensaje = $"Existen vendedores sin realizar el cobro. {Environment.NewLine}" +
                    $"Hasta que se reciban todos los vendedores no se puede cerrar el juego.{Environment.NewLine}"                    
                };
            }
            else
                return new RespuestaDominio() { Ok = true };
        }

        public List<VistaConsultaListadoCartonesDevueltos> ConsultarListadoCartones(int pIdProgramacion)
        {
            return mRepositorio.ConsultarListadoCartones(pIdProgramacion).ToList();
        }
    }
}
