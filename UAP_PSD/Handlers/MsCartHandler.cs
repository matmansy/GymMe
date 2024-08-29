using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Factories;
using UAP_PSD.Models;
using UAP_PSD.Repositories;

namespace UAP_PSD.Handlers
{
    public class MsCartHandler
    {
        public static String AddCart(int userId, int supplementId, int quantity)
        {
            MsCart newcart = MsCartFactory.Create(userId, supplementId, quantity);
            MsCartRepository.AddToCart(newcart);
            return "Success!";
        }

        public static void ClearCart(int userId)
        {
            MsCartRepository.clearCart(userId);
        }
    }
}