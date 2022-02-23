using Caja.Entidades;
using Caja.Entidades.Vistas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioIngresoProgramacionJuego : RepositorioBase, IRepositorio<IngresoProgramacionJuego, int>
    {
        private readonly string mTabla = "gastosprogramacionjuegos";

        public RepositorioIngresoProgramacionJuego(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<VistaIngresosProgramacionJuego> Find(int pIdProgramacion)
        {
            IEnumerable<VistaIngresosProgramacionJuego> result = base.FetchObjects<VistaIngresosProgramacionJuego>($"SELECT * FROM vingresosprogramacionjuego WHERE IdProgramacionJuego = {pIdProgramacion} AND Estado = 'A';");

            return result;
        }

        public IEnumerable<VistaIngresosProgramacionJuego> Find(int pIdProgramacion, int pIdUsuario)
        {
            IEnumerable<VistaIngresosProgramacionJuego> result = base.FetchObjects<VistaIngresosProgramacionJuego>($"SELECT * FROM vingresosprogramacionjuego WHERE IdProgramacionJuego = {pIdProgramacion} AND IdUsuario = {pIdUsuario} AND Estado = 'A';");

            return result;
        }

        public IEnumerable<IngresoProgramacionJuego> Find()
        {
            throw new NotImplementedException();
        }

        public IngresoProgramacionJuego FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IngresoProgramacionJuego> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public ConceptoIngreso ObtenerConceptoIngreso(int pIdConcepto)
        {
            return base.FetchObject<ConceptoIngreso>($"SELECT * FROM conceptoingresos WHERE IdConceptoIngreso = {pIdConcepto} LIMIT 1;");
        }
        public int Insert(IngresoProgramacionJuego objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearIngresoProgramacionJuego", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parIdUsuario", objEntidad.IdUsuario));
                command.Parameters.Add(new MySqlParameter("parIdConceptoIngreso", objEntidad.IdConceptoIngreso));
                command.Parameters.Add(new MySqlParameter("parDescripcion", objEntidad.Descripcion));
                command.Parameters.Add(new MySqlParameter("parValor", objEntidad.Valor));
                
                command.Parameters.Add(new MySqlParameter("outIdIngresoJuego", MySqlDbType.Int32));
                command.Parameters["outIdIngresoJuego"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdIngresoJuego = (int)command.Parameters["outIdIngresoJuego"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdIngresoJuego;
        }

        public int Update(IngresoProgramacionJuego objEntidad)
        {
            throw new NotImplementedException();
        }
    }
}


