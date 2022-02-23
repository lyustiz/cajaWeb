using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioCliente : RepositorioBase, IRepositorio<Cliente, int>
    {
        #region Cliente
        public IEnumerable<Cliente> Find()
        {
            IEnumerable<Cliente> result = base.FetchObjects<Cliente>($"SELECT * FROM clientes ORDER BY Nombre;");

            return result;
        }

        public IEnumerable<Cliente> Find(string filtro)
        {
            string where;

            if (filtro.IsNullOrEmpty())
                return Find();
            else
                where = $" (nombre LIKE '%{filtro}%' OR celular LIKE '%{filtro}%' OR barrio LIKE '%{filtro}%')";

            IEnumerable<Cliente> result = base.FetchObjects<Cliente>($"SELECT * FROM clientes WHERE {where} ORDER BY Nombre;");

            return result;
        }

        public Cliente FindOne(int id)
        {
            return base.FetchObject<Cliente>($"SELECT * FROM clientes WHERE IdCliente = {id};");
        }

        public IEnumerable<Cliente> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int Insert(Cliente objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearCliente", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parNombre", objEntidad.Nombre));
                command.Parameters.Add(new MySqlParameter("parCelular", objEntidad.Celular));
                command.Parameters.Add(new MySqlParameter("parBarrio", objEntidad.Barrio));

                command.Parameters.Add(new MySqlParameter("outIdCliente", MySqlDbType.Int32));
                command.Parameters["outIdCliente"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                result = (int)command.Parameters["outIdCliente"].Value;
                command.Connection.Close();
            }

            return result;
        }

        public int Update(Cliente objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarCliente", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdCliente", objEntidad.IdCliente));
                command.Parameters.Add(new MySqlParameter("parNombre", objEntidad.Nombre));
                command.Parameters.Add(new MySqlParameter("parCelular", objEntidad.Celular));
                command.Parameters.Add(new MySqlParameter("parBarrio", objEntidad.Barrio));

                command.ExecuteNonQuery();
                result = objEntidad.IdCliente;
                command.Connection.Close();
            }

            return result;
        }

        #endregion

        #region Cliente Modulo

        public IEnumerable<ClienteModulo> FindByNumero(int numero)
        {
            IEnumerable<ClienteModulo> result = base.FetchObjects<ClienteModulo>($"select cm.IdClienteModulo, cm.IdCliente, c.Nombre AS NombreCliente," +
                $" cm.IdModulo, m.Numero AS NumeroModulo, cm.Estado, cm.FechaInicio, cm.FechaFin" +
                $" from clientesmodulos cm, clientes c, modulos m where cm.IdCliente = c.IdCliente and cm.IdModulo = m.IdModulo and m.Numero = {numero} and cm.Estado = 'A'; ");

            return result;
        }

        public IEnumerable<ClienteModulo> FindByCliente(int idCliente)
        {
            IEnumerable<ClienteModulo> result = base.FetchObjects<ClienteModulo>($"select cm.IdClienteModulo, cm.IdCliente, c.Nombre AS NombreCliente," +
                $" cm.IdModulo, m.Numero AS NumeroModulo, cm.Estado, cm.FechaInicio, cm.FechaFin" +
                $" from clientesmodulos cm, clientes c, modulos m where cm.IdCliente = c.IdCliente and cm.IdModulo = m.IdModulo and cm.IdCliente = {idCliente} and cm.Estado = 'A'; ");

            return result;
        }

        public int FindByOtrosClientes(int idCliente, int numero)
        {
            int result = base.FetchObject<int>($"select count(0) from clientesmodulos cm, clientes c, modulos m where cm.IdCliente = c.IdCliente and cm.IdModulo = m.IdModulo and cm.IdCliente <> {idCliente} and m.Numero = {numero} and cm.Estado = 'A'; ");

            return result;
        }

        public int AddClienteModulo(ClienteModulo objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearClienteModulo", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdCliente", objEntidad.IdCliente));
                command.Parameters.Add(new MySqlParameter("parIdModulo", objEntidad.IdModulo));
                command.Parameters.Add(new MySqlParameter("parFechaInicio", objEntidad.FechaInicio.Date));
                command.Parameters.Add(new MySqlParameter("parFechaFin", objEntidad.FechaFin.Date));

                command.Parameters.Add(new MySqlParameter("outIdClienteModulo", MySqlDbType.Int32));
                command.Parameters["outIdClienteModulo"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                result = (int)command.Parameters["outIdClienteModulo"].Value;
                command.Connection.Close();
            }

            return result;
        }

        public void DeshabilitarClienteModulo(int id, string estado)
        {
            string query = $"UPDATE clientesmodulos SET Estado = '{estado}' WHERE IdClienteModulo = {id};";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        #endregion
    }
}
