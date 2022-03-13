using System.Security.Cryptography;
using Metrology.Models;
using System.Text;

namespace Metrology.Services
{
    internal static class LoginService
    {
        internal static User CurrentUser {get; set; }


        internal static string GetHashedPassword(string password)
        {
            var unhashed = Encoding.UTF8.GetBytes(password);
            return Encoding.UTF8.GetString(SHA256.HashData(unhashed));
        }

        internal static bool VerifyPassword(string hashedPassword, string passWord)
        {
            return GetHashedPassword(passWord) == hashedPassword;
        }
    }
}
