using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace System
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class EnumExtensionMethods
    {
        /// <summary>
        /// Obtiene el string del atributo Description asociado al Enum
        /// Ej: [Description("Hola que tal)"]
        /// </summary>
        /// <param name="en">Enum</param>
        /// <returns></returns>
        /// 
        public static readonly Dictionary<Type, Dictionary<Enum, string>> mCachedDescriptions = new Dictionary<Type, Dictionary<Enum, string>>();

        private static string GetEnumDescription(Type type, Enum value)
        {
            var memInfo = type.GetMember(value.ToString());
            if (memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }
            return value.ToString();
        }

        public static string ToDescription(this Enum en)
        {
            Type type = en.GetType();

            var values = mCachedDescriptions.GetOrAddValue(type, _ =>
            {
                var res = new Dictionary<Enum, string>();
                foreach (Enum value in type.GetEnumValues())
                {
                    res.Add(value, GetEnumDescription(type, value));
                }

                return res;
            });

            return values.GetOrAddValue(en, value =>
            {
                MemberInfo[] memInfo = type.GetMember(value.ToString());
                if (memInfo.Length > 0)
                {
                    object[] attrs = memInfo[0].GetCustomAttributes(
                        typeof(DescriptionAttribute),
                        false);
                    if (attrs.Length > 0)
                        return ((DescriptionAttribute)attrs[0]).Description;
                }
                return value.ToString();
            }
                );
        }

        public static T GetAttribute<T>(this Enum en) where T : Attribute
        {
            Type type = en.GetType();
            MemberInfo[] memInfo = type.GetMember(en.ToString());
            if (memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(
                    typeof(T),
                    false);
                if (attrs.Length > 0)
                    return ((T)attrs[0]);
            }
            return null;
        }

        public static string ToCaseDB(this Type type, string name, string fieldName)
        {
            if (type.IsEnum == false)
                throw new InvalidOperationException("Solo para Enums");

            string res = " '" + name + "' = CASE " + fieldName + "\n ";

            Type underType = Enum.GetUnderlyingType(type);

            foreach (var item in Enum.GetValues(type))
            {
                MemberInfo[] memInfo = type.GetMember(Enum.GetName(type, item));

                if (memInfo != null && memInfo.Length > 0)
                {
                    res += " WHEN " + Convert.ChangeType(item, underType, null).ToString() + " THEN ";
                    object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                    if (attrs != null && attrs.Length > 0)
                        res += "'" + ((DescriptionAttribute)attrs[0]).Description + "' \n";
                }
            }

            return res += " ELSE 'FALTA' \n END ";
        }

        public static string GetEnumValueDescription(this Type type, object value)
        {
            MemberInfo[] memInfo = type.GetMember(Enum.GetName(type, value).ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(
                    typeof(DescriptionAttribute),
                    false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }
            return string.Empty;
        }

        public static T Append<T>(this System.Enum type, T value)
        {
            return (T)(object)(((int)(object)type | (int)(object)value));
        }

        public static T Remove<T>(this System.Enum type, T value)
        {
            return (T)(object)(((int)(object)type & ~(int)(object)value));
        }

        public static bool Has<T>(this System.Enum type, T value)
        {
            return (((int)(object)type & (int)(object)value) == (int)(object)value);
        }

        public static T GetEnumValue<T>(string str) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new Exception("T must be an Enumeration type.");
            }
            T val = ((T[])Enum.GetValues(typeof(T)))[0];
            if (!string.IsNullOrEmpty(str))
            {
                foreach (T enumValue in (T[])Enum.GetValues(typeof(T)))
                {
                    if (enumValue.ToString().ToUpper().Equals(str.ToUpper()))
                    {
                        val = enumValue;
                        break;
                    }
                }
            }

            return val;
        }
    }
}
