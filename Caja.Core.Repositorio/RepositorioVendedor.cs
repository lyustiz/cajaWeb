using Caja.Core.Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    /// <summary>
    /// Clase de acceso a datos de Vendedor Hoja
    /// </summary>
    public partial class RepositorioVendedor : RepositorioBase
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioVendedor"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioVendedor(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        /// <summary>
        /// Obtener la información de un vendedor.
        /// </summary>
        /// <param name="pIdVendedor">Identificador unico del vendedor.</param>
        /// <returns><see cref="Vendedoreshojas"/></returns>
        public Vendedores Obtener(int pIdVendedor)
        {
            return Contexto.Vendedores.Find(pIdVendedor);
        }

        /// <summary>
        /// Obtener la información de un vendedor.
        /// </summary>
        /// <param name="pCelular">Identificador unico del vendedor.</param>
        /// <returns><see cref="Vendedoreshojas"/></returns>
        public Vendedores ObtenerPorCelular(string pCelular)
        {
            return Contexto.Vendedores.Where(x=> x.Celular == pCelular).FirstOrDefault();
        }
        public Vendedores Login(string pCelular, string pPassword)
        {
            return Contexto.Vendedores.Where(x => (x.Celular == pCelular) & (x.Password == pPassword) ).FirstOrDefault();
        }

        public IEnumerable<Vendedores> ObtenerVendedores()
        {
            return Contexto.Vendedores.ToList();
        }

        public IEnumerable<Vendedores> ObtenerVendedores(string filtro)
        {
            return Contexto.Vendedores.Where(x => x.Nombres.Contains(filtro) || x.Apellidos.Contains(filtro) || x.Documento.Contains(filtro) || x.Celular.Contains(filtro)).ToList();
        }

        public bool Modificar(Vendedores registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                var registroUp = Contexto.Vendedores.Find(registro.IdVendedor);

                registroUp.Nombres = registro.Nombres;
                registroUp.Apellidos = registro.Apellidos;
                registroUp.Direccion = registro.Direccion;
                registroUp.Telefono = registro.Telefono;
                registroUp.Celular = registro.Celular;
                registroUp.Documento = registro.Documento;
                registroUp.IdCiudad = registro.IdCiudad;
                registroUp.IdEstadoCivil = registro.IdEstadoCivil;
                registroUp.FechaNacimiento = registro.FechaNacimiento;

                Contexto.Vendedores.Update(registroUp);
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

        public bool Insertar(Vendedores registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Contexto.Vendedores.Add(registro);
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

        public bool ModificarEstado(int idVendedor)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Vendedores vendedor = Contexto.Vendedores.Find(idVendedor);

                if (vendedor != null)
                {
                    if (vendedor.Estado == "A")
                        vendedor.Estado = "I";
                    else
                        vendedor.Estado = "A";

                    Contexto.Vendedores.Update(vendedor);
                }

                Contexto.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }
    }
}

