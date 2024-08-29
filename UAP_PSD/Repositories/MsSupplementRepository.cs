using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Models;

namespace UAP_PSD.Repositories
{
    public class MsSupplementRepository
    {
        private static DatabaseEntities1 db = DatabaseSingleton.GetInstance();

        public static void UpdateSupplement(int supplementId, string supplementName, DateTime ExpiryDate, int price, int typeId)
        {
            MsSupplement msSupplement = (from x in db.MsSupplements where x.SupplementID == supplementId select x).FirstOrDefault();
            msSupplement.SupplementName = supplementName;
            msSupplement.SupplementExpiryDate = ExpiryDate;
            msSupplement.SupplementPrice = price;
            msSupplement.SupplementTypeID = typeId;
            db.SaveChanges();
        }

        public static void DeleteSupplement(int supplementId)
        {
           MsSupplement msSupplement = (from x in db.MsSupplements where x.SupplementID == supplementId select x).FirstOrDefault();
           if(msSupplement != null)
            {
                db.MsSupplements.Remove(msSupplement);
                db.SaveChanges();
            }
        }

        public static List<MsSupplement> GetSupplement()
        {
            return (from x in db.MsSupplements select x).ToList();
        }
    }
}