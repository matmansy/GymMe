using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Handlers;

namespace UAP_PSD.Controller
{
    public class RegisterController
    {
        public static string Register(string Username, string Email, string Password, string DOB, string Gender, string ConfirmPassword)
        {
            if  (Username == null || Username.Equals(""))
            {
                return "Username Cannot Be Empty!!";
            }
            if (Username.Length < 5 || Username.Length > 15)
            {
                return "Username length must be between 5-15 characters long!!";
            }
            if (!Username.All(char.IsLetterOrDigit))
            {
                return "Username can only contain letter and digits!!";
            }
            if(Email == null || Email.Equals(""))
            {
                return "Email cannot be empty!";
            }
            if (!Email.EndsWith(".com"))
            {
                return "Email is not valid!";
            }
            if (Gender == null || Gender.Equals(""))
            {
                return "Gender must be chosen!!";
            }
            if (Password == null || Password.Equals(""))
            {
                return "Password cannot be empty!!";
            }
            if (!Password.All(char.IsLetterOrDigit))
            {
                return "Password can only contain letter / digits!!";
            }
            if (ConfirmPassword == null || ConfirmPassword.Equals(""))
            {
                return "Password confirmation cannot be empty!!";
            }
            if (ConfirmPassword != Password)
            {
                return "Password doesn't match.";
            }
            return "Success";
        }


    }

}