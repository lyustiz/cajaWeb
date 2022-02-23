using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Caja.Datos.DataLayer
{
    public static class Ducking<T>
    {
        private sealed class FieldData
        {
            private static CultureInfo Culture = CultureInfo.CurrentCulture;

            private FieldInfo mFieldInfo;

            private readonly bool mIsNullable;
            private Action<T, object> mSetter;
            private readonly Func<T, object, T> mSetterStruct;

            private object DefaultValue { get; }
            private Type NullableType { get; }
            public readonly string mDataName;
            private bool IsValueType { get; }

            public FieldData(FieldInfo fieldInfo)
            {
                mFieldInfo = fieldInfo;
                var attbs = fieldInfo.GetCustomAttributes(typeof(DefaultValueAttribute), false);
                if (attbs.Length > 0)
                {
                    DefaultValueAttribute defaultvalue = (DefaultValueAttribute)attbs[0];
                    DefaultValue = Convert.ChangeType(defaultvalue.Value, mFieldInfo.FieldType);
                }

                // ColumnName (For named mapping)
                mDataName = mFieldInfo.Name;

                attbs = fieldInfo.GetCustomAttributes(typeof(DuckingColumnAttribute), false);
                if (attbs.Length > 0)
                {
                    DuckingColumnAttribute colName = (DuckingColumnAttribute)attbs[0];
                    mDataName = colName.ColumnName;
                }


                mIsNullable = fieldInfo.FieldType.IsValueType &&
                              fieldInfo.FieldType.IsGenericType &&
                              fieldInfo.FieldType.GetGenericTypeDefinition() == typeof(Nullable<>);

                if (mIsNullable)
                    NullableType = fieldInfo.FieldType.GetGenericArguments()[0];

                if (mIsStruct)
                    mSetterStruct = MakeSetterStruct(fieldInfo);
                else
                    mSetter = MakeSetter(fieldInfo);

                IsValueType = mFieldInfo.FieldType.IsValueType;
            }

            public void SetValue(T current, object value)
            {
                if (value == DBNull.Value)
                {
                    if (IsValueType && DefaultValue == null)
                    {
                        if (!mIsNullable)
                            throw new Exception("The field: " + mFieldInfo.Name + " is a value type and the data reader returns DbNull. You must use [DefaultValue] or a Nullable Type to avoid this issue.");
                        //else
                        // no set because it uses the default Value (that is unset)
                    }
                    else
                        mSetter(current, DefaultValue);
                }
                else
                {
                    if (mIsNullable)
                        mSetter(current, Convert.ChangeType(value, NullableType, Culture));
                    else if (mFieldInfo.FieldType.IsEnum && value.GetType() == typeof(string))
                        mSetter(current, Enum.Parse(mFieldInfo.FieldType, (string)value, true));
                    else
                    {
                        if (mFieldInfo.CustomAttributes.Where(x => x.AttributeType == typeof(HashEncodeFieldAttribute)).ToList().Any())
                        {
                            //// Si es campo tiene el atributo HashEncodeField, se hace el Hash del valor.
                            //var hashEncode = HashIdsResolver.Encode(Convert.ToInt32(value));
                            //mSetter(current, Convert.ChangeType(hashEncode, mFieldInfo.FieldType, Culture));
                        }
                        else
                        {
                            mSetter(current, Convert.ChangeType(value, mFieldInfo.FieldType, Culture));
                        }
                    }

                }


            }

            public T SetValueStruct(T current, object value)
            {
                if (value == DBNull.Value)
                {
                    if (IsValueType && DefaultValue == null)
                    {
                        if (!mIsNullable)
                            throw new Exception("The field: " + mFieldInfo.Name +
                                                " is a value type and the data reader returns DbNull. You must use [DefaultValue] or a Nullable Type to avoid this issue.");
                        //else
                        // no set because it uses the default Value (that is unset)
                    }
                    else
                        current = mSetterStruct(current, DefaultValue);
                }
                else
                {
                    if (mIsNullable)
                        current = mSetterStruct(current, Convert.ChangeType(value, NullableType, Culture));
                    else if (mFieldInfo.FieldType.IsEnum &&
                             value.GetType() == typeof(string))
                        current = mSetterStruct(current, Enum.Parse(mFieldInfo.FieldType, (string)value, true));
                    else
                        current = mSetterStruct(current, Convert.ChangeType(value, mFieldInfo.FieldType, Culture));
                }

                return current;
            }
        }

        private static FieldData[] mFieldData;
        //private static Dictionary<string, FieldData> mFieldDataByName;

        private static CreateNewObject mFastConstructor;
        private static bool mIsStruct;
        static Ducking()
        {
            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (fields.Length == 0)
                throw new InvalidOperationException("The class: " + typeof(T).Name +
                                                    " must contain at least one field.");

            mIsStruct = typeof(T).IsValueType;

            //Remove ignored
            fields = Array.FindAll(fields, (x) => !x.IsDefined(typeof(DuckingIgnoreFieldAttribute), false));

            if (!mIsStruct)
                mFastConstructor = CreateFastConstructor();

            mFieldData = new FieldData[fields.Length];
            //mFieldDataByName = new Dictionary<string, FieldData>();

            for (int i = 0; i < fields.Length; i++)
            {
                var data = new FieldData(fields[i]);
                mFieldData[i] = data;
                //mFieldDataByName.Add(data.mFieldInfo.Name, data);
            }

        }

        private static Action<T, object> MakeSetter(FieldInfo field)
        {
            DynamicMethod m = new DynamicMethod(
                "setthefield_" + field.Name, MethodAttributes.Static | MethodAttributes.Public,
                CallingConventions.Standard,
                typeof(void),
                new[] { (mIsStruct ? typeof(T).MakeByRefType() : typeof(T)), typeof(object) }, typeof(T), true);

            ILGenerator cg = m.GetILGenerator();

            // arg0.<field> = arg1

            //if (mIsStruct)
            //    cg.Emit(OpCodes.Ldarga_S, 0);            
            //else

            cg.Emit(OpCodes.Ldarg_0);

            cg.Emit(OpCodes.Ldarg_1);

            if (field.FieldType.IsValueType)
                cg.Emit(OpCodes.Unbox_Any, field.FieldType);
            else
                cg.Emit(OpCodes.Castclass, field.FieldType);

            cg.Emit(OpCodes.Stfld, field);

            cg.Emit(OpCodes.Ret);

            return (Action<T, object>)m.CreateDelegate(typeof(Action<T, object>));
        }

        private static Func<T, object, T> MakeSetterStruct(FieldInfo field)
        {
            DynamicMethod m = new DynamicMethod(
                "setthefield_" + field.Name, MethodAttributes.Static | MethodAttributes.Public,
                CallingConventions.Standard,
                typeof(T),
                new[] { typeof(T), typeof(object) }, typeof(T), true);

            ILGenerator cg = m.GetILGenerator();

            //LocalBuilder a = cg.DeclareLocal(typeof(T));

            // arg0.<field> = arg1

            cg.Emit(OpCodes.Ldarga_S, 0);
            cg.Emit(OpCodes.Ldarg_1);

            if (field.FieldType.IsValueType)
                cg.Emit(OpCodes.Unbox_Any, field.FieldType);
            else
                cg.Emit(OpCodes.Castclass, field.FieldType);

            cg.Emit(OpCodes.Stfld, field);

            cg.Emit(OpCodes.Ldarg_0);
            //cg.Emit(OpCodes.Stloc, a);

            //cg.Emit(OpCodes.Ldloc, a);

            cg.Emit(OpCodes.Ret);

            return (Func<T, object, T>)m.CreateDelegate(typeof(Func<T, object, T>));
        }


        public static T[] DataTableByIndex(DataTable table)
        {
            var res = new List<T>();

            foreach (DataRow row in table.Rows)
            {
                T current = default(T);
                if (!mIsStruct)
                    current = (T)mFastConstructor();

                for (int i = 0; i < mFieldData.Length; i++)
                {
                    var value = row[i];
                    var fieldData = mFieldData[i];

                    if (mIsStruct)
                        current = fieldData.SetValueStruct(current, value);
                    else
                        fieldData.SetValue(current, value);
                }

                res.Add(current);
            }

            return res.ToArray();
        }

        public static T[] DataTableByName(DataTable table)
        {
            var res = new List<T>();

            foreach (DataRow row in table.Rows)
            {
                T current = default(T);
                if (!mIsStruct)
                    current = (T)mFastConstructor();


                for (int i = 0; i < mFieldData.Length; i++)
                {
                    var name = mFieldData[i].mDataName;
                    var value = row[name];

                    var fieldData = mFieldData[i];

                    if (mIsStruct)
                        current = fieldData.SetValueStruct(current, value);
                    else
                        fieldData.SetValue(current, value);

                }
                res.Add(current);
            }

            return res.ToArray();
        }

        public static T RecordByIndex(IDataRecord reader)
        {
            if (mFieldData.Length > reader.FieldCount)
                throw new IndexOutOfRangeException("The IDataRecord contains only " + reader.FieldCount + " and the class " + mFieldData.Length.ToString());

            T current = default(T);
            if (!mIsStruct)
                current = (T)mFastConstructor();


            for (int i = 0; i < mFieldData.Length; i++)
            {
                var value = reader[i];
                var fieldData = mFieldData[i];

                if (mIsStruct)
                    current = fieldData.SetValueStruct(current, value);
                else
                    fieldData.SetValue(current, value);

            }

            return current;
        }


        private delegate object CreateNewObject();

        private static CreateNewObject CreateFastConstructor()
        {
            var dm = new DynamicMethod("_CreateRecordFast_FH_RT_",
                MethodAttributes.Static | MethodAttributes.Public,
                CallingConventions.Standard,
                typeof(object),
                new[] { typeof(object[]) },
                typeof(T),
                true);

            ILGenerator generator = dm.GetILGenerator();

            var constructor =
                typeof(T).GetConstructor(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic,
                    null,
                    new Type[] { },
                    new ParameterModifier[] { });

            if (constructor == null)
                throw new InvalidOperationException("The type: " + typeof(T).Name + " must have a parameter less constructor (public or private) ");

            generator.Emit(OpCodes.Newobj, constructor);

            generator.Emit(OpCodes.Ret);

            return (CreateNewObject)dm.CreateDelegate(typeof(CreateNewObject));
        }


        public static T RecordByName(IDataRecord reader)
        {
            if (mFieldData.Length > reader.FieldCount)
                throw new IndexOutOfRangeException("The IDataRecord contains only " + reader.FieldCount + " and the class " + mFieldData.Length.ToString());

            T current = default(T);
            if (!mIsStruct)
                current = (T)mFastConstructor();


            for (int i = 0; i < mFieldData.Length; i++)
            {
                var name = mFieldData[i].mDataName;
                object value;
                try
                {
                    value = reader[name];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException("The IDataRecord not contains the field: " + name);
                }

                var fieldData = mFieldData[i];

                if (mIsStruct)
                    current = fieldData.SetValueStruct(current, value);
                else
                    fieldData.SetValue(current, value);

            }

            return current;

        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public sealed class DuckingColumnAttribute
        : Attribute
    {
        public DuckingColumnAttribute(string columnName)
        {
            ColumnName = columnName;
        }

        internal string ColumnName;
    }

    [AttributeUsage(AttributeTargets.Field)]
    public sealed class DuckingIgnoreFieldAttribute
        : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Field)]
    public sealed class HashEncodeFieldAttribute
        : Attribute
    {
    }
}

