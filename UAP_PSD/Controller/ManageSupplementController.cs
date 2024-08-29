using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Handlers;

namespace UAP_PSD.Controller
{
    public class ManageSupplementController
    {
        public static String UpdateSupplement(int id, String supplementName, DateTime supplementExpiryDate, int price, int typeId)
        {
            if (!supplementName.Contains("Supplement"))
            {
                return "Supplement name must contain 'Supplement'!";
            }
            if(supplementExpiryDate <= DateTime.Now)
            {
                return "Expiry Date must be greater than today's date!";
            }
            if(price < 3000)
            {
                return "Price must be at least 3000!";
            }
            if(typeId <= 0)
            {
                return "Supplement's type ID cannot be empty!";
            }

            MsSupplementHandler.UpdateSupplement(id, supplementName, supplementExpiryDate, price, typeId);
            return "Success!";
        }

        public static void DeleteSupplement(int id)
        {
            MsSupplementHandler.DeleteSupplement(id);
        }
    }
}