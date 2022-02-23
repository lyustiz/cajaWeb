using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioRecaudoDetalle : RepositorioBase, IRepositorio<RecaudoDetalle, int>
    {
        private readonly string mTabla = "recaudodetalles";

        public RepositorioRecaudoDetalle(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<RecaudoDetalle> Find()
        {
            throw new NotImplementedException();
        }

        public RecaudoDetalle FindOne(int id)
        {
            RecaudoDetalle result = base.FetchObject<RecaudoDetalle>($"SELECT * FROM {mTabla} WHERE IdRecaudoDetalle = {id} LIMIT 1;");

            return result;
        }

        public IEnumerable<RecaudoDetalle> Find(int mIdProgamacionJuego)
        {
            IEnumerable<RecaudoDetalle> result = base.FetchObjects<RecaudoDetalle>($"SELECT * FROM {mTabla} WHERE Estado = 'A' AND IdProgramacionJuego = {mIdProgamacionJuego};");

            return result;
        }

        public IEnumerable<RecaudoDetalle> Find(int mIdProgamacionJuego, int mIdUsuario)
        {
            IEnumerable<RecaudoDetalle> result = base.FetchObjects<RecaudoDetalle>($"SELECT * FROM {mTabla} WHERE Estado = 'A' AND IdProgramacionJuego = {mIdProgamacionJuego} AND IdUsuario = {mIdUsuario};");

            return result;
        }

        public int Insert(RecaudoDetalle objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearRecaudoDetalle", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parIdUsuario", objEntidad.IdUsuario));
                command.Parameters.Add(new MySqlParameter("parIdDefinicionMoneda", objEntidad.IdDefinicionMoneda));
                command.Parameters.Add(new MySqlParameter("parCantidad", objEntidad.Cantidad));
                command.Parameters.Add(new MySqlParameter("parTotalRecaudo", objEntidad.TotalRecaudo));

                command.Parameters.Add(new MySqlParameter("outIdRecaudoDetalle", MySqlDbType.Int32));
                command.Parameters["outIdRecaudoDetalle"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdRecaudoDetalle = (int)command.Parameters["outIdRecaudoDetalle"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdRecaudoDetalle;
        }

        public int Update(RecaudoDetalle objEntidad)
        {
            throw new NotImplementedException();
        }
    }
}
