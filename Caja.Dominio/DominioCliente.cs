using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioCliente
    {
        readonly RepositorioCliente mRepositorio;
        public DominioCliente()
        {
            mRepositorio = new RepositorioCliente();
        }

        public List<Cliente> FetchAll()
        {
            return mRepositorio.Find().ToList();
        }

        public List<Cliente> FetchWhere(string filtro)
        {
            return mRepositorio.Find(filtro).ToList();
        }
        public Cliente FetchOne(int id)
        {
            return mRepositorio.FindOne(id);
        }

        public List<Cliente> FetchOnes(int[] ids)
        {
            throw new System.NotImplementedException();
        }

        public int Save(Cliente objEntidad)
        {
            if (objEntidad.IdCliente > 0)
                return mRepositorio.Update(objEntidad);
            else
                return mRepositorio.Insert(objEntidad);
        }

        public List<ClienteModulo> FindByNumero(int numero)
        {
            return mRepositorio.FindByNumero(numero).ToList();
        }

        public List<ClienteModulo> FindByCliente(int idCliente)
        {
            return mRepositorio.FindByCliente(idCliente).ToList();
        }

        public bool ExisteModuloCliente(int idCliente, int numero)
        {
            var listaModulosCliente = mRepositorio.FindByCliente(idCliente).ToList();

            return listaModulosCliente.Exists(x => x.NumeroModulo == numero);
        }

        public bool ExisteModuloEnOtroCliente(int idCliente, int numero)
        {
            return mRepositorio.FindByOtrosClientes(idCliente, numero) > 0;
        }

        public int AddClienteModulo(ClienteModulo objEntidad)
        {
            return mRepositorio.AddClienteModulo(objEntidad);
        }

        public void DeshabilitarClienteModulo(string estado, int idClienteModulo)
        {
            mRepositorio.DeshabilitarClienteModulo(idClienteModulo, estado);
        }
    }
}
