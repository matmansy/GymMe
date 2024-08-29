using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Models;

namespace UAP_PSD.Factories
{
    public class MsCartFactory
    {
        public static MsCart Create(int UserID, int SupplementID, int Quantity)
        {
            MsCart newCart = new MsCart
            {
                UserID = UserID,
                SupplementID = SupplementID,
                Quantity = Quantity
            };
            return newCart;
        }
    }
}