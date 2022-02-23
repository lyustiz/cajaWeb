using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Caja.Datos.DataLayer;
using System.Data;
using Newtonsoft.Json;

namespace Caja.Datos
{
    public class RepositorioBase
    {
        protected readonly string ActionInsert = "Insertar";
        protected readonly string ActionModify = "Modificar";
        protected readonly string ActionStatus = "Cambiar Estado";
        protected readonly string ActionSecondKey = "Segunda Clave";
        protected readonly int IdUsuarioAuditoria;

        public RepositorioBase()
        {
        }

        public RepositorioBase(int pIdUsuario)
        {
            IdUsuarioAuditoria = pIdUsuario;
        }

        
        protected List<T> FetchObjects<T>(string sql)
        {
            var res = new List<T>();

            var connection = DatabaseConnection.getDBConnection();
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader dr = command.ExecuteReader();

            try
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        res.Add(Ducking<T>.RecordByIndex(dr));
                    }
                }
            }
            finally
            {
                dr.Close();
            }

            connection.Close();
            connection.Dispose();

            return res;
        }

        protected T FetchObject<T>(string sql)
        {
            T res = default;

            var connection = DatabaseConnection.getDBConnection();
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader dr = command.ExecuteReader();

            try
            {
                if (dr.Read())
                {
                    res = Ducking<T>.RecordByIndex(dr);
                }
            }
            finally
            {
                dr.Close();
            }

            connection.Close();
            connection.Dispose();

            return res;
        }
        
        protected int InsertAudit<T>(string pTable, string pAction, T pNewRecord, T pOldrecord)
        {
            int result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearAuditoria", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new MySqlParameter("parIdUsuario", IdUsuarioAuditoria));
                command.Parameters.Add(new MySqlParameter("parTabla", pTable));
                command.Parameters.Add(new MySqlParameter("parAccion", pAction));
                command.Parameters.Add(new MySqlParameter("parRegistroNuevo", JsonConvert.SerializeObject(pNewRecord)));

                if (pAction == ActionInsert || pAction == ActionSecondKey)
                    command.Parameters.Add(new MySqlParameter("parRegistroAnterior", string.Empty));
                else
                    command.Parameters.Add(new MySqlParameter("parRegistroAnterior", JsonConvert.SerializeObject(pOldrecord)));

                command.Parameters.Add(new MySqlParameter("outIdAuditoria", MySqlDbType.Int32));
                command.Parameters["outIdAuditoria"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                result = (int)command.Parameters["outIdAuditoria"].Value;
                command.Connection.Close();
            }

            return result;
        }

    }
}
