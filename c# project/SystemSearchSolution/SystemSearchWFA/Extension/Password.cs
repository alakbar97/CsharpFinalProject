using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SystemSearchWFA.Extension
{
    public class Password
    {
        public static string HashPassword(string password)
        {
            byte[] byteArray = ASCIIEncoding.ASCII.GetBytes(password);

            byte[] hashedArray = new SHA256Managed().ComputeHash(byteArray);

            string hashedPassword = ASCIIEncoding.ASCII.GetString(hashedArray);

            return hashedPassword;
        }

        public static bool CheckPassword(string password, string hashedPassword)
        {
            return HashPassword(password) == hashedPassword;
        }
    }
}
