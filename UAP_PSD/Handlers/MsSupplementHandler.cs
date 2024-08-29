using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Models;
using UAP_PSD.Repositories;

namespace UAP_PSD.Handlers
{
    public class MsSupplementHandler
    {
        public static DatabaseEntities1 db = DatabaseSingleton.GetInstance();
        
        public static void DeleteSupplement(int Id)
        {
            MsSupplementRepository.DeleteSupplement(Id);
        }

        public static void UpdateSupplement(int Id, String supplementName, DateTime expiryDate, int price, int typeId)
        {
            MsSupplementRepository.UpdateSupplement(Id, supplementName, expiryDate, price, typeId);
        }
    }
}