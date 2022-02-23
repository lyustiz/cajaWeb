using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace System
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class StringExtensionMethods
    {
        public static string SubstringFrom(this string me, string from)
        {
            if (me.IsNullOrEmpty())
                return string.Empty;

            var index = me.IndexOfIgnoreCase(from);
            if (index < 0)
                return string.Empty;

            return me.Substring(index + from.Length);
        }

        public static Boolean IsNumeric(this char me)
        {
            int result;
            return int.TryParse(me.ToString(), out result);
        }

        public static Boolean IsNumeric(this string me)
        {
            int result;
            return int.TryParse(me.ToString(), out result);
        }

        public static string SubstringTo(this string me, string to)
        {
            if (me.IsNullOrEmpty())
                return string.Empty;

            var index = me.IndexOfIgnoreCase(to);
            if (index < 0)
                return string.Empty;

            return me.Substring(0, index);
        }

        /// <summary>
        /// Determina si una cadena es Nula o Vacia
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>Verdadero o Falso</returns>
        public static bool IsNullOrEmpty(this string texto)
        {
            return String.IsNullOrEmpty(texto) || String.IsNullOrWhiteSpace(texto);
        }

        /// <summary>
        /// Determina si una cadena NO es Nula o Vacia
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>Verdadero o Falso</returns>
        public static bool NotIsNullOrEmpty(this string texto)
        {
            return !String.IsNullOrEmpty(texto);
        }

        public static string ToCamelCase(this string texto)
        {
            string letra = texto.Substring(0, 1).ToUpper();
            return $"{letra}{texto.Substring(1)}";
        }

        /// <summary>
        /// Indica en que lugar el string contine el texto toCheck lo busca con OrdinalIgnoringCase
        /// </summary>
        /// <param name="text"></param>
        /// <param name="toCheck">Texto a busar</param>
        /// <returns>El indice donde aparece por primera vez la cadena toCheck ignorando el case.</returns>
        public static int IndexOfIgnoreCase(this string text, string toCheck)
        {
            return text.IndexOf(toCheck, StringComparison.OrdinalIgnoreCase);
        }

        public static bool StartsWithIgnoreCase(this string text, string toCheck)
        {
            if (toCheck.IsNullOrEmpty())
                return true;

            if (text.IsNullOrEmpty())
                return toCheck.IsNullOrEmpty();

            return text.StartsWith(toCheck, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Indica si el string contine el texto toCheck lo busca con OrdinalIgnoringCase
        /// </summary>
        /// <param name="text"></param>
        /// <param name="toCheck">Texto a busar</param>
        /// <returns>True if the string contains the text toCheck ignoring case.</returns>
        public static bool ContainsIgnoreCase(this string text, string toCheck)
        {
            if (toCheck.IsNullOrEmpty())
                throw new ArgumentException("El parametro 'toCheck' es vacio");

            return text.IndexOfIgnoreCase(toCheck) >= 0;
        }
    }  
}