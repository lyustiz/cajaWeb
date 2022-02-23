
using Caja.Core.Entidades;
using Caja.Core.Repositorio;
using Caja.MVC.Core.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace Caja.MVC.Core.Negocio
{
    public partial class NegocioClienteModulo
    {
        private readonly RepositorioClienteModulo repositorio = null;

        public NegocioClienteModulo(IConfiguration pConfiguracion)
        {
            repositorio = new RepositorioClienteModulo(pConfiguracion);
        }

        public ClienteModulo Consultar(int id)
        {
            return repositorio.ObtenerModulo(id);
        }

        public IEnumerable<ClienteModulo> Consultar()
        {
            return repositorio.ObtenerClientesModulos();
        }

        public RespuestaNegocio<ClienteModuloModel> Guardar(ClienteModuloModel modelo)
        {
            RespuestaNegocio<ClienteModuloModel> respuesta = new();
            Validar(modelo, respuesta);
            if (!respuesta.Ok)
            {
                return respuesta;
            }
            using var transaction = repositorio.Contexto.Database.BeginTransaction();
            var operacion = false;
            if (modelo.IdClienteModulo > 0)
            {
                var registro = new ClienteModulo()
                {
                    IdClienteModulo = modelo.IdClienteModulo,
                    IdCliente = modelo.IdCliente,
                    IdModulo = modelo.IdModulo,
                    Estado = modelo.Estado,
                    IdJuegoInicio = modelo.IdJuegoInicio,
                    IdJuegoFin = modelo.IdJuegoFin
                };
                try
                {

                    repositorio.Modificar(registro);
                    transaction.Commit();
                    respuesta.RespuestaOK(modelo);
                }
                catch (System.Exception)
                {
                    respuesta.RespuestaError("No se logro editar la información. Intentelo nuevamente.");
                    transaction.Rollback();
                }
                return respuesta;
            }
            else
            {
                foreach (var item in modelo.ListaIdModulosSeleccionados)
                {
                    var registro = new ClienteModulo()
                    {
                        IdClienteModulo = modelo.IdClienteModulo,
                        IdCliente = modelo.IdCliente,
                        IdModulo = item,
                        Estado = "A",
                        IdJuegoInicio = modelo.IdJuegoInicio,
                        IdJuegoFin = modelo.IdJuegoFin
                    };
                    operacion = repositorio.Insertar(registro);
                    if (!operacion)
                    {
                        respuesta.RespuestaError("No se logro guardar la información. Intentelo nuevamente.");
                        transaction.Rollback();
                        return respuesta;
                    }
                        
                }
                respuesta.RespuestaOK(modelo);
                transaction.Commit();
                return respuesta;
            }
        }

        private void Validar(ClienteModuloModel modelo, RespuestaNegocio<ClienteModuloModel> respuesta)
        {

            respuesta.Mensaje = string.Empty;
            respuesta.Ok = true;
            if (modelo.IdCliente == 0)
            {
                respuesta.Mensaje = "Selecciona un cliente";
                respuesta.Ok = false;
                return;
            }
            if (modelo.ListaIdModulosSeleccionados == null)
            {
                respuesta.Mensaje = "Selecciona al menos un módulo";
                respuesta.Ok = false;
                return;
            }
            if (modelo.IdJuegoInicio == 0)
            {
                respuesta.Mensaje = "Selecciona un juego inicio";
                respuesta.Ok = false;
                return;
            }
            if (modelo.IdJuegoFin == 0)
            {
                respuesta.Mensaje = "Selecciona un juego fin";
                respuesta.Ok = false;
                return;
            }
        }
    }
}
