using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioPorcentajePremio : RepositorioBase, IRepositorio<PorcentajePremio, int>
    {
        public IEnumerable<PorcentajePremio> Find()
        {
            throw new NotImplementedException();
        }

        public PorcentajePremio FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public PorcentajePremio FindOne()
        {
            return base.FetchObject<PorcentajePremio>($"SELECT * FROM porcentajepremios WHERE Estado = 'A' LIMIT 1;");
        }

        public IEnumerable<PorcentajePremio> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int Insert(PorcentajePremio objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearProcentajesPremios", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("parP1C", objEntidad.Premio1Cartones));
                command.Parameters.Add(new MySqlParameter("parP1P", objEntidad.Premio1Porcentaje));
                command.Parameters.Add(new MySqlParameter("parP2C", objEntidad.Premio2Cartones));
                command.Parameters.Add(new MySqlParameter("parP2P", objEntidad.Premio2Porcentaje));
                command.Parameters.Add(new MySqlParameter("parP3C", objEntidad.Premio3Cartones));
                command.Parameters.Add(new MySqlParameter("parP3P", objEntidad.Premio3Porcentaje));
                command.Parameters.Add(new MySqlParameter("parP4C", objEntidad.Premio4Cartones));
                command.Parameters.Add(new MySqlParameter("parP4P", objEntidad.Premio4Porcentaje));
                command.Parameters.Add(new MySqlParameter("parP5C", objEntidad.Premio5Cartones));
                command.Parameters.Add(new MySqlParameter("parP5P", objEntidad.Premio5Porcentaje));
                command.Parameters.Add(new MySqlParameter("parIdUsuario", objEntidad.IdUsuario));
                command.Parameters.Add(new MySqlParameter("parActivoDescuento", objEntidad.ActivoDescuento));

                command.Parameters.Add(new MySqlParameter("outIdProcentajePremio", MySqlDbType.Int32));
                command.Parameters["outIdProcentajePremio"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                result = (int)command.Parameters["outIdProcentajePremio"].Value;
                command.Connection.Close();
            }

            return result;
        }

        public int Update(PorcentajePremio objEntidad)
        {
            throw new NotImplementedException();
        }
    }
}
