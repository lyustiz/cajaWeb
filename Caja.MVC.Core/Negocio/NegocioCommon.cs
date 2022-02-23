using System;
using System.Text;

namespace Caja.MVC.Core.Negocio
{
    public static class NegocioCommon
    {
        public static string DesEncriptar(string _cadenaAdesencriptar)
        {
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            string result = Encoding.Unicode.GetString(decryted);
            return result;
        }

        public static string Encriptar(string _cadenaAencriptar)
        {
            byte[] encryted = Encoding.Unicode.GetBytes(_cadenaAencriptar);
            string result = Convert.ToBase64String(encryted);
            return result;
        }
    }
}
