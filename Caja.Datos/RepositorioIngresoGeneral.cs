using Caja.Entidades;
using Caja.Entidades.Vistas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioIngresoGeneral : RepositorioBase, IRepositorio<IngresoGeneral, int>
    {
        private readonly string mTabla = "ingresosgenerales";

        public RepositorioIngresoGeneral(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<VistaIngresoGeneral> Find(byte pMes, short pAnio)
        {
            IEnumerable<VistaIngresoGeneral> result = base.FetchObjects<VistaIngresoGeneral>($"SELECT * FROM vingresosgenerales WHERE Estado = 'A' AND Mes = {pMes} AND Anio = {pAnio};");

            return result;
        }

        public IEnumerable<IngresoGeneral> Find()
        {
            throw new NotImplementedException();
        }

        public IngresoGeneral FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IngresoGeneral> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public double CalularTotalGastado(int pIdConcepto, byte pMes, short pAnio)
        {
            string sql = $"SELECT COALESCE(SUM(Valor), 0) AS Valor FROM {mTabla} WHERE Estado = 'A' AND IdConceptoGasto = {pIdConcepto} AND Mes = {pMes} AND Anio = {pAnio};";

            return base.FetchObject<double>(sql);
        }

        public ConceptoIngreso ObtenerConceptoIngreso(int pIdConcepto)
        {
            return base.FetchObject<ConceptoIngreso>($"SELECT * FROM conceptoingresos WHERE IdConceptoIngreso = {pIdConcepto} LIMIT 1;");
        }

        public int Insert(IngresoGeneral objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearIngresoGeneral", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new MySqlParameter("parIdUsuario", objEntidad.IdUsuario));
                command.Parameters.Add(new MySqlParameter("parIdConceptoIngreso", objEntidad.IdConceptoIngreso));
                command.Parameters.Add(new MySqlParameter("parDescripcion", objEntidad.Descripcion));
                command.Parameters.Add(new MySqlParameter("parValor", objEntidad.Valor));
                command.Parameters.Add(new MySqlParameter("parSocio", objEntidad.Socio));
                command.Parameters.Add(new MySqlParameter("parFechaRegistro", objEntidad.FechaRegistro));
                command.Parameters.Add(new MySqlParameter("parMes", objEntidad.Mes));
                command.Parameters.Add(new MySqlParameter("parAnio", objEntidad.Anio));
                command.Parameters.Add(new MySqlParameter("parOrigenPago", objEntidad.OrigenPago));

                command.Parameters.Add(new MySqlParameter("outIdIngresoGeneral", MySqlDbType.Int32));
                command.Parameters["outIdIngresoGeneral"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdIngresoGeneral = (int)command.Parameters["outIdIngresoGeneral"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdIngresoGeneral;
        }

        public int Update(IngresoGeneral objEntidad)
        {
            throw new NotImplementedException();
        }
    }
}


