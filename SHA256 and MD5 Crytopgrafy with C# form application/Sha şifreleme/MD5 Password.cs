using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Sha_şifreleme
{
    class MD5_Password
    {
        public static string pass5(string str)
        {
            StringBuilder sb = new StringBuilder();
            MD5CryptoServiceProvider ShaPass = new MD5CryptoServiceProvider();
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
