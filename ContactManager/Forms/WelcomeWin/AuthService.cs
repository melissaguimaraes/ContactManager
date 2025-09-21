using BCrypt.Net;
using ContactManager.Helper;
using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace ContactManager
{
    
    // handles authentication services, validate password, hasing etc.
    public static class AuthService
    {
        // TODO: To be deleted - deprecated
        // public static string User = null;
        // 3 users incl pw 
        //private static readonly Dictionary<string, string> Users = new(StringComparer.OrdinalIgnoreCase)
        //{
        //    ["admin"] = "admin",
        //    ["melissa"] = "melissa",
        //    ["kyra"] = "kyra"
        //};

        private static ContactHandler contactHandler = ContactHandler.GetContactHandler();

        // static variable to access the current loged in user throughout the projetct
        public static Employee CurrentUser { get; private set; }

        // TODO: To be deleted - deprecated
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


            Employee authEmployee = contactHandler.GetAdminByUsername(username.Trim());

            if (authEmployee == null)
                return false;

            if (AuthService.ValidatePassword(password, authEmployee.Password))
            {
                CurrentUser = authEmployee;
                return true;
            }

            return false;

            // TODO: To be deleted - deprecated
            //// Chackes if user exists and credentials match
            //if (Users.TryGetValue(username.Trim(), out var pw) && pw == password)
            //{
            //    // sets loged in user as current session
            //    CurrentUser = username.Trim();

            //    return true;
            //}
            //return false;
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

        /*
        Hashes the password.

        @return: string (hashed password)
        */
        public static string HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        /*
        Verifies if the password matches the hashed password

        @parameter: password
        @parameter: hashedPassword

        @return: bool (password is valid)
        */
        public static bool ValidatePassword(string password, string hashedPassword)
        {
            string hashedInput = HashPassword(password);
            return hashedInput == hashedPassword;
        }
    }
}



