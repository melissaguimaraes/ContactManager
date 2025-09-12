using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    
    public static class AuthService
    {
        public static string User = null;
        // 3 users incl pw
        private static readonly Dictionary<string, string> Users = new(StringComparer.OrdinalIgnoreCase)
        {
            ["admin"] = "admin",
            ["melissa"] = "melissa",
            ["kyra"] = "kyra"
        };

        public static string? CurrentUser { get; private set; }



        // checks username/password 

        public static bool Validate(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            if (Users.TryGetValue(username.Trim(), out var pw) && pw == password)
            {
                CurrentUser = username.Trim();

                return true;
            }
            return false;
        }

        //optional logs out user

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}



