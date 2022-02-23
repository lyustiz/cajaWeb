using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja.Datos
{
    public sealed class RepositorioProgramacionJuegoDinero : RepositorioBase, IRepositorio<ProgramacionJuegoDinero, int>
    {
        private readonly string mTabla = "programacionjuegosdineros";

        public RepositorioProgramacionJuegoDinero(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<ProgramacionJuegoDinero> Find()
        {
            IEnumerable<ProgramacionJuegoDinero> result = base.FetchObjects<ProgramacionJuegoDinero>($"SELECT * FROM {mTabla};");

            return result;
        }

        public ProgramacionJuegoDinero FindOne(int id)
        {
            ProgramacionJuegoDinero result = base.FetchObject<ProgramacionJuegoDinero>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuegoDinero = {id};");

            return result;
        }

        public ProgramacionJuegoDinero FindByProgramacion(int id)
        {
            ProgramacionJuegoDinero result = base.FetchObject<ProgramacionJuegoDinero>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuego = {id} AND Estado = 'A';");

            return result;
        }

        public IEnumerable<ProgramacionJuegoDinero> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProgramacionJuegoDinero objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearProgramacionJuegoDinero", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parTotalCartones", objEntidad.TotalCartones));
                command.Parameters.Add(new MySqlParameter("parAsistenciaSocial", objEntidad.AsistenciaSocial));
                command.Parameters.Add(new MySqlParameter("parTotalVentas", objEntidad.TotalVentas));
                command.Parameters.Add(new MySqlParameter("parTotalCuentasCobrar", objEntidad.TotalCuentasCobrar));
                command.Parameters.Add(new MySqlParameter("parTotalRecaudoJuego", objEntidad.TotalRecaudoJuego));
                command.Parameters.Add(new MySqlParameter("parDineroBanco", objEntidad.DineroBanco));
                command.Parameters.Add(new MySqlParameter("parEfectivo", objEntidad.Efectivo));
                
                command.Parameters.Add(new MySqlParameter("outIdProgramacionJuegoDinero", MySqlDbType.Int32));
                command.Parameters["outIdProgramacionJuegoDinero"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdProgramacionJuegoDinero = (int)command.Parameters["outIdProgramacionJuegoDinero"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdProgramacionJuegoDinero;
        }

        public int Update(ProgramacionJuegoDinero objEntidad)
        {
            var registroActual = FindByProgramacion(objEntidad.IdProgramacionJuego);

            string query = $"UPDATE {mTabla} SET dinerobanco = {objEntidad.DineroBanco}, Efectivo = {objEntidad.Efectivo}, CerradoBanco = 'C' WHERE IdProgramacionJuego = {objEntidad.IdProgramacionJuego} AND Estado = 'A';";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionModify, objEntidad, registroActual);

            return objEntidad.IdProgramacionJuegoDinero;
        }

        public void Deshabilitar(int pIdProgramacion)
        {
            string query = $"UPDATE {mTabla} SET Estado = 'I' WHERE IdProgramacionJuego = {pIdProgramacion} AND Estado = 'A';";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
        }
    }
}
