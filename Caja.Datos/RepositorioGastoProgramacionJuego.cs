using Caja.Entidades;
using Caja.Entidades.Vistas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioGastoProgramacionJuego : RepositorioBase, IRepositorio<GastoProgramacionJuego, int>
    {
        private readonly string mTabla = "gastosprogramacionjuegos";

        public RepositorioGastoProgramacionJuego(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<VistaGastosProgramacionJuego> Find(int pIdProgramacion)
        {
            IEnumerable<VistaGastosProgramacionJuego> result = base.FetchObjects<VistaGastosProgramacionJuego>($"SELECT * FROM vgastosprogramacionjuego WHERE IdProgramacionJuego = {pIdProgramacion} AND Estado = 'A';");

            return result;
        }

        public IEnumerable<VistaGastosProgramacionJuego> Find(int pIdProgramacion, int pIdUsuario)
        {
            IEnumerable<VistaGastosProgramacionJuego> result = base.FetchObjects<VistaGastosProgramacionJuego>($"SELECT * FROM vgastosprogramacionjuego WHERE IdProgramacionJuego = {pIdProgramacion} AND IdUsuario = {pIdUsuario} AND Estado = 'A';");

            return result;
        }

        public IEnumerable<GastoProgramacionJuego> Find()
        {
            throw new NotImplementedException();
        }

        public GastoProgramacionJuego FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GastoProgramacionJuego> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public decimal CalularTotalGastado(int pIdConcepto, int mMes, int mAnio)
        {
            string sql = $"SELECT COALESCE(SUM(Valor), 0) AS Valor FROM gastosprogramacionjuegos WHERE Estado = 'A' AND IdConceptoGasto = {pIdConcepto} " +
                $"AND IdProgramacionJuego BETWEEN" +
                $"(SELECT COALESCE(MIN(IdProgramacionJuego), 0)  FROM programacionjuegos WHERE MONTH(FechaProgramada) = {mMes} AND YEAR(FechaProgramada) = {mAnio}) " +
                $"AND" +
                $"(SELECT COALESCE(MAX(IdProgramacionJuego), 0) FROM programacionjuegos WHERE MONTH(FechaProgramada) = {mMes} AND YEAR(FechaProgramada) = {mAnio});";

            return base.FetchObject<decimal>(sql);
        }

        public ConceptoGasto ObtenerConceptoGasto(int pIdConcepto)
        {
            return base.FetchObject<ConceptoGasto>($"SELECT * FROM conceptogastos WHERE IdConceptoGasto = {pIdConcepto} LIMIT 1;");
        }

        public int Insert(GastoProgramacionJuego objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearGastoProgramacionJuego", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parIdUsuario", objEntidad.IdUsuario));
                command.Parameters.Add(new MySqlParameter("parIdConceptoGasto", objEntidad.IdConceptoGasto));
                command.Parameters.Add(new MySqlParameter("parDescripcion", objEntidad.Descripcion));
                command.Parameters.Add(new MySqlParameter("parValor", objEntidad.Valor));
                command.Parameters.Add(new MySqlParameter("parSocio", objEntidad.Socio));

                command.Parameters.Add(new MySqlParameter("outIdGastoJuego", MySqlDbType.Int32));
                command.Parameters["outIdGastoJuego"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdGastoJuego = (int)command.Parameters["outIdGastoJuego"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdGastoJuego;
        }

        public int Update(GastoProgramacionJuego objEntidad)
        {
            throw new NotImplementedException();
        }
    }
}

