using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Factories;
using UAP_PSD.Models;
using UAP_PSD.Repositories;

namespace UAP_PSD.Handlers
{
    public class MsUserHandler
    {
        public static String DoLogin(String username, String password)
        {
           MsUser msUser = MsUserRepository.GetUser(username, password);
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "Username and password cannot be empty.";
            }
            return "Success";
        }

        public static String DoRegister(String username, String password, String email, String gender, String dob, string confirmPassword)
        {
            MsUser emailValidate = MsUserRepository.GetUserByEmail(email);

            if (emailValidate != null) return "Email already exists!";

            MsUser msUser = MsUserFactory.Create(username, email, dob, gender, "Customer", password);
            MsUserRepository.AddUser(msUser);
            return "Success";
        }

        public static void UpdateProfile(int id, String username, String Email, DateTime DOB, String Gender, String Role)
        {
            MsUserRepository.UpdateProfile(id, username, Email, Gender, DOB, Role);   
        }

        public static void UpdatePassword(string oldPass, string newPass)
        {
            MsUserRepository.UpdatePassword(oldPass, newPass);
        }
    }
}
