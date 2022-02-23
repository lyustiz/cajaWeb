using Microsoft.Extensions.Configuration;

namespace Caja.Core.Repositorio
{
    /// <summary>
    /// Clase base de los repositorios.
    /// </summary>
    public class RepositorioBase
    {
        private CajaContext contexto;
        private readonly IConfiguration configuracion;
        private readonly bool dispose;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        public RepositorioBase(IConfiguration pConfiguracion, bool pDispose)
        {
            configuracion = pConfiguracion;
            dispose = pDispose;
        }

        /// <summary>
        /// Obtiene el contexto de los datos.
        /// </summary>
        public CajaContext Contexto
        {
            get
            {
                if (contexto is null)
                    contexto = new CajaContext(configuracion);

                return contexto;
            }
        }

        /// <summary>
        /// Libera los recursos asignados para el contexto.
        /// </summary>
        /// <param name="pLiberar">Indica si libera los recursos asignados para el contexto.</param>
        /// <param name="pGuardarCambios">Indica si guarda los cambios realizados en el contexto.</param>
        public void Dispose(bool pLiberar = false, bool pGuardarCambios = false)
        {
            Contexto.ConfirmarCambios((dispose || pLiberar), pGuardarCambios);
        }
    }
}
