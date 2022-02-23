using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioUsuario : RepositorioBase, IRepositorio<Usuario, int>
    {
        public IEnumerable<Usuario> Find()
        {
            IEnumerable<Usuario> result = base.FetchObjects<Usuario>($"SELECT * FROM usuarios ORDER BY NombreCompleto;");

            return result;
        }

        public IEnumerable<Usuario> FindByPerfil(int[] idPerfiles)
        {
            IEnumerable<Usuario> result = base.FetchObjects<Usuario>($"select usua.* from usuarios usua, perfilesusuario perf where usua.IdUsuario = perf.IdUsuario and perf.IdPerfil in ({string.Join(",", idPerfiles)});");

            /*foreach (var item in result)
            {
                var perfiles = base.FetchObjects<Perfil>($"select perf.* from perfilesusuario peus, perfiles perf where peus.IdPerfil = perf.IdPerfil and peus.IdUsuario = {item.IdUsuario};");
                item.Perfiles = perfiles;
            }*/

            return result;
        }

        public IEnumerable<Perfil> FindPerfilesByUsuario(int idUsuario)
        {
            IEnumerable<Perfil> result = base.FetchObjects<Perfil>($"SELECT perf.* FROM perfilesusuario peus, perfiles perf " +
                $"WHERE peus.IdPerfil = perf.IdPerfil AND perf.EsVisible = 1 AND peus.IdUsuario = {idUsuario} GROUP BY perf.IdPerfil, perf.Nombre, perf.Descripcion, perf.EsVisible;");

            return result;
        }

        public Usuario FindOne(int id)
        {
            return base.FetchObject<Usuario>($"SELECT * FROM usuarios WHERE IdUsuario = {id};");
        }

        public IEnumerable<Usuario> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int Insert(Usuario objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parNombreCompleto", objEntidad.NombreCompleto));
                command.Parameters.Add(new MySqlParameter("parLogin", objEntidad.Login));
                command.Parameters.Add(new MySqlParameter("parClave", Seguridad.Encriptar(objEntidad.Clave)));
                command.Parameters.Add(new MySqlParameter("parClaveAjustes", Seguridad.Encriptar(objEntidad.ClaveAjustes)));

                command.Parameters.Add(new MySqlParameter("outIdUsuario", MySqlDbType.Int32));
                command.Parameters["outIdUsuario"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                result = (int)command.Parameters["outIdUsuario"].Value;
                command.Connection.Close();
            }

            return result;
        }

        public int InsertPerfil(Perfil objEntidad, int idUsuario)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearPerfilUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdPerfil", objEntidad.IdPerfil));
                command.Parameters.Add(new MySqlParameter("parIdUsuario", idUsuario));

                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            return result;
        }

        public int Update(Usuario objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdUsuario", objEntidad.IdUsuario));
                command.Parameters.Add(new MySqlParameter("parNombreCompleto", objEntidad.NombreCompleto));
                command.Parameters.Add(new MySqlParameter("parLogin", objEntidad.Login));
                command.Parameters.Add(new MySqlParameter("parClave", Seguridad.Encriptar(objEntidad.Clave)));
                command.Parameters.Add(new MySqlParameter("parClaveAjustes", Seguridad.Encriptar(objEntidad.ClaveAjustes)));
                command.Parameters.Add(new MySqlParameter("parEstado", objEntidad.Estado));

                result = command.ExecuteNonQuery();
                command.Connection.Close();
            }

            return result;
        }

        public Usuario FindByLogin(string login)
        {
            Usuario result = base.FetchObject<Usuario>($"SELECT * FROM usuarios WHERE login='{login}';");

            return result;
        }

        public void UpdateLastLogin(int id)
        {
            string query = $"UPDATE usuarios SET FechaUltimoIngreso = NOW() WHERE IdUsuario = {id};";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        public void UpdatePorcentaje(int id, double porcentaje)
        {
            string query = $"UPDATE usuarios SET Porcentaje = {porcentaje} WHERE IdUsuario = {id};";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        public void Deshabilitar(int id, string estado)
        {
            string query = $"UPDATE usuarios SET Estado = '{estado}' WHERE IdUsuario = {id};";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        public void EliminarPerfiles(int idUsuario)
        {
            string query = $"DELETE FROM perfilesusuario WHERE IdUsuario = {idUsuario};";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }

        public void UpdateMaximoJuegos(string cantidadJuegos)
        {
            string query = $"UPDATE parametrosgenerales SET Valor = '{cantidadJuegos}' WHERE Referencia = 'MaximoJuegos';";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }
    }
}
