using System;
using System.Collections.Generic;
using System.Linq;
using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioProgramacionJuegoHojaDevuelta : RepositorioBase, IRepositorio<ProgramacionJuegoHojaDevuelta, int>
    {
        private readonly string mTabla = "programacionjuegoshojasdevueltas";

        public RepositorioProgramacionJuegoHojaDevuelta(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<ProgramacionJuegoHojaDevuelta> Find()
        {
            IEnumerable<ProgramacionJuegoHojaDevuelta> result = base.FetchObjects<ProgramacionJuegoHojaDevuelta>($"SELECT * FROM {mTabla};");

            return result;
        }

        public IEnumerable<ProgramacionJuegoHojaDevuelta> Find(int pId)
        {
            IEnumerable<ProgramacionJuegoHojaDevuelta> result = base.FetchObjects<ProgramacionJuegoHojaDevuelta>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuego = {pId} AND Estado = 'A';");

            return result;
        }

        public ProgramacionJuegoHojaDevuelta FindOne(int id)
        {
            return base.FetchObject<ProgramacionJuegoHojaDevuelta>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuegoHojaDevuelta = {id};");
        }

        public ProgramacionJuegoHojaDevuelta FindOne(int pIdProgramacionJuego, int pNumeroHoja, string pEstado)
        {
            return base.FetchObject<ProgramacionJuegoHojaDevuelta>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuego = {pIdProgramacionJuego} AND NumeroHoja = {pNumeroHoja} AND Estado = '{pEstado}'");
        }

        public IEnumerable<ProgramacionJuegoHojaDevuelta> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProgramacionJuegoHojaDevuelta objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearProgramacionJuegoHojaDevueltas", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));                
                command.Parameters.Add(new MySqlParameter("parNumeroHoja", objEntidad.NumeroHoja));

                command.Parameters.Add(new MySqlParameter("outIdProgramacionJuegoHojaDevuelta", MySqlDbType.Int32));
                command.Parameters["outIdProgramacionJuegoHojaDevuelta"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdProgramacionJuegoHojaDevuelta = (int)command.Parameters["outIdProgramacionJuegoHojaDevuelta"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdProgramacionJuegoHojaDevuelta;
        }

        public int Update(ProgramacionJuegoHojaDevuelta objEntidad)
        {
            var registroActual = FindOne(objEntidad.IdProgramacionJuegoHojaDevuelta);

            /// TODO Implementar la modificación del registro.

            InsertAudit(mTabla, ActionModify, objEntidad, registroActual);

            return objEntidad.IdProgramacionJuegoHojaDevuelta;
        }

        public void Deshabilitar(int pIdProgramacionJuego)
        {
            string query = $"UPDATE {mTabla} SET Estado = 'I' WHERE IdProgramacionJuego = {pIdProgramacionJuego} AND Estado = 'A';";
            
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }            
        }

        public void Deshabilitar(int pIdProgramacionJuego, int pNumeroHoja)
        {
            string query = $"UPDATE {mTabla} SET Estado = 'I' WHERE IdProgramacionJuego = {pIdProgramacionJuego} AND Estado = 'A' AND NumeroHoja = {pNumeroHoja};";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }
    }
}


