using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Diet.DAL.Entities;

namespace Diet.BLL
{
    public class UserManager
    {
        DietAppContext db = new DietAppContext();          
        public static bool IsValidPassword(string password)
        {
            int uppercaseCount = 0;
            int lowercaseCount = 0;
            int specialCharCount = 0;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    uppercaseCount++;
                }
                else if (char.IsLower(c))
                {
                    lowercaseCount++;
                }
                else if (c == '!' || c == ':' || c == '+' || c == '*')
                {
                    specialCharCount++;
                }
            }

            return password.Length >= 8
                && uppercaseCount >= 2
                && lowercaseCount >= 3
                && specialCharCount >= 2;
        }
        public  bool CheckEmailFormat(string Email)
        {
            return Regex.IsMatch(Email, @"^.*\.com$");   
        }
        public string EncryptoPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
