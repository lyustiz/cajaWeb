using Caja.Entidades;
using Caja.Entidades.Vistas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioProgramacionJuego : RepositorioBase, IRepositorio<ProgramacionJuego, int>
    {
        private readonly string mTabla = "programacionjuegos";

        public RepositorioProgramacionJuego(int pIdUsuario) : base(pIdUsuario)
        {                
        }

        public IEnumerable<ProgramacionJuego> Find()
        {
            IEnumerable<ProgramacionJuego> result = base.FetchObjects<ProgramacionJuego>($"SELECT * FROM {mTabla} ORDER BY IdProgramacionJuego DESC;");

            return result;
        }

        public IEnumerable<ProgramacionJuego> Find(string filtro)
        {
            if (filtro.IsNullOrEmpty())
                return Find();            

            IEnumerable<ProgramacionJuego> result = base.FetchObjects<ProgramacionJuego>($"SELECT * FROM {mTabla} WHERE {filtro} ORDER BY IdProgramacionJuego;");

            return result;
        }

        public IEnumerable<ProgramacionJuego> FindEstadistica(int anio, int mes)
        {
            IEnumerable<ProgramacionJuego> result = base.FetchObjects<ProgramacionJuego>($"SELECT * FROM {mTabla} WHERE YEAR(FechaProgramada) = {anio} AND MONTH(FechaProgramada) = {mes};");

            return result;
        }

        public IEnumerable<VistaProgramacionJuegoVendedores> FindProgramacionJuegoHojas(string filtro)
        {
            string where;

            if (filtro.IsNullOrEmpty())
                where = " 1 = 1 ";
            else
                where = $" (codigo LIKE '%{filtro}%' OR nombres LIKE '%{filtro}%' OR apellidos LIKE '%{filtro}%' OR celular LIKE '%{filtro}%' " +
                    $"OR documento LIKE '%{filtro}%')";

            IEnumerable<VistaProgramacionJuegoVendedores> result = base.FetchObjects<VistaProgramacionJuegoVendedores>($"SELECT * FROM vprogramacionjuegovendedores WHERE {where};");

            return result;
        }

        public IEnumerable<VistaVendedoresProgramacion> FindVendedoresProgramacion(string filtro, int pIdProgramacionJuego)
        {
            string where;

            if (filtro.IsNullOrEmpty())
                where = " 1 = 1 ";
            else
                where = $" (codigo LIKE '%{filtro}%' OR nombres LIKE '%{filtro}%' OR apellidos LIKE '%{filtro}%' OR celular LIKE '%{filtro}%' " +
                    $"OR documento LIKE '%{filtro}%') ";

            IEnumerable<VistaVendedoresProgramacion> result = base.FetchObjects<VistaVendedoresProgramacion>($"SELECT * FROM vvendedoresprogramacion WHERE IdProgramacionJuego = {pIdProgramacionJuego} AND {where};");

            return result;
        }

        public int CantidadProgramacionesAbiertas()
        {
            return base.FetchObject<int>($"SELECT COUNT(0) FROM {mTabla} WHERE Estado = 'A';");            
        }

        public int SiguienteIdProgramacion()
        {
            return base.FetchObject<int>($"SELECT COALESCE(MAX(IdProgramacionJuego),0) + 1 FROM {mTabla};");
        }

        public int ProgramacionMasAntigua()
        {
            return base.FetchObject<int>($"SELECT COALESCE(Min(IdProgramacionJuego),0) FROM {mTabla} WHERE Estado = 'A';");
        }

        public ProgramacionJuego FindOne(int id)
        {
            return base.FetchObject<ProgramacionJuego>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuego = {id} LIMIT 1;");
        }

        public string FindSerieProgramacion(int id)
        {
            var registro = base.FetchObject<Listabla>($"SELECT seri.* FROM {mTabla} prog INNER JOIN listablas seri ON prog.IdSerie = seri.IdLisTablas WHERE prog.IdProgramacionJuego = {id} LIMIT 1;");

            return registro.Simbolo;
        }

        public Tuple<int, int> ObtenerRangoAniosProgramaciones()
        {
            int anioInicial = base.FetchObject<int>($"SELECT COALESCE(YEAR(MIN(FechaProgramada)), YEAR(NOW())) FROM {mTabla};");
            int anioFinal = base.FetchObject<int>($"SELECT COALESCE(YEAR(MAX(FechaProgramada)), YEAR(NOW())) FROM {mTabla};");

            return new Tuple<int, int>(anioInicial, anioFinal);
        }

        public void ActualizarTotalPremios(int id, double totalPremios)
        {
            ProgramacionJuego registroActual = FindOne(id);

            string query = $"UPDATE {mTabla} SET TotalPremios = {totalPremios} WHERE IdProgramacionJuego = {id};";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            var registroNuevo = (ProgramacionJuego)registroActual.Clone();
            registroNuevo.TotalPremios = totalPremios;

            InsertAudit(mTabla, ActionModify, registroNuevo, registroActual);
        }

        public int Insert(ProgramacionJuego objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearProgramacionJuego", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new MySqlParameter("parFechaProgramada", objEntidad.FechaProgramada));
                command.Parameters.Add(new MySqlParameter("parValorCarton", objEntidad.ValorCarton));
                command.Parameters.Add(new MySqlParameter("parTotalCartones", objEntidad.TotalCartones));
                command.Parameters.Add(new MySqlParameter("parValorModulo", objEntidad.ValorModulo));
                command.Parameters.Add(new MySqlParameter("parTotalModulos", objEntidad.TotalModulos));
                command.Parameters.Add(new MySqlParameter("parTotalPremios", objEntidad.TotalPremios));
                command.Parameters.Add(new MySqlParameter("parIdSerie", objEntidad.IdSerie));
                command.Parameters.Add(new MySqlParameter("parCartonInicial", objEntidad.CartonInicial));
                command.Parameters.Add(new MySqlParameter("parCartonFinal", objEntidad.CartonFinal));
                command.Parameters.Add(new MySqlParameter("parHojaInicial", objEntidad.HojaInicial));
                command.Parameters.Add(new MySqlParameter("parHojaFinal", objEntidad.HojaFinal));                

                command.Parameters.Add(new MySqlParameter("outIdProgramacionJuego", MySqlDbType.Int32));
                command.Parameters["outIdProgramacionJuego"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdProgramacionJuego = (int)command.Parameters["outIdProgramacionJuego"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdProgramacionJuego;
        }

        public int Update(ProgramacionJuego objEntidad)
        {
            ProgramacionJuego registroActual = FindOne(objEntidad.IdProgramacionJuego);

            string query = $"UPDATE {mTabla} SET CartonFinal = {objEntidad.CartonFinal}, HojaFinal = {objEntidad.HojaFinal} WHERE IdProgramacionJuego = {objEntidad.IdProgramacionJuego};";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            var registroNuevo = objEntidad;

            InsertAudit(mTabla, ActionModify, registroNuevo, registroActual);

            return objEntidad.IdProgramacionJuego;
        }

        public int UpdateResultadoFinal(ProgramacionJuego objEntidad)
        {
            //ProgramacionJuego registroActual = FindOne(objEntidad.IdProgramacionJuego);

            string query = $"UPDATE {mTabla} SET ResultadoFinal = {objEntidad.ResultadoFinal} WHERE IdProgramacionJuego = {objEntidad.IdProgramacionJuego} AND Estado = 'C';";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            //var registroNuevo = objEntidad;
            //InsertAudit(mTabla, ActionModify, registroNuevo, registroActual);

            return objEntidad.IdProgramacionJuego;
        }

        public int Cerrar(ProgramacionJuego objEntidad)
        {
            ProgramacionJuego registroActual = FindOne(objEntidad.IdProgramacionJuego);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCerrarProgramacionJuego", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));

                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            objEntidad = FindOne(objEntidad.IdProgramacionJuego);

            InsertAudit(mTabla, ActionStatus, objEntidad, registroActual);

            return objEntidad.IdProgramacionJuego;
        }

        public int ExistenJuegosParaCerrar()
        {
            return base.FetchObject<int>($"SELECT COALESCE(COUNT(0), 0) AS Cantidad FROM {mTabla} WHERE Estado = 'A';");
        }

        public int CantidadHojasImpresas(int pCartonesHoja, int pIdProgramacion)
        {
            try
            {
                return base.FetchObject<int>($"SELECT CONVERT(COALESCE(((CartonFinal - CartonInicial) / {pCartonesHoja}) ,0), UNSIGNED INTEGER) AS Cantidad FROM {mTabla} WHERE IdProgramacionJuego = {pIdProgramacion};");
            }
            catch
            {
                return 0;
            }
        }

        public int CantidadHojasEntregadas(int pIdProgramacion)
        {
            return base.FetchObject<int>($"SELECT COALESCE(COUNT(NumeroHoja), 0) AS Cantidad FROM vconsultalistadocartonesdevueltos WHERE IdProgramacionJuego = {pIdProgramacion} AND Estado = 'A';");            
        }

        public IEnumerable<VistaConsultaListadoCartonesDevueltos> ConsultarListadoCartones(int pIdProgramacion)
        {
            return base.FetchObjects<VistaConsultaListadoCartonesDevueltos>($"SELECT * FROM vconsultalistadocartonesdevueltos WHERE IdProgramacionJuego = {pIdProgramacion} AND Estado = 'A';");
        }

        public int CantidadVendedoresSinPago(int pIdProgramacion)
        {
            return base.FetchObject<int>($"SELECT COALESCE(COUNT(Cobrado), 0) AS Cantidad FROM vendedoresresumen WHERE IdProgramacionJuego = {pIdProgramacion} AND Cobrado = 0;");
        }        
    }
}

