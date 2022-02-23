using Caja.Entidades;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioCiudad : RepositorioBase, IRepositorio<Ciudad, int>
    {
        public IEnumerable<Ciudad> Find()
        {
            return base.FetchObjects<Ciudad>($"SELECT * FROM ciudades ORDER BY IdCiudad;");
        }

        public IEnumerable<Ciudad> FindByPais(int idPais)
        {
            return base.FetchObjects<Ciudad>($"SELECT * FROM ciudades WHERE IdPais = {idPais} ORDER BY IdCiudad;");
        }

        public Ciudad FindOne(int id)
        {
            return base.FetchObject<Ciudad>($"SELECT * FROM ciudades WHERE IdCiudad = {id};");
        }

        public IEnumerable<Ciudad> FindOnes(int[] ids)
        {
            return base.FetchObjects<Ciudad>($"SELECT * FROM ciudades WHERE IdCiudades IN {string.Join(",", ids)};");
        }

        public int Insert(Ciudad objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearCiudad", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdPais", objEntidad.IdPais));
                command.Parameters.Add(new MySqlParameter("parDescripcion", objEntidad.Descripcion.Trim()));

                command.Parameters.Add(new MySqlParameter("outIdCiudad", MySqlDbType.Int32));
                command.Parameters["outIdCiudad"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                result = (int)command.Parameters["outIdCiudad"].Value;
                command.Connection.Close();
            }

            return result;
        }

        public int Update(Ciudad objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarCiudad", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdCiudad", objEntidad.IdCiudad));
                command.Parameters.Add(new MySqlParameter("parIdPais", objEntidad.IdPais));
                command.Parameters.Add(new MySqlParameter("parDescripcion", objEntidad.Descripcion.Trim()));

                result = command.ExecuteNonQuery();
                command.Connection.Close();
            }

            return result;
        }
    }
}

