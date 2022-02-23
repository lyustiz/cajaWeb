using Caja.Datos;
using Caja.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caja.Dominio
{
    public sealed class DominioVendedorCobroCarton : DominioBase
    {
        readonly RepositorioVendedorCobroCarton mRepositorio;
        readonly RepositorioVendedorCuentaCobrar mRepositorioCuentaCobrar;
        readonly RepositorioVendedorResumen mRepositorioVendedorResumen;

        public DominioVendedorCobroCarton(int pIdUsuario)
        {
            mRepositorio = new RepositorioVendedorCobroCarton(pIdUsuario);
            mRepositorioCuentaCobrar = new RepositorioVendedorCuentaCobrar(pIdUsuario);
            mRepositorioVendedorResumen = new RepositorioVendedorResumen(pIdUsuario);
        }

        public VendedorCobroCarton ObtenerPorVendedor(int pIdVendedor, int pIdProgramacion)
        {
            return mRepositorio.FindByVendedorProgramacion(pIdVendedor, pIdProgramacion);
        }

        public List<VendedorCobroCarton> ObtenerPorUsuario(int pIdUsuario, int pIdProgramacion)
        {
            return mRepositorio.FindByUsuarioProgramacion(pIdUsuario, pIdProgramacion);
        }

        public List<VendedorCobroCarton> ObtenerPorProgramacion(int pIdProgramacion)
        {
            return mRepositorio.FindByProgramacion(pIdProgramacion).ToList();
        }

        public List<int> FindProgramacionGroupByUsuario(int pIdProgramacion)
        {
            return mRepositorio.FindProgramacionGroupByUsuario(pIdProgramacion).ToList();
        }

        public VendedorCobroCarton ObtenerResumen(int pId)
        {
            return mRepositorio.FindOne(pId);
        }

        public RespuestaDominio GuardarRegistro(VendedorCobroCarton objVendedorCobroCarton)
        {
            try
            {
                VendedorCobroCarton cobroCarton = ObtenerPorVendedor(objVendedorCobroCarton.IdVendedor, objVendedorCobroCarton.IdProgramacionJuego);

                if (cobroCarton is null)
                {
                    objVendedorCobroCarton.IdVendedorCobroCarton = mRepositorio.Insert(objVendedorCobroCarton);

                    if (objVendedorCobroCarton.IdVendedorCobroCarton <= 0)
                        return Error("El cobro de cartón no se guardo correctamente, por favor verifique la información.");

                    /// Actualizar el resumen del vendedor.
                    VendedorResumen vendedorResumen = mRepositorioVendedorResumen.FindByVendedorProgramacion(objVendedorCobroCarton.IdVendedor, objVendedorCobroCarton.IdProgramacionJuego);

                    if (vendedorResumen is null)
                        return Error("El vendedor no tiene un resumen previo en el sistema.");

                    vendedorResumen.CartonesDevueltos = objVendedorCobroCarton.CartonesDevueltos;
                    vendedorResumen.NumeroHojasDevueltas = objVendedorCobroCarton.NumeroHojasEntregadas;
                    vendedorResumen.PorcentajeComision = objVendedorCobroCarton.PorcentajeComision;
                    vendedorResumen.Cobrado = 1;
                    vendedorResumen.CartonesCortesia = objVendedorCobroCarton.CartonesCortesia;
                    vendedorResumen.Faltante = objVendedorCobroCarton.Faltante;
                    vendedorResumen.GastoCortesia = objVendedorCobroCarton.GastoCortesia;

                    mRepositorioVendedorResumen.Update(vendedorResumen);

                    VendedorCuentaCobrar cuentaCobrar = mRepositorioCuentaCobrar.FindByVendedorProgramacion(objVendedorCobroCarton.IdVendedor, objVendedorCobroCarton.IdProgramacionJuego);

                    if (cuentaCobrar is null && objVendedorCobroCarton.Faltante > 0)
                    {
                        /// Insertar registro de cuenta por cobrar,
                        cuentaCobrar = new VendedorCuentaCobrar()
                        {
                            IdProgramacionJuego = objVendedorCobroCarton.IdProgramacionJuego,
                            IdVendedor = objVendedorCobroCarton.IdVendedor,
                            Valor = objVendedorCobroCarton.Faltante
                        };

                        int mIdCuentaCobro = mRepositorioCuentaCobrar.Insert(cuentaCobrar);

                        if (mIdCuentaCobro > 0)
                            return Ok($"Se registró el cobro correctamente y se generó una cuenta de cobro por el faltante de {objVendedorCobroCarton.Faltante}.");
                        else
                            return Ok("Se guardo el cobro pero NO SE GUARDO la cuenta por cobrar del faltante.");
                    }

                    return Ok($"Se registró  el cobro correctamente.");
                }
                else
                    return Error("Esta información no se puede modificar.");
            }
            catch (Exception ex)
            {
                return Error($"Error: {ex.Message}");
            }
        }

        public SumatoriaValores CalcularSumatoriaValores(int pIdProgramacion)
        {
            return mRepositorio.CalcularSumatoriaValores(pIdProgramacion);
        }
    }
}



