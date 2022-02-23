using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioNominaDescuento : RepositorioBase, IRepositorio<NominaDescuento, int>
    {
        private readonly string mTabla = "nominadescuentos";

        public RepositorioNominaDescuento(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<NominaDescuento> Find()
        {
            throw new NotImplementedException();
        }

        public NominaDescuento FindOne(int id)
        {
            NominaDescuento result = base.FetchObject<NominaDescuento>($"SELECT * FROM {mTabla} WHERE IdNominaDescuento = {id} LIMIT 1;");
            return result;
        }

        public IEnumerable<NominaDescuento> Find(int mIdProgamacionJuego, int mIdUsuario)
        {
            IEnumerable<NominaDescuento> result = base.FetchObjects<NominaDescuento>($"SELECT * FROM {mTabla} WHERE Estado = 'A' AND IdProgramacionJuego = {mIdProgamacionJuego} AND IdUsuario = {mIdUsuario};");
            return result;
        }

        public int Insert(NominaDescuento objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearNominaDescuentos", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parIdUsuario", objEntidad.IdUsuario));
                command.Parameters.Add(new MySqlParameter("parMes", objEntidad.Mes));
                command.Parameters.Add(new MySqlParameter("parAnio", objEntidad.Anio));
                command.Parameters.Add(new MySqlParameter("parConcepto", objEntidad.Concepto));
                command.Parameters.Add(new MySqlParameter("parCobrado", objEntidad.Cobrado));
                command.Parameters.Add(new MySqlParameter("parValor", objEntidad.Valor));

                command.Parameters.Add(new MySqlParameter("outIdNominaDescuento", MySqlDbType.Int32));
                command.Parameters["outIdNominaDescuento"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdNominaDescuento = (int)command.Parameters["outIdNominaDescuento"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdNominaDescuento;
        }

        public int Update(NominaDescuento objEntidad)
        {
            throw new NotImplementedException();
        }
    }
}

