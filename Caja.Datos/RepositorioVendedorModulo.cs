using Caja.Entidades;
using Caja.Entidades.Vistas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Caja.Datos
{
    public sealed class RepositorioVendedorModulo : RepositorioBase, IRepositorio<VendedorModulo, int>
    {
        private readonly string mTabla = "vendedoresmodulos";

        public RepositorioVendedorModulo(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<VendedorModulo> Find()
        {
            IEnumerable<VendedorModulo> result = base.FetchObjects<VendedorModulo>($"SELECT * FROM {mTabla};");

            return result;
        }

        public IEnumerable<VendedorModulo> FindByVendedor(int pIdVendedor, int pIdProgramacion)
        {
            return base.FetchObjects<VendedorModulo>($"SELECT * FROM {mTabla} WHERE Estado = 'A' AND IdVendedor = {pIdVendedor} AND IdProgramacionJuego = {pIdProgramacion};");
        }

        public IEnumerable<VendedorModulo> FindByProgramacion(int id)
        {
            return base.FetchObjects<VendedorModulo>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuego = {id} AND Estado = 'A';");
        }

        public IEnumerable<VistaModulosCartonesExportables> FindByExportables(int pIdProgramacion)
        {
            return base.FetchObjects<VistaModulosCartonesExportables>($"SELECT vemo.IdProgramacionJuego, modu.IdModulo, clie.Nombre, clie.Celular, clie.Barrio, modu.Carton1, modu.Serie1, modu.Carton2, " +
                $"modu.Serie2, modu.Carton3, modu.Serie3, modu.Carton4, modu.Serie4, modu.Carton5, modu.Serie5, modu.Carton6, modu.Serie6, vemo.Estado " +
                $"FROM vendedoresmodulos vemo INNER JOIN clientesmodulos clmo ON vemo.IdClienteModulo = clmo.IdClienteModulo " +
                $"INNER JOIN modulos modu ON clmo.IdModulo = modu.IdModulo " +
                $"INNER JOIN clientes clie ON clmo.IdCliente = clie.IdCliente " +
                $"WHERE vemo.IdProgramacionJuego = {pIdProgramacion} AND vemo.Estado = 'A'");
        }

        public IEnumerable<VendedorModulo> FindByModulo(int id)
        {
            return base.FetchObjects<VendedorModulo>($"SELECT * FROM {mTabla} WHERE IdClienteModulo = {id};");
        }

        public VendedorModulo FindOne(int id)
        {
            return base.FetchObject<VendedorModulo>($"SELECT * FROM {mTabla} WHERE IdVendedorModulo = {id};");
        }

        public IEnumerable<VendedorModulo> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int Insert(VendedorModulo objEntidad)
        {
            /// TODO Implementar la creacion del registro.

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdVendedorModulo;
        }

        public int Update(VendedorModulo objEntidad)
        {
            var registroActual = FindOne(objEntidad.IdVendedorModulo);

            /// TODO Implementar la modificación del registro.

            InsertAudit(mTabla, ActionModify, objEntidad, registroActual);

            return objEntidad.IdVendedorModulo;
        }

        public void Deshabilitar(int id, string estado)
        {
            string query = $"UPDATE {mTabla} SET Estado = '{estado}' WHERE IdVendedorModulo = {id};";
            var registroActual = FindOne(id);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            var registroNuevo = (VendedorModulo)registroActual.Clone();
            registroNuevo.Estado = Convert.ToChar(estado);

            InsertAudit(mTabla, ActionStatus, registroNuevo, registroActual);
        }
    }
}

