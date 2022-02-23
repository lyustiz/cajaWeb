using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Bingo.Datos.DataLayer
{

    /// <summary>
    /// This is a DataReader that 'fixes' any null values before
    /// they are returned to our enties code.
    /// </summary>
    internal sealed class SafeDataReader : IDataReader
    {

        private readonly IDataReader mDataReader;

        private const Int32 DefaultInt32 = 0;
        private const Int16 DefaultInt16 = 0;
        private const Int64 DefaultInt64 = 0;
        private const byte DefaultByte = 0;
        private const decimal DefaultDecimal = 0;
        private const double DefaultDouble = 0;
        private const float DefaultFloat = 0;

        /// <summary>
        /// Initializes the SafeDataReader object to use data from
        /// the provided DataReader object.
        /// </summary>
        /// <param name="dataReader">The source DataReader object containing the data.</param>
        public SafeDataReader(IDataReader dataReader)
        {
            mDataReader = dataReader;
        }

        public bool HasRows
        {
            get
            {
                if (mDataReader is MySqlDataReader)
                {
                    return ((MySqlDataReader)mDataReader).HasRows;
                }
                else
                {
                    return true;
                }
            }
        }


        /// <summary>
        /// Gets a string value from the datareader.
        /// </summary>
        /// <remarks>
        /// Returns empty string for null.
        /// </remarks>
        public string GetString(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return string.Empty;
            }
            else
            {
                var res = mDataReader.GetString(i);
                if (res.Length == 0) // Reduce memory
                    return string.Empty;
                else
                    return res;
            }
        }


        /// <summary>
        /// Gets a string value from the datareader but make it unique in memory
        /// </summary>
        /// <remarks>
        /// Returns empty string for null.
        /// </remarks>
        public string GetStringInterned(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return string.Empty;
            }
            else
            {
                var res = mDataReader.GetString(i);
                if (res.Length == 0)
                    return string.Empty;
                else
                    return string.Intern(res);
            }
        }

        /// <summary>
        /// Gets a string value from the datareader.
        /// </summary>
        /// <remarks>
        /// Returns "" for null.
        /// </remarks>
        public string GetString(string name)
        {
            return this.GetString(this.GetOrdinal(name));
        }

        /// <summary>
        /// Gets a value of type <see cref="System.Object" /> from the datareader.
        /// </summary>
        /// <remarks>
        /// Returns Nothing for null.
        /// </remarks>
        public object GetValue(int i)
        {
            return mDataReader.GetValue(i);
            //If mDataReader.IsDBNull(i) Then
            //    Return Nothing
            //Else
            //    Return mDataReader.GetValue(i)
            //End If
        }

        /// <summary>
        /// Gets a value of type <see cref="System.Object" /> from the datareader.
        /// </summary>
        /// <remarks>
        /// Returns Nothing for null.
        /// </remarks>
        public object GetValue(string name)
        {
            return this.GetValue(this.GetOrdinal(name));
        }

        public int GetInt32(int i, int nullValue)
        {
            if (mDataReader.IsDBNull(i))
            {
                return nullValue;
            }
            else
            {
                return mDataReader.GetInt32(i);
            }
        }

        public int GetInt32(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return DefaultInt32;
            }
            else
            {
                return mDataReader.GetInt32(i);
            }
        }


        public T? GetNullable<T>(int i) where T : struct
        {
            if (mDataReader.IsDBNull(i))
            {
                return null;
            }
            else
            {
                return (T)mDataReader.GetValue(i);
            }
        }

        public char? GetNullableChar(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return null;
            }
            else
            {
                var str = this.mDataReader.GetString(i);
                if (str.Length == 1)
                    return str[0];
                else if (str.Length == 0)
                    throw new InvalidOperationException("Cualquiera es nullable char, no es null pero no tiene ningun caracter, medio mentira me parece");
                else
                    throw new InvalidOperationException("Cualquiera es nullable char, no es null pero tiene mas de un caracter: " + str);
            }
        }

        public string GetNullableString(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return null;
            }
            else
            {
                return mDataReader.GetString(i);
            }
        }

        /// <summary>
        /// Gets an integer from the datareader.
        /// </summary>
        /// <remarks>
        /// Returns 0 for null.
        /// </remarks>
        public int GetInt32(string name)
        {
            return this.GetInt32(this.GetOrdinal(name));
        }

        /// <summary>
        /// Gets a double from the datareader.
        /// </summary>
        /// <remarks>
        /// Returns 0 for null.
        /// </remarks>
        public double GetDouble(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return DefaultDouble;
            }
            else
            {
                return mDataReader.GetDouble(i);
            }
        }


        public double GetDouble(int i, double nullValue)
        {
            if (mDataReader.IsDBNull(i))
            {
                return nullValue;
            }
            else
            {
                return mDataReader.GetDouble(i);
            }
        }

        /// <summary>
        /// Gets a double from the datareader.
        /// </summary>
        /// <remarks>
        /// Returns 0 for null.
        /// </remarks>
        public double GetDouble(string name)
        {
            return this.GetDouble(this.GetOrdinal(name));
        }

        ///' <remarks>
        ///' A null is converted into the min possible date
        ///' See Chapter 5 for more details on the SmartDate class.
        ///' </remarks>
        ///' <param name="i">The column number within the datareader.</param>
        //'Public Function GetSmartDate(ByVal i As Integer) As SmartDate
        //    If mDataReader.IsDBNull(i) Then
        //        Return New SmartDate
        //    Else
        //        Return New SmartDate(mDataReader.GetDateTime(i))
        //    End If
        //End Function


        ///' <remarks>
        ///' A null is converted into min possible date
        ///' See Chapter 5 for more details on the SmartDate class.
        ///' </remarks>
        //Public Function GetSmartDate(ByVal Name As String) As SmartDate
        //    mIndex = Me.GetOrdinal(Name)
        //    Return Me.GetSmartDate(mIndex)
        //End Function


        /// <summary>
        /// Gets a Guid value from the datareader.
        /// </summary>
        public Guid GetGuid(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return Guid.Empty;
            }
            else
            {
                return mDataReader.GetGuid(i);
            }
        }

        /// <summary>
        /// Gets a Guid value from the datareader.
        /// </summary>
        public Guid GetGuid(string name)
        {
            return this.GetGuid(this.GetOrdinal(name));
        }

        /// <summary>
        /// Reads the next row of data from the datareader.
        /// </summary>
        public bool Read()
        {
            return mDataReader.Read();
        }

        /// <summary>
        /// Moves to the next result set in the datareader.
        /// </summary>
        public bool NextResult()
        {
            return mDataReader.NextResult();
        }

        /// <summary>
        /// Closes the datareader.
        /// </summary>
        public void Close()
        {
            if (!IsClosed)
            {
                mDataReader.Close();
            }
        }

        /// <summary>
        /// Returns the depth property value from the datareader.
        /// </summary>
        public int Depth
        {
            get { return mDataReader.Depth; }
        }

        /// <summary>
        /// Calls the Dispose method on the underlying datareader.
        /// </summary>
        public void Dispose()
        {
            mDataReader.Dispose();
        }

        /// <summary>
        /// Returns the FieldCount property from the datareader.
        /// </summary>
        public int FieldCount
        {
            get { return mDataReader.FieldCount; }
        }

        /// <summary>
        /// Gets a boolean value from the datareader.
        /// </summary>
        public bool GetBoolean(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return false;
            }
            else
            {
                return mDataReader.GetBoolean(i);
            }
        }

        public TimeSpan GetTimeSpan(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return TimeSpan.Zero;
            }
            else
            {
                return ((MySqlDataReader)mDataReader).GetTimeSpan(i);
            }
        }
        /// <summary>
        /// Gets a boolean value from the datareader.
        /// </summary>
        public bool GetBoolean(string name)
        {
            return this.GetBoolean(this.GetOrdinal(name));
        }

        /// <summary>
        /// Gets a byte value from the datareader.
        /// </summary>
        public byte GetByte(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return DefaultByte;
            }
            else
            {
                return mDataReader.GetByte(i);
            }
        }


        public byte GetByte(int i, byte defValue)
        {
            if (mDataReader.IsDBNull(i))
            {
                return defValue;
            }
            else
            {
                return mDataReader.GetByte(i);
            }
        }

        /// <summary>
        /// Gets a byte value from the datareader.
        /// </summary>
        public byte GetByte(string name)
        {
            return this.GetByte(this.GetOrdinal(name));
        }

        /// <summary>
        /// Invokes the GetBytes method of the underlying datareader.
        /// </summary>
        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            if (mDataReader.IsDBNull(i))
            {
                return 0;
            }
            else
            {
                return mDataReader.GetBytes(i, fieldOffset, buffer, bufferoffset, length);
            }
        }


        /// <summary>
        /// Invokes the GetBytes method of the underlying datareader.
        /// </summary>
        public byte[] GetBytes(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return null;
            }
            else
            {
                return (byte[])GetValue(i);
            }
        }

        /// <summary>
        /// Invokes the GetBytes method of the underlying datareader.
        /// </summary>
        public long GetBytes(string name, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            return this.GetBytes(this.GetOrdinal(name), fieldOffset, buffer, bufferoffset, length);
        }

        /// <summary>
        /// Gets a char value from the datareader.
        /// </summary>
        public char GetChar(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return char.MinValue;
            }
            else
            {
                var str = this.mDataReader.GetString(i);
                if (str.Length == 1)
                    return str[0];
                else if (str.Length == 0)
                    throw new InvalidOperationException("Cualquiera es nullable char, no es null pero no tiene ningun caracter, medio mentira me parece");
                else
                    throw new InvalidOperationException("Cualquiera es nullable char, no es null pero tiene mas de un caracter: " + str);
            }
        }

        /// <summary>
        /// Gets a char value from the datareader.
        /// </summary>
        public char GetChar(string name)
        {
            return this.GetChar(this.GetOrdinal(name));
        }

        /// <summary>
        /// Invokes the GetChars method of the underlying datareader.
        /// </summary>
        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            if (mDataReader.IsDBNull(i))
            {
                return 0;
            }
            else
            {
                return mDataReader.GetChars(i, fieldoffset, buffer, bufferoffset, length);
            }
        }

        /// <summary>
        /// Invokes the GetChars method of the underlying datareader.
        /// </summary>
        public long GetChars(string name, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            return this.GetChars(this.GetOrdinal(name), fieldoffset, buffer, bufferoffset, length);
        }

        /// <summary>
        /// Invokes the GetData method of the underlying datareader.
        /// </summary>
        public IDataReader GetData(int i)
        {
            return mDataReader.GetData(i);
        }

        /// <summary>
        /// Invokes the GetData method of the underlying datareader.
        /// </summary>
        public IDataReader GetData(string name)
        {
            return this.GetData(this.GetOrdinal(name));
        }

        /// <summary>
        /// Invokes the GetDataTypeName method of the underlying datareader.
        /// </summary>
        public string GetDataTypeName(int i)
        {
            return mDataReader.GetDataTypeName(i);
        }

        /// <summary>
        /// Invokes the GetDataTypeName method of the underlying datareader.
        /// </summary>
        public string GetDataTypeName(string name)
        {
            return this.GetDataTypeName(this.GetOrdinal(name));
        }

        /// <summary>
        /// Gets a date value from the datareader.
        /// </summary>
        public DateTime GetDateTime(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return DateTime.MinValue;
            }
            else
            {
                return mDataReader.GetDateTime(i);
            }
        }

        public DateTime GetDateTime(string name)
        {
            return this.GetDateTime(this.GetOrdinal(name));
        }

        public decimal GetDecimal(int i, decimal nullValue)
        {
            if (mDataReader.IsDBNull(i))
            {
                return nullValue;
            }
            else
            {
                return mDataReader.GetDecimal(i);
            }
        }

        public decimal GetDecimal(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return DefaultDecimal;
            }
            else
            {
                return mDataReader.GetDecimal(i);
            }
        }

        /// <summary>
        /// Gets a decimal value from the datareader.
        /// </summary>
        public decimal GetDecimal(string name)
        {
            return this.GetDecimal(this.GetOrdinal(name));
        }

        /// <summary>
        /// Invokes the GetFieldType method of the underlying datareader.
        /// </summary>
        public Type GetFieldType(int i)
        {
            return mDataReader.GetFieldType(i);
        }

        /// <summary>
        /// Invokes the GetFieldType method of the underlying datareader.
        /// </summary>
        public Type GetFieldType(string name)
        {
            return this.GetFieldType(this.GetOrdinal(name));
        }

        /// <summary>
        /// Gets a Single value from the datareader.
        /// </summary>
        public float GetFloat(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return DefaultFloat;
            }
            else
            {
                return mDataReader.GetFloat(i);
            }
        }

        /// <summary>
        /// Gets a Single value from the datareader.
        /// </summary>
        public float GetFloat(string name)
        {
            return this.GetFloat(this.GetOrdinal(name));
        }


        public Int16 GetInt16(int i, Int16 nullValue)
        {
            if (mDataReader.IsDBNull(i))
            {
                return nullValue;
            }
            else
            {
                return mDataReader.GetInt16(i);
            }
        }

        /// <summary>
        /// Gets a Short value from the datareader.
        /// </summary>
        public short GetInt16(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return DefaultInt16;
            }
            else
            {
                return mDataReader.GetInt16(i);
            }
        }

        /// <summary>
        /// Gets a Short value from the datareader.
        /// </summary>
        public short GetInt16(string name)
        {
            return this.GetInt16(this.GetOrdinal(name));
        }

        public Int64 GetInt64(int i, Int64 nullValue)
        {
            if (mDataReader.IsDBNull(i))
            {
                return nullValue;
            }
            else
            {
                return mDataReader.GetInt64(i);
            }
        }
        /// <summary>
        /// Gets a Long value from the datareader.
        /// </summary>
        public long GetInt64(int i)
        {
            if (mDataReader.IsDBNull(i))
            {
                return DefaultInt64;
            }
            else
            {
                return mDataReader.GetInt64(i);
            }
        }

        /// <summary>
        /// Gets a Long value from the datareader.
        /// </summary>
        public long GetInt64(string name)
        {
            return this.GetInt64(this.GetOrdinal(name));
        }

        /// <summary>
        /// Invokes the GetName method of the underlying datareader.
        /// </summary>
        public string GetName(int i)
        {
            return mDataReader.GetName(i);
        }

        /// <summary>
        /// Gets an ordinal value from the datareader.
        /// </summary>
        public int GetOrdinal(string name)
        {
            return mDataReader.GetOrdinal(name);
        }

        /// <summary>
        /// Invokes the GetSchemaTable method of the underlying datareader.
        /// </summary>
        public DataTable GetSchemaTable()
        {
            return mDataReader.GetSchemaTable();
        }

        /// <summary>
        /// Invokes the GetValues method of the underlying datareader.
        /// </summary>
        public int GetValues(object[] values)
        {
            return mDataReader.GetValues(values);
        }

        /// <summary>
        /// Returns the IsClosed property value from the datareader.
        /// </summary>
        public bool IsClosed
        {
            get { return mDataReader.IsClosed; }
        }

        /// <summary>
        /// Invokes the IsDBNull method of the underlying datareader.
        /// </summary>
        public bool IsDBNull(int i)
        {
            return mDataReader.IsDBNull(i);
        }

        /// <summary>
        /// Invokes the IsDBNull method of the underlying datareader.
        /// </summary>
        public bool IsDBNull(string name)
        {
            return this.IsDBNull(this.GetOrdinal(name));
        }

        /// <summary>
        /// Returns a value from the datareader.
        /// </summary>
        /// <remarks>
        /// Returns Nothing if the value is null.
        /// </remarks>
        public object this[string name]
        {
            //If DBNull.Value.Equals(value) Then
            //    Return Nothing
            //Else
            //    Return value
            //End If
            get { return mDataReader[name]; }
        }

        /// <summary>
        /// Returns a value from the datareader.
        /// </summary>
        /// <remarks>
        /// Returns Nothing if the value is null.
        /// </remarks>
        public object this[int i]
        {
            //If mDataReader.IsDBNull(i) Then
            //    Return Nothing
            //Else
            //    Return mDataReader.Item(i)
            //End If
            get { return mDataReader[i]; }
        }

        /// <summary>
        /// Returns the RecordsAffected property value from the underlying datareader.
        /// </summary>
        public int RecordsAffected
        {
            get { return mDataReader.RecordsAffected; }
        }
    }

}
