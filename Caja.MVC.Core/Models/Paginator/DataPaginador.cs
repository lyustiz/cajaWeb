
using System.Collections.Generic;

namespace Caja.MVC.Core.Models.Paginator
{
    public class DataPaginador<T>
    {
        public List<T> Lista { get; set; }
        public string Pagi_info { get; set; }
        public string Pagi_navegacion { get; set; }
        public T Modelo { get; set; }
        public int Registros { get; set; }
        public string Search { get; set; }
        public string ErrorMessage { get; set; }
    }
}
