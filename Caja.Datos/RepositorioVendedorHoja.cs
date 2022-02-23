using Caja.Entidades;
using Caja.Entidades.Vistas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioVendedorHoja : RepositorioBase, IRepositorio<VendedorHoja, int>
    {
        private readonly string mTabla = "vendedoreshojas";

        public RepositorioVendedorHoja(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<VendedorHoja> Find()
        {
            IEnumerable<VendedorHoja> result = base.FetchObjects<VendedorHoja>($"SELECT * FROM {mTabla};");

            return result;
        }                

        public IEnumerable<VendedorHoja> FindByVendedor(int pIdVendedor, int pIdProgramacion)
        {
            return base.FetchObjects<VendedorHoja>($"SELECT * FROM {mTabla} WHERE Estado = 'A' AND IdVendedor = {pIdVendedor} AND IdProgramacionJuego = {pIdProgramacion};");
        }

        public VendedorHoja FindByVendedor(int pIdVendedor, int pIdProgramacion, int pNumeroHoja)
        {
            return base.FetchObject<VendedorHoja>($"SELECT * FROM {mTabla} WHERE Estado = 'A' AND IdVendedor = {pIdVendedor} AND IdProgramacionJuego = {pIdProgramacion} AND NumeroHoja = {pNumeroHoja};");
        }

        public IEnumerable<VendedorHoja> FindByProgramacion(int id)
        {
            return base.FetchObjects<VendedorHoja>($"SELECT * FROM {mTabla} WHERE IdProgramacionJuego = {id} AND Estado = 'A';");
        }

        public IEnumerable<VistaVendedoresEntregaCartones> FindVendedoresEntregaCartones(string filtro)
        {
            string where;

            if (filtro.IsNullOrEmpty())
                return base.FetchObjects<VistaVendedoresEntregaCartones>($"SELECT * FROM vvendedoresentregacartones WHERE IdVendedor IS NOT NULL;");
            else
                where = $" (Codigo LIKE '%{filtro}%' OR Nombres LIKE '%{filtro}%' OR Apellidos LIKE '%{filtro}%')";

            IEnumerable<VistaVendedoresEntregaCartones> result = base.FetchObjects<VistaVendedoresEntregaCartones>($"SELECT * FROM vvendedoresentregacartones WHERE IdVendedor IS NOT NULL {where};");

            return result;
        }

        public bool ExisteHoja(int pIdProgramacion, int pNumeroHoja)
        {
            var cantidad = base.FetchObject<int>($"SELECT COUNT(0) FROM {mTabla} WHERE Estado = 'A' AND IdProgramacionJuego = {pIdProgramacion} AND NumeroHoja = {pNumeroHoja};");

            return cantidad > 0;
        }

        public IEnumerable<VendedorHoja> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }
        public VendedorHoja FindOne(int id)
        {
            return base.FetchObject<VendedorHoja>($"SELECT * FROM {mTabla} WHERE IdVendedorHoja = {id};");
        }

        public int Insert(VendedorHoja objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearVendedorHoja", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.Add(new MySqlParameter("parIdProgramacionJuego", objEntidad.IdProgramacionJuego));
                command.Parameters.Add(new MySqlParameter("parIdVendedor", objEntidad.IdVendedor));
                command.Parameters.Add(new MySqlParameter("parNumeroHoja", objEntidad.NumeroHoja));

                command.Parameters.Add(new MySqlParameter("outIdVendedorHoja", MySqlDbType.Int32));
                command.Parameters["outIdVendedorHoja"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdVendedorHoja = (int)command.Parameters["outIdVendedorHoja"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdVendedorHoja;
        }

        public int Update(VendedorHoja objEntidad)
        {
            var registroActual = FindOne(objEntidad.IdVendedorHoja);

            /// TODO Implementar la modificación del registro.

            InsertAudit(mTabla, ActionModify, objEntidad, registroActual);

            return objEntidad.IdVendedorHoja;
        }

        public void Deshabilitar(int pId)
        {
            string query = $"UPDATE {mTabla} SET Estado = 'I' WHERE IdVendedorHoja = {pId};";
            var registroActual = FindOne(pId);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            var registroNuevo = (VendedorHoja)registroActual.Clone();
            registroNuevo.Estado = Convert.ToChar('I');

            InsertAudit(mTabla, ActionStatus, registroNuevo, registroActual);
        }
    }
}

