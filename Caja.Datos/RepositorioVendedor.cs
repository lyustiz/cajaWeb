using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioVendedor : RepositorioBase, IRepositorio<Vendedor, int>
    {
        private readonly string mTabla = "vendedores";

        public RepositorioVendedor(int pIdUsuario) : base(pIdUsuario)
        {
        }

        public IEnumerable<Vendedor> Find()
        {
            IEnumerable<Vendedor> result = base.FetchObjects<Vendedor>($"SELECT * FROM {mTabla} ORDER BY Estado, Codigo;");

            return result;
        }

        public IEnumerable<Vendedor> Find(string filtro)
        {
            string where;

            if (filtro.IsNullOrEmpty())
                return Find();
            else
                where = $" (codigo LIKE '%{filtro}%' OR nombres LIKE '%{filtro}%' OR apellidos LIKE '%{filtro}%' OR celular LIKE '%{filtro}%' " +
                    $"OR telefono LIKE '%{filtro}%' OR documento LIKE '%{filtro}%')";

            IEnumerable<Vendedor> result = base.FetchObjects<Vendedor>($"SELECT * FROM {mTabla} WHERE {where} ORDER BY Estado, Codigo;");

            return result;
        }

        public Vendedor FindOne(int id)
        {
            return base.FetchObject<Vendedor>($"SELECT * FROM vendedores WHERE IdVendedor = {id};");
        }

        public IEnumerable<Vendedor> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int GetMaxId()
        {
            return base.FetchObject<int>($"SELECT COALESCE(MAX(IdVendedor),0) + 1 FROM {mTabla};");
        }

        public bool ExisteDocumento(string documento)
        {
            var result = base.FetchObject<int>($"SELECT COUNT(0) FROM {mTabla} WHERE Documento = {documento};");

            return result > 0;
        }

        public int Insert(Vendedor objEntidad)
        {
            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearVendedor", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parCodigo", objEntidad.Codigo));
                command.Parameters.Add(new MySqlParameter("parNombres", objEntidad.Nombres));
                command.Parameters.Add(new MySqlParameter("parApellidos", objEntidad.Apellidos));
                command.Parameters.Add(new MySqlParameter("parDireccion", objEntidad.Direccion));
                command.Parameters.Add(new MySqlParameter("parTelefono", objEntidad.Telefono));
                command.Parameters.Add(new MySqlParameter("parCelular", objEntidad.Celular));
                command.Parameters.Add(new MySqlParameter("parIdCiudad", objEntidad.IdCiudad));
                command.Parameters.Add(new MySqlParameter("parFechaNacimiento", objEntidad.FechaNacimiento));
                command.Parameters.Add(new MySqlParameter("parIdEstadoCivil", objEntidad.IdEstadoCivil));
                command.Parameters.Add(new MySqlParameter("parDocumento", objEntidad.Documento));
                command.Parameters.Add(new MySqlParameter("parIdUsuarioCreacion", objEntidad.IdUsuarioCreacion));

                command.Parameters.Add(new MySqlParameter("outIdVendedor", MySqlDbType.Int32));
                command.Parameters["outIdVendedor"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                objEntidad.IdVendedor = (int)command.Parameters["outIdVendedor"].Value;
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionInsert, objEntidad, null);

            return objEntidad.IdVendedor;
        }

        public int Update(Vendedor objEntidad)
        {
            Vendedor registroActual = FindOne(objEntidad.IdVendedor);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarVendedor", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdVendedor", objEntidad.IdVendedor));
                command.Parameters.Add(new MySqlParameter("parCodigo", objEntidad.Codigo));
                command.Parameters.Add(new MySqlParameter("parNombres", objEntidad.Nombres));
                command.Parameters.Add(new MySqlParameter("parApellidos", objEntidad.Apellidos));
                command.Parameters.Add(new MySqlParameter("parDireccion", objEntidad.Direccion));
                command.Parameters.Add(new MySqlParameter("parTelefono", objEntidad.Telefono));
                command.Parameters.Add(new MySqlParameter("parCelular", objEntidad.Celular));
                command.Parameters.Add(new MySqlParameter("parIdCiudad", objEntidad.IdCiudad));
                command.Parameters.Add(new MySqlParameter("parFechaNacimiento", objEntidad.FechaNacimiento));
                command.Parameters.Add(new MySqlParameter("parIdEstadoCivil", objEntidad.IdEstadoCivil));
                command.Parameters.Add(new MySqlParameter("parDocumento", objEntidad.Documento));                

                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            InsertAudit(mTabla, ActionModify, objEntidad, registroActual);

            return objEntidad.IdVendedor;
        }

        public void Deshabilitar(int id, string estado)
        {
            string query = $"UPDATE {mTabla} SET Estado = '{estado}' WHERE IdVendedor = {id};";
            Vendedor registroActual = FindOne(id);

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            var registroNuevo = (Vendedor)registroActual.Clone();
            registroNuevo.Estado = Convert.ToChar(estado);

            InsertAudit(mTabla, ActionStatus, registroNuevo, registroActual);
        }       
    }
}
