using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioModulo : RepositorioBase, IRepositorio<Modulo, int>
    {
        public Modulo Find(int numero)
        {
            return base.FetchObject<Modulo>($"SELECT * FROM modulos WHERE Numero = {numero} LIMIT 1;");
        }

        public IEnumerable<Modulo> Find()
        {
            return base.FetchObjects<Modulo>($"SELECT * FROM modulos ORDER BY IdModulo;");
        }

        public IEnumerable<Modulo> Find(string filtro)
        {
            string where;

            if (filtro.IsNullOrEmpty())
                return Find();
            else
                where = $" (1 = 1) ";

            IEnumerable<Modulo> result = base.FetchObjects<Modulo>($"SELECT * FROM modulos WHERE {where} ORDER BY IdModulo;");

            return result;
        }

        public Modulo FindOne(int id)
        {
            return base.FetchObject<Modulo>($"SELECT * FROM modulos WHERE IdModulo = {id};");
        }

        public bool ExisteModulo(int numero, int idModulo)
        {
            return base.FetchObject<int>($"SELECT COUNT(0) FROM modulos WHERE Numero = {numero} AND IdModulo <> {idModulo};") > 0;
        }

        public bool ExisteModulo(int numero)
        {
            return base.FetchObject<int>($"SELECT COUNT(0) FROM modulos WHERE Numero = {numero};") > 0;
        }

        public bool ExisteCartonSerie(int carton, string serie, int idModulo)
        {
            return base.FetchObject<int>($"SELECT COUNT(0) FROM modulos WHERE " +
                $"(Carton1 = {carton} AND Serie1 = '{serie}' AND IdModulo <> {idModulo})" +
                $" OR (Carton2 = {carton} AND Serie2 = '{serie}' AND IdModulo <> {idModulo})" +
                $" OR (Carton3 = {carton} AND Serie3 = '{serie}' AND IdModulo <> {idModulo})" +
                $" OR (Carton4 = {carton} AND Serie4 = '{serie}' AND IdModulo <> {idModulo})" +
                $" OR (Carton5 = {carton} AND Serie5 = '{serie}' AND IdModulo <> {idModulo})" +
                $" OR (Carton6 = {carton} AND Serie6 = '{serie}' AND IdModulo <> {idModulo});") > 0;
        }

        public IEnumerable<Modulo> FindOnes(int[] ids)
        {
            return base.FetchObjects<Modulo>($"SELECT * FROM modulos WHERE IdModulo IN {string.Join(",", ids)};");
        }

        public int Insert(Modulo objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearModulo", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parNumero", objEntidad.Numero));
                command.Parameters.Add(new MySqlParameter("parCarton1", objEntidad.Carton1));
                command.Parameters.Add(new MySqlParameter("parSerie1", objEntidad.Serie1));
                command.Parameters.Add(new MySqlParameter("parCarton2", objEntidad.Carton2));
                command.Parameters.Add(new MySqlParameter("parSerie2", objEntidad.Serie2));
                command.Parameters.Add(new MySqlParameter("parCarton3", objEntidad.Carton3));
                command.Parameters.Add(new MySqlParameter("parSerie3", objEntidad.Serie3));
                command.Parameters.Add(new MySqlParameter("parCarton4", objEntidad.Carton4));
                command.Parameters.Add(new MySqlParameter("parSerie4", objEntidad.Serie4));
                command.Parameters.Add(new MySqlParameter("parCarton5", objEntidad.Carton5));
                command.Parameters.Add(new MySqlParameter("parSerie5", objEntidad.Serie5));
                command.Parameters.Add(new MySqlParameter("parCarton6", objEntidad.Carton6));
                command.Parameters.Add(new MySqlParameter("parSerie6", objEntidad.Serie6));

                command.Parameters.Add(new MySqlParameter("outIdModulo", MySqlDbType.Int32));
                command.Parameters["outIdModulo"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                result = (int)command.Parameters["outIdModulo"].Value;
                command.Connection.Close();
            }

            return result;
        }

        public int Update(Modulo objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarModulo", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdModulo", objEntidad.IdModulo));
                command.Parameters.Add(new MySqlParameter("parNumero", objEntidad.Numero));
                command.Parameters.Add(new MySqlParameter("parCarton1", objEntidad.Carton1));
                command.Parameters.Add(new MySqlParameter("parSerie1", objEntidad.Serie1));
                command.Parameters.Add(new MySqlParameter("parCarton2", objEntidad.Carton2));
                command.Parameters.Add(new MySqlParameter("parSerie2", objEntidad.Serie2));
                command.Parameters.Add(new MySqlParameter("parCarton3", objEntidad.Carton3));
                command.Parameters.Add(new MySqlParameter("parSerie3", objEntidad.Serie3));
                command.Parameters.Add(new MySqlParameter("parCarton4", objEntidad.Carton4));
                command.Parameters.Add(new MySqlParameter("parSerie4", objEntidad.Serie4));
                command.Parameters.Add(new MySqlParameter("parCarton5", objEntidad.Carton5));
                command.Parameters.Add(new MySqlParameter("parSerie5", objEntidad.Serie5));
                command.Parameters.Add(new MySqlParameter("parCarton6", objEntidad.Carton6));
                command.Parameters.Add(new MySqlParameter("parSerie6", objEntidad.Serie6));

                command.ExecuteNonQuery();
                result = objEntidad.IdModulo;
                command.Connection.Close();
            }

            return result;
        }
    }
}
