using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Factories;
using UAP_PSD.Models;

namespace UAP_PSD.Repositories
{
    public class MsUserRepository
    {
        private static DatabaseEntities1 db = DatabaseSingleton.GetInstance();
        
        public static MsUser GetUser(string username, string password)
        {
            return (from x in db.MsUsers where x.UserName.Equals(username) && x.UserPassword.Equals(password) select x).FirstOrDefault();
        }

        public static MsUser GetPassword(String password)
        {
            return (from x in db.MsUsers where x.UserPassword == password select x).FirstOrDefault();
        }

        public static List<MsUser> GetCustomers()
        {
            return (from x in db.MsUsers where x.UserRole.Equals("Customer") select x).ToList();
        }

        public static MsUser GetUserByID(int id)
        {
            return db.MsUsers.FirstOrDefault(x => x.UserID == id);
        }

        public static MsUser GetUserByEmail(string email)
        {
            return(from x in db.MsUsers where x.UserEmail == email select x).FirstOrDefault();
        }

        public static void AddUser(MsUser user)
        {
            db.MsUsers.Add(user);
            db.SaveChanges();
        } 

        public static void UpdateProfile(int id, string username,  string email, string gender, DateTime DOB, string role )
        {
            var user = db.MsUsers.FirstOrDefault(x=>x.UserID == id);
            if (user != null)
            {
                user.UserName = username;
                user.UserEmail = email;
                user.UserGender = gender;
                user.UserRole = role;
                user.UserDOB = DOB;
                db.SaveChanges();
            }
        }

        public static void UpdatePassword(string oldPassword, string newPassword)
        {
            var user = db.MsUsers.FirstOrDefault(x => x.UserPassword == oldPassword);
            if (user!=null)
            {
                user.UserPassword = newPassword;
                db.SaveChanges();
            }
        }
    }
}