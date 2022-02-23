using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioRecaudoTotal : RepositorioBase, IRepositorio<RecaudoTotal, int>
    {
        private readonly string mTabla = "recaudototales";

        public RepositorioRecaudoTotal(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<RecaudoTotal> Find()
        {
            throw new NotImplementedException();
        }

        public RecaudoTotal FindOne(int id)
        {
            RecaudoTotal result = base.FetchObject<RecaudoTotal>($"SELECT '' AS NombreUsuario, r.* FROM {mTabla} r WHERE r.IdRecaudoTotal = {id} LIMIT 1;");

            return result;
        }

        public RecaudoTotal FindOne(int mIdProgamacionJuego, int mIdUsuario)
        {
            RecaudoTotal result = base.FetchObject<RecaudoTotal>($"SELECT '' AS NombreUsuario, r.* FROM {mTabla} r WHERE r.Estado = 'A' AND r.IdProgramacionJuego = {mIdProgamacionJuego} AND r.IdUsuario = {mIdUsuario} LIMIT 1;");

            return result;
        }

        public IEnumerable<RecaudoTotal> Find(int mIdProgamacionJuego)
        {
            IEnumerable<RecaudoTotal> result = base.FetchObjects<RecaudoTotal>($"SELECT '' AS NombreUsuario, r.* FROM {mTabla} r WHERE r.Estado = 'A' AND r.IdProgramacionJuego = {mIdProgamacionJuego};");

            return result;
        }

        public IEnumerable<RecaudoTotal> Find(int mIdProgamacionJuego, int mIdUsuario)
        {
            IEnumerable<RecaudoTotal> result = base.FetchObjects<RecaudoTotal>($"SELECT '' AS NombreUsuario, r.* FROM {mTabla} r WHERE r.Estado = 'A' AND r.IdProgramacionJuego = {mIdProgamacionJuego} AND r.IdUsuario = {mIdUsuario};");

            return result;
        }

        public int Insert(RecaudoTotal objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearRecaudoTotal", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parIdUsuario", objEntidad.IdUsuario));
                command.Parameters.Add(new MySqlParameter("parRecaudoTotal", objEntidad.RecuadoTotal));
                command.Parameters.Add(new MySqlParameter("parValorRecaudoCalculado", objEntidad.ValorRecaudoCalculado));
                command.Parameters.Add(new MySqlParameter("parDiferencia", objEntidad.Diferencia));
                command.Parameters.Add(new MySqlParameter("parIncluirGastosGenerales", objEntidad.IncluirGastosGenerales));
                command.Parameters.Add(new MySqlParameter("parGastos", objEntidad.Gastos));
                command.Parameters.Add(new MySqlParameter("parIngresos", objEntidad.Ingresos));
                command.Parameters.Add(new MySqlParameter("parRegistroGastos", objEntidad.RegistroGastos));
                command.Parameters.Add(new MySqlParameter("parRegistroIngresos", objEntidad.RegistroIngresos));

                command.Parameters.Add(new MySqlParameter("outIdRecaudoTotal", MySqlDbType.Int32));
                command.Parameters["outIdRecaudoTotal"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdRecaudoTotal = (int)command.Parameters["outIdRecaudoTotal"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdRecaudoTotal;
        }

        public int Update(RecaudoTotal objEntidad)
        {
            RecaudoTotal registroActual = FindOne(objEntidad.IdRecaudoTotal);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarRecaudoTotal", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdRecaudoTotal", objEntidad.IdRecaudoTotal));
                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parIdUsuario", objEntidad.IdUsuario));
                command.Parameters.Add(new MySqlParameter("parRecaudoTotal", objEntidad.RecuadoTotal));
                command.Parameters.Add(new MySqlParameter("parValorRecaudoCalculado", objEntidad.ValorRecaudoCalculado));
                command.Parameters.Add(new MySqlParameter("parDiferencia", objEntidad.Diferencia));
                command.Parameters.Add(new MySqlParameter("parIncluirGastosGenerales", objEntidad.IncluirGastosGenerales));
                command.Parameters.Add(new MySqlParameter("parGastos", objEntidad.Gastos));
                command.Parameters.Add(new MySqlParameter("parIngresos", objEntidad.Ingresos));
                command.Parameters.Add(new MySqlParameter("parRegistroGastos", objEntidad.RegistroGastos));
                command.Parameters.Add(new MySqlParameter("parRegistroIngresos", objEntidad.RegistroIngresos));

                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionModify, objEntidad, registroActual);

            return objEntidad.IdRecaudoTotal;
        }
    }
}
