using Caja.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    /// <summary>
    /// Clase de acceso a datos de usuarios.
    /// </summary>
    public sealed class RepositorioUsuario : RepositorioBase
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase  <see cref="RepositorioUsuario"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioUsuario(IConfiguration pConfiguracion, bool pDispose = true) : base(pConfiguracion, pDispose)
        {
        }

        /// <summary>
        /// Obtener la información de un usuario
        /// </summary>
        /// <param name="login">Login unico del usuario.</param>
        /// <returns><see cref="Usuarios"/></returns>
        public Usuarios Obtener(string login)
        {
            return Contexto.Usuarios.FirstOrDefault(x => x.Login == login);
        }

        /// <summary>
        /// Obtener la información de un usuario
        /// </summary>
        /// <param name="id">Identificador unido del usuario.</param>
        /// <returns><see cref="Usuarios"/></returns>
        public Usuarios Obtener(int id)
        {
            return Contexto.Usuarios.FirstOrDefault(x => x.IdUsuario == id);
        }

        public Usuarios login(string login, string clave)
        {
            return Contexto.Usuarios.FirstOrDefault(x => x.Login == login & x.Clave == clave);
        }

        /// <summary>
        /// Obtener un listado de los usuarios.
        /// </summary>        
        /// <returns>Listado de<see cref="Usuarios"/></returns>
        public IEnumerable<Usuarios> Obtener()
        {
            return Contexto.Usuarios.ToList();
        }

       
        public IEnumerable<Perfilesusuario> ObtenerPerfilesUsuario(int idUsuario)
        {
            return Contexto.Perfilesusuario.Where(x => x.IdUsuario == idUsuario);
        }

        public IEnumerable<Perfiles> ObtenerPerfiles()
        {
            return Contexto.Perfiles.Where(x => x.EsVisible.Value == 1);
        }

        /// <summary>
        /// Obtener la lista de usuarios con perfil Socios.
        /// </summary>        
        /// <returns><see cref="IEnumerable<Usuarios>"/></returns>
        public IEnumerable<Usuarios> ObtenerSocios()
        {
            IEnumerable<Perfilesusuario> listaUsuariosSocios = Contexto.Perfilesusuario.Where(x => x.IdPerfil == 8 || x.IdPerfil == 3);

            return Contexto.Usuarios.Where(x => listaUsuariosSocios.Select(y => y.IdUsuario).Contains(x.IdUsuario) || x.EsSocio.Value == true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaUsuarios"></param>
        /// <returns></returns>
        public bool GuardarPorcentaje(List<Usuarios> listaUsuarios)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                foreach (Usuarios usuario in listaUsuarios)
                {
                    Usuarios usuarioActual = Contexto.Usuarios.Find(usuario.IdUsuario);

                    if (usuarioActual != null)
                    {
                        usuarioActual.Porcentaje = usuario.Porcentaje;
                        Contexto.Usuarios.Update(usuarioActual);
                    }
                }

                Contexto.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="perfiles"></param>
        /// <returns></returns>
        public bool Modificar(Usuarios usuario, IEnumerable<Perfilesusuario> perfiles)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Usuarios usuarioActual = Contexto.Usuarios.Find(usuario.IdUsuario);

                if (usuarioActual != null)
                {
                    usuarioActual.NombreCompleto = usuario.NombreCompleto;
                    usuarioActual.Login = usuario.Login;
                    usuarioActual.Clave = usuario.Clave;
                    usuarioActual.ClaveAjustes = usuario.ClaveAjustes;

                    Contexto.Usuarios.Update(usuarioActual);

                    var listaPerfilesActuales = Contexto.Perfilesusuario.Where(x => x.IdUsuario == usuarioActual.IdUsuario);
                    Contexto.RemoveRange(listaPerfilesActuales);

                    foreach (var perfil in perfiles)
                    {
                        perfil.IdUsuario = usuarioActual.IdUsuario;
                        Contexto.Perfilesusuario.Add(perfil);
                    }                        
                }

                Contexto.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="perfiles"></param>
        /// <returns></returns>
        public bool ModificarEstado(int idUsuario)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Usuarios usuarioActual = Contexto.Usuarios.Find(idUsuario);

                if (usuarioActual != null)
                {
                    if (usuarioActual.Estado == "H")
                        usuarioActual.Estado = "D";
                    else
                        usuarioActual.Estado = "H";

                    Contexto.Usuarios.Update(usuarioActual);                    
                }

                Contexto.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="perfiles"></param>
        /// <returns></returns>
        public bool Insertar(Usuarios usuario, IEnumerable<Perfilesusuario> perfiles)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                Contexto.Usuarios.Add(usuario);
                Contexto.SaveChanges();
                transaction.Commit();

                usuario = Contexto.Usuarios.FirstOrDefault(x => x.Login == usuario.Login);

                foreach (var perfil in perfiles)
                {
                    perfil.IdUsuario = usuario.IdUsuario;
                    Contexto.Perfilesusuario.Add(perfil);
                }

                Contexto.SaveChanges();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
        }
    }
}
