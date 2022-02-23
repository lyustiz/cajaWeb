using System.Collections.Generic;

namespace Caja.API.Reflection
{
    public static class ReflectionFunctions
    {
        public static List<string> ObtenerNombresClase<T>(T item) where T : class
        {
            List<string> lista = null;
            foreach (var prop in item.GetType().GetProperties())
            {
                lista.Add(prop.Name);
            }
            return lista;
        }
        //public List<string> ObtenerNombresYValoresClase<T>(T item) where T : class
        //{
        //    List<string> lista = null;
        //    foreach (var prop in item.GetType().GetProperties())
        //    {
        //        lista.Add(prop.Name, prop.GetValue(item, null));
        //    }
        //    return lista;
        //}
    }
}
