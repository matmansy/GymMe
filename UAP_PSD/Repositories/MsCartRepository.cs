using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Models;

namespace UAP_PSD.Repositories
{
    public class MsCartRepository
    {
        private static DatabaseEntities1 db = DatabaseSingleton.GetInstance();

        public static void AddToCart(MsCart cart)
        {
            db.MsCarts.Add(cart);
            db.SaveChanges();
        }

        public static void clearCart(int userId)
        {
            DatabaseEntities1 db = DatabaseSingleton.GetInstance();
            List<MsCart> userCart = db.MsCarts.Where(cart => cart.UserID == userId).ToList();
            db.MsCarts.RemoveRange(userCart);
            db.SaveChanges();
        }

        public static List<MsCart> CallCart(int userId)
        {
            return (from cart in db.MsCarts where cart.UserID == userId select cart).ToList();
        }

    }
}