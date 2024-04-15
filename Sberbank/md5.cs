using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Sberbank
{
    internal class md5
    {
        public static string hashPassword(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(b);  
            StringBuilder sd = new StringBuilder();
            foreach (var a in hash) 
                sd.Append(a.ToString("X2"));
                return Convert.ToString(sd);
        }
    }
}
