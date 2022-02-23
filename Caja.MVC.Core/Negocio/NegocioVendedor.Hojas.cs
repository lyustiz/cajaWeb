using Caja.Core.Entidades;
using Caja.MVC.Core.DataSets;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Caja.MVC.Core.Negocio
{
    public partial class NegocioVendedor
    {
        /// <summary>
        /// Consultar la lista de hojas por vendedor de una programación.
        /// </summary>
        /// <param name="pIdProgramacion">Identificador unido de la programación.</param>        
        public List<Vendedoreshojas> ConsultarHojasPorProgramacion(int pIdProgramacion)
        {
            return repositorio.ObtenerPorProgramacion(pIdProgramacion).ToList();
        }

        public List<Vendedoreshojas> ObtenerHojasVendedor(int pIdVendedor, int pIdProgramacion)
        {
            return repositorio.ObtenerPorVendedor(pIdVendedor, pIdProgramacion).ToList();
        }

        public Vendedoreshojas ExisteHoja(int pIdProgramacion, int pNumeroHoja)
        {
            return repositorio.ExisteHoja(pIdProgramacion, pNumeroHoja);
        }


        public bool GuardarHojas(Vendedoresresumen resumen, List<int> hojas)
        {
            return repositorio.GuardarHojas(resumen, hojas);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pIdProgramacion"></param>
        /// <returns></returns>
        public DataSet ReporteHojasPorProgramacion(int pIdProgramacion)
        {
            DtsPlanilla ds = new();
            var tablaDetalle = ds.DetallePlanilla;

            var listaVendedores = ConsultarHojasPorProgramacion(pIdProgramacion);
            var listaHojas = listaVendedores;

            foreach (var vendedor in listaVendedores.GroupBy(x => x.IdVendedor).ToList())
            {
                var listaHojasVendedor = listaHojas.Where(x => x.IdVendedor == vendedor.Key).OrderBy(x => x.NumeroHoja).Take(15);
                var indice = 1;

                DtsPlanilla.DetallePlanillaRow row = tablaDetalle.NewDetallePlanillaRow();

                var objVendedor = ConsultarVendedor(vendedor.Key);

                row.CodigoVendedor = objVendedor.Codigo;
                row.NombreVendedor = $"{objVendedor.Nombres} {objVendedor.Apellidos}";
                row.Total = listaHojasVendedor.Count();

                foreach (var hoja in listaHojasVendedor)
                {
                    switch (indice)
                    {
                        case 1:
                            row.Hoja1 = hoja.NumeroHoja;
                            break;
                        case 2:
                            row.Hoja2 = hoja.NumeroHoja;
                            break;
                        case 3:
                            row.Hoja3 = hoja.NumeroHoja;
                            break;
                        case 4:
                            row.Hoja4 = hoja.NumeroHoja;
                            break;
                        case 5:
                            row.Hoja5 = hoja.NumeroHoja;
                            break;
                        case 6:
                            row.Hoja6 = hoja.NumeroHoja;
                            break;
                        case 7:
                            row.Hoja7 = hoja.NumeroHoja;
                            break;
                        case 8:
                            row.Hoja8 = hoja.NumeroHoja;
                            break;
                        case 9:
                            row.Hoja9 = hoja.NumeroHoja;
                            break;
                        case 10:
                            row.Hoja10 = hoja.NumeroHoja;
                            break;
                        case 11:
                            row.Hoja11 = hoja.NumeroHoja;
                            break;
                        case 12:
                            row.Hoja12 = hoja.NumeroHoja;
                            break;
                        case 13:
                            row.Hoja13 = hoja.NumeroHoja;
                            break;
                        case 14:
                            row.Hoja14 = hoja.NumeroHoja;
                            break;
                        case 15:
                            row.Hoja15 = hoja.NumeroHoja;
                            break;
                    }

                    indice++;
                }

                tablaDetalle.AddDetallePlanillaRow(row);
            }

            ds.AcceptChanges();

            return ds;
        }
    }
}
