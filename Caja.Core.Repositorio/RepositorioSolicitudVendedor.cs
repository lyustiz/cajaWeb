using Caja.Core.Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Caja.Core.Repositorio
{
    /// <summary>
    /// Clase de acceso a datos de clientes.
    /// </summary>
    public partial class RepositorioSolicitudVendedor : RepositorioBase
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioSolicitudVendedor"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioSolicitudVendedor(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        /// <summary>
        /// Obtener la información de un cliente.
        /// </summary>
        /// <param name="pIdCliente">Identificador unico del vendedor.</param>
        /// <returns><see cref="Clientes"/></returns>
        public SolicitudesVendedores Obtener(int pIdSolicitudVendedor)
        {
            return Contexto.SolicitudesVendedores.Find(pIdSolicitudVendedor);
        }

        public List<SolicitudesVendedores> ObtenerPorVendedor(int pIdVendedor)
        {
            return Contexto.SolicitudesVendedores.Where(s => s.IdVendedor == pIdVendedor).ToList();
        }


        public bool Modificar(SolicitudesVendedores registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                var registroUp = Contexto.SolicitudesVendedores.Find(registro.IdSolicitudVendedor);

                registroUp.Estado = registro.Estado;
                registroUp.FechaModificacion = DateTime.Now; 

                Contexto.SolicitudesVendedores.Update(registroUp);
                Contexto.SaveChanges();
                transaction.Commit();

                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }

        public bool Insertar(SolicitudesVendedores registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Contexto.SolicitudesVendedores.Add(registro);
                Contexto.SaveChanges();
                transaction.Commit();

                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }

        public SolicitudesVendedores InsertarRetornar(SolicitudesVendedores registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                registro.FechaModificacion = null;
                registro.FechaSolicitud = DateTime.Now;
                registro.Estado = "P";
                Contexto.SolicitudesVendedores.Add(registro);
                Contexto.SaveChanges();
                transaction.Commit();

                return registro;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return null;
            }
        }

    }

}

