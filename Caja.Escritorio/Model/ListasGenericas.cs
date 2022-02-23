using System.Collections.Generic;

namespace Caja.Escritorio.Model
{
    public static class ListasGenericas
    {
        public static List<ItemCombo> GenerarListaEstadoCivil()
        {
            var lista = new List<ItemCombo>();
            lista.Add(new ItemCombo(1, "Soltero(a)"));
            lista.Add(new ItemCombo(2, "Casado(a)"));
            lista.Add(new ItemCombo(3, "Union Libre"));
            lista.Add(new ItemCombo(4, "Separado(a)"));
            lista.Add(new ItemCombo(5, "Divorciado(a)"));
            lista.Add(new ItemCombo(6, "Viudo(a)"));

            return lista;
        }

        public static List<ItemCombo> GenerarListaMeses()
        {
            var lista = new List<ItemCombo>();
            lista.Add(new ItemCombo(1, "Enero"));
            lista.Add(new ItemCombo(2, "Febrero"));
            lista.Add(new ItemCombo(3, "Marzo"));
            lista.Add(new ItemCombo(4, "Abril"));
            lista.Add(new ItemCombo(5, "Mayo"));
            lista.Add(new ItemCombo(6, "Junio"));
            lista.Add(new ItemCombo(7, "Julio"));
            lista.Add(new ItemCombo(8, "Agosto"));
            lista.Add(new ItemCombo(9, "Septiembre"));
            lista.Add(new ItemCombo(10, "Octubre"));
            lista.Add(new ItemCombo(11, "Noviembre"));
            lista.Add(new ItemCombo(12, "Diciembre"));

            return lista;
        }
    }
}

