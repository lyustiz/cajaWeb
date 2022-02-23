using Caja.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    public partial class RepositorioVendedor : RepositorioBase
    {
        public IEnumerable<Vendedoresreferencias> ObtenerRerencias(int pIdVendedor)
        {
            return Contexto.Vendedoresreferencias.Where(x => x.IdVendedor == pIdVendedor);
        }

        public Vendedoresreferencias ObtenerRerencia(int pIdReferencia)
        {
            return Contexto.Vendedoresreferencias.FirstOrDefault(x => x.IdVendedorReferencia == pIdReferencia);
        }

        public bool Modificar(Vendedoresreferencias registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                var registroUp = Contexto.Vendedoresreferencias.Find(registro.IdVendedorReferencia);

                registroUp.Nombres = registro.Nombres;
                registroUp.Apellidos = registro.Apellidos;
                registroUp.Direccion = registro.Direccion;
                registroUp.Telefono = registro.Telefono;
                registroUp.Celular = registro.Celular;
                registroUp.Documento = registro.Documento;
                registroUp.IdCiudad = registro.IdCiudad;
                registroUp.IdTipoRelacion = registro.IdTipoRelacion;                

                Contexto.Vendedoresreferencias.Update(registroUp);
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

        public bool Insertar(Vendedoresreferencias registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Contexto.Vendedoresreferencias.Add(registro);
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
