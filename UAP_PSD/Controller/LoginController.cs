using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Handlers;

namespace UAP_PSD.Controller
{
    public class LoginController
    {
        public static String CheckUsername(String username)
        {
            String response = "";

            if (username.Equals("")) 
            {
                response = "Username cannot be empty!";
                return response;
            }
            return response;
        }

        public static String CheckPassword(String password)
        {
            String response = "";

            if (password.Equals(""))
            {
                response = "Password cannot be empty!";
                return response;
            }
            return response;
        }

        public static String DoLogin(String username, String password)
        {
            String response = CheckUsername(username);
            if (response.Equals("")) response = CheckPassword(password);
            if (response.Equals("")) response = MsUserHandler.DoLogin(username, password);

            return response;
        }
    }
}