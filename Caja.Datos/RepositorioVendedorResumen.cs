using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioVendedorResumen : RepositorioBase, IRepositorio<VendedorResumen, int>
    {
        private readonly string mTabla = "vendedoresresumen";

        public RepositorioVendedorResumen(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<VendedorResumen> Find()
        {
            IEnumerable<VendedorResumen> result = base.FetchObjects<VendedorResumen>($"SELECT * FROM {mTabla};");

            return result;
        }

        public VendedorResumen FindByVendedorProgramacion(int pIdVendedor, int pIdProgramacion)
        {
            var result = base.FetchObject<VendedorResumen>($"SELECT * FROM {mTabla} WHERE IdVendedor = {pIdVendedor} AND IdProgramacionJuego = {pIdProgramacion} AND Estado = 'A' LIMIT 1;");

            return result;
        }

        public IEnumerable<VendedorResumen> FindByProgramacion(int pId)
        {
            IEnumerable<VendedorResumen> result = base.FetchObjects<VendedorResumen>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuego = {pId};");

            return result;
        }

        public VendedorResumen FindOne(int id)
        {
            return base.FetchObject<VendedorResumen>($"SELECT * FROM {mTabla} WHERE IdVendedorResumen = {id};");
        }

        public IEnumerable<VendedorResumen> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int Insert(VendedorResumen objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearVendedorResumen", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parIdVendedor", objEntidad.IdVendedor));
                command.Parameters.Add(new MySqlParameter("parTotalCartones", objEntidad.TotalCartones));
                command.Parameters.Add(new MySqlParameter("parCartonesCortesia", objEntidad.CartonesCortesia));
                command.Parameters.Add(new MySqlParameter("parValorTotal", objEntidad.ValorTotal));
                command.Parameters.Add(new MySqlParameter("parPagoAnticipado", objEntidad.PagoAnticipado));
                command.Parameters.Add(new MySqlParameter("parValorPendiente", objEntidad.ValorPendiente));
                command.Parameters.Add(new MySqlParameter("parCartonesDevueltos", objEntidad.CartonesDevueltos));
                command.Parameters.Add(new MySqlParameter("parNumeroHojasDevueltas", objEntidad.NumeroHojasDevueltas));
                command.Parameters.Add(new MySqlParameter("parPorcentajeComision", objEntidad.PorcentajeComision));
                command.Parameters.Add(new MySqlParameter("parCobrado", objEntidad.Cobrado));
                command.Parameters.Add(new MySqlParameter("parFaltante", objEntidad.Faltante));
                command.Parameters.Add(new MySqlParameter("parGastoCortesia", objEntidad.GastoCortesia));
                command.Parameters.Add(new MySqlParameter("parCantidadModulos", objEntidad.CantidadModulos));
                command.Parameters.Add(new MySqlParameter("parValorModulos", objEntidad.ValorModulos));

                command.Parameters.Add(new MySqlParameter("outIdVendedorResumen", MySqlDbType.Int32));
                command.Parameters["outIdVendedorResumen"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdVendedorResumen = (int)command.Parameters["outIdVendedorResumen"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdVendedorResumen;
        }

        public int Update(VendedorResumen objEntidad)
        {
            var registroActual = FindOne(objEntidad.IdVendedorResumen);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarVendedorResumen", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdVendedorResumen", objEntidad.IdVendedorResumen));
                command.Parameters.Add(new MySqlParameter("parTotalCartones", objEntidad.TotalCartones));
                command.Parameters.Add(new MySqlParameter("parCartonesCortesia", objEntidad.CartonesCortesia));
                command.Parameters.Add(new MySqlParameter("parValorTotal", objEntidad.ValorTotal));
                command.Parameters.Add(new MySqlParameter("parPagoAnticipado", objEntidad.PagoAnticipado));
                command.Parameters.Add(new MySqlParameter("parValorPendiente", objEntidad.ValorPendiente));
                command.Parameters.Add(new MySqlParameter("parCartonesDevueltos", objEntidad.CartonesDevueltos));
                command.Parameters.Add(new MySqlParameter("parNumeroHojasDevueltas", objEntidad.NumeroHojasDevueltas));
                command.Parameters.Add(new MySqlParameter("parPorcentajeComision", objEntidad.PorcentajeComision));
                command.Parameters.Add(new MySqlParameter("parCobrado", objEntidad.Cobrado));
                command.Parameters.Add(new MySqlParameter("parFaltante", objEntidad.Faltante));
                command.Parameters.Add(new MySqlParameter("parGastoCortesia", objEntidad.GastoCortesia));
                command.Parameters.Add(new MySqlParameter("parCantidadModulos", objEntidad.CantidadModulos));
                command.Parameters.Add(new MySqlParameter("parValorModulos", objEntidad.ValorModulos));

                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionModify, objEntidad, registroActual);

            return objEntidad.IdVendedorResumen;
        }

        public void Deshabilitar(int pId)
        {
            string query = $"UPDATE {mTabla} SET Estado = 'I' WHERE IdVendedorResumen = {pId};";
            var registroActual = FindOne(pId);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            var registroNuevo = (VendedorResumen)registroActual.Clone();
            registroNuevo.Estado = Convert.ToChar('I');

            InsertAudit(mTabla, ActionStatus, registroNuevo, registroActual);
        }
    }
}


