using Caja.Entidades;
using Caja.Entidades.Vistas;
using System.Collections.Generic;

namespace Caja.Datos
{
    public sealed class RepositorioRoe : RepositorioBase
    {
        public IEnumerable<TipoRelacion> FindAllTiposRelacion()
        {
            return base.FetchObjects<TipoRelacion>($"SELECT IdTipoRelacion, Descripcion FROM tiposrelacion ORDER BY IdTipoRelacion;");
        }

        public IEnumerable<Listabla> FindAllSeries()
        {
            return base.FetchObjects<Listabla>($"SELECT * FROM listablas;");
        }

        public IEnumerable<ItemLista> FindAllFiguras()
        {
            return base.FetchObjects<ItemLista>($"SELECT IdPlenoAutomatico AS Id, Nombre FROM plenoautomatico Order By Nombre;");
        }

        public IEnumerable<ItemLista> FindAllConceptoGastos()
        {
            return base.FetchObjects<ItemLista>($"SELECT IdConceptoGasto AS Id, Descripcion AS Nombre FROM conceptogastos Order By Descripcion;");
        }

        public IEnumerable<ItemLista> FindAllConceptoIngresos()
        {
            return base.FetchObjects<ItemLista>($"SELECT IdConceptoIngreso AS Id, Descripcion AS Nombre FROM conceptoingresos Order By Descripcion;");
        }

        public IEnumerable<ItemLista> FindAllSocios()
        {
            return base.FetchObjects<ItemLista>($"SELECT IdUsuario as Id, NombreCompleto AS Nombre FROM usuarios WHERE Porcentaje > 0 AND Estado = 'H';");
        }

        public IEnumerable<DefinicionMoneda> FindAllDefinicionMoneda()
        {
            return base.FetchObjects<DefinicionMoneda>("SELECT mone.IdDefinicionMoneda, mone.Moneda, mone.Tipo, mone.Nominal, mone.Equivalencia, mone.GrupoSuma " +
                "FROM definicionmonedas mone, parametrosgenerales para " +
                "WHERE mone.Moneda = para.Valor AND(para.Referencia = 'strModeda' OR para.Referencia = 'strMoneda') ORDER BY mone.IdDefinicionMoneda;");
        }

        public IEnumerable<VistaVendedorCobroCartones> FindAllVendedoresCobroCartones(int pIdProgramacion)
        {
            return base.FetchObjects<VistaVendedorCobroCartones>($"SELECT vend.Nombres, vend.Apellidos, veco.* FROM vendedores vend INNER JOIN vendedorescobrocartones" +
                $" veco ON vend.IdVendedor = veco.IdVendedor WHERE veco.Estado = 'A' and veco.IdProgramacionJuego = {pIdProgramacion}; ");
        }

        public IEnumerable<VistaVendedorCobroCartones> FindAllVendedoresCobroCartones(int pIdProgramacion, int pIdUsuario)
        {
            return base.FetchObjects<VistaVendedorCobroCartones>($"SELECT vend.Nombres, vend.Apellidos, veco.*" +
                $" FROM vendedorescobrocartones AS veco INNER JOIN vendedores vend ON veco.IdVendedor = vend.IdVendedor" +
                $" INNER JOIN vendedoresresumen AS veru ON veco.IdProgramacionJuego = veru.IdProgramacionJuego And veco.IdVendedor = veru.IdVendedor And veco.Estado = veru.Estado" +
                $" WHERE veco.Estado = 'A' AND veco.IdUsuario = {pIdUsuario} AND veco.IdProgramacionJuego = {pIdProgramacion};");
        }

        public IEnumerable<int> FindAllVendedoresCobroCartonesPorUsuario(int pIdUsuario)
        {
            return base.FetchObjects<int>($"SELECT veco.IdProgramacionJuego FROM vendedores vend INNER JOIN vendedorescobrocartones" +
                $" veco ON vend.IdVendedor = veco.IdVendedor WHERE veco.Estado = 'A' and veco.IdUsuario = {pIdUsuario}; ");
        }

        public IEnumerable<RecaudoTotal> FindRecaudoProgramacion(int pIdProgramacion)
        {
            return base.FetchObjects<RecaudoTotal>($"SELECT usua.NombreCompleto AS NombreUsuario, reto.* FROM recaudototales reto, usuarios usua WHERE usua.IdUsuario = reto.IdUsuario AND reto.IdProgramacionJuego = {pIdProgramacion} AND reto.Estado = 'A';");
        }

        public IEnumerable<FiguraProgramacion> FindFigurasProgramacion(int pIdProgramacion)
        {
            return base.FetchObjects<FiguraProgramacion>($"select f.nombre AS Nombre, p.ValorPremio from programacionjuegosfiguras p, plenoautomatico f " +
                $"where p.IdPlenoAutomatico = f.IdPlenoAutomatico and p.IdProgramacionJuego = {pIdProgramacion} and p.Estado = 'A'; ");
        }
    }
}
