using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UAP_PSD.Models;

namespace UAP_PSD.Repositories
{
    public class TransactionHeaderRepository
    {
        private static DatabaseEntities1 db = DatabaseSingleton.GetInstance();

        public static List<TransactionHeader> GetAllTransactionHeaders()
        {
            return (from x in db.TransactionHeaders select x).ToList();
        }

        public static TransactionHeader GetTransactionHeaderById(int id)
        {
            return db.TransactionHeaders.FirstOrDefault(x => x.TransactionID == id);
        }

        public static void AddTransactionHeader(TransactionHeader transactionHeader)
        {
            db.TransactionHeaders.Add(transactionHeader);
            db.SaveChanges();
        }

        public static void UpdateStatus(int ID, string status)
        {
            TransactionHeaderRepository.UpdateStatus(ID, status);
        }

        public static void DeleteTransactionHeader(int id)
        {
            var transactionHeader = db.TransactionHeaders.FirstOrDefault(x => x.TransactionID == id);
            if (transactionHeader != null)
            {
                db.TransactionHeaders.Remove(transactionHeader);
                db.SaveChanges();
            }
        }
    }
}