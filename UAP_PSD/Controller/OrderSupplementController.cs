using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UAP_PSD.Controller
{
    public class OrderSupplementController
    {
        public static String VerCart(int userId, int supplementId, int quantity)
        {
            if (quantity == 0)
            {
                return "Total quantity Must bigger than 0";
            }

            return "Success!";
        }
    }
}