using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caja.Core.Entidades;

namespace Caja.Core.Repositorio
{
    public partial class RepositorioVendedor : RepositorioBase
    {
        public Vendedoresresumen FindByVendedorProgramacion(int pIdVendedor, int pIdProgramacion)
        {
            return Contexto.Vendedoresresumen.FirstOrDefault(x => x.IdVendedor == pIdVendedor && x.IdProgramacionJuego == pIdProgramacion && x.Estado == "A");         
        }

        public bool Eliminar(Vendedoresresumen registro, Vendedoreshojas hoja)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {                
                hoja.Estado = "I";
                Contexto.Vendedoreshojas.Update(hoja);
                Contexto.Vendedoresresumen.Update(registro);

                if (registro.TotalCartones == 0)
                {
                    // validar si modulos igual a 0 i deshabilitar el resumen.
                }

                Contexto.SaveChanges();
                transaction.Commit();

                return true;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }
    }
}
