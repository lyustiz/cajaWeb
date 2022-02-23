using Caja.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Caja.Datos
{
    public sealed class RepositorioVendedorReferencia : RepositorioBase, IRepositorio<VendedorReferencia, int>
    {
        private readonly string mTabla = "vendedoresreferencias";

        public IEnumerable<VendedorReferencia> Find()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VendedorReferencia> Find(int idVendedor)
        {
            IEnumerable<VendedorReferencia> result = base.FetchObjects<VendedorReferencia>($"SELECT * FROM {mTabla} WHERE IdVendedor = {idVendedor} ORDER BY IdVendedorReferencia;");

            return result;
        }

        public VendedorReferencia FindOne(int id)
        {
            return base.FetchObject<VendedorReferencia>($"SELECT * FROM {mTabla} WHERE IdVendedorReferencia = {id};");
        }

        public IEnumerable<VendedorReferencia> FindOnes(int[] ids)
        {
            throw new NotImplementedException();
        }

        public int Insert(VendedorReferencia objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psCrearVendedorReferencia", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdVendedor", objEntidad.IdVendedor));
                command.Parameters.Add(new MySqlParameter("parIdTipoRelacion", objEntidad.IdTipoRelacion));
                command.Parameters.Add(new MySqlParameter("parNombres", objEntidad.Nombres));
                command.Parameters.Add(new MySqlParameter("parApellidos", objEntidad.Apellidos));
                command.Parameters.Add(new MySqlParameter("parDireccion", objEntidad.Direccion));
                command.Parameters.Add(new MySqlParameter("parTelefono", objEntidad.Telefono));
                command.Parameters.Add(new MySqlParameter("parCelular", objEntidad.Celular));
                command.Parameters.Add(new MySqlParameter("parIdCiudad", objEntidad.IdCiudad));                
                command.Parameters.Add(new MySqlParameter("parDocumento", objEntidad.Documento));
                command.Parameters.Add(new MySqlParameter("parIdUsuarioCreacion", objEntidad.IdUsuarioCreacion));

                command.Parameters.Add(new MySqlParameter("outIdVendedorReferencia", MySqlDbType.Int32));
                command.Parameters["outIdVendedorReferencia"].Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();
                result = (int)command.Parameters["outIdVendedorReferencia"].Value;
                command.Connection.Close();
            }

            return result;
        }

        public int Update(VendedorReferencia objEntidad)
        {
            var result = 0;

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand("psModificarVendedorReferencia", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("parIdVendedorReferencia", objEntidad.IdVendedorReferencia));
                command.Parameters.Add(new MySqlParameter("parIdTipoRelacion", objEntidad.IdTipoRelacion));
                command.Parameters.Add(new MySqlParameter("parNombres", objEntidad.Nombres));
                command.Parameters.Add(new MySqlParameter("parApellidos", objEntidad.Apellidos));
                command.Parameters.Add(new MySqlParameter("parDireccion", objEntidad.Direccion));
                command.Parameters.Add(new MySqlParameter("parTelefono", objEntidad.Telefono));
                command.Parameters.Add(new MySqlParameter("parCelular", objEntidad.Celular));
                command.Parameters.Add(new MySqlParameter("parIdCiudad", objEntidad.IdCiudad));                                
                command.Parameters.Add(new MySqlParameter("parDocumento", objEntidad.Documento));

                command.ExecuteNonQuery();
                result = objEntidad.IdVendedorReferencia;
                command.Connection.Close();
            }

            return result;
        }
    }
}
