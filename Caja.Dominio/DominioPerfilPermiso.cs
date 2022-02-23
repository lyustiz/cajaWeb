using Caja.Datos;
using Caja.Entidades;
using Caja.Entidades.Vistas;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Caja.Dominio
{
    public sealed class DominioPerfilPermiso
    {
        readonly RepositorioPerfilPermiso mRepositorio;

        readonly RepositorioUsuario mRepositorioUsuario;
        public DominioPerfilPermiso()
        {
            mRepositorio = new RepositorioPerfilPermiso();
            mRepositorioUsuario = new RepositorioUsuario();
        }

        public List<Perfil> FindPerfiles()
        {
            return mRepositorio.FindPerfiles().ToList();
        }

        public List<Perfil> FindPerfiles(int pIdUsuario)
        {
            return mRepositorio.FindPerfiles(pIdUsuario).ToList();
        }

        public List<VistaPerfilPermisos> FetchByPerfil(int idPerfil)
        {
            return mRepositorio.FindByIdPerfil(idPerfil).ToList();
        }

        public List<PerfilPermiso> FetchAll()
        {
            return mRepositorio.Find().ToList();
        }

        public PerfilPermiso FetchOne(int id)
        {
            return mRepositorio.FindOne(id);
        }

        public List<PerfilPermiso> FetchOnes(int[] ids)
        {
            return mRepositorio.FindOnes(ids).ToList();
        }

        public int Save(PerfilPermiso objEntidad)
        {
            if (objEntidad.IdPerfilPermisos > 0)
                return mRepositorio.Update(objEntidad);
            else
                return mRepositorio.Insert(objEntidad);
        }

        public int ObtenerOCrearPermiso(Menu objMenu, int pIdUsuario)
        {
            var menu = mRepositorio.ObtenerMenu(objMenu.NombreMenu);

            if (menu is null)
            {
                objMenu.IdMenu = mRepositorio.InsertMenu(objMenu);
                mRepositorio.InsertarPermiso(objMenu.IdMenu, pIdUsuario);

                return objMenu.IdMenu;
            }
            else
            {
                mRepositorio.InsertarPermiso(menu.IdMenu, pIdUsuario);
                return menu.IdMenu;
            }                
        }

        public bool TienePermiso(int pIdMenu, int pIdUsuario)
        {
            var listaPerfiles = mRepositorioUsuario.FindPerfilesByUsuario(pIdUsuario).ToList();

            if (listaPerfiles.Count == 0)
                return false;

            var listaPermisos = mRepositorio.FindOnes(listaPerfiles.Select(x => x.IdPerfil).ToArray()).ToList();

            return listaPermisos.Exists(x => x.IdMenu == pIdMenu && x.Habilitado == true);
        }
    }
}


