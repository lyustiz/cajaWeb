using Caja.Core.Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    public sealed class RepositorioClienteModulo : RepositorioBase    
    {
        public RepositorioClienteModulo(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        public IEnumerable<ClienteModulo> ObtenerClientesModulos()
        {
            return Contexto.Clientesmodulos.ToList();
        }

        public bool ExistePorIdClienteModulo(int IdClienteModulo)
        {
            return Contexto.Clientesmodulos.ToList().Exists(x => x.IdClienteModulo == IdClienteModulo);
        }

        public ClienteModulo ObtenerModulo(int id)
        {
            return Contexto.Clientesmodulos.FirstOrDefault(x => x.IdClienteModulo == id);
        }

        public bool Modificar(ClienteModulo registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                var registroUp = Contexto.Clientesmodulos.Find(registro.IdModulo);

                registroUp.IdClienteModulo = registro.IdClienteModulo;
                registroUp.IdCliente = registro.IdCliente;
                registroUp.IdModulo = registro.IdModulo;
                registroUp.Estado = registro.Estado;
                registroUp.IdJuegoInicio = registro.IdJuegoInicio;
                registroUp.IdJuegoFin = registro.IdJuegoFin;

                Contexto.Clientesmodulos.Update(registroUp);
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

        public bool Insertar(ClienteModulo registro)
        {
            try
            {
                Contexto.Clientesmodulos.Add(registro);
                Contexto.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }
    }
}
