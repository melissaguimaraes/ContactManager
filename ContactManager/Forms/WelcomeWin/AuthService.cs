using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public static string CurrentUser { get; private set; }

        // checks username/password 

        /*
        Validates if user input is not null/empty
        
        @parameter: username
        @parameter: password
        
        @return: boolean (input is valid)
         */
        public static bool Validate(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            // Chackes if user exists and credentials match
            if (Users.TryGetValue(username.Trim(), out var pw) && pw == password)
            {
                // sets loged in user as current session
                CurrentUser = username.Trim();

                return true;
            }
            return false;
        }

        /*
         Central mehtod to log out current user out

        @parameter: formToClose (current form)
         */
        public static void Logout(Form formToClose)
        {
            formToClose.Close();
            WelcomeWin win = new WelcomeWin();
            win.Show();
            CurrentUser = null;

        }
    }
}



