using App.Common;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Caja.Datos
{
    public static class DatabaseConnection
    {
        static MySqlConnection databaseConnection = null;
        public static MySqlConnection getDBConnection()
        {
            if (databaseConnection == null)
            {
                string connectionString = ConfigReader.DataBase;
                connectionString = DesencriptaConexion(connectionString);
                databaseConnection = new MySqlConnection(connectionString);
            }

            if (databaseConnection.State == System.Data.ConnectionState.Closed)
                databaseConnection.Open();

            return databaseConnection;
        }

        //Desencripta el string de la conexion
        private static string DesencriptaConexion(string pCadena)
        {
            byte[] Clave = Encoding.ASCII.GetBytes("5&(/58Jet7G5r4g%5/&$8&$!");
            byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");
            byte[] inputBytes = Convert.FromBase64String(pCadena);
            byte[] resultBytes = new byte[inputBytes.Length];
            string textoLimpio = String.Empty;
            RijndaelManaged cripto = new RijndaelManaged();
            using (MemoryStream ms = new MemoryStream(inputBytes))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(Clave, IV), CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(objCryptoStream, true))
                    {
                        textoLimpio = sr.ReadToEnd();
                    }
                }
            }
            return textoLimpio;
        }
    }
}
