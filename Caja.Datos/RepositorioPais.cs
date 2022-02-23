using Caja.Entidades;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioPais : RepositorioBase, IRepositorio<Pais, int>
    {
        public IEnumerable<Pais> Find()
        {
            return base.FetchObjects<Pais>($"SELECT * FROM paises ORDER BY IdPais;");
        }

        public Pais FindOne(int id)
        {
            return base.FetchObject<Pais>($"SELECT * FROM paises WHERE IdPais = {id};");
        }

        public IEnumerable<Pais> FindOnes(int[] ids)
        {
            return base.FetchObjects<Pais>($"SELECT * FROM paises WHERE IdPais IN {string.Join(",", ids)};");
        }

        public int Insert(Pais objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearPais", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parDescripcion", objEntidad.Descripcion.Trim()));

                command.Parameters.Add(new MySqlParameter("outIdPais", MySqlDbType.Int32));
                command.Parameters["outIdPais"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                result = (int)command.Parameters["outIdPais"].Value;
                command.Connection.Close();
            }

            return result;
        }

        public int Update(Pais objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarPais", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdPais", objEntidad.IdPais));                
                command.Parameters.Add(new MySqlParameter("parDescripcion", objEntidad.Descripcion.Trim()));                

                result = command.ExecuteNonQuery();
                command.Connection.Close();
            }

            return result;
        }
    }
}
