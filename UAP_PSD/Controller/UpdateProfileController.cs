using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Handlers;
using UAP_PSD.Models;
using UAP_PSD.Repositories;

namespace UAP_PSD.Controller
{
    public class UpdateProfileController
    {
        public static string UpdateProfile(int id, string Username, string Email, DateTime DOB, string Gender, string Role, object value)
        {
            if (string.IsNullOrEmpty(Username))
            {
                return "Username cannot be empty.";
            }

            if (Username.Length < 5 || Username.Length > 15)
            {
                return "Username length must be between 5 and 15 characters.";
            }

            if (!Username.All(char.IsLetterOrDigit))
            {
                return "Username can only contain alphabetic characters and numbers.";
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                return "Email cannot be empty.";
            }

            if (!Email.EndsWith(".com"))
            {
                return "Email must end with '.com'.";
            }

            if (DOB == default)
            {
                return "Date of Birth cannot be empty.";
            }

            if (string.IsNullOrWhiteSpace(Gender))
            {
                return "Gender must be chosen and cannot be empty.";
            }

            MsUserHandler.UpdateProfile(id, Username, Email, DOB, Gender, "Admin");
            return "Success";
        }

        public static String UpdatePassword(String oldPass, String newPass)
        {
            if (string.IsNullOrEmpty(oldPass)) 
            {
                return "Old Password must be filled!";
            }

            if (string.IsNullOrEmpty(newPass))
            {
                return "New Password must be filled!";
            }

            if (!newPass.All(char.IsLetterOrDigit))
            {
                return "New Password must be alphanumeric!";
            }

            if (MsUserRepository.GetPassword(oldPass) == null){
                return "Old password not the same as current password!";
            }
            MsUserHandler.UpdatePassword(oldPass, newPass);
            return "Success";
        }
    }
}