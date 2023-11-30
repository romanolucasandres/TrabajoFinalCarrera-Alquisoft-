using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class S_Encriptar
    {
        public static string EncriptarPW(string pw)
        {
            UnicodeEncoding codigo = new UnicodeEncoding();
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            byte[] hash = sha.ComputeHash(codigo.GetBytes(pw));

            return Convert.ToBase64String(hash);
        }
    }
}
