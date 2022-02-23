using Caja.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace Caja.Core.Repositorio
{
    public sealed class RepositorioFigurasPA 
    {
        private MySqlConnection databaseConnection = new MySqlConnection("Server=MYSQL5045.site4now.net;Database=db_a544b3_carombo;Uid=a544b3_carombo;Pwd=BingoJL2021");

        private string psObtenerFiguras = "psObtenerFiguras";
        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioUsuario"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        

        public IEnumerable<FiguraPA> Obtener()
        {
            List<FiguraPA> lista = null;
            using (var connection = databaseConnection)
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(psObtenerFiguras, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.ExecuteNonQuery();
                //ar reader = command.ExecuteReader();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        lista = new List<FiguraPA>();
                        while (reader.Read())
                        {
                            lista.Add(new FiguraPA
                            {
                                IdFigura = (int)reader["IdFigura"],
                                Nombre = reader["Nombre"]?.ToString(),
                                Posiciones = reader["Posiciones"]?.ToString(),
                                Estado = reader["Estado"]?.ToString(),
                            });
                        }
                    }
                    
                }
            command.Connection.Close();
            }
         return lista;
        }
    }
}
