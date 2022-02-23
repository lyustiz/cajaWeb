using System;
using System.Collections.Generic;
using System.Reflection;

namespace Caja.Core.Entidades
{
    public static class ReflectionFunctions
    {
        public static List<string> ObtenerNombresClase<T>(T item) where T : class
        {
            List<string> lista = new List<string>();
            foreach (var prop in item.GetType().GetProperties())
            {
                lista.Add(prop.Name);
            }
            return lista;
        }
        public static bool AsignarValor<T>(T item,string name, object? value) where T : class
        {
            try
            {
                PropertyInfo propertyInfo = item.GetType().GetProperty(name);
                propertyInfo.SetValue(item, Convert.ChangeType(value, propertyInfo.PropertyType), null);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
