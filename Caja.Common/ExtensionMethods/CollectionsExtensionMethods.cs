using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace System
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class CollectionsExtensionMethods
    {
        public static bool IsNullOrZeroItems(this IList list)
        {
            return list == null || list.Count == 0;
        }

        public static bool NotIsNullOrZeroItems(this IList list)
        {
            return !IsNullOrZeroItems(list);
        }

        /// <summary>
        /// Search the <paramref name="source"/> in the <paramref name="list"/> and returns trus if found it
        /// </summary>
        /// <typeparam name="T">The Generic Class</typeparam>
        /// <param name="source">Value to search for</param>
        /// <param name="list">List to search in</param>
        /// <returns></returns>
        public static bool IsOn<T>(this T source, params T[] list) where T : IComparable
        {
            for (int i = 0; i < list.Length; i++)



            {
                if (list[i] == null)
                {
                    if (source == null)
                        return true;
                }
                else if (list[i].CompareTo(source) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsOnIgnoreCase(this string source, params string[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (source.EqualsIgnoreCase(list[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool EqualsIgnoreCase(this string text, string toCheck)
        {
            return string.Equals(text, toCheck, StringComparison.OrdinalIgnoreCase);
        }

        public static TValue GetOrAddValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TValue> newValueCreator)
        {
            TValue res;
            if (dictionary.TryGetValue(key, out res))
                return res;

            res = newValueCreator(key);
            dictionary[key] = res;
            return res;

        }
    }
}
