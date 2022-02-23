using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioVendedorCobroCarton : RepositorioBase, IRepositorio<VendedorCobroCarton, int>
    {
        private readonly string mTabla = "vendedorescobrocartones";

        public RepositorioVendedorCobroCarton(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<VendedorCobroCarton> Find()
        {
            IEnumerable<VendedorCobroCarton> result = base.FetchObjects<VendedorCobroCarton>($"SELECT * FROM {mTabla};");

            return result;
        }

        public VendedorCobroCarton FindByVendedorProgramacion(int pIdVendedor, int pIdProgramacion)
        {
            var result = base.FetchObject<VendedorCobroCarton>($"SELECT * FROM {mTabla} WHERE IdVendedor = {pIdVendedor} AND IdProgramacionJuego = {pIdProgramacion} AND Estado = 'A' LIMIT 1;");

            return result;
        }

        public List<VendedorCobroCarton> FindByUsuarioProgramacion(int pIdUsuario, int pIdProgramacion)
        {
            var result = base.FetchObjects<VendedorCobroCarton>($"SELECT * FROM {mTabla} WHERE IdUsuario = {pIdUsuario} AND IdProgramacionJuego = {pIdProgramacion} AND Estado = 'A';");

            return result;
        }

        public IEnumerable<VendedorCobroCarton> FindByProgramacion(int pId)
        {
            IEnumerable<VendedorCobroCarton> result = base.FetchObjects<VendedorCobroCarton>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuego = {pId};");

            return result;
        }

        public IEnumerable<int> FindProgramacionGroupByUsuario(int pId)
        {
            IEnumerable<int> result = base.FetchObjects<int>($"SELECT IdUsuario FROM {mTabla} WHERE IdProgramacionJuego = {pId} AND Estado = 'A';");

            return result;
        }

        public VendedorCobroCarton FindOne(int id)
        {
            return base.FetchObject<VendedorCobroCarton>($"SELECT * FROM {mTabla} WHERE IdVendedorCobroCarton = {id};");
        }

        public IEnumerable<VendedorCobroCarton> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int Insert(VendedorCobroCarton objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearVendedorCobroCarton", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parIdUsuario", IdUsuarioAuditoria));                
                command.Parameters.Add(new MySqlParameter("parIdVendedor", objEntidad.IdVendedor));
                command.Parameters.Add(new MySqlParameter("parTotalCartones", objEntidad.TotalCartones));
                command.Parameters.Add(new MySqlParameter("parCartonesDevueltos", objEntidad.CartonesDevueltos));
                command.Parameters.Add(new MySqlParameter("parNumeroHojasEntregadas", objEntidad.NumeroHojasEntregadas));
                command.Parameters.Add(new MySqlParameter("parPorcentajeComision", objEntidad.PorcentajeComision));
                command.Parameters.Add(new MySqlParameter("parTotalVentas", objEntidad.TotalVentas));
                command.Parameters.Add(new MySqlParameter("parCartonesCortesia", objEntidad.CartonesCortesia));                
                command.Parameters.Add(new MySqlParameter("parValorComision", objEntidad.ValorComision));
                command.Parameters.Add(new MySqlParameter("parAbonos", objEntidad.Abonos));
                command.Parameters.Add(new MySqlParameter("parTotalPagado", objEntidad.TotalPagado));
                command.Parameters.Add(new MySqlParameter("parFaltante", objEntidad.Faltante));
                command.Parameters.Add(new MySqlParameter("parTotalRecibido", objEntidad.TotalRecibido));
                command.Parameters.Add(new MySqlParameter("parGastoCortesia", objEntidad.GastoCortesia));                
                command.Parameters.Add(new MySqlParameter("parTotalModulos", objEntidad.TotalModulos));

                command.Parameters.Add(new MySqlParameter("outIdVendedorCobroCarton", MySqlDbType.Int32));
                command.Parameters["outIdVendedorCobroCarton"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdVendedorCobroCarton = (int)command.Parameters["outIdVendedorCobroCarton"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdVendedorCobroCarton;
        }

        public int Update(VendedorCobroCarton objEntidad)
        {
            var registroActual = FindOne(objEntidad.IdVendedorCobroCarton);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarVendedorCobroCarton", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdVendedorCobroCarton", objEntidad.IdVendedorCobroCarton));
                command.Parameters.Add(new MySqlParameter("parTotalCartones", objEntidad.TotalCartones));
                command.Parameters.Add(new MySqlParameter("parCartonesDevueltos", objEntidad.CartonesDevueltos));
                command.Parameters.Add(new MySqlParameter("parNumeroHojasEntregadas", objEntidad.NumeroHojasEntregadas));
                command.Parameters.Add(new MySqlParameter("parPorcentajeComision", objEntidad.PorcentajeComision));
                command.Parameters.Add(new MySqlParameter("parTotalVentas", objEntidad.TotalVentas));
                command.Parameters.Add(new MySqlParameter("parCartonesCortesia", objEntidad.CartonesCortesia));
                command.Parameters.Add(new MySqlParameter("parValorComision", objEntidad.ValorComision));
                command.Parameters.Add(new MySqlParameter("parAbonos", objEntidad.Abonos));
                command.Parameters.Add(new MySqlParameter("parTotalPagado", objEntidad.TotalPagado));
                command.Parameters.Add(new MySqlParameter("parFaltante", objEntidad.Faltante));
                command.Parameters.Add(new MySqlParameter("parTotalRecibido", objEntidad.TotalRecibido));
                command.Parameters.Add(new MySqlParameter("parGastoCortesia", objEntidad.GastoCortesia));
                command.Parameters.Add(new MySqlParameter("parTotalModulos", objEntidad.TotalModulos));

                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionModify, objEntidad, registroActual);

            return objEntidad.IdVendedorCobroCarton;
        }

        public void Deshabilitar(int pId)
        {
            string query = $"UPDATE {mTabla} SET Estado = 'I' WHERE IdVendedorCobroCarton = {pId};";
            var registroActual = FindOne(pId);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            var registroNuevo = (VendedorCobroCarton)registroActual.Clone();
            registroNuevo.Estado = Convert.ToChar('I');

            InsertAudit(mTabla, ActionStatus, registroNuevo, registroActual);
        }

        public SumatoriaValores CalcularSumatoriaValores(int pIdProgramacion)
        {
            var sumatoria = base.FetchObject<SumatoriaValores>($"SELECT COALESCE(SUM(TotalCartones - CartonesDevueltos - CartonesCortesia), 0) AS TotalCartones, " +
                $"COALESCE(SUM(TotalPagado), 0) AS TotalPagado, " +
                $"COALESCE(SUM(TotalRecibido), 0) AS TotalRecibido, " +
                $"COALESCE(SUM(Faltante), 0) AS Faltante, " +
                $"0 AS TotalPremios " +
                $"FROM {mTabla} WHERE IdProgramacionJuego = {pIdProgramacion} AND Estado = 'A';");

            sumatoria.TotalPremios = base.FetchObject<double>($"SELECT COALESCE(SUM(ValorPremio), 0) AS TotalPremios FROM programacionjuegosfiguras WHERE IdProgramacionJuego = {pIdProgramacion} AND Estado = 'A';");

            return sumatoria;
        }
    }
}



