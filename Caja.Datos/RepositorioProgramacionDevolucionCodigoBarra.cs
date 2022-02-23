using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioProgramacionDevolucionCodigoBarra : RepositorioBase, IRepositorio<ProgramacionDevolucionCodigoBarra, int>
    {
        private readonly string mTabla = "programaciondevolucioncodigobarras";

        public RepositorioProgramacionDevolucionCodigoBarra(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<ProgramacionDevolucionCodigoBarra> Find()
        {
            IEnumerable<ProgramacionDevolucionCodigoBarra> result = base.FetchObjects<ProgramacionDevolucionCodigoBarra>($"SELECT * FROM {mTabla};");

            return result;
        }

        public IEnumerable<ProgramacionDevolucionCodigoBarra> FindByVendedor(int pIdVendedor, int pIdProgramacion)
        {
            return base.FetchObjects<ProgramacionDevolucionCodigoBarra>($"SELECT * FROM {mTabla} WHERE IdVendedor = {pIdVendedor} AND IdProgramacionJuego = {pIdProgramacion};");
        }

        public IEnumerable<ProgramacionDevolucionCodigoBarra> FindByProgramacion(int id)
        {
            return base.FetchObjects<ProgramacionDevolucionCodigoBarra>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuego = {id};");
        }

        public ProgramacionDevolucionCodigoBarra FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProgramacionDevolucionCodigoBarra> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProgramacionDevolucionCodigoBarra objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearDevolucionCodigoBarra", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parIdVendedor", objEntidad.IdVendedor));
                command.Parameters.Add(new MySqlParameter("parHojaCarton", objEntidad.HojaCarton));               

                command.Parameters.Add(new MySqlParameter("outIdDevolucionCodigoBarra", MySqlDbType.Int32));
                command.Parameters["outIdDevolucionCodigoBarra"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdDevolucionCodigoBarra = (int)command.Parameters["outIdDevolucionCodigoBarra"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdDevolucionCodigoBarra;
        }

        public int Update(ProgramacionDevolucionCodigoBarra objEntidad)
        {
            var registroActual = FindOne(objEntidad.IdDevolucionCodigoBarra);

            /// TODO Implementar la modificación del registro.

            InsertAudit(mTabla, ActionModify, objEntidad, registroActual);

            return objEntidad.IdDevolucionCodigoBarra;
        }

        public void Delete(int pIdVendedor, int pIdProgramacion)
        {
            string query = $"DELETE FROM {mTabla} WHERE IdVendedor = {pIdVendedor} AND IdProgramacionJuego = {pIdProgramacion};";
            
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }
    }
}


