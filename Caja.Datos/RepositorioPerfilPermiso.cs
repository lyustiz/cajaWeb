using Caja.Entidades;
using Caja.Entidades.Vistas;
using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Caja.Datos
{
    public sealed class RepositorioPerfilPermiso : RepositorioBase, IRepositorio<PerfilPermiso, int>
    {
        public IEnumerable<Perfil> FindPerfiles()
        {
            return base.FetchObjects<Perfil>($"SELECT perf.IdPerfil, perf.Nombre, perf.Descripcion FROM perfiles perf WHERE perf.EsVisible = 1;");
        }

        public IEnumerable<Perfil> FindPerfiles(int pIdUsuario)
        {
            return base.FetchObjects<Perfil>($"SELECT perf.IdPerfil, perf.Nombre, perf.Descripcion FROM perfilesusuario peus, perfiles perf " +
                $"WHERE peus.IdPerfil = perf.IdPerfil AND perf.EsVisible = 1 AND peus.IdUsuario = {pIdUsuario};");
        }

        public IEnumerable<VistaPerfilPermisos> FindByIdPerfil(int idPerfil)
        {
            return base.FetchObjects<VistaPerfilPermisos>($"SELECT * FROM vperfilpermisos WHERE IdPerfil = {idPerfil};");
        }

        public IEnumerable<PerfilPermiso> Find()
        {
            throw new NotImplementedException();
        }

        public PerfilPermiso FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PerfilPermiso> FindOnes(int[] ids)
        {
            return base.FetchObjects<PerfilPermiso>($"SELECT * FROM perfilpermisos WHERE IdPerfil IN ({string.Join(",", ids)});");
        }

        public int Insert(PerfilPermiso objEntidad)
        {
            throw new NotImplementedException();
        }

        public int Update(PerfilPermiso objEntidad)
        {
            int result = 0;
            string query = $"UPDATE perfilpermisos SET Habilitado = {objEntidad.Habilitado} WHERE IdPerfilPermisos = {objEntidad.IdPerfilPermisos};";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                result = command.ExecuteNonQuery();
                command.Connection.Close();
            }

            return result;
        }

        public void GenerareData()
        {
            var perfiles = base.FetchObjects<Perfil>("SELECT perf.IdPerfil, perf.Nombre, perf.Descripcion FROM perfiles perf WHERE perf.EsVisible = 1;");
            var menus = base.FetchObjects<Menu>("SELECT * FROM menus;");

            foreach (var perfil in perfiles)
            {
                foreach (var menu in menus)
                {
                    var existe = base.FetchObject<int>($"SELECT COUNT(0) FROM perfilpermisos WHERE IdPerfil = {perfil.IdPerfil} AND IdMenu = {menu.IdMenu};");

                    if (existe == 0)
                    {
                        string query = $"INSERT INTO perfilpermisos (IdPerfil, IdMenu, Lectura, Escritura, Eliminacion, Habilitado) VALUES ({perfil.IdPerfil}, {menu.IdMenu}, 0, 0, 0, 1);";

                        using (var connection = DatabaseConnection.getDBConnection())
                        {
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.ExecuteNonQuery();
                            command.Connection.Close();
                        }
                    }
                }
            }
        }

        public Menu ObtenerMenu(string pNombreMenu)
        {
            return base.FetchObject<Menu>($"SELECT * FROM menus WHERE NombreMenu = '{pNombreMenu}' LIMIT 1;");
        }

        public int InsertMenu(Menu objEntidad)
        {
            string query = $"INSERT INTO menus (NombreMenu, Descripcion) VALUES ('{objEntidad.NombreMenu}', '{objEntidad.Descripcion}');";

            using (var connection = DatabaseConnection.getDBConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            objEntidad.IdMenu = FetchObject<int>($"SELECT IdMenu FROM menus WHERE NombreMenu = '{objEntidad.NombreMenu}' LIMIT 1;");

            return objEntidad.IdMenu;
        }

        public void InsertarPermiso(int pIdMenu, int pIdUsuario)
        {
            var perfiles = base.FetchObjects<Perfil>($"SELECT * FROM perfilesusuario peus, perfiles perf " +
                $" WHERE peus.IdPerfil = perf.IdPerfil AND perf.EsVisible = 1 AND peus.IdUsuario = {pIdUsuario}; ");
            
            foreach (var perfil in perfiles)
            {
                var existe = base.FetchObject<int>($"SELECT COUNT(0) FROM perfilpermisos WHERE IdPerfil = {perfil.IdPerfil} AND IdMenu = {pIdMenu};");

                if (existe == 0)
                {
                    string query = $"INSERT INTO perfilpermisos (IdPerfil, IdMenu, Lectura, Escritura, Eliminacion, Habilitado) VALUES ({perfil.IdPerfil}, {pIdMenu}, 0, 0, 0, 0);";

                    using (var connection = DatabaseConnection.getDBConnection())
                    {
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                    }
                }                
            }
        }
    }
}
