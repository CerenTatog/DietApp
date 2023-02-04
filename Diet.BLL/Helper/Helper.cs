using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Diet.BLL.Helper
{
    public static class Helper
    {
        public static string GetEnumDisplayName(this Enum enumType)
        {
            return enumType.GetType().GetMember(enumType.ToString())
                           .First()
                           .GetCustomAttribute<DisplayAttribute>()
                           .Name;
        }
        public static bool IsValidPassword(this string password)
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

        public static string EncryptoPassword(this string password)
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

        public static bool CheckEmailFormat(this string Email)
        {
            return Regex.IsMatch(Email, @"^.*\.com$");
        }
    }
}
