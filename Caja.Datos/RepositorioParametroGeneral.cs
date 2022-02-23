using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioParametroGeneral : RepositorioBase, IRepositorio<ParametroGeneral, int>
    {
        public IEnumerable<ParametroGeneral> Find()
        {
            throw new NotImplementedException();
        }

        public ParametroGeneral FindBy(TipoBusquedaParametroGeneral tipo, object valor)
        {
            if (tipo == TipoBusquedaParametroGeneral.Id)
                return FindOne((int)valor);
            else if (tipo == TipoBusquedaParametroGeneral.Referencia)
                return base.FetchObject<ParametroGeneral>($"SELECT * FROM parametrosgenerales WHERE Referencia = '{(string)valor}';");

            return null;
        }

        public ParametroGeneral FindOne(int id)
        {
            return base.FetchObject<ParametroGeneral>($"SELECT * FROM parametrosgenerales WHERE IdParametros_Generales = {id};");
        }

        public IEnumerable<ParametroGeneral> FindOnes(int[] ids)
        {
            return base.FetchObjects<ParametroGeneral>($"SELECT * FROM parametrosgenerales WHERE IdParametros_Generales IN {string.Join(",", ids)};");
        }

        public int Insert(ParametroGeneral objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearParametroGeneral", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdEmpresa", objEntidad.IdEmpresa));
                command.Parameters.Add(new MySqlParameter("parReferencia", objEntidad.Referencia));
                command.Parameters.Add(new MySqlParameter("parDescripcion", objEntidad.Descripcion));
                command.Parameters.Add(new MySqlParameter("parValor", objEntidad.Valor));

                command.Parameters.Add(new MySqlParameter("outIdParametro", MySqlDbType.Int32));
                command.Parameters["outIdParametro"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                result = (int)command.Parameters["outIdParametro"].Value;
                command.Connection.Close();
            }

            return result;
        }

        public int Update(ParametroGeneral objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarParametroGeneral", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdParametro", objEntidad.IdParametros_Generales));                
                command.Parameters.Add(new MySqlParameter("parReferencia", objEntidad.Referencia));
                command.Parameters.Add(new MySqlParameter("parDescripcion", objEntidad.Descripcion));
                command.Parameters.Add(new MySqlParameter("parValor", objEntidad.Valor));

                result = command.ExecuteNonQuery();
                command.Connection.Close();
            }

            return result;
        }
    }
}
