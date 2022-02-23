using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioFlujoCaja : RepositorioBase, IRepositorio<FlujoCaja, int>
    {
        private readonly string mTabla = "flujocaja";

        public RepositorioFlujoCaja(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<FlujoCaja> Find()
        {
            IEnumerable<FlujoCaja> result = base.FetchObjects<FlujoCaja>($"SELECT * FROM {mTabla} ORDER BY IdFlujoCaja;");

            return result;
        }

        public FlujoCaja FindOne(int id)
        {
            return base.FetchObject<FlujoCaja>($"SELECT * FROM {mTabla} WHERE IdFlujoCaja = {id};");
        }

        public FlujoCaja FindByProgramacion(int pIdProgramacionJuego)
        {
            return base.FetchObject<FlujoCaja>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuego = {pIdProgramacionJuego} AND Estado = 'A';");
        }

        public IEnumerable<FlujoCaja> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int GetMaxId()
        {
            return base.FetchObject<int>($"SELECT COALESCE(MAX(IdFlujoCaja),0) FROM {mTabla} WHERE Estado = 'A';");
        }

        public int Insert(FlujoCaja objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearFlujoCaja", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parValorInicial", objEntidad.ValorInicial));
                command.Parameters.Add(new MySqlParameter("parValorFinal", objEntidad.ValorFinal));
                command.Parameters.Add(new MySqlParameter("parValorInicialBancos", objEntidad.ValorInicialBancos));
                command.Parameters.Add(new MySqlParameter("parValorFinalBancos", objEntidad.ValorFinalBancos));
                command.Parameters.Add(new MySqlParameter("parValorInicialSocial", objEntidad.ValorInicialSocial));
                command.Parameters.Add(new MySqlParameter("parValorFinalSocial", objEntidad.ValorFinalSocial));

                command.Parameters.Add(new MySqlParameter("outIdFlujoCaja", MySqlDbType.Int32));
                command.Parameters["outIdFlujoCaja"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdFlujoCaja = (int)command.Parameters["outIdFlujoCaja"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdFlujoCaja;
        }

        public int InsertHistorial(HistoricoFlujoCaja objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearHistoricoFlujoCaja", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(new MySqlParameter("parIdUsuario", objEntidad.IdUsuario));
                command.Parameters.Add(new MySqlParameter("parMes", objEntidad.Mes));
                command.Parameters.Add(new MySqlParameter("parAnio", objEntidad.Anio));
                command.Parameters.Add(new MySqlParameter("parOrigenPago", objEntidad.OrigenPago));
                command.Parameters.Add(new MySqlParameter("parValor", objEntidad.Valor));
                command.Parameters.Add(new MySqlParameter("parAccion", objEntidad.Accion));                

                command.Parameters.Add(new MySqlParameter("outIdHistoricoFlujoCaja", MySqlDbType.Int32));
                command.Parameters["outIdHistoricoFlujoCaja"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdHistoricoFlujoCaja = (int)command.Parameters["outIdHistoricoFlujoCaja"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdHistoricoFlujoCaja;
        }

        public int Update(FlujoCaja objEntidad)
        {
            FlujoCaja registroActual = FindOne(objEntidad.IdFlujoCaja);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarFlujoCaja", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdFlujoCaja", objEntidad.IdFlujoCaja));
                command.Parameters.Add(new MySqlParameter("parValorInicial", objEntidad.ValorInicial));
                command.Parameters.Add(new MySqlParameter("parValorFinal", objEntidad.ValorFinal));
                command.Parameters.Add(new MySqlParameter("parValorInicialBancos", objEntidad.ValorInicialBancos));
                command.Parameters.Add(new MySqlParameter("parValorFinalBancos", objEntidad.ValorFinalBancos));
                command.Parameters.Add(new MySqlParameter("parValorInicialSocial", objEntidad.ValorInicialSocial));
                command.Parameters.Add(new MySqlParameter("parValorFinalSocial", objEntidad.ValorFinalSocial));

                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionModify, objEntidad, registroActual);

            return objEntidad.IdFlujoCaja;
        }

        public void ModificarValorFinal(int id, string campo, decimal valor)
        {
            string query = $"UPDATE {mTabla} SET {campo} = {valor} WHERE IdFlujoCaja = {id};".Replace(",",".");
            FlujoCaja registroActual = FindOne(id);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            var registroNuevo = FindOne(id);

            InsertAudit(mTabla, ActionModify, registroNuevo, registroActual);
        }

        public void Deshabilitar(int id, string estado)
        {
            string query = $"UPDATE {mTabla} SET Estado = '{estado}' WHERE IdFlujoCaja = {id};";
            FlujoCaja registroActual = FindOne(id);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            var registroNuevo = (FlujoCaja)registroActual.Clone();
            registroNuevo.Estado = estado;

            InsertAudit(mTabla, ActionStatus, registroNuevo, registroActual);
        }
    }
}

