using System;
using System.Text;

namespace POMCSharpAutomation.Factory
{
    public static class PasswordEncrypt
    {
        public static string Encrypt(string plainText)
        {
            var plainBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainBytes);
        }

        public static string Decrypt(string encryptedText)
        {
            var bytes = Convert.FromBase64String(encryptedText);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
