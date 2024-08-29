using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Models;

namespace UAP_PSD.Factories
{
    public class MsUserFactory
    {
        public static MsUser Create(String Username, String UserEmail, String UserDOB, String UserGender, String UserRole, String userPassword)
        {
            MsUser newUser = new MsUser
            {
                UserName = Username,
                UserEmail = UserEmail,
                UserDOB = DateTime.Parse(UserDOB),
                UserGender = UserGender,
                UserRole = UserRole,
                UserPassword = userPassword
            };
            return newUser;
        }
    }
}