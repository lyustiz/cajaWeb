using Caja.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caja.MVC.Core.Negocio
{
    public partial class NegocioVendedor
    {            
        public Vendedoresresumen ConsultarHojasPorProgramacion(int pIdVendedor, int pIdProgramacion)
        {
            return repositorio.FindByVendedorProgramacion(pIdVendedor,pIdProgramacion);
        }

        public bool EliminarHojaVendedor(Vendedoresresumen registro, Vendedoreshojas hoja)
        {
            return repositorio.Eliminar(registro, hoja);
        }
    }
}
