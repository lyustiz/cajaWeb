using Caja.Datos;
using Caja.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioUsuario
    {
        readonly RepositorioUsuario mRepositorio;
        public DominioUsuario()
        {
            mRepositorio = new RepositorioUsuario();
        }

        public List<Usuario> FetchAll()
        {
            return mRepositorio.Find().ToList();
        }

        public List<Usuario> FetchByPerfil(int[] idPerfiles)
        {
            return mRepositorio.FindByPerfil(idPerfiles).ToList();
        }

        public List<Perfil> FindPerfilesByUsuario(int idUsuario)
        {
            return mRepositorio.FindPerfilesByUsuario(idUsuario).ToList();
        }

        public Usuario FetchOne(int id)
        {
            return mRepositorio.FindOne(id);
        }

        public List<Usuario> FetchOnes(int[] ids)
        {
            throw new System.NotImplementedException();
        }

        public int Save(Usuario objEntidad)
        {
            throw new System.NotImplementedException();
        }

        public int GuardarConPerfiles(Usuario objEntidad, List<Perfil> perfiles)
        {
            if (objEntidad.IdUsuario > 0)
            {
                mRepositorio.Update(objEntidad);

                mRepositorio.EliminarPerfiles(objEntidad.IdUsuario);

                foreach (var perfil in perfiles)
                    mRepositorio.InsertPerfil(perfil, objEntidad.IdUsuario);
            }
            else
            {
                objEntidad.IdUsuario = mRepositorio.Insert(objEntidad);

                if (objEntidad.IdUsuario > 0)
                {
                    foreach (var perfil in perfiles)
                        mRepositorio.InsertPerfil(perfil, objEntidad.IdUsuario);
                }
            }

            return objEntidad.IdUsuario;
        }

        public void Deshabilitar(int id, string estado)
        {
            mRepositorio.Deshabilitar(id, estado);
        }              

        public Usuario Valid(string login)
        {
            return mRepositorio.FindByLogin(login);
        }

        public void UpdateLastLogin(int id)
        {
            mRepositorio.UpdateLastLogin(id);
        }

        public void UpdatePorcentaje(int id, double porcentaje)
        {
            mRepositorio.UpdatePorcentaje(id, porcentaje);
        }

        public void UpdateMaximoJuegos(string cantidad)
        {
            mRepositorio.UpdateMaximoJuegos(cantidad);
        }      
    }
}
