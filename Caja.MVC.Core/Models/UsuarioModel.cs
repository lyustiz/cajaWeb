using Caja.Core.Entidades;
using Caja.MVC.Core.Negocio;
using Caja.MVC.Core.Validaciones;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Caja.MVC.Core.Models
{
    public class UsuarioModel
    {
        public UsuarioModel()
        {
            this.Perfiles = new List<PerfilModel>();
        }

        public int Id { get; set; }

        [DisplayName("Usuario")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string Usuario { get; set; }

        [DisplayName("Nombre Completo")]
        [Required(ErrorMessage = "Campo Requerido.")]
        public string NombreCompleto { get; set; }

        [DisplayName("Clave")]
        [Required(ErrorMessage = "Campo Requerido.")]
        //[ClaveValidacion(ErrorMessage = "Contraseña no valida")]
        public string Clave { get; set; }

        [DisplayName("Confirmar Clave")]
        [Required(ErrorMessage = "Campo Requerido.")]
        [Compare("Clave", ErrorMessage = "Las claves no coinciden, validelas de nuevo por favor.")]
        public string ConfirmarClave { get; set; }

        [DisplayName("Clave Ajustes")]
        public string ClaveAjustes { get; set; }

        [DisplayName("Confirmar Clave Ajustes")]
        [Compare("ClaveAjustes", ErrorMessage = "Las claves de ajustes no coinciden, validelas de nuevo por favor.")]
        public string ConfirmarClaveAjustes { get; set; }

        public string Estado { get; set; }

        public List<PerfilModel> Perfiles { get; set; }

        public UsuarioModel ToModel(Usuarios registro, IEnumerable<Perfilesusuario> perfiles = null)
        {
            var usuario = new UsuarioModel() {
                Id = registro.IdUsuario,
                Usuario = registro.Login,
                NombreCompleto = registro.NombreCompleto,
                Clave = NegocioCommon.DesEncriptar(registro.Clave),
                ConfirmarClave = NegocioCommon.DesEncriptar(registro.Clave),
                ClaveAjustes = NegocioCommon.DesEncriptar(registro.ClaveAjustes),
                ConfirmarClaveAjustes = NegocioCommon.DesEncriptar(registro.ClaveAjustes),
                Estado = registro.Estado
            };

            if (perfiles != null)
            {
                foreach (var perfil in perfiles)
                {
                    usuario.Perfiles.Add(new PerfilModel() { Id = perfil.IdPerfil, Seleccionado = true });
                }                
            }

            return usuario;
        }

        public List<UsuarioModel> ToModelList(IEnumerable<Usuarios> listado)
        {
            List<UsuarioModel> modelo = new();

            listado.ToList().ForEach(x => modelo.Add(ToModel(x)));

            return modelo;
        }
    }

    public class PerfilModel
    {
        public short Id { get; set; }

        public string Nombre { get; set; }

        public bool Seleccionado { get; set; }
    }

    public class LoginModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El usuario es obligatorio.")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [ClaveValidacion(ErrorMessage = "Contraseña no valida")]
        public string Contrasena { get; set; }

        public string NombreCompleto { get; set; }        
    }
}
