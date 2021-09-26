using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Sha_şifreleme
{
    class Sha256
    {
        public static string pass256(string str)
        {
            StringBuilder sb = new StringBuilder();
            SHA256CryptoServiceProvider ShaPass = new SHA256CryptoServiceProvider();
            byte[] bt = Encoding.UTF8.GetBytes(str);
            bt = ShaPass.ComputeHash(bt);
            foreach (byte b in bt)
            {
                sb.Append(b.ToString("x2").ToLower());
            }

            return sb.ToString();
        }
    }
}
