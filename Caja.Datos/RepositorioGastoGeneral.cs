using Caja.Entidades;
using Caja.Entidades.Vistas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioGastoGeneral : RepositorioBase, IRepositorio<GastoGeneral, int>
    {
        private readonly string mTabla = "gastosgenerales";

        public RepositorioGastoGeneral(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<VistaGastoGeneral> Find(byte pMes, short pAnio)
        {
            IEnumerable<VistaGastoGeneral> result = base.FetchObjects<VistaGastoGeneral>($"SELECT * FROM vgastosgenerales WHERE Estado = 'A' AND Mes = {pMes} AND Anio = {pAnio};");

            return result;
        }

        public IEnumerable<GastoGeneral> Find()
        {
            throw new NotImplementedException();
        }

        public GastoGeneral FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GastoGeneral> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public double CalularTotalGastado(int pIdConcepto, byte pMes, short pAnio)
        {
            string sql = $"SELECT COALESCE(SUM(Valor), 0) AS Valor FROM {mTabla} WHERE Estado = 'A' AND IdConceptoGasto = {pIdConcepto} AND Mes = {pMes} AND Anio = {pAnio};";

            return base.FetchObject<double>(sql);
        }

        public ConceptoGasto ObtenerConceptoGasto(int pIdConcepto)
        {
            return base.FetchObject<ConceptoGasto>($"SELECT * FROM conceptogastos WHERE IdConceptoGasto = {pIdConcepto} LIMIT 1;");
        }

        public int Insert(GastoGeneral objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearGastoGeneral", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                                
                command.Parameters.Add(new MySqlParameter("parIdUsuario", objEntidad.IdUsuario));
                command.Parameters.Add(new MySqlParameter("parIdConceptoGasto", objEntidad.IdConceptoGasto));
                command.Parameters.Add(new MySqlParameter("parDescripcion", objEntidad.Descripcion));
                command.Parameters.Add(new MySqlParameter("parValor", objEntidad.Valor));
                command.Parameters.Add(new MySqlParameter("parSocio", objEntidad.Socio));
                command.Parameters.Add(new MySqlParameter("parFechaRegistro", objEntidad.FechaRegistro));
                command.Parameters.Add(new MySqlParameter("parMes", objEntidad.Mes));
                command.Parameters.Add(new MySqlParameter("parAnio", objEntidad.Anio));
                command.Parameters.Add(new MySqlParameter("parOrigenPago", objEntidad.OrigenPago));

                command.Parameters.Add(new MySqlParameter("outIdGastoGeneral", MySqlDbType.Int32));
                command.Parameters["outIdGastoGeneral"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdGastoGeneral = (int)command.Parameters["outIdGastoGeneral"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdGastoGeneral;
        }

        public int Update(GastoGeneral objEntidad)
        {
            throw new NotImplementedException();
        }
    }
}

