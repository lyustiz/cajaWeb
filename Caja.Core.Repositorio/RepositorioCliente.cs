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
    public partial class RepositorioCliente : RepositorioBase
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioCliente"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioCliente(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        /// <summary>
        /// Obtener la información de un cliente.
        /// </summary>
        /// <param name="pIdCliente">Identificador unico del vendedor.</param>
        /// <returns><see cref="Clientes"/></returns>
        public Clientes Obtener(int pIdCliente)
        {
            return Contexto.Clientes.Find(pIdCliente);
        }

        public IEnumerable<Clientes> ObtenerClientes()
        {
            return Contexto.Clientes.ToList();
        }

        public IEnumerable<Clientes> ObtenerPorVendedor(int IdVendedor)
        {

            try
            {
                var items = Contexto.Clientes.Where(c => c.IdVendedor == IdVendedor);
                return items.ToList();
            }
            catch (Exception) {
                return new List<Clientes>();
            }

            
        }

        public IEnumerable<Clientes> ObtenerClientes(string filtro)
        {
            return Contexto.Clientes.Where(x => x.Nombre.Contains(filtro) || x.Celular.Contains(filtro) || x.Barrio.Contains(filtro)).ToList();
        }

        public bool Modificar(Clientes registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                var registroUp = Contexto.Clientes.Find(registro.IdCliente);

                registroUp.Nombre = registro.Nombre;
                registroUp.Celular = registro.Celular;
                registroUp.Barrio = registro.Barrio;

                Contexto.Clientes.Update(registroUp);
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

        public bool Insertar(Clientes registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Contexto.Clientes.Add(registro);
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

        public bool GuardarActualizarLote(List<Clientes> clientes)
        {
            int IdVendedor = clientes[0].IdVendedor;

            List<Clientes> ClientesDb = Contexto.Clientes
                                   .Where(c => c.IdVendedor == IdVendedor)
                                   .ToList();

            List<string> CodigosClientes = ClientesDb.Select(c => c.Codigo).ToList();

            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                foreach (Clientes cliente in clientes)
                {
                    if (CodigosClientes.Contains(cliente.Codigo))
                    {
                        var clienteUp = ClientesDb.Find(c => c.Codigo == cliente.Codigo);
                        clienteUp.Nombre = cliente.Nombre;
                        clienteUp.Celular = cliente.Celular;
                        clienteUp.NumeroDocumento =  String.IsNullOrEmpty( cliente.NumeroDocumento) ? "0" : cliente.NumeroDocumento;
                        clienteUp.Barrio = cliente.Barrio;
                        clienteUp.Estado = cliente.Estado;
                        Contexto.Clientes.Update(clienteUp);
                    }
                    else
                    {
                        Contexto.Clientes.AddRange(cliente);
                    }
                }
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
    }
        
}

