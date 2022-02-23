using Caja.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Core.Repositorio
{
    public partial class RepositorioVendedor : RepositorioBase
    {
        /// <summary>
        /// Obtener la información de un usuario
        /// </summary>
        /// <param name="referencia">Referencia única del parametro.</param>
        /// <returns><see cref="Parametrosgenerales"/></returns>
        public IEnumerable<Vendedoreshojas> ObtenerPorProgramacion(int pIdProgramacion)
        {
            return Contexto.Vendedoreshojas.Where(x => x.IdProgramacionJuego == pIdProgramacion && x.Estado == "A");
        }

        public IEnumerable<Vendedoreshojas> ObtenerPorVendedor(int pIdVendedor, int pIdProgramacion)
        {
            return Contexto.Vendedoreshojas.Where(x => x.IdVendedor == pIdVendedor && x.IdProgramacionJuego == pIdProgramacion && x.Estado == "A");
        }

        public Vendedoreshojas ObtenerPorVendedor(int pIdVendedor, int pIdProgramacion, int hoja)
        {
            return Contexto.Vendedoreshojas.FirstOrDefault(x => x.IdVendedor == pIdVendedor && x.IdProgramacionJuego == pIdProgramacion && x.Estado == "A" && x.NumeroHoja == hoja);
        }

        public Vendedoreshojas ExisteHoja(int pIdProgramacion, int pNumeroHoja)
        {
            return Contexto.Vendedoreshojas.FirstOrDefault(x => x.Estado == "A" && x.IdProgramacionJuego == pIdProgramacion && x.NumeroHoja == pNumeroHoja);
        }

        public bool GuardarHojas(Vendedoresresumen resumen, List<int> hojas)
        {
            using var transaction = Contexto.Database.BeginTransaction();

            try
            {
                var resu = FindByVendedorProgramacion(resumen.IdVendedor, resumen.IdProgramacionJuego);

                if (resu == null)
                {
                    resu = new Vendedoresresumen() { IdProgramacionJuego = resumen.IdProgramacionJuego, IdVendedor = resumen.IdVendedor, Estado = "A" };
                    Contexto.Vendedoresresumen.Add(resu);
                    Contexto.SaveChanges();

                    resu.IdVendedorResumen = FindByVendedorProgramacion(resumen.IdVendedor, resumen.IdProgramacionJuego).IdVendedorResumen;
                }

                foreach (var hoja in hojas)
                {
                    var vendedorHoja = ObtenerPorVendedor(resumen.IdVendedor, resumen.IdProgramacionJuego, hoja);

                    if (vendedorHoja == null)
                    {
                        vendedorHoja = new Vendedoreshojas() { IdProgramacionJuego = resumen.IdProgramacionJuego, IdVendedor = resumen.IdVendedor, NumeroHoja = hoja, Estado = "A"};
                        Contexto.Vendedoreshojas.Add(vendedorHoja);
                    }
                }

                resu.TotalCartones = resumen.TotalCartones;
                resu.CartonesCortesia = resumen.CartonesCortesia;
                resu.ValorTotal = resumen.ValorTotal;
                resu.ValorPendiente = resu.ValorTotal - resu.PagoAnticipado;

                Contexto.Vendedoresresumen.Update(resu);
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
