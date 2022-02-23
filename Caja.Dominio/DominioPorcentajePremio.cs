using Caja.Datos;
using Caja.Entidades;

namespace Caja.Dominio
{
    public sealed class DominioPorcentajePremio
    {
        readonly RepositorioPorcentajePremio mRepositorio;
        public DominioPorcentajePremio()
        {
            mRepositorio = new RepositorioPorcentajePremio();
        }

        public PorcentajePremio FetchOne()
        {
            return mRepositorio.FindOne();
        }

        public int Save(PorcentajePremio objEntidad)
        {
            if (objEntidad.IdPorcentajePremio > 0)
                return mRepositorio.Update(objEntidad);
            else
                return mRepositorio.Insert(objEntidad);
        }

        public int CalcularPorcentaje(int cartones)
        {
            PorcentajePremio objEntidad = FetchOne();
            int porcentaje = 0;

            if (objEntidad.ActivoDescuento == 1)
            {
                if (cartones > objEntidad.Premio1Cartones)
                {
                    if (cartones > objEntidad.Premio2Cartones)
                    {
                        if (cartones > objEntidad.Premio3Cartones)
                        {
                            if (cartones > objEntidad.Premio4Cartones)
                                porcentaje = objEntidad.Premio5Porcentaje;
                            else
                                porcentaje = objEntidad.Premio4Porcentaje;
                        }
                        else
                            porcentaje = objEntidad.Premio3Porcentaje;
                    }
                    else
                        porcentaje = objEntidad.Premio2Porcentaje;
                }
                else
                    porcentaje = objEntidad.Premio1Porcentaje;
            }
            else
                porcentaje = -1;

            return porcentaje;
        }
    }
}


