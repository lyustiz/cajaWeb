using System.Collections.Generic;
using System.Linq;

namespace Caja.MVC.Core.Models
{
    public class ComboModel
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public ComboModel()
        {
        }

        public ComboModel(int value, string text)
        {
            Value = value;
            Text = text;
        }

        public IOrderedEnumerable<ComboModel> ListaSiNo()
        {
            List<ComboModel> lista = new();

            lista.Add(new ComboModel { Value = 0, Text = "No" });
            lista.Add(new ComboModel { Value = 1, Text = "Si" });

            return lista.OrderBy(x => x.Value);
        }

        public IOrderedEnumerable<ComboModel> ListaEstadoCivil()
        {
            List<ComboModel> lista = new();

            lista.Add(new ComboModel(1, "Soltero(a)"));
            lista.Add(new ComboModel(2, "Casado(a)"));
            lista.Add(new ComboModel(3, "Union Libre"));
            lista.Add(new ComboModel(4, "Separado(a)"));
            lista.Add(new ComboModel(5, "Divorciado(a)"));
            lista.Add(new ComboModel(6, "Viudo(a)"));

            return lista.OrderBy(x => x.Value);
        }

        public IOrderedEnumerable<ComboModel> ListaTiposRelacion()
        {
            List<ComboModel> lista = new();

            lista.Add(new ComboModel(1, "Conyugue"));
            lista.Add(new ComboModel(2, "Referencia Personal"));
            lista.Add(new ComboModel(3, "Referencia Familiar"));
            lista.Add(new ComboModel(4, "Hijo(a)"));

            return lista.OrderBy(x => x.Value);
        }
    }
}
