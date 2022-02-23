namespace Caja.MVC.Core.Models
{
    public class MonedaModel
    {
        readonly string pesos = "$";
        readonly string dolares = "U$";
        readonly string euros = "€";

        public string Tipo { get; set; }

        public string Formato { get; set; }

        public MonedaModel()
        {                
        }

        public MonedaModel(string moneda, string formato)
        {
            Tipo = moneda;

            if (string.IsNullOrWhiteSpace(moneda))
                Tipo = pesos;

            Formato = formato;
        }
    }
}
