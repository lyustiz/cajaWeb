using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioConceptoGasto : RepositorioBase, IRepositorio<ConceptoGasto, int>
    {
        public IEnumerable<ConceptoGasto> Find()
        {
            return base.FetchObjects<ConceptoGasto>($"SELECT * FROM conceptogastos ORDER BY IdConceptoGasto;");
        }

        public IEnumerable<ConceptoGasto> FindEstadistica()
        {
            return base.FetchObjects<ConceptoGasto>($"SELECT * FROM conceptogastos WHERE Valor <> 0 OR ValorMaximo <> 0 ORDER BY Valor DESC, ValorMaximo DESC;");
        }

        public ConceptoGasto FindOne(int id)
        {
            return base.FetchObject<ConceptoGasto>($"SELECT * FROM conceptogastos WHERE IdConceptoGasto = {id} LIMIT 1;");
        }

        public IEnumerable<ConceptoGasto> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int Insert(ConceptoGasto objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearConceptoGasto", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("parIdConceptoGasto", objEntidad.IdConceptoGasto));
                command.Parameters.Add(new MySqlParameter("parDescripcion", objEntidad.Descripcion));
                command.Parameters.Add(new MySqlParameter("parValor", objEntidad.Valor));
                command.Parameters.Add(new MySqlParameter("parValorMaximo", objEntidad.ValorMaximo));
                command.Parameters.Add(new MySqlParameter("parControlado", objEntidad.Controlado));
                command.Parameters.Add(new MySqlParameter("parSocios", objEntidad.Socios));

                result = command.ExecuteNonQuery();
                command.Connection.Close();
            }

            return result;
        }

        public int Update(ConceptoGasto objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarConceptoGasto", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("parIdConceptoGasto", objEntidad.IdConceptoGasto));
                command.Parameters.Add(new MySqlParameter("parDescripcion", objEntidad.Descripcion));
                command.Parameters.Add(new MySqlParameter("parValor", objEntidad.Valor));
                command.Parameters.Add(new MySqlParameter("parValorMaximo", objEntidad.ValorMaximo));
                command.Parameters.Add(new MySqlParameter("parControlado", objEntidad.Controlado));
                command.Parameters.Add(new MySqlParameter("parSocios", objEntidad.Socios));

                result = command.ExecuteNonQuery();
                command.Connection.Close();
            }

            return result;
        }
    }
}
