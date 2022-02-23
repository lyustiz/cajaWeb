using Caja.Datos;
using Caja.Entidades;
using Caja.Entidades.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioVendedorHojas : DominioBase
    {
        readonly RepositorioVendedorHoja mRepositorio;
        readonly RepositorioVendedorResumen mRepositorioResumen;
        readonly RepositorioVendedorModulo mRepositorioVendedorModulo;

        public DominioVendedorHojas(int pIdUsuario)
        {
            mRepositorio = new RepositorioVendedorHoja(pIdUsuario);
            mRepositorioResumen = new RepositorioVendedorResumen(pIdUsuario);
            mRepositorioVendedorModulo = new RepositorioVendedorModulo(pIdUsuario);
        }

        public List<VendedorHoja> ObtenerHojasVendedor(int pIdVendedor, int pIdProgramacion)
        {
            return mRepositorio.FindByVendedor(pIdVendedor, pIdProgramacion).ToList();
        }

        public VendedorHoja ObtenerHojaVendedor(int pIdVendedor, int pIdProgramacion, int pHoja)
        {
            return mRepositorio.FindByVendedor(pIdVendedor, pIdProgramacion, pHoja);
        }

        public List<VendedorHoja> ObtenerHojasProgramacion(int pIdProgramacion)
        {
            return mRepositorio.FindByProgramacion(pIdProgramacion).ToList();
        }

        public List<VistaVendedoresEntregaCartones> FindVendedoresEntregaCartones(string filtro)
        {
            return mRepositorio.FindVendedoresEntregaCartones(filtro).ToList();
        }

        public bool ExisteHoja(int pIdProgramacion, int pNumeroHoja)
        {
            return mRepositorio.ExisteHoja(pIdProgramacion, pNumeroHoja);
        }


        public VendedorHoja ObtenerHoja(int pId)
        {
            return mRepositorio.FindOne(pId);
        }

        public RespuestaDominio RegistrarHojaVendedor(VendedorResumen objResumen, VendedorHoja objVendedorHoja, List<int> lisHojas)
        {
            try
            {
                var vendedorResumen = mRepositorioResumen.FindByVendedorProgramacion(objVendedorHoja.IdVendedor, objVendedorHoja.IdProgramacionJuego);

                if (vendedorResumen is null)
                {
                    vendedorResumen = new VendedorResumen() { IdProgramacionJuego = objVendedorHoja.IdProgramacionJuego, IdVendedor = objVendedorHoja.IdVendedor };
                    vendedorResumen.IdVendedorResumen = mRepositorioResumen.Insert(vendedorResumen);
                }

                foreach (var hoja in lisHojas)
                {
                    var vendedorHoja = mRepositorio.FindByVendedor(objVendedorHoja.IdVendedor, objVendedorHoja.IdProgramacionJuego, hoja);

                    if (vendedorHoja is null)
                    {
                        vendedorHoja = new VendedorHoja() { IdProgramacionJuego = objVendedorHoja.IdProgramacionJuego, IdVendedor = objVendedorHoja.IdVendedor, NumeroHoja = hoja };
                        vendedorHoja.IdVendedorHoja = mRepositorio.Insert(vendedorHoja);
                    }
                }

                vendedorResumen.TotalCartones = objResumen.TotalCartones;
                vendedorResumen.CartonesCortesia = objResumen.CartonesCortesia;
                vendedorResumen.ValorTotal = objResumen.ValorTotal;
                vendedorResumen.ValorPendiente = vendedorResumen.ValorTotal - vendedorResumen.PagoAnticipado;

                vendedorResumen.IdVendedorResumen = mRepositorioResumen.Update(vendedorResumen);

                return Ok($"Las hojas se asociaron correctamente.", vendedorResumen.IdVendedorResumen);
            }
            catch (Exception ex)
            {
                return Error(ex.Message);
            }
        }

        public RespuestaDominio RegistrarHojaVendedor(VendedorHoja objVendedorHoja)
        {
            try
            {
                objVendedorHoja.IdVendedorHoja = mRepositorio.Insert(objVendedorHoja);

                return Ok($"Registro creado correctamente.", objVendedorHoja.IdVendedorHoja);
            }
            catch (Exception ex)
            {
                return Error(ex.Message);
            }
        }

        public RespuestaDominio EliminarHojaVendedor(VendedorResumen objVendedorResumen, VendedorHoja objVendedorHoja)
        {
            try
            {
                objVendedorHoja = mRepositorio.FindByVendedor(objVendedorHoja.IdVendedor, objVendedorHoja.IdProgramacionJuego, objVendedorHoja.NumeroHoja);
                mRepositorio.Deshabilitar(objVendedorHoja.IdVendedorHoja);

                objVendedorResumen.IdVendedorResumen = mRepositorioResumen.Update(objVendedorResumen);

                if (objVendedorResumen.TotalCartones == 0)
                {
                    var modulos = mRepositorioVendedorModulo.FindByVendedor(objVendedorHoja.IdVendedor, objVendedorHoja.IdProgramacionJuego).ToList();

                    if (modulos.Count == 0)
                        mRepositorioResumen.Deshabilitar(objVendedorResumen.IdVendedorResumen);
                }

                return Ok($"La hoja se eliminó correctamente.", objVendedorHoja.IdVendedorHoja);
            }
            catch (Exception ex)
            {
                return Error(ex.Message);
            }
        }

        public RespuestaDominio Deshabilitar(VendedorHoja objVendedorHoja)
        {
            try
            {
                objVendedorHoja = mRepositorio.FindByProgramacion(objVendedorHoja.IdProgramacionJuego).FirstOrDefault(x => x.NumeroHoja == objVendedorHoja.NumeroHoja);

                if (objVendedorHoja != null)
                {
                    mRepositorio.Deshabilitar(objVendedorHoja.IdVendedorHoja);
                }

                return Ok($"La hoja se eliminó correctamente.", objVendedorHoja.IdVendedorHoja);
            }
            catch (Exception ex)
            {
                return Error(ex.Message);
            }
        }
    }
}

