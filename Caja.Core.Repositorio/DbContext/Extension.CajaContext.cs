using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Caja.Core.Repositorio
{
    /// <summary>
    /// Clase <see cref="CajaContext"/>.
    /// </summary>
    public partial class CajaContext
    {
        private readonly IConfiguration configuracion = null;
        private bool finalizo;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="CajaContext"/>.
        /// </summary>
        /// <param name="pConfiguracion">Representa un conjunto de propiedades de configuración de la aplicación de clave/valor.</param>
        public CajaContext(IConfiguration pConfiguracion)
        {
            configuracion = pConfiguracion;
        }

        /// <summary>
        /// Configurar las funcionalidades del contexto.
        /// </summary>
        /// <param name="optionsBuilder">Opciones de configuración del contexto.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(configuracion.GetSection("ConnectionStrings:CajaContext").Value);
            }
        }

        /// <summary>
        /// Conformar los cambios realizados en el contexto.
        /// </summary>
        /// <param name="pDispose">Indica si libera los recursos asignados para el contexto.</param>
        /// <param name="pGuardarCambios">Indica si guarda los cambios realizados en el contexto.</param>
        public void ConfirmarCambios(bool pDispose, bool pGuardarCambios = false)
        {
            if (!finalizo)
            {
                finalizo = pDispose;

                if (pGuardarCambios)
                    SaveChanges();

                if (pDispose)
                    Dispose();
            }
        }
    }
}
