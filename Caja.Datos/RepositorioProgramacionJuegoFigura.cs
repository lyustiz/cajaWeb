using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioProgramacionJuegoFigura : RepositorioBase, IRepositorio<ProgramacionJuegoFigura, int>
    {
        private readonly string mTabla = "programacionjuegosfiguras";

        public RepositorioProgramacionJuegoFigura(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<ProgramacionJuegoFigura> Find()
        {
            IEnumerable<ProgramacionJuegoFigura> result = base.FetchObjects<ProgramacionJuegoFigura>($"SELECT * FROM {mTabla} ORDER BY IdProgramacionJuegoFigura DESC;");

            return result;
        }

        public IEnumerable<ProgramacionJuegoFigura> Find(int pIdProgramacion)
        {
            IEnumerable<ProgramacionJuegoFigura> result = base.FetchObjects<ProgramacionJuegoFigura>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuego = {pIdProgramacion} ORDER BY IdProgramacionJuegoFigura DESC;");

            return result;
        }

        public IEnumerable<ProgramacionJuegoFigura> Find(string filtro)
        {
            if (filtro.IsNullOrEmpty())
                return Find();

            IEnumerable<ProgramacionJuegoFigura> result = base.FetchObjects<ProgramacionJuegoFigura>($"SELECT * FROM {mTabla} WHERE {filtro} ORDER BY IdProgramacionJuegoFigura DESC;");

            return result;
        }

        public ProgramacionJuegoFigura FindOne(int id)
        {
            return base.FetchObject<ProgramacionJuegoFigura>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuegoFigura = {id} LIMIT 1;");
        }

        public int Insert(ProgramacionJuegoFigura objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearProgramacionJuegoFigura", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parIdPlenoAutomatico", objEntidad.IdPlenoAutomatico));
                command.Parameters.Add(new MySqlParameter("parValorPremio", objEntidad.ValorPremio));

                command.Parameters.Add(new MySqlParameter("outIdProgramacionJuegoFigura", MySqlDbType.Int32));
                command.Parameters["outIdProgramacionJuegoFigura"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdProgramacionJuegoFigura = (int)command.Parameters["outIdProgramacionJuegoFigura"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdProgramacionJuegoFigura;
        }

        public int Update(ProgramacionJuegoFigura objEntidad)
        {
            throw new NotImplementedException();
        }

        public void Deshabilitar(int id)
        {
            ProgramacionJuegoFigura registroActual = FindOne(id);

            string query = $"UPDATE ProgramacionJuegosFiguras SET Estado = 'I' WHERE IdProgramacionJuegoFigura = {id};";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            var registroNuevo = (ProgramacionJuegoFigura)registroActual.Clone();
            registroNuevo.Estado = "I";

            InsertAudit(mTabla, ActionStatus, registroNuevo, registroActual);
        }
    }
}


