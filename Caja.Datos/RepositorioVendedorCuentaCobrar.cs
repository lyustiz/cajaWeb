using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioVendedorCuentaCobrar : RepositorioBase, IRepositorio<VendedorCuentaCobrar, int>
    {
        private readonly string mTabla = "vendedorescuentascobrar";

        public RepositorioVendedorCuentaCobrar(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<VendedorCuentaCobrar> Find()
        {
            IEnumerable<VendedorCuentaCobrar> result = base.FetchObjects<VendedorCuentaCobrar>($"SELECT * FROM {mTabla};");

            return result;
        }

        public VendedorCuentaCobrar FindByVendedorProgramacion(int pIdVendedor, int pIdProgramacion)
        {
            var result = base.FetchObject<VendedorCuentaCobrar>($"SELECT * FROM {mTabla} WHERE IdVendedor = {pIdVendedor} AND IdProgramacionJuego = {pIdProgramacion} AND Estado = 'A' LIMIT 1;");

            return result;
        }

        public IEnumerable<VendedorCuentaCobrar> FindByProgramacion(int pId)
        {
            IEnumerable<VendedorCuentaCobrar> result = base.FetchObjects<VendedorCuentaCobrar>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuego = {pId};");

            return result;
        }

        public VendedorCuentaCobrar FindOne(int id)
        {
            return base.FetchObject<VendedorCuentaCobrar>($"SELECT * FROM {mTabla} WHERE IdVendedorCuentaCobrar = {id};");
        }

        public IEnumerable<VendedorCuentaCobrar> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int Insert(VendedorCuentaCobrar objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearVendedorCuentaCobrar", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parIdVendedor", objEntidad.IdVendedor));
                command.Parameters.Add(new MySqlParameter("parValor", objEntidad.Valor));

                command.Parameters.Add(new MySqlParameter("outIdVendedorCuentaCobrar", MySqlDbType.Int32));
                command.Parameters["outIdVendedorCuentaCobrar"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdVendedorCuentaCobrar = (int)command.Parameters["outIdVendedorCuentaCobrar"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdVendedorCuentaCobrar;
        }

        public int Update(VendedorCuentaCobrar objEntidad)
        {
            throw new NotImplementedException();

            /*var registroActual = FindOne(objEntidad.IdVendedorCuentaCobrar);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarVendedorCobroCarton", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdVendedorCuentaCobrar", objEntidad.IdVendedorCuentaCobrar));

                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionModify, objEntidad, registroActual);

            return objEntidad.IdVendedorCuentaCobrar;*/
        }

        public void Deshabilitar(int pId)
        {
            string query = $"UPDATE {mTabla} SET Estado = 'I' WHERE IdVendedorCuentaCobrar = {pId};";
            var registroActual = FindOne(pId);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            var registroNuevo = (VendedorCuentaCobrar)registroActual.Clone();
            registroNuevo.Estado = Convert.ToChar('I');

            InsertAudit(mTabla, ActionStatus, registroNuevo, registroActual);
        }
    }
}




