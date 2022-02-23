using Caja.Entidades;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace Caja.Datos
{
    public sealed class RepositorioAuditoriaHistoria : RepositorioBase, IRepositorio<AuditoriaHistoria, int>
    {
        public IEnumerable<AuditoriaHistoria> Find()
        {
            throw new System.NotImplementedException();
        }

        public AuditoriaHistoria FindOne(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<AuditoriaHistoria> FindOnes(int[] ids)
        {
            throw new System.NotImplementedException();
        }

        public int Insert(AuditoriaHistoria objEntidad)
        {
            var result = 0;

            if (objEntidad.Estado == default(char))
                objEntidad.Estado = 'A';

            string query = $"INSERT INTO auditoriahistoria(IdUsuario, Estado, Accion, ValorAnterior, ValorNuevo, IdJuego) VALUES" +
                $" ({objEntidad.IdUsuario}, '{objEntidad.Estado}', {objEntidad.Acccion}, '{objEntidad.ValorAnterior}', '{objEntidad.ValorNuevo}', (SELECT COALESCE(MAX(IdJuego),0) FROM juegos));";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                result = command.ExecuteNonQuery();
                command.Connection.Close();
            }

            return result;
        }

        public int Update(AuditoriaHistoria objEntidad)
        {
            throw new System.NotImplementedException();
        }
    }
}


