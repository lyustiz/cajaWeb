using Caja.Core.Entidades;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    public sealed class RepositorioModulos : RepositorioBase    
    {
        public RepositorioModulos(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        public IEnumerable<Modulos> ObtenerModulos()
        {
            return Contexto.Modulos.ToList();
        }

        public bool ExistePorNumero(int numero)
        {
            return Contexto.Modulos.ToList().Exists(x => x.Numero == numero);
        }

        public bool ExistePorNumero(int numero, int idModulo)
        {
            return Contexto.Modulos.ToList().Exists(x => x.Numero == numero && x.IdModulo != idModulo);
        }

        public bool ExisteCartonSerie(int carton, string serie, int modulo)
        {
            return Contexto.Modulos.Count(x => (x.Carton1 == carton && x.Serie1 == serie && x.IdModulo != modulo)
            || (x.Carton2 == carton && x.Serie2 == serie && x.IdModulo != modulo)
            || (x.Carton3 == carton && x.Serie3 == serie && x.IdModulo != modulo)
            || (x.Carton4 == carton && x.Serie4 == serie && x.IdModulo != modulo)
            || (x.Carton5 == carton && x.Serie5 == serie && x.IdModulo != modulo)
            || (x.Carton6 == carton && x.Serie6 == serie && x.IdModulo != modulo)) > 0;
        }

        public Modulos ObtenerModulo(int id)
        {
            return Contexto.Modulos.FirstOrDefault(x => x.IdModulo == id);
        }

        public bool Modificar(Modulos registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                var registroUp = Contexto.Modulos.Find(registro.IdModulo);

                registroUp.Numero = registro.Numero;
                registroUp.Serie1 = registro.Serie1;
                registroUp.Carton1 = registro.Carton1;
                registroUp.Serie2 = registro.Serie2;
                registroUp.Carton2 = registro.Carton2;
                registroUp.Serie3 = registro.Serie3;
                registroUp.Carton3 = registro.Carton3;
                registroUp.Serie4 = registro.Serie4;
                registroUp.Carton4 = registro.Carton4;
                registroUp.Serie5 = registro.Serie5;
                registroUp.Carton5 = registro.Carton5;
                registroUp.Serie6 = registro.Serie6;
                registroUp.Carton6 = registro.Carton6;

                Contexto.Modulos.Update(registroUp);
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

        public bool Insertar(Modulos registro)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Contexto.Modulos.Add(registro);
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
